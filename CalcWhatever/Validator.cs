using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcWhatever
{
    public static class Validator
    {
        public static int? ValidIsNumber(string str)
        {
            if(int.TryParse(str.Trim(), out var result))
            {
                return result;
            }

            return null;
            //return int.TryParse(str.Trim(), out int result) ? result : null;
        }

        
    }
}
