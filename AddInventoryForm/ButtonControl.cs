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

        private void ButtonControl_Load(object sender, EventArgs e)
        {

        }

        public TabPage = 

        private void EditBtn_Click(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void SampleBtn_Click(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {

        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }


        private void TestButton_Click(object sender, EventArgs e)
        {
            invWeapPan1.testButton();
        }
        private void AddInventoryBtn_Click(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
            AddInventoryBtn.Enabled = false;
            EditBtn.Enabled = false;
            if (InvTabControl.SelectedTab == WeapTab)
            {
                invWeapPan1.EnableDisable();

            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (currTab == Tab.Weap)
            {
                if (invWeapPan1.SaveRecord())
                {
                    SaveButton.Enabled = false;
                }
            }
            AddInventoryBtn.Enabled = true;

        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (currTab == Tab.Weap)
            {
                invWeapPan1.RemoveRecord();
                RemoveButton.Enabled = true;
                EditBtn.Enabled = false;
            }

        }


        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if (currTab == Tab.Weap)
            {
                if (invWeapPan1.DataLoss())
                {
                    var m = MessageBox.Show("Are you sure you wish to exit without saveing your changes?", "Close", MessageBoxButtons.YesNo);
                    if (m == DialogResult.Yes)
                    {
                        Close();
                    }
                }
                Close();
            }

        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (currTab == Tab.Weap)
            {
                invWeapPan1.EditRecord();
                SaveButton.Enabled = true;
                EditBtn.Enabled = false;
            }

        }

        private void EditBtnEnb(bool b)
        {
            EditBtn.Enabled = b;

        }
        private void SaveBtnEnb(bool b)
        {
            SaveButton.Enabled = b;

        }
        private void AddBtnEnb(bool b)
        {
            AddInventoryBtn.Enabled = b;

        }
        private void RemoveBtnEnb(bool b)
        {
            RemoveButton.Enabled = b;

        }

    }
}
