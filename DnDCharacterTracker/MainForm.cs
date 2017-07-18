using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage;


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

           
        }

        private void EnablePanelContents(Form form, bool enabled)
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

        private void strScore_ValueChanged(object sender, EventArgs e)
        {          

        }

        private void strMod_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void dexScore_ValueChanged(object sender, EventArgs e)
        {         

        }

        private void dexMod_ValueChanged_1(object sender, EventArgs e)
        {
    
        }

        private void conScore_ValueChanged(object sender, EventArgs e)
        {  

        }

        private void conMod_ValueChanged(object sender, EventArgs e)
        {

        }

        private void intScore_ValueChanged(object sender, EventArgs e)
        {

        }

        private void intMod_ValueChanged(object sender, EventArgs e)
        {

        }

        private void wisScore_ValueChanged(object sender, EventArgs e)
        {

        }

        private void wisMod_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chaScore_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chaMod_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void RaceCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CharDetails_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
  

        }

        private void ClassCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void SkillsCheck_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        List<string[]> InventoryListMain = new List<string[]>();






    }
}



