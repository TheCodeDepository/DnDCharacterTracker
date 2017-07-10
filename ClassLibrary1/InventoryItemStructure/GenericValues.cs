using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public abstract class GenericValues
    {
         GenericValues(string itemID, int value, int weight, string notes)
        {
            ItemID = itemID;
            Value = value;
            Weight = weight;
            Notes = notes;
        }
        public string ItemID { get; set; }
        public int Value { get; set; }
        public int Weight { get; set; }
        public string Notes { get; set; }
    }
}
