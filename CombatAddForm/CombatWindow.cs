using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Storage;

namespace CombatForm
{
    public partial class CombatWindow : Form
    {
        private List<CombatRecord> MainList = Storage.Storage.CombatList;
        private List<Label> Asterisks = new List<Label>();

        public CombatWindow()
        {
            InitializeComponent();
        }
        public CombatWindow(int key)
        {
            InitializeComponent();
            cRecord = key;
            AddButton.Text = "Save";
        }
        private int cRecord = -1;
        private static void MessageBoxInvalidInput(string field)
        {
            string message = string.Format("Please enter a valid value in the '{0}' field.", field);
            MessageBox.Show(message, "Invaild Input", MessageBoxButtons.OK);
        }
        private bool CheckTextBoxes()
        {
            int result;
            if (string.IsNullOrEmpty(UnitIDFix.Text))
            {
                MessageBoxInvalidInput("Unit ID");
                Asterisks.Add(unitIDLbl.Asterisk());
                return false;
            }
            if (!(int.TryParse(Experience.Text, out result)))
            {
                MessageBoxInvalidInput("Experience");
                Asterisks.Add(expLbl.Asterisk());

                return false;

            }
            if (!(int.TryParse(GoldGained.Text, out result)))
            {
                GoldGained.Text = "0";
            }
            return true;
        }
        private bool CheckFieldChange()
        {
            CombatRecord q = MainList.Find(p => p.key == cRecord);
            if (UnitIDFix.Text == q.unitID)
            {
                return true;
            }
            if (GoldGained.Text == q.gold.ToString())
            {
                return true;
            }
            if (Experience.Text == q.exp.ToString())
            {
                return true;
            }
            if (q.loot == GetLootList())
            {
                return true;

            }
            return false;
        }
        private List<string> GetLootList()
        {
            List<string> lootList = new List<string>();
            foreach (DataGridViewRow row in LootGrid.Rows)
            {
                string input = string.Empty;
                input += row.Cells[0].Value;
                if (!string.IsNullOrEmpty(input))
                {
                    var CharUpper = Char.ToUpper(input[0]) + input.Substring(1);
                    lootList.Add(CharUpper);
                }

            }
            Close();
            return lootList;
        }
        private void LoadRecord()
        {
            CombatRecord q = MainList.Find(p => p.key == cRecord);
            UnitIDFix.Text = q.unitID;
            GoldGained.Text = q.gold.ToString();
            Experience.Text = q.exp.ToString();
            foreach (string item in q.loot)
            {
                LootGrid.Rows.Add(item);
            }
        }
        private void CombatWindow_Load(object sender, EventArgs e)
        {
            if (cRecord != -1)
            {
                LoadRecord();
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            var temp = new CombatRecord(UnitIDFix, Experience, GoldGained, GetLootList());
            Asterisks.Clear();
            if (cRecord != -1)
            {
                var q = MainList.FindIndex(p => p.key == cRecord);
                MainList.RemoveAt(q);
                MainList.Add(temp);
            }
            else if (CheckTextBoxes())
            {
                MainList.Add(temp);                
            }

        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (CheckFieldChange())
            {

                var m = MessageBox.Show("Are you sure you wish to quit without saveing?", "Cancel", MessageBoxButtons.YesNo);
                if (m == DialogResult.Yes)
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }       

    }

}
