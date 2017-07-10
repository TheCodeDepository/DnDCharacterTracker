﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        ArmorItem(string itemID, int value, int weight, string notes, int bonusAc,TypeOfArmour armorGrade,string penaultyCheck,string spellFaliure) :base(itemID, value, weight, notes)
        {
            BonusAC = bonusAc;
            ArmourGrade = armorGrade;
            CheckPenaulty = penaultyCheck;
            SpellFaliure = spellFaliure;
        }
    }
}
