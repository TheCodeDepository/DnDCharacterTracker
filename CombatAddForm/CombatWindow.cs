using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatAddForm
{
    public partial class CombatWindow : Form
    {

        private string lootAquired = null;
        string[] ImportedArray;

        public CombatWindow()
        {
            InitializeComponent();
        }

        public CombatWindow(string[] arr)
        {
            InitializeComponent();
            ImportedArray = arr;
            UnitIDProp = arr[0];
            ExpereienceProp = arr[1];
            GoldProp = arr[2];
            LootGained = arr[3];
        }

        public string AddNameProp
        {
            get { return AddButton.Text; }
            set { AddButton.Text = value; }
        }

        public string LootGained
        {
            get { return lootAquired; }

            set
            {
                string[] arr = value.Split(',');
                foreach (var item in arr)
                {
                    LootGrid.Rows.Add(item.Trim(' '));
                }
                LootGrid.AllowUserToAddRows = true;
            }
        }

        public string UnitIDProp
        {
            get
            {
                if (UnitIDFix.Text != "")
                {
                    return UnitIDFix.Text.First().ToString().ToUpper() + UnitIDFix.Text.Substring(1);
                }
                return null;
             }
            set { UnitIDFix.Text = value; }
        }

        public string ExpereienceProp
        {
            get { return Experience.Text; }
            set { Experience.Text = value; }
        }

        public int ExperiencePropInt
        {
            get
            {
                if (Experience.Text.Length > 0)
                {
                    return int.Parse(Experience.Text);
                }
                return 0;
            }
            set
            {
                if (value.ToString().Length > 0)
                {
                    Experience.Text = value.ToString();
                }
            }
        }

        public string GoldProp
        {
            get { return GoldGained.Text; }
            set { GoldGained.Text = value; }
        }

        public int GoldPropInt
        {
            get
            {
                if (GoldGained.Text.Length > 0)
                {
                    return int.Parse(GoldGained.Text);
                }
                return 0;
            }
            set
            {
                if (value.ToString().Length > 0)
                {
                    GoldGained.Text = value.ToString();
                }
            }
        }

        private bool CheckValidValue()
        {
            int result;
            if (UnitIDProp == null)
            {
                MessageBoxInvalidInput("Unit ID");
                return false;
            }
            if (!(int.TryParse(ExpereienceProp, out result)))
            {
                MessageBoxInvalidInput("Experience");
                return false;
            }
            if (!(int.TryParse(GoldProp, out result)))
            {
                MessageBoxInvalidInput("Gold");
                return false;
            }
            
            return true;
            #region
            //truefalse = UnitIDProp != string.Empty;
            //if (!truefalse) { message += "'Unit ID'"; }
            //truefalse = (int.TryParse(GoldProp, out result));
            //if (!truefalse) { message += "'Gold'"; }

            //truefalse = (int.TryParse(ExpereienceProp, out result));
            //if (!truefalse) { message += "'Experience'"; }
            //if (true)
            //{

            //}
            //MessageBox.Show("Please enter a valid value in the 'Gold' field.", "Invaild Input", MessageBoxButtons.OK);
            //return truefalse;
#endregion
        }

        private static void MessageBoxInvalidInput(string field)
        {
            string message = string.Format("Please enter a valid value in the '{0}' field.", field);
            MessageBox.Show(message, "Invaild Input", MessageBoxButtons.OK);
        }

        private void GetLootList()
        {
            

            foreach (DataGridViewRow row in LootGrid.Rows)
            {
                string result = "";
                string input = string.Empty;
                input += row.Cells[0].Value;
                if (!(input == ""))
                {
                    result = input.First().ToString().ToUpper() + input.Substring(1);
                    if (lootAquired == null)
                    {
                        lootAquired += result;
                    }
                    else
                    {
                        lootAquired += string.Format(", {0}", result);
                    }
                }

            }
            if (lootAquired != null)
            {
                lootAquired = lootAquired.TrimEnd(' ', ',');

            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int GoldNum;
            if (!CheckValidValue())
            {
                return;
            }
            var box = MessageBox.Show("Are you sure you want to save any changes made?", "Save File", MessageBoxButtons.YesNo);


            if (!(int.TryParse(GoldGained.Text, out GoldNum)) || box == DialogResult.No)
            {
                return;
            }
            GetLootList();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            
            if (LootGained != null || UnitIDProp != null || ExpereienceProp != null || GoldGained != null)
            {
                if (CheckEquality())
                {
                    Close();
                }
                CloseWindow();
            }
            else
            {
                CloseWindow();
            }

        }
        
        private bool CheckEquality()
        {
            
            
            bool truefalse = false;
            if (ImportedArray == null)
            {
                return truefalse;
            }
            string one = ImportedArray[0];
            string two = ImportedArray[1];
            string three = ImportedArray[2];
            string four = ImportedArray[3];
            string one1 = UnitIDProp;
            string two2 = ExpereienceProp;
            string three3 = GoldProp;
            string four4 = LootGained;


            if (one1 == one && two == two2 && three == three3 && four == four4)
            {
                truefalse = true;
            }
            return truefalse;
        }

        private void CloseWindow()
        {
            var message = MessageBox.Show("Are you sure you want to close this window without saveing?", "Exit", MessageBoxButtons.YesNo);

            if (message == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                return;
            }
        }

        private void LootGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CombatWindow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UnitIDProp = "test";
            ExpereienceProp = "300";
            GoldProp = "400";
            LootGrid.Rows.Add("test");
            LootGrid.Rows.Add("test1");
        }
    }

}
