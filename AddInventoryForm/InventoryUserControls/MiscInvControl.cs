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
    public partial class MiscInvControl : InvPanel
    {
        public MiscInvControl()
        {
            InitializeComponent();
        }



        public override bool SaveRecord()
        {

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

        public override bool DataLoss()
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

        bool tf = true;

        public override void SampleInput()
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

        public override void LoadSelectedRecord()
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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CList = MiscListBox;
            CurrentRecord = -1;
            InventoryList = Storage.Storage.InventoryList;
            EnableFields(false);
            LoadList();
        }
    }
}
