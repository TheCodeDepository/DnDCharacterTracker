using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Storage;

namespace Storage
{

    public struct CombatRecord
    {
        private static int pKey = 0;
        public int key;
        public string unitID;
        public int exp;
        public int gold;
        public List<string> loot;
        public CombatRecord(TextBox UnitID, TextBox Exp, TextBox Gold, List<string> Loot)
        {
            key = pKey;
            pKey++;
            unitID = UnitID.Text;
            exp = Exp.Text.ToInt();
            gold = Gold.Text.ToInt();
            loot = Loot;
        }
        public CombatRecord(string UnitID, int Exp, int Gold, List<string> Loot)
        {
            key = pKey;
            pKey++;
            unitID = UnitID;
            exp = Exp;
            gold = Gold;
            loot = Loot;
        }

        public int GetKey()
        {
            return key;
        }






    }
}
