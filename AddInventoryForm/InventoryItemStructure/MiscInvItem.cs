using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddInventoryForm
{
    class MiscInvItem : GenericValues
    {

        public string Usage { get; set; }
        
        public MiscInvItem(string itemID, int value, int weight, string notes, string usage):base( itemID,  value,  weight, notes)
        {
            Usage = usage;
        }
        


    }
}
