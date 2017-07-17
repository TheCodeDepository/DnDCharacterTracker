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

namespace AddInventoryForm
{
    public partial class WeaponInvControl : InvPanel
    {
        public WeaponInvControl()
        {
            InitializeComponent();
        }

        private void TypeOfWeap_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (TypeOfWeap.Text == "Ranged")
            {
                RangeTb.Enabled = true;
            }
            else
            {
                RangeTb.Enabled = false;
            }
        }



        public override bool SaveRecord()
        {

            if (!ValidateFields())
            {
                MessageBox.Show("Please Ensure you fill all Mandatory Fields");
                return false;
            }
            if (CurrentRecord > -1)
            {
                var query = InventoryList.FindIndex(p => p.Key == CurrentRecord);
                InventoryList[query] = new WeaponItem(ItemIDTb, CostTB, WeightTb, NotesTb, DamageTb, CriticalTb, RangeTb, UpgradesTb);
            }
            else
            {
                InventoryList.Add(new WeaponItem(ItemIDTb, CostTB, WeightTb, NotesTb, DamageTb, CriticalTb, RangeTb, UpgradesTb));

            }

            LoadList();
            ClearFields();          
            return true;
        }
        public override bool DataLoss()
        {
            var CurrentFields = new WeaponItem(ItemIDTb, CostTB, WeightTb, NotesTb, DamageTb, CriticalTb, RangeTb, UpgradesTb);
            if (CurrentRecord > 0)
            {               
                return !Equals(CurrentFields, this);
            }
            else
            {
                foreach (var item in FieldsPanel.Controls)
                {
                    var textBoxs = item as TextBox;
                    if (textBoxs != null)
                    {
                        if (!string.IsNullOrWhiteSpace(textBoxs.Text))
                        {
                            return true;
                        }
                    }
                    else
                    {
                        ComboBox CboBox = (ComboBox)item;
                        if (!string.IsNullOrWhiteSpace(CboBox.Text))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }      
        bool tf = true;
        public override void SampleInput()
        {
            tf = !tf;
            if (tf)
            {
                ItemIDTb.Text = "Cross Bow";
                TypeOfWeap.Text = "Ranged";
                RangeTb.Text = "30";
                CostTB.Text = "300";
                DamageTb.Text = "1d8";
                CriticalTb.Text = "19-20/x2";
                WeightTb.Text = "20";
                UpgradesTb.Text = "Masterpiece, Something else, textextextextext";
                NotesTb.Text = "test";
                

            }
            else
            {
                ItemIDTb.Text = "Sword";
                TypeOfWeap.Text = "Melee";
                CostTB.Text = "12321";
                DamageTb.Text = "2d6";
                CriticalTb.Text = "19-20/x2";
                WeightTb.Text = "20";
                UpgradesTb.Text = "Masterpiece, Something else, textextextextext";
                NotesTb.Text = "test";
                

            }
        }      
        public override void Panel_Load(object sender, EventArgs e)
        {
            CList = WeaponListBox;
            CurrentRecord = -1;
            InventoryList = Storage.Storage.InventoryList;
            EnableFields(false);
            LoadList();
            RangeTb.Enabled = false;
            
        }
        public override void LoadSelectedRecord()
        {
            int temp = -1;
            foreach (var item in WeaponListBox.SelectedIndices)
            {
                temp = (int)item;
            }
            if (temp != -1)
            {
                var q = InventoryList.Find(p => p.Key == CurrentListKeys[temp]);
                var i = (WeaponItem)q;
                CurrentRecord = i.Key;
                ItemIDTb.Text = i.ItemID;
                CostTB.Text = i.Value.ToString();
                WeightTb.Text = i.Weight.ToString();
                DamageTb.Text = i.Damage;
                CriticalTb.Text = i.Critical;
                if (i.Range > 0)
                {
                    TypeOfWeap.SelectedIndex = 1;
                    RangeTb.Text = i.Range.ToString();

                }
                else
                {
                    TypeOfWeap.SelectedIndex = 0;
                }
                UpgradesTb.Text = i.Upgrades;
                NotesTb.Text = i.Notes;

            }
        } 

        //Input Validation

        private bool ValidateFields()
        {
            bool t = true;
            if (string.IsNullOrWhiteSpace(ItemIDTb.Text))
            {
                Asterisk(IDLbl.Location);
                t = false;

            }
            if (string.IsNullOrWhiteSpace(CostTB.Text))
            {
                Asterisk(ValueLbl.Location);
                t = false;

            }
            if (string.IsNullOrWhiteSpace(WeightTb.Text))
            {
                Asterisk(WeightLbl.Location);
                t = false;

            }

            if (TypeOfWeap.Text == "Ranged")
            {
                if (string.IsNullOrWhiteSpace(RangeTb.Text))
                {
                    Asterisk(RangeLbl.Location);
                    t = false;

                }
            }
            else
            {
                if (TypeOfWeap.SelectedIndex == -1)
                {
                    Asterisk(WeapTypeLbl.Location);
                    t = false;

                }
                if (TypeOfWeap.SelectedIndex == 0)
                {
                    RangeTb.Text = "0";
                }
            }
            if (!ValidateCritical(CriticalTb.Text))
            {
                Asterisk(CritLbl.Location);
                t = false;

            }
            if (!ValidateDamage(DamageTb.Text))
            {
                Asterisk(DamageLbl.Location);
                t = false;

            }
            return t;
        }

        private bool ValidateCritical(string critical)
        {
            string[] arr = critical.Split('-', '/');
            if (arr.Count() == 3)
            {
                if (!arr[2].Contains("x"))
                {
                    return false;
                }
                if ((arr[0].ToInt() > 20) || (arr[0].ToInt() == -1))
                {
                    return false;
                }
                if ((arr[1].ToInt() > 20) || (arr[1].ToInt() == -1))
                {
                    return false;
                }
                arr[2] = arr[2].TrimStart('x');
                if ((arr[2].ToInt() > 10) || (arr[2].ToInt() == -1))
                {
                    return false;
                }
                return true;
            }
            else if (arr.Count() == 2)
            {
                if (!arr[1].Contains("x"))
                {
                    return false;
                }
                if ((arr[0].ToInt() > 20) || arr[0].ToInt() == -1)
                {
                    return false;
                }
                arr[1] = arr[1].TrimStart('x');

                if ((arr[1].ToInt() > 10) || (arr[1].ToInt() == -1))
                {
                    return false;
                }
                return true;

            }
            else
            {
                return false;
            }
        }

        private bool ValidateDamage(string damage)
        {
            string[] arr = damage.Split('d');
            if (arr.Count() != 2)
            {
                return false;
            }
            if ((arr[0].ToInt() > 20) || (arr[0].ToInt() == -1))
            {
                return false;
            }
            if ((arr[1].ToInt() > 20) || (arr[1].ToInt() == -1))
            {
                return false;
            }
            if ((arr[1].ToInt() % 2 == 0) && (arr[1].ToInt() > 4))
            {
                return true;
            }
            return false;


        }


    }
}
