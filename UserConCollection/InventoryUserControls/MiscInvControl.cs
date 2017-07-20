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
    public partial class MiscInvControl : UserControl , IButtons
    {
        public MiscInvControl()
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
                InventoryList[query] = new MiscInvItem(ItemIDTb, ValueTB, WeightTb, NotesTb, UsageTb);
            }
            else
            {
                InventoryList.Add(new MiscInvItem(ItemIDTb, ValueTB, WeightTb, NotesTb, UsageTb));
            }
      
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
            if (string.IsNullOrWhiteSpace(ValueTB.Text))
            {
                Asterisk(ValueLbl.Location);

                result = true;


            }
            if (string.IsNullOrWhiteSpace(WeightTb.Text))
            {
                Asterisk(WeightLbl.Location);
                result = true;

            }

            if (string.IsNullOrWhiteSpace(UsageTb.Text))
            {
                Asterisk(UsageLbl.Location);

                result = true;


            }
            return result;
        }

        public bool DataLoss()
        {


            var CurrentFields =  new MiscInvItem(ItemIDTb, ValueTB, WeightTb, NotesTb, UsageTb);
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
                ItemIDTb.Text = "Wand of healing";
                ValueTB.Text = "300";
                WeightTb.Text = "5";
                UsageTb.Text = "1d4 Heal, 15 feet.";
                NotesTb.Text = "Found in Britonia";


            }
            else
            {
                ItemIDTb.Text = "Healing Potion";
                ValueTB.Text = "50";
                WeightTb.Text = "1";
                UsageTb.Text = "Heal 50 HP";
                NotesTb.Text = "Found in Wurst";


            }
        }

        public void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedRecord();
            if (MiscListBox.SelectedIndices.Count > 0)
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
            MiscListBox.Items.Clear();
            var q = InventoryList.Where(p => p is MiscInvItem);
            foreach (var item in q.ToList())
            {
                MiscListBox.Items.Add(item.ItemID);
                CurrentListKeys.Add(item.Key);
            }
        }

        private void LoadSelectedRecord()
        {
            int temp = -1;
            foreach (var item in MiscListBox.SelectedIndices)
            {
                temp = (int)item;
            }
            if (temp != -1)
            {
                var q = InventoryList.Find(p => p.Key == CurrentListKeys[temp]);
                var i = (MiscInvItem)q;
                CurrentRecord = i.Key;
                ItemIDTb.Text = i.ItemID;
                ValueTB.Text = i.Value.ToString();
                WeightTb.Text = i.Weight.ToString();
                UsageTb.Text = i.Usage;
                NotesTb.Text = i.Notes;

            }
        }

    }
}
