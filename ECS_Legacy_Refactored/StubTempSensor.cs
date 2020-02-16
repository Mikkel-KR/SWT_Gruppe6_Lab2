using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS_Legacy_Refactored
{
    public class StubTempSensor : ITempSensor
    {
        public StubTempSensor(int tmp)
        {
            Temperature = tmp;
        }

        public int Temperature { get; set; }

        public int GetTemp()
        {
            return Temperature;
        }
    }
}
