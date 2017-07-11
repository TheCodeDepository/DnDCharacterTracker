using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;



namespace Storage
{
    public class WeaponItem : GenericValues, IEquatable<WeaponItem>
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
        public WeaponItem(string itemID, string value, string weight, string notes, string damage, string critical, string range, string upgrades) : base(itemID, value.ToInt(), weight.ToInt(), notes)
        {
            Damage = damage;
            Critical = critical;
            Range = range.ToInt();
            Upgrades = upgrades;
            if (range.ToInt() < 1)
            {
                Range = 0;
            }

        }
        public WeaponItem(TextBox itemID, TextBox value, TextBox weight, TextBox notes, TextBox damage, TextBox critical, TextBox range, TextBox upgrades) : base(itemID.Text, value.Text.ToInt(), weight.Text.ToInt(), notes.Text)
        {
            Damage = damage.Text;
            Critical = critical.Text;
            Range = range.Text.ToInt();
            Upgrades = upgrades.Text;
            if (range.Text.ToInt() < 1)
            {
                Range = 0;
            }

        }

        public bool Equals(WeaponItem other)
        {
            
            if (ItemID != other.ItemID)
            {
                return false;
            }
            if (Value != other.Value)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;

            }
            if (Notes != other.Notes)
            {
                return false;

            }
            if (Damage != other.Damage)
            {
                return false;

            }
            if (Critical != other.Critical)
            {
                return false;

            }
            if (Range != other.Range)
            {
                return false;

            }
            if (Upgrades != other.Upgrades)
            {
                return false;
            }
            return true;
        }
    }
}
