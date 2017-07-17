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
    public partial class ArmorInvControl : UserControl , IButtons
    {
        public ArmorInvControl()
        {
            InitializeComponent();
        }

        private void ForceNum(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Propertys

        private int CurrentRecord { get; set; }
        public List<GenericValues> InventoryList { get; set; }
        private List<Label> Asterisks = new List<Label>();
        private List<int> CurrentListKeys = new List<int>();


        //IButtons

        Action<bool> EditBtnEnable;
        public void SubscribeEdit(Action<bool> Method)
        {
            EditBtnEnable = Method;
        }

        Action<bool> SaveBtnEnable;
        public void SubscribeSave(Action<bool> Method)
        {
            SaveBtnEnable = Method;
        }

        Action<bool> AddBtnEnable;
        public void SubscribeAdd(Action<bool> Method)
        {
            AddBtnEnable = Method;
        }

        Action<bool> RemoveBtnEnable;
        public void SubscribeRemove(Action<bool> Method)
        {
            RemoveBtnEnable = Method;
        }

        Action<bool> SampleBtnEnable;
        public void SampleRemove(Action<bool> Method)
        {
            SampleBtnEnable = Method;
        }

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
            if (CheckEmptyFields())
            {
                MessageBox.Show("Please Ensure you fill all Mandatory Fields");
                return false;
            }
            if (CurrentRecord != -1)
            {
                var query = InventoryList.FindIndex(p => p.Key == CurrentRecord);
                InventoryList[query] = new ArmorItem(ItemIDTb, ValueTb, WeightTb, NotesTb, ACTb, ArmorGradeCbo, PenTb, SpellFailureTb);
            }
            else
            {
                InventoryList.Add(new ArmorItem(ItemIDTb, ValueTb, WeightTb, NotesTb, ACTb, ArmorGradeCbo, PenTb, SpellFailureTb));
            }
            AddBtnEnable(true);
            LoadList();
            ClearFields();            
            return true;
        }

        private bool CheckEmptyFields()
        {
            bool result = false;
            if (string.IsNullOrWhiteSpace(ItemIDTb.Text))
            {
                Asterisk(ItemIDLbl.Location);
                result = true;
            }
            if (string.IsNullOrWhiteSpace(ValueTb.Text))
            {
                Asterisk(ValueLbl.Location);

                result = true;


            }
            if (string.IsNullOrWhiteSpace(WeightTb.Text))
            {
                Asterisk(WeightLbl.Location);
                result = true;

            }

            if (string.IsNullOrWhiteSpace(ACTb.Text))
            {
                Asterisk(ArmorClsLbl.Location);

                result = true;


            }
            if (ArmorGradeCbo.SelectedIndex == -1)
            {
                Asterisk(GradeLbl.Location);
                result = true;
            }
            return result;
        }

        public bool DataLoss()
        {


            var CurrentFields = new ArmorItem(ItemIDTb,ValueTb,WeightTb,NotesTb,ACTb,ArmorGradeCbo,PenTb,SpellFailureTb);
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
            SaveBtnEnable(true);
            EditBtnEnable(false);
            AddBtnEnable(false);
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
                ItemIDTb.Text = "Light Chain Mail";
                ArmorGradeCbo.SelectedIndex = 0;
                ValueTb.Text = "300";
                ACTb.Text = "5";
                WeightTb.Text = "20";
                SpellFailureTb.Text = "Masterpiece, Something else, textextextextext";
                PenTb.Text = "Penaultys go here";
                NotesTb.Text = "test";


            }
            else
            {
                ItemIDTb.Text = "Heavy Armor";
                ArmorGradeCbo.SelectedIndex = 2;
                ValueTb.Text = "12321";
                ACTb.Text = "26";
                WeightTb.Text = "20";
                SpellFailureTb.Text = "Masterpiece, Something else, textextextextext";
                PenTb.Text = "Penaultys go here";
                NotesTb.Text = "test";


            }
        }

       public void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedRecord();
            if (ArmorListBox.SelectedIndices.Count > 0)
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
            InventoryList = Storage.Storage.InventoryList;
            EnableFields(false);
            LoadList();
            CurrentRecord = -1;
        }

        //Functions

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

        private void LoadList()
        {
            CurrentListKeys.Clear();
            ArmorListBox.Items.Clear();
            var q = InventoryList.Where(p => p is ArmorItem);
            foreach (var item in q.ToList())
            {
                ArmorListBox.Items.Add(item.ItemID);
                CurrentListKeys.Add(item.Key);
            }
        }

        private void LoadSelectedRecord()
        {
            int temp = -1;
            foreach (var item in ArmorListBox.SelectedIndices)
            {
                temp = (int)item;
            }
            if (temp != -1)
            {
                var q = InventoryList.Find(p => p.Key == CurrentListKeys[temp]);
                var i = (ArmorItem)q;
                CurrentRecord = i.Key;
                ItemIDTb.Text = i.ItemID;
                ValueTb.Text = i.Value.ToString();
                WeightTb.Text = i.Weight.ToString();
                ACTb.Text = i.BonusAC.ToString();
                ArmorGradeCbo.SelectedIndex = (int)i.ArmourGrade;
                SpellFailureTb.Text = i.SpellFaliure;
                NotesTb.Text = i.Notes;

            }
        }

    }
}
