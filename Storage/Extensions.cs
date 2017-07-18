using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.ComponentModel;
using Storage;

namespace Storage
{
    public static class Extensions
    {
        public static List<Label> Asterisks { get; private set; }

        public static int ToInt(this string str)
        {
            int result = -1 ;
            int.TryParse(str, out result);
            return result;
        }

        public static string ToUpperFirstLetter(this string source)
        {
            if (string.IsNullOrEmpty(source))
            {
                return string.Empty;
            }
            char[] letters = source.ToCharArray();
            letters[0] = char.ToUpper(letters[0]);
            return new string(letters);
        }

        public static string ToTitleCase(this string str)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }

        public static Label Asterisk(this Label label)
        {
            var p = label.Location;
            Label l = new Label();
            l.Location = new Point(p.X - 10, p.Y);
            l.Text = @"*";
            l.ForeColor = Color.Red;
            l.Font = new Font("Microsoft Sans Serif", 10);
            
            
            return l;
        }


    }
}
