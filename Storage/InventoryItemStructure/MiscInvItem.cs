using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage
{
    public class MiscInvItem : GenericValues
    {

        public string Usage { get; set; }

        public MiscInvItem(string itemID, int value, int weight, string notes, string usage) : base(itemID, value, weight, notes)
        {
            Usage = usage;
        }

        public MiscInvItem(TextBox itemID, TextBox value, TextBox weight, TextBox notes, TextBox usage) :base(itemID.Text, value.Text.ToInt(), weight.Text.ToInt(), notes.Text)
        {
            Usage = usage.Text;

        }



    }
}
