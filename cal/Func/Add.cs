using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal.Func
{
    public class Add
    {
        public Add(string first, string second)
        {
            if (double.TryParse(first, out var f) && double.TryParse(second, out var s))
            {
                First = f;
                Second = s;
                Result = First + Second;
            }
            else
            {
                Result = null;
            }
        }

        private double? First {  get; set; }
        private double? Second {  get; set; }
        public double? Result {  get; set; }
    }
}
