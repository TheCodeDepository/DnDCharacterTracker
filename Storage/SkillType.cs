using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class SkillType
    {
        private static int pKey = 0;
        public string SkillName { get; set; }
        public string Description { get; set; }
        public int SkillRank { get; set; }
        public Mod AbilityMod { get; set; }
        public int SkillMiscMod { get; set; }
        public bool ClassSkill { get; set; }
        public int Key { get; private set; }


        public SkillType(string Name, string Desription, Mod abilityMod, bool classSkill)
        {
            SkillName = Name;
            Description = Desription;
            AbilityMod = abilityMod;
            ClassSkill = classSkill;
            Key = pKey;
            pKey++;
            
        }

    }
}
