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
    public partial class InvWeapPan : UserControl
    {
        public InvWeapPan()
        {
            InitializeComponent();
        }

        


        //Fields
        private int CurrentRecord { get; set; }

        public List<GenericValues> InventoryList { get; set; }

        private List<Label> asterisks = new List<Label>();

        private List<int> CurrentListKeys = new List<int>();



        //Event Handlers

        private void WeaponListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedRecord();
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


                LoadListItem((WeaponItem)q);
                CurrentRecord = q.Key;
            }
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

        private void InvWeapPan_Load(object sender, EventArgs e)
        {
            EnableDisable();
            InventoryList = Storage.Storage.InventoryList;
            LoadList();
            RangeTb.Enabled = false;
        }

        private void RangeTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void WeapTypeLbl_Click(object sender, EventArgs e)
        {

        }



        //Buttons
        public bool SaveRecord()
        {
            if (asterisks.Count > 0)
            {
                foreach (Label item in asterisks)
                {
                    item.Dispose();
                }
            }
            if (!ValidateFields())
            {
                MessageBox.Show("Please Ensure you fill all Mandatory Fields");
                return false;
            }

            Storage.Storage.InventoryList.Add(new WeaponItem(ItemIDTb.Text, CostTB.Text.ToInt(), WeightTb.Text.ToInt(), NotesTb.Text, DamageTb.Text, CriticalTb.Text, RangeTb.Text.ToInt(), UpgradesTb.Text));
            LoadList();
            ClearFields();
            EnableDisable();
            return true;
        }

        private void ClearFields()
        {
            foreach (var item in panel2.Controls)
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
                }
            }
        }

        public void RemoveRecord()
        {
            int index = -1;
            foreach (var item in WeaponListBox.SelectedIndices)
            {
                index = item.ToString().ToInt();
            }
            InventoryList.RemoveAt(index);
            InventoryList.RemoveAt(index);
        }

        public void AddRecord()
        {
            throw new NotImplementedException();
        }

        public void EditRecord(WeaponItem I)
        {
            LoadSelectedRecord();
        }

        int count = 0;
        public void testButton()
        {
            if (count == 0)
            {
                ItemIDTb.Text = "Cross Bow";
                TypeOfWeap.Text = "Ranged";
                RangeTb.Text = "30";
                CostTB.Text = "300";
                DamageTb.Text = "1d8";
                CriticalTb.Text = "19-20/x2";
                WeightTb.Text = "20kg";
                UpgradesTb.Text = "Masterpiece, Something else, textextextextext";
                NotesTb.Text = "test";
                count++;

            }
            else
            {
                ItemIDTb.Text = "Sword";
                TypeOfWeap.Text = "Melee";
                CostTB.Text = "12321";
                DamageTb.Text = "2d6";
                CriticalTb.Text = "19-20/x2";
                WeightTb.Text = "20kg";
                UpgradesTb.Text = "Masterpiece, Something else, textextextextext";
                NotesTb.Text = "test";
                count--;

            }
        }





        //Functions
        internal void EnableDisable()
        {
            foreach (Control item in panel2.Controls)
            {
                item.Enabled = !item.Enabled;
            }
            TypeOfWeap_SelectedIndexChanged_1(new object(), new EventArgs());
        }

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

        private void LoadListItem(WeaponItem i)
        {
            CurrentRecord = i;
            ItemIDTb.Text = i.ItemID;
            CostTB.Text = i.Value.ToString();
            WeightTb.Text = i.Weight.ToString();
            DamageTb.Text = i.Damage;
            CriticalTb.Text = i.Critical;
            if (i.Range > 0)
            {
                TypeOfWeap.Text = "Ranged";
                RangeTb.Text = i.Range.ToString();

            }
            UpgradesTb.Text = i.Upgrades;
            NotesTb.Text = i.Notes;

        }




        //Input Validation

        private void Asterisk(Point p)
        {

            Label l = new Label();
            l.Location = new Point(p.X - 10, p.Y);
            l.Text = @"*";
            l.ForeColor = Color.Red;
            l.Font = new Font("Microsoft Sans Serif", 10);
            asterisks.Add(l);
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
                    Asterisk(DamageLbl.Location);
                    t = false;

                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(TypeOfWeap.Text))
                {
                    Asterisk(CritLbl.Location);
                    t = false;

                }
                if (TypeOfWeap.Text == "Melee")
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
