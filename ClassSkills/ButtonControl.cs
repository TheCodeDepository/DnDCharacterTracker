using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Storage;

namespace ClassSkills
{
    public partial class ButtonControl : UserControl
    {

        public ButtonControl()
        {
            InitializeComponent();

        }

        public IButtons ButtonInterfaces;

        private void ButtonControl_Load(object sender, EventArgs e)
        {
            ButtonEnabler();

        }

        private void ButtonEnabler()
        {
            RemoveBtnEnb(false);
            SaveBtnEnb(false);
            EditBtnEnb(false);
            AddBtnEnb(true);
            CancelBtnEnb(false);
        }

        public void SubscribeButtons()
        {
            ButtonInterfaces.SubscribeEdit(EditBtnEnb);
            ButtonInterfaces.SubscribeSave(SaveBtnEnb);
            ButtonInterfaces.SubscribeAdd(AddBtnEnb);
            ButtonInterfaces.SubscribeRemove(RemoveBtnEnb);
        }



        private void EditBtn_Click(object sender, EventArgs e)
        {
            ButtonInterfaces.EditRecord();
            SaveBtn.Enabled = true;
            EditBtn.Enabled = false;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if (ButtonInterfaces.DataLoss())
            {
                var m = MessageBox.Show("Are you sure you wish to exit without saveing your changes?", "Close", MessageBoxButtons.YesNo);
                if (m == DialogResult.Yes)
                {
                    SkillsForm.ActiveForm.Close();
                }
            }
            Form.ActiveForm.Close();

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            if (ButtonInterfaces.SaveRecord())
            {
                SaveBtn.Enabled = false;
                AddBtn.Enabled = true;
                ButtonInterfaces.EnableFields(false);
            }
        }

        private void SampleBtn_Click(object sender, EventArgs e)
        {
            ButtonInterfaces.SampleInput();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ButtonInterfaces.ClearFields();
            ButtonInterfaces.EnableFields(false);
            CancelBtnEnb(false);
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {

            ButtonInterfaces.RemoveRecord();
            RemoveBtn.Enabled = true;
            EditBtn.Enabled = false;

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            SaveBtn.Enabled = true;
            AddBtn.Enabled = false;
            EditBtn.Enabled = false;
            ButtonInterfaces.EnableFields(true);

        }


        private void EditBtnEnb(bool b)
        {
            EditBtn.Enabled = b;

        }
        private void SaveBtnEnb(bool b)
        {
            SaveBtn.Enabled = b;

        }
        private void AddBtnEnb(bool b)
        {
            AddBtn.Enabled = b;

        }
        private void RemoveBtnEnb(bool b)
        {
            RemoveBtn.Enabled = b;

        }
        private void CancelBtnEnb(bool b)
        {
            CancelBtn.Enabled = b;

        }


    }
}
