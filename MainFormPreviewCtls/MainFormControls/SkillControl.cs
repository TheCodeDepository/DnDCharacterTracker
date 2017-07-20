﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Storage;

namespace MainFormPreviewCtls
{ 
    
    public partial class SkillControl : UserControl
    {
        

        public SkillControl()
        {
            InitializeComponent();
        }

        public string SkilName { get { return SkillName.Text; } set { SkillName.Text = value; } }
        public int RankTextBox { get { return RankTb.Text.ToInt(); } set { RankTb.Text = value.ToString(); } }
        public int MiscModifier { get { return MiscMod.Text.ToInt(); } private set {  MiscMod.Text = value.ToString(); } }


        private int Total { get { return TotalTb.Text.ToInt(); } set { TotalTb.Text = value.ToString(); } }
        private string AbilityModType { get { return ModTypeLbl.Text; } set { ModTypeLbl.Text = value; } }
        private int AbilityModifier { get { return ModTb.Text.ToInt(); } set { ModTb.Text = value.ToString(); } }
        private bool ClassSkill { get; set; }


        Func<int> AbiMod;

        public SkillControl(string name, int rank, string modLbl, Func<int> Mod,bool classSkill)
        {
            InitializeComponent();
            SkilName = name;
            RankTextBox = rank;
            AbiMod = Mod;
            AbilityModType = modLbl;
            ClassSkill = classSkill;
        }
        public void RefreshAbilityModifier()
        {
            AbilityModifier = AbiMod();
        }

      


   





        private void ModTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Total = AbilityModifier + MiscModifier + (RankTextBox * Storage.Storage.CharacterLevel);
        }

        private void label156_Click(object sender, EventArgs e)
        {

        }

        private void label111_Click(object sender, EventArgs e)
        {

        }

        private void ModTypeLbl_Click(object sender, EventArgs e)
        {

        }

        private void ModTb_TextChanged(object sender, EventArgs e)
        {
            int misc = 0;
            if (ClassSkill is true)
            {
                if (RankTextBox > 0)
                {
                    misc += 3;
                    misc += RankTextBox;
                    MiscModifier = misc;
                    Total = misc + AbilityModifier;

                }

            }
            else
            {
                MiscModifier = RankTextBox;
                Total = misc + AbilityModifier;
            }
            
        }
    }


}
