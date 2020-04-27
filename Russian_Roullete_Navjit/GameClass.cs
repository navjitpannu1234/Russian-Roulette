using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russian_Roullete_Navjit
{
    class GameClass
    {
        public int nvLoad { get; set; }
        public int nvSpin { get; set; }

        public int ShootnvLoop(int nvskip)//for accessing the shoot loop
        {
            if (nvskip == 6)
            {
                nvskip = 1;
            }
            else
            {
                nvskip++;
            }
            return nvskip;
        }
    }
}
