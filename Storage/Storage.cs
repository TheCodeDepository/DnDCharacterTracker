using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;



namespace Storage
{
  
    public static class Storage
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static List<GenericValues> InventoryList = new List<GenericValues>();
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static List<CombatRecord> CombatList = new List<CombatRecord>();

    }
}
