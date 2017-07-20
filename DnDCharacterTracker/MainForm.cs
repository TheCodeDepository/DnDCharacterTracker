using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage;
using MainFormPreviewCtls;

using System.Windows.Forms;


namespace MainForm
{

    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1200, 800);
            this.MaximumSize = new Size(1200, 800);



        }

        private void OnLoad(object sender, EventArgs e)
        {
            SkillList.SubsribeButtons(
                characterStats1.TotalStr,
                characterStats1.TotalDex,
                characterStats1.TotalCon,
                characterStats1.TotalInt,
                characterStats1.TotalWis,
                characterStats1.TotalCha
                );
            characterStats1.SubRefresh(skillList1.RefreshMods);

            Storage.Storage.Skills.Add(new SkillType("Flying and shit", "You can fly", Mod.STR, true));
            Storage.Storage.Skills.Add(new SkillType("Procrastination", "You can fly", Mod.STR, false));
            Storage.Storage.Skills.Add(new SkillType("Wasted Time tes", "You can fly", Mod.DEX, true));
            Storage.Storage.Skills.Add(new SkillType("Salad Muncherer", "You can fly", Mod.DEX, false));
            Storage.Storage.Skills.Add(new SkillType("Weliwopter flyi", "You can fly", Mod.STR, true));
            skillList1.GenControls();
            skillList1.DrawList();

        }

        private void EnablePanelContents(Form form, bool enabled)
        {
            foreach (Control ctrl in form.Controls)
            {
                ctrl.Enabled = enabled;
            }
        }


        private void RaceCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ClassCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }







    }
}



