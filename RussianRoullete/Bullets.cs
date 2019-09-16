using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRoullete
{
    public class Bullets
    {
        public int Load { get; set; }
        public int Spin { get; set; }

        public int ShootLoop(int skip)//This fumction is for setting shoot the gun that how many chance it will take
        {
            if(skip==6)
            {
                skip = 1;
            }
            else
            {
                skip++;
            }
            return skip;
        }
    }
}
