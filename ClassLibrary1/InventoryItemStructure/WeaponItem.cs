using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class WeaponItem : GenericValues
    {

        public string Damage { get; set; }
        public string Critical { get; set; }
        public string Upgrades { get; set; }
        public int Range { get; set; }

        public WeaponItem(string itemID, int value, int weight, string notes, string damage, string critical, int range, string upgrades) :base(itemID,  value,  weight, notes)
        {
            Damage = damage;
            Critical = critical;
            Range = range;
            Upgrades = upgrades;
            if (range < 1)
            {
                Range = 0;
            }

        }
    }
}
