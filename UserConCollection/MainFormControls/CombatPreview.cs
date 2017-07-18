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
using ;


namespace UserConCollection.MainFormControls
{
    public partial class CombatPreview : UserControl
    {
        private List<CombatRecord> MainList = Storage.Storage.CombatList;


        public CombatPreview()
        {
            InitializeComponent();
        }
        //public CombatPreview(Form _window)
        //{
        //    InitializeComponent();
        //    window = _window;
        //}

        private void AddButton_Click(object sender, EventArgs e)
        {
            var window = new Com
            window.ShowDialog();
            LoadList();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            ViewButtonMeth();
        }

        private void ViewButtonMeth()
        {
            int index = 0;

            if (this.CombatRecords.SelectedItems.Count > 1 || this.CombatRecords.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Please only select one record.");
                return;
            }

            foreach (int listViewItem in CombatRecords.SelectedIndices)
            {
                index = listViewItem;
            }
            var Edit = new window(MainList[index].key);
            Edit.ShowDialog();
            LoadList();
            

        }   


        private void LevelingList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ViewButtonMeth();

        }

        private void LevelingList_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Delete == e.KeyCode)
            {
                foreach (ListViewItem listViewItem in CombatRecords.SelectedItems)
                {
                    MainList.RemoveAt(listViewItem.Index);
                }
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewItem in CombatRecords.SelectedItems)
            {
               MainList.RemoveAt(listViewItem.Index);
            }
        }

        private void LoadList()
        {
            CombatRecords.Items.Clear();
            foreach (var item in MainList)
            {
                string temp = string.Empty;
                foreach (var s in item.loot)
                {
                    s.Trim();
                    temp += string.Format($"{s}, ");
                }
                temp = temp.Trim(',', ' ');
                var tempList = new ListViewItem(new string[] { item.unitID, item.gold.ToString(), item.exp.ToString(), temp });
                CombatRecords.Items.Add(tempList);
            }
        }

        public int TotalEXPProp
        {
            get
            {
                if (TotalEXP.Text.Length > 0)
                {
                    return int.Parse(TotalEXP.Text);
                }
                return 0;
            }
            set
            {
                if (value.ToString().Length > 0)
                {
                    TotalEXP.Text = value.ToString();
                };
            }
        }

        private int GetInteger(string num)

        {
            int returnResult = 0;
            if (int.TryParse(num, out returnResult))
            {
                return returnResult;
            }
            return -1;
        }
    }
}
