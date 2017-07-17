using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddInventoryForm
{
    public partial class ButtonControl : UserControl
    {

        public ButtonControl()
        {
            InitializeComponent();

        }

        public InvPanel CurrentPanel;

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
            SampleBtnEnb(false);
        }


        private void EditBtn_Click(object sender, EventArgs e)
        {
            CurrentPanel.EditRecord();
            CancelBtnEnb(true);
            AddBtnEnb(false);
            SaveBtnEnb(true);
            EditBtnEnb(false);
            RemoveBtnEnb(false);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if (CurrentPanel.DataLoss())
            {
                var m = MessageBox.Show("Are you sure you wish to exit without saveing your changes?", "Close", MessageBoxButtons.YesNo);
                if (m == DialogResult.Yes)
                {
                    InventoryForm.ActiveForm.Close();
                }
            }
            InventoryForm.ActiveForm.Close();

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            if (CurrentPanel.SaveRecord())
            {
                CurrentPanel.ClearAsterisks();
                CancelBtnEnb(false);
                AddBtnEnb(true);
                SaveBtnEnb(false);
                CurrentPanel.EnableFields(false);
            }
        }

        private void SampleBtn_Click(object sender, EventArgs e)
        {
            CurrentPanel.SampleInput();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            CurrentPanel.ClearFields();
            CurrentPanel.EnableFields(false);
            CancelBtnEnb(false);
            SaveBtnEnb(false);
            AddBtnEnb(true);
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            CurrentPanel.RemoveRecord();
            EditBtnEnb(false);
            RemoveBtnEnb(false);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            SampleBtnEnb(true);
            CancelBtnEnb(true);
            SaveBtnEnb(true);
            EditBtnEnb(false);
            AddBtnEnb(false);           
            CurrentPanel.EnableFields(true);

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
        private void SampleBtnEnb(bool b)
        {
            SampleBtn.Enabled = b;

        }



    }
}
