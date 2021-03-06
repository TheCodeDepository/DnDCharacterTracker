﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDCharacterTracker
{
    public partial class SkillControl : UserControl
    {
        public SkillControl()
        {
            InitializeComponent();
        }
        public string SkilName { get { return SkillName.Text; } set { SkillName.Text = value; } }
        public int RankTextBox { get { return GetInteger(RankTb.Text); } set { RankTb.Text = value.ToString(); } }
        public int AbilityModifier { get { return GetInteger(ModTb.Text); } set { ModTb.Text = value.ToString(); } }
        public int MiscModifier { get {return GetInteger(MiscMod.Text); } private set {  MiscMod.Text = value.ToString(); } }
        public int Total { get { return GetInteger(TotalTb.Text); } private set { TotalTb.Text = value.ToString(); } }
        public string AbilityModType { get { return ModTypeLbl.Text; } set { ModTypeLbl.Text = value; } }







        private int GetInteger(string s)
        {
            int num;
            if (int.TryParse(s, out num))
            {
                return num;
            }
            return -5;
        }

        private void ModTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Total = AbilityModifier + MiscModifier;
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
    }
}
