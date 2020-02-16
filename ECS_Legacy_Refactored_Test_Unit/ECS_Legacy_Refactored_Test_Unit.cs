using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS_Legacy_Refactored;

namespace ECS_Legacy_Refactored_Test_Unit
{

    [TestFixture]
    public class ECSTest
    {
        private ECS uut;



        [SetUp]
        public void SetupTest()
        {
            
        }

        [Test]
        public void Regulate_TemperatureUnderThreshold_HeaterTurnOnCalled(int threshold, int temperature, uint TurnOnCount, uint TurnOffCount)
        {
            uut.Heater_ = new MockHeater();
            uut.TempSensor_ = new StubTempSensor(temperature);


        }




    }
}
