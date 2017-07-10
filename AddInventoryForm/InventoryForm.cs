using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddInventoryForm
{
    public enum Tab
    {
        Weap,Armor,Misc
    }

    
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }
         

        private Tab currTab;

        public Tab CurrTab
        {
            get
            {
                if (InvTabControl.SelectedTab == WeapTab)
                {
                    return Tab.Weap;

                }
                else if (InvTabControl.SelectedTab == ArmourTab)
                {
                    return Tab.Armor;
                }
                else if (InvTabControl.SelectedTab == MiscTab)
                {
                    return Tab.Misc;
                }
                return CurrTab;
            }
            set
            {
                CurrTab = value;
            }
        }






        private void Inventory_Load(object sender, EventArgs e)
        {
            //LoadList();

        }

        private void WeaponListBox_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void WeaponListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void WeapTypeLbl_Click(object sender, EventArgs e)
        {

        }

        private void TypeOfWeap_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void InvTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void EnableDisable(bool val)
        {
            foreach (Control item in panel1.Controls)
            {
                item.Enabled = val;
            }
        }

        


        //Buttons On Inventory Panel

        int count = 0;
        private void TestButton_Click(object sender, EventArgs e)
        {
            invWeapPan1.testButton();
        }


        private void AddInventoryBtn_Click(object sender, EventArgs e)
        {
            if (InvTabControl.SelectedTab == WeapTab)
            {
                invWeapPan1.EnableDisable();
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (InvTabControl.SelectedTab == WeapTab)
            {
                invWeapPan1.SaveRecord();
                
            }
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {


        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {

        }

        //Functional Methods



        //private bool ValidateCritical(string critical)
        //{


        //    string[] arr = critical.Split('-', '/');



        //    if (arr.Count() == 3)
        //    {
        //        if (!arr[2].Contains("x"))
        //        {
        //            return false;
        //        }
        //        if ((GetInteger(arr[0]) > 20) || GetInteger(arr[0]) == -1)
        //        {
        //            return false;
        //        }
        //        if ((GetInteger(arr[1]) > 20) || GetInteger(arr[1]) == -1)
        //        {
        //            return false;
        //        }
        //        arr[2] = arr[2].TrimStart('x');
        //        if ((GetInteger(arr[2]) > 10) || GetInteger(arr[2]) == -1)
        //        {
        //            return false;
        //        }
        //        return true;
        //    }
        //    else if (arr.Count() == 2)
        //    {
        //        if (!arr[1].Contains("x"))
        //        {
        //            return false;
        //        }
        //        if ((GetInteger(arr[0]) > 20) || GetInteger(arr[0]) == -1)
        //        {
        //            return false;
        //        }
        //        arr[1] = arr[1].TrimStart('x');

        //        if ((GetInteger(arr[1]) > 10) || GetInteger(arr[1]) == -1)
        //        {
        //            return false;
        //        }
        //        return true;

        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //private bool ValidateDamage(string damage)
        //{
        //    string[] arr = damage.Split('d');
        //    if (arr.Count() != 2)
        //    {
        //        return false;
        //    }
        //    if (GetInteger(arr[0]) > 20 || GetInteger(arr[0]) == -1)
        //    {
        //        return false;
        //    }
        //    if (GetInteger(arr[1]) > 20 || GetInteger(arr[1]) == -1)
        //    {
        //        return false;
        //    }
        //    if (GetInteger(arr[1]) % 2 == 0 && GetInteger(arr[1]) > 4)
        //    {
        //        return true;
        //    }
        //    return false;

        //    #region OldValidation

        //    //int diceused = 0;
        //    //string DiceUsed = string.Empty;
        //    //int arrFrontCount = 0;
        //    //bool fail = false;
        //    //char[] target = damage.ToArray();
        //    //for (int i = 0; i < target.Length; i++)
        //    //{

        //    //    if (GetInteger(target[i]) == -1)
        //    //    {
        //    //        if (fail)
        //    //        {
        //    //            return false;
        //    //        }
        //    //        fail = true;
        //    //        if (target[i] != 'd')
        //    //        {
        //    //            return false;
        //    //        }
        //    //        if (i > 1)
        //    //        {
        //    //            string diceRollsTotal = string.Empty;
        //    //            for (int d = 0; d < i; d++)
        //    //            {
        //    //                diceRollsTotal += target[d];
        //    //            }
        //    //            if (GetInteger(diceRollsTotal) > 20)
        //    //            {
        //    //                return false;
        //    //            }

        //    //        }
        //    //        arrFrontCount = i + 1;

        //    //    }
        //    //    else if (fail == true)
        //    //    {
        //    //        if ((target.Count() - arrFrontCount) > 2)
        //    //        {
        //    //            return false;
        //    //        }
        //    //        else
        //    //        {

        //    //            DiceUsed += target[i];
        //    //            diceused = GetInteger(DiceUsed);
        //    //            if (diceused > 20)
        //    //            {
        //    //                return false;
        //    //            }
        //    //        }
        //    //    }
        //    //}
        //    //if ((diceused % 2 == 0) && !(diceused < 4))
        //    //{
        //    //    return true;
        //    //}
        //    //return false;
        //    #endregion
        //}



    }
}
