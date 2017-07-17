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
using Storage;


using System.Windows.Forms;


namespace DnDCharacterTracker
{

    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1200, 800);

        }

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

            //decimal total = (strScore.Value + dexScore.Value + conScore.Value + intScore.Value + wisScore.Value + chaScore.Value);
            //if (total > maxScore)
            //{
            //    return -1;
            //}

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
            //for (int i = 0; i <= 34; i++)
            //{
            //    GetSetAbiSkillsMods(i, GetAbilityModifier(i));
            //    GetSetTotMods(i, (GetSetAbiSkillsMods(i) + GetSetMiscMods(i)));
            //}
        }

        private void SkillsCheck_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //Combat Buttons

       



        //Inventory Code


        List<string[]> InventoryListMain = new List<string[]>();






    }
}



