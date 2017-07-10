using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public static class Extensions
    {

        public static int ToInt(this string str)
        {
            int result = -1 ;
            int.TryParse(str, out result);
            return result;
        }

    }
}
