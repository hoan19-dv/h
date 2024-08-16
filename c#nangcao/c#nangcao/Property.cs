using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_nangcao
{
    public class Date
    {
        int _month;
        public int Month
        {
            get { return _month; }
            set
            {
                if (value > 0 && value < 13)
                {
                    _month = value;
                }
            }
        }
       public void date()
        {   
            Console.WriteLine(Month);
        }
    }
}
