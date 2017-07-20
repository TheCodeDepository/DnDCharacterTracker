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

namespace MainFormPreviewCtls


{
    public partial class SkillList : UserControl
    {
        public SkillList()
        {
            InitializeComponent();

        }

        List<SkillControl> SkillItems = new List<SkillControl>();
        List<SkillType> Skills = Storage.Storage.Skills;
        private static List<Func<int>> Mods = new List<Func<int>>();
        public static void SubsribeButtons(Func<int> str, Func<int> dex, Func<int> con, Func<int> INT, Func<int> wis, Func<int> cha)
        {
            Mods.Add(str);
            Mods.Add(dex);
            Mods.Add(con);
            Mods.Add(INT);
            Mods.Add(wis);
            Mods.Add(cha);

        }




        private void MngInvButton_Click(object sender, EventArgs e)
        {
            ClassSkills.SkillsForm manage = new ClassSkills.SkillsForm();
            manage.ShowDialog();
            GenControls();
            DrawList();
            RefreshMods();
        }

        public void GenControls()
        {
            SkillItems.Clear();

            foreach (SkillType item in Skills)
            {

                switch (item.AbilityMod)
                {
                    case Mod.STR:
                        SkillItems.Add(new SkillControl(item.SkillName, item.SkillRank, "STR:", Mods[0], item.ClassSkill));
                        break;
                    case Mod.DEX:
                        SkillItems.Add(new SkillControl(item.SkillName, item.SkillRank, "DEX:", Mods[1], item.ClassSkill));
                        break;
                    case Mod.CON:
                        SkillItems.Add(new SkillControl(item.SkillName, item.SkillRank, "CON:", Mods[2], item.ClassSkill));
                        break;
                    case Mod.INT:
                        SkillItems.Add(new SkillControl(item.SkillName, item.SkillRank, "INT:", Mods[3], item.ClassSkill));
                        break;
                    case Mod.WIS:
                        SkillItems.Add(new SkillControl(item.SkillName, item.SkillRank, "WIS:", Mods[4], item.ClassSkill));
                        break;
                    case Mod.CHA:
                        SkillItems.Add(new SkillControl(item.SkillName, item.SkillRank, "CHA:", Mods[5], item.ClassSkill));
                        break;
                    default:
                        break;
                }


            }
        }
        public void RefreshMods()
        {
            foreach (var item in SkillItems)
            {
                item.RefreshAbilityModifier();
            }
        }

        public void DrawList()
        {
            int loc = 3;
            foreach (var item in SkillItems)
            {
                item.Location = new Point(3, loc);
                ListPanel.Controls.Add(item);
                loc = (item.Location.Y + item.Height + 3);
            }
        }


    }


}
