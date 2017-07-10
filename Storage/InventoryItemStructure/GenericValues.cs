using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public abstract class GenericValues
    {
        public static int LastKey = 0;
        public GenericValues(string itemID, int value, int weight, string notes)
        {
            ItemID = itemID;
            Value = value;
            Weight = weight;
            Notes = notes;
            Key = LastKey++;
        }
        public int Key { get; set; }
        public string ItemID { get; set; }
        public int Value { get; set; }
        public int Weight { get; set; }
        public string Notes { get; set; }
    }
}
