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

namespace UserConCollection.InventoryUserControls


{
    public partial class WeaponInvControl : UserControl, IButtons
    {
        public WeaponInvControl()
        {
            InitializeComponent();
        }



        //Fields

        private int CurrentRecord { get; set; }
        public List<GenericValues> InventoryList { get; set; }
        private List<Label> Asterisks = new List<Label>();
        private List<int> CurrentListKeys = new List<int>();


        //Event Handlers

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
        private void ForceNum(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }


        //IButtons

        public void EnableFields(bool val)
        {
            val = !val;
            foreach (var item in FieldsPanel.Controls)
            {
                var textBoxs = item as TextBox;
                if (textBoxs != null)
                {
                    textBoxs.ReadOnly = val;
                }
                else
                {
                    ComboBox CboBox = (ComboBox)item;
                    CboBox.Enabled = !val;
                }
            }

        }

        public bool SaveRecord()
        {
            if (Asterisks.Count > 0)
            {
                foreach (Label item in Asterisks)
                {
                    item.Dispose();
                }
            }
            if (!ValidateFields())
            {
                MessageBox.Show("Please Ensure you fill all Mandatory Fields");
                return false;
            }
            if (CurrentRecord != -1)
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

        public bool DataLoss()
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

        public void RemoveRecord()
        {
            var q = InventoryList.FindIndex(p => p.Key == CurrentRecord);
            InventoryList.RemoveAt(q);
            LoadList();
        }

        public void EditRecord()
        {
            LoadSelectedRecord();
            EnableFields(true);
        }

        public void ClearFields()
        {
            foreach (var item in FieldsPanel.Controls)
            {
                var textBoxs = item as TextBox;
                if (textBoxs != null)
                {
                    textBoxs.Clear();
                }
                else
                {
                    ComboBox CboBox = (ComboBox)item;
                    CboBox.ResetText();
                    CboBox.SelectedIndex = -1;
                }
            }
        }

        bool tf = true;
        public void SampleInput()
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

        public void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedRecord();
            if (WeaponListBox.SelectedIndices.Count > 0)
            {
                EditBtnEnable(true);
                RemoveBtnEnable(true);

            }
            else
            {
                EditBtnEnable(false);
                RemoveBtnEnable(false);

            }
        }
        public void ListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            EditRecord();
        }
        public void Panel_Load(object sender, EventArgs e)
        {
            CurrentRecord = -1;
            InventoryList = Storage.Storage.InventoryList;
            EnableFields(false);
            LoadList();
            RangeTb.Enabled = false;
        }


        Action<bool> EditBtnEnable;
        public void SubscribeEdit(Action<bool> Method)
        {
            EditBtnEnable = Method;
        }
        //Action<bool> SaveBtnEnable;
        //public void SubscribeSave(Action<bool> Method)
        //{
        //    SaveBtnEnable = Method;
        //}
        //Action<bool> AddBtnEnable;
        //public void SubscribeAdd(Action<bool> Method)
        //{
        //    AddBtnEnable = Method;
        //}
        Action<bool> RemoveBtnEnable;
        public void SubscribeRemove(Action<bool> Method)
        {
            RemoveBtnEnable = Method;
        }
        //Action<bool> SampleBtnEnable;
        //public void SampleRemove(Action<bool> Method)
        //{
        //    SampleBtnEnable = Method;
        //}


        //Functions

        private void LoadList()
        {
            
            CurrentListKeys.Clear();
            WeaponListBox.Items.Clear();
            var q = InventoryList.Where(p => p is WeaponItem);
            foreach (var item in q.ToList())
            {
                WeaponListBox.Items.Add(item.ItemID);
                CurrentListKeys.Add(item.Key);
            }
        }

        private void LoadSelectedRecord()
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

        private void Asterisk(Point p)
        {

            Label l = new Label();
            l.Location = new Point(p.X - 10, p.Y);
            l.Text = @"*";
            l.ForeColor = Color.Red;
            l.Font = new Font("Microsoft Sans Serif", 10);
            Asterisks.Add(l);
            this.Controls.Add(l);
        }

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
