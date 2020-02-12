using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS_Legacy_Refactored
{
    internal class TempSensor
    {
        private Random gen = new Random();

        public int GetTemp()
        {
            return gen.Next(-5, 45);
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
