using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal.Func
{
    public class Root
    {
        public Root(string second)
        {
            if (double.TryParse(second, out var s))
            {
                Second = s;
                Result = Math.Sqrt((double)Second);
            }
            else
            {
                Result = null;
            }
        }

        private double? Second { get; set; }
        public double? Result { get; set; }
    }
}
