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
    public partial class ArmorInvControl : InvPanel
    {
        public ArmorInvControl()
        {
            InitializeComponent();
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
                InventoryList[query] = new ArmorItem(ItemIDTb, ValueTb, WeightTb, NotesTb, ACTb, ArmorGradeCbo, PenTb, SpellFailureTb);
            }
            else
            {
                InventoryList.Add(new ArmorItem(ItemIDTb, ValueTb, WeightTb, NotesTb, ACTb, ArmorGradeCbo, PenTb, SpellFailureTb));
            }


            LoadList();
            ClearFields();
            return true;
        }

        public override bool DataLoss()
        {


            var CurrentFields = new ArmorItem(ItemIDTb, ValueTb, WeightTb, NotesTb, ACTb, ArmorGradeCbo, PenTb, SpellFailureTb);
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

        public override void Panel_Load(object sender, EventArgs e)
        {
            InventoryList = Storage.Storage.InventoryList;
            EnableFields(false);
            LoadList();
            CurrentRecord = -1;
            this.CList = ArmorListBox;
        }

        public override void LoadSelectedRecord()
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
