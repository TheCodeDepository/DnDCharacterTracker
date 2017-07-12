using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage
{
    public enum TypeOfArmour
    {
        Light,Medium,Heavy
    }
    public class ArmorItem : GenericValues
    {

        public int BonusAC { get; set; }
        public TypeOfArmour ArmourGrade { get; set; }
        public string CheckPenaulty { get; set; }
        public string  SpellFaliure { get; set; }


        public ArmorItem(string itemID, int value, int weight, string notes, int bonusAc,TypeOfArmour armorGrade,string penaultyCheck,string spellFaliure) :base(itemID, value, weight, notes)
        {
            BonusAC = bonusAc;
            ArmourGrade = armorGrade;
            CheckPenaulty = penaultyCheck;
            SpellFaliure = spellFaliure;
        }

        public ArmorItem(TextBox itemID, TextBox value, TextBox weight, TextBox notes, TextBox bonusAc, ComboBox armorGrade, TextBox penaultyCheck, TextBox spellFaliure) : base(itemID.Text, value.Text.ToInt(), weight.Text.ToInt(), notes.Text)
        {
            BonusAC = bonusAc.Text.ToInt();
            ArmourGrade = (TypeOfArmour)armorGrade.SelectedIndex;
            CheckPenaulty = penaultyCheck.Text;
            SpellFaliure = spellFaliure.Text;
        }
    }
}
