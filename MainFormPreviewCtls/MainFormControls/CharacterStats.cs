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

namespace MainFormPreviewCtls.MainFormControls
{
    public partial class CharacterStats : UserControl
    {
        public CharacterStats()
        {
            InitializeComponent();
  
        }

        public string ChangeStat(NumericUpDown Value1)
        {            
           return ((int)Math.Floor(Value1.Value - 10) / 2).ToString();
        }

        Action RefreshSkills;

        public void SubRefresh(Action a)
        {
            RefreshSkills = a;
        }

        private void CharacterStats_Load(object sender, EventArgs e)
        {
        }

        private void StrModChange(object sender, EventArgs e)
        {
            RefreshSkills();

        }
        private void DexModChange(object sender, EventArgs e)
        {
            RefreshSkills();

        }
        private void ConModChange(object sender, EventArgs e)
        {
            RefreshSkills();

        }
        private void IntModChange(object sender, EventArgs e)
        {
            RefreshSkills();

        }
        private void WisModChange(object sender, EventArgs e)
        {
            RefreshSkills();

        }
        private void ChaModChange(object sender, EventArgs e)
        {
            RefreshSkills();

        }


        public int TotalStr()
        {
           return strModTot.Text.ToInt();
        }
        public int TotalDex()
        {
            return dexModTot.Text.ToInt();
        }
        public int TotalCon()
        {
            return conModTot.Text.ToInt();
        }
        public int TotalInt()
        {
            return intModTot.Text.ToInt();
        }
        public int TotalWis()
        {
            return wisModTot.Text.ToInt();
        }
        public int TotalCha()
        {
            return chaModTot.Text.ToInt();
        }


        private void conScore_ValueChanged(object sender, EventArgs e)
        {
            conModTot.Text = ChangeStat(conScore);
        }

        private void chaScore_ValueChanged(object sender, EventArgs e)
        {
            chaModTot.Text = ChangeStat(chaScore);
        }

        private void dexScore_ValueChanged(object sender, EventArgs e)
        {
            dexModTot.Text = ChangeStat(dexScore);
        }

        private void intScore_ValueChanged(object sender, EventArgs e)
        {
            intModTot.Text = ChangeStat(intScore);
        }

        private void wisScore_ValueChanged(object sender, EventArgs e)
        {
            wisModTot.Text = ChangeStat(wisScore);
        }

        private void strScore_ValueChanged(object sender, EventArgs e)
        {
            strModTot.Text = ChangeStat(strScore);
        }


    }
}
