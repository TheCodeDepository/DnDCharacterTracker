using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public static class Storage
    {


        public static List<GenericValues> inventoryList = new List<GenericValues>();
        public static List<GenericValues> InventoryList
        {
            get { return inventoryList; }
            set { inventoryList = value; }
        }

    }
}
