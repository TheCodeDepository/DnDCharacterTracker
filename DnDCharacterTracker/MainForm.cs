using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddInventoryForm;
using CombatAddForm;


using System.Windows.Forms;


namespace DnDCharacterTracker
{

    public partial class MainForm : Form
    {

        private int maxScore = 100;
        //private Statistics newCharacterSheet;

        private List<string[]> CombatResults = new List<string[]>(); //All battle history in string[] form.


        public int strModifer
        {
            get { return GetInteger(strModTot.Text); }
            set
            {
                if (value >= -5)
                {
                    strModTot.Text = value.ToString();
                }

            }
        }
        public int dexModifer
        {
            get { return GetInteger(dexModTot.Text); }
            set { dexModTot.Text = value.ToString(); }
        }
        public int conModifer
        {
            get { return GetInteger(conModTot.Text); }
            set
            {
                if (value >= -5)
                {
                    conModTot.Text = value.ToString();
                }

            }
        }
        public int intModifer
        {
            get { return GetInteger(intModTot.Text); }
            set
            {
                if (value >= -5)
                {
                    intModTot.Text = value.ToString();
                }

            }
        }
        public int wisModifer
        {
            get { return GetInteger(wisModTot.Text); }
            set
            {
                if (value >= -5)
                {
                    wisModTot.Text = value.ToString();
                }

            }
        }
        public int chaModifer
        {
            get { return GetInteger(chaModTot.Text); }
            set
            {
                if (value >= -5)
                {
                    chaModTot.Text = value.ToString();
                }

            }
        }


        public MainForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1200, 800);

        }

        //public int GetSetRanks(int i)
        //{
        //    return (int)ranks[i].Value;
        //}
        //public void GetSetRanks(int i, int value)
        //{
        //    if (i < ranks.Length && value >= 0)
        //    {
        //        ranks[i].Value = value;
        //    }
        //}
        //public int GetSetAbiSkillsMods(int i)
        //{
        //    return GetInteger(abiMods[i].Text);
        //}
        //public void GetSetAbiSkillsMods(int i, int value)
        //{
        //    abiMods[i].Text = value.ToString();
        //}
        //public int GetSetMiscMods(int i)
        //{
        //    return GetInteger(miscMods[i].Text);
        //}
        //public void GetSetMiscMods(int i, int value)
        //{
        //    if (i < ranks.Length)
        //    {
        //        miscMods[i].Text = value.ToString();
        //    }
        //}
        //public int GetSetTotMods(int i)
        //{
        //    return GetInteger(TotMods[i].Text);
        //}
        //public void GetSetTotMods(int i, int value)
        //{
        //    if (i < ranks.Length)
        //    {
        //        TotMods[i].Text = value.ToString();
        //    }
        //}
        //public int GetAbilityModifier(int i)
        //{
        //    return GetInteger(AbilityModfiers[i].Text);
        //}



        private void OnLoad(object sender, EventArgs e)
        {


            EnabledPanelContents(this, false);
            menuStrip1.Enabled = true;

           
        }

        private void EnabledPanelContents(Form form, bool enabled)
        {
            foreach (Control ctrl in form.Controls)
            {

                ctrl.Enabled = enabled;
            }
        }

        public string ChangeStat(decimal Value1)
        {
            int result = (int)Math.Floor((decimal)((Value1 - 10) / 2));
            return string.Format("{0}", result);
        }

        private decimal MaxAbilityScore(decimal num)
        {

            decimal total = (strScore.Value + dexScore.Value + conScore.Value + intScore.Value + wisScore.Value + chaScore.Value);
            if (total > maxScore)
            {
                return -1;
            }

            return 0;
        }

        #region Scores/Modfiers


        private void strScore_ValueChanged(object sender, EventArgs e)
        {
            strScore.Value += MaxAbilityScore(strScore.Value);
            strModTot.Text = ChangeStat(strScore.Value);
            SetAllAbilityBox();

        }

        private void strMod_ValueChanged(object sender, EventArgs e)
        {

            strModTot.Text = ChangeStat(strScore.Value);
        }

        private void dexScore_ValueChanged(object sender, EventArgs e)
        {
            dexScore.Value += MaxAbilityScore(dexScore.Value);
            dexModTot.Text = ChangeStat(dexScore.Value);
            SetAllAbilityBox();

        }

        private void dexMod_ValueChanged_1(object sender, EventArgs e)
        {
            dexModTot.Text = ChangeStat(dexScore.Value);
        }

        private void conScore_ValueChanged(object sender, EventArgs e)
        {
            conScore.Value += MaxAbilityScore(conScore.Value);
            conModTot.Text = ChangeStat(conScore.Value);
            SetAllAbilityBox();

        }

        private void conMod_ValueChanged(object sender, EventArgs e)
        {
            conModTot.Text = ChangeStat(conScore.Value);
        }

        private void intScore_ValueChanged(object sender, EventArgs e)
        {
            intScore.Value += MaxAbilityScore(intScore.Value);
            intModTot.Text = ChangeStat(intScore.Value);
            SetAllAbilityBox();

        }

        private void intMod_ValueChanged(object sender, EventArgs e)
        {
            intModTot.Text = ChangeStat(intScore.Value);
        }

        private void wisScore_ValueChanged(object sender, EventArgs e)
        {
            wisScore.Value += MaxAbilityScore(wisScore.Value);
            wisModTot.Text = ChangeStat(wisScore.Value);
            SetAllAbilityBox();

        }

        private void wisMod_ValueChanged(object sender, EventArgs e)
        {
            wisModTot.Text = ChangeStat(wisScore.Value);
        }

        private void chaScore_ValueChanged(object sender, EventArgs e)
        {
            chaScore.Value += MaxAbilityScore(chaScore.Value);
            chaModTot.Text = ChangeStat(chaScore.Value);
            SetAllAbilityBox();


        }

        private void chaMod_ValueChanged(object sender, EventArgs e)
        {
            chaModTot.Text = ChangeStat(chaScore.Value);

        }
        #endregion

        private void RaceCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CharDetails_Click(object sender, EventArgs e)
        {
            //Help window = new Help();
            //window.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //newCharacterSheet = new Statistics();
            EnabledPanelContents(this, true);
        }

        private void ClassCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSKills();
        }

        private void SetSKills()
        {
            //newCharacterSheet.SetClass = (byte)ClassCombo.SelectedIndex;
            //bool[] arr = newCharacterSheet.GetClassSkills();
            //for (int i = 0; i <= (arr.Length - 1); i++)
            //{
            //    SkillsCheck.SetItemChecked(i, arr[i]);

            //}
            SetAllAbilityBox();

        }

        private void SetAllAbilityBox()
        {
            for (int i = 0; i <= 34; i++)
            {
                //GetSetAbiSkillsMods(i, GetAbilityModifier(i));
                //GetSetTotMods(i, (GetSetAbiSkillsMods(i) + GetSetMiscMods(i)));
            }
        }

        private void SkillsCheck_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //Combat Buttons

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (CombatWindow newKill = new CombatWindow())
            {
                var result = newKill.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string[] ResultingArr = { newKill.UnitIDProp, newKill.ExpereienceProp, newKill.GoldProp, newKill.LootGained };
                    CombatResults.Insert(0, ResultingArr);

                    LevelingList.Items.Insert(0, new ListViewItem(ResultingArr));

                    Gold += newKill.GoldPropInt;

                    TotalEXPProp += newKill.ExperiencePropInt;

                    return;

                }
            }

        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            ViewButtonMeth();
        }

        private void ViewButtonMeth()
        {
            int index = 0;

            if (this.LevelingList.SelectedItems.Count > 1 || this.LevelingList.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Please only select one record.");
                return;
            }

            foreach (int listViewItem in LevelingList.SelectedIndices)
            {
                index = listViewItem;
            }

            string[] arr = CombatResults[index];

            CombatWindow ViewKill = new CombatWindow(arr);

            ViewKill.AddNameProp = "Save";

            var result = ViewKill.ShowDialog();
            if (result == DialogResult.OK)
            {
                string[] ResultingArr = { ViewKill.UnitIDProp, ViewKill.ExpereienceProp, ViewKill.GoldProp, ViewKill.LootGained };
                CombatResults.RemoveAt(index);

                CombatResults.Insert(index, ResultingArr);
                LevelingList.Items.RemoveAt(index);
                LevelingList.Items.Insert(index, new ListViewItem(ResultingArr));
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LevelingList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ViewButtonMeth();

        }

        private void LevelingList_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Delete == e.KeyCode)
            {
                foreach (ListViewItem listViewItem in ((ListView)sender).SelectedItems)
                {
                    string[] arr = CombatResults[listViewItem.Index];
                    Gold = Gold - GetInteger(arr[2]);
                    TotalEXPProp = TotalEXPProp - GetInteger(arr[1]);
                    CombatResults.RemoveAt(listViewItem.Index);
                    listViewItem.Remove();
                }
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem listViewItem in LevelingList.SelectedItems)
            {
                string[] arr = CombatResults[listViewItem.Index];
                Gold = Gold - GetInteger(arr[2]);
                TotalEXPProp = TotalEXPProp - GetInteger(arr[1]);

                CombatResults.RemoveAt(listViewItem.Index);
                listViewItem.Remove();
            }

        }

        private void LevelingList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public int Gold
        {
            get
            {
                if (GoldTotal.Text.Length == 0)
                {
                    return 0;
                }
                return int.Parse(GoldTotal.Text);
            }
            set
            {
                if (value.ToString().Length > 0)
                {
                    GoldTotal.Text = value.ToString();
                }
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



        //Inventory Code


        List<string[]> InventoryListMain = new List<string[]>();


        private void InventoryViewBtn()
        {
            //{
            //    int index = 0;

            //    if (InventoryList.SelectedItems.Count != 1)
            //    {
            //        MessageBox.Show("Please only select one record.");
            //        return;
            //    }

            //    foreach (int item in InventoryList.SelectedIndices)
            //    {
            //        index = item;
            //    }
            //    var AddInventory = new InventoryForm(index ,InventoryListMain);
            //    AddInventory.ShowDialog();
            //    if (AddInventory.DialogResult != DialogResult.Cancel)
            //    {
            //        InventoryListMain = AddInventory.AllInventory;
            //        RefreshInventory();

            //    }


            //}
        }

        private void addBtnInventory_Click(object sender, EventArgs e)
        {
            //var AddInventory = new InventoryForm();
            //AddInventory.ShowDialog();

        }

        private void RefreshInventory()
        {
            //string[] Reference = { "ItemType", "ItemID", "Value", "Quantity", "Weight", "WeapType", "Range", "Damage", "Critical", "Upgrades", "Notes", "ArmourClass", "Grade", "Penaultys", "Usage" };

            //InventoryList.Items.Clear();

            //foreach (var item in InventoryListMain)
            //{
            //    string[] arr = { item[1], item[2], item[10] };
            //    InventoryList.Items.Add(new ListViewItem(arr));
            //}

            #region oldcode
            //if (FilterCbo.Text == "Catagory")
            //{
            //    var WeaponGroup = new ListViewGroup();
            //    var ArmourGroup = new ListViewGroup();
            //    var MiscGroup = new ListViewGroup();
            //    if (WeapInvList.Count > 0)
            //    {
            //        foreach (var item in WeapInvList)
            //        {
            //            string[] arr = { item[0], item[3], item[8] };
            //            WeaponGroup.Items.Add(new ListViewItem(arr));
            //        }
            //    }
            //    if (ArmourInvList.Count > 0)
            //    {
            //        foreach (var item in ArmourInvList)
            //        {
            //            string[] arr = { item[0], item[3], item[8] };
            //            ArmourGroup.Items.Add(new ListViewItem(arr));
            //        }
            //    }
            //    if (MiscInvList.Count > 0)
            //    {
            //        foreach (var item in MiscInvList)
            //        {
            //            string[] arr = { item[0], item[3], item[8] };
            //            MiscGroup.Items.Add(new ListViewItem(arr));
            //        }
            //    }



            //}
            //else
            //{
            //    if (WeapInvList.Count > 0)
            //    {
            //        foreach (var item in WeapInvList)
            //        {
            //            string[] arr = { item[0], item[3], item[8] };
            //            InventoryList.Items.Add(new ListViewItem(arr));

            //        }
            //    }
            //    if (ArmourInvList.Count > 0)
            //    {
            //        foreach (var item in ArmourInvList)
            //        {
            //            string[] arr = { item[0], item[3], item[8] };
            //            InventoryList.Items.Add(new ListViewItem(arr));
            //        }
            //    }
            //    if (MiscInvList.Count > 0)
            //    {
            //        foreach (var item in MiscInvList)
            //        {
            //            string[] arr = { item[0], item[3], item[8] };
            //            InventoryList.Items.Add(new ListViewItem(arr));
            //        }
            //    }
            //}
            #endregion

        }


        private void InventoryList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            InventoryViewBtn();

        }




        private void InventoryList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FilterCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ViewInvBtn_Click(object sender, EventArgs e)
        {
            InventoryViewBtn();
        }
    }
}



