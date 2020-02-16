using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS_Legacy_Refactored
{
    public class MockHeater : IHeater
    {
        public uint TurnOnCount { get; set; }
        public uint TurnOffCount { get; set; }
        public void TurnOn()
        {
            TurnOnCount++;
        }

        public void TurnOff()
        {
            TurnOffCount++;
        }
    }
}
