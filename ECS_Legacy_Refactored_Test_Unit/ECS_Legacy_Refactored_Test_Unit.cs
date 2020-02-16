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

        [TestCase(-5, -10, 1)]
        [TestCase(5, 0, 1)]
        [TestCase(5, -5, 1)]
        public void Regulate_TemperatureUnderThreshold_HeaterTurnOnCalled(int threshold, int temperature, int onCountResult)
        {
            uut = new ECS(threshold);

            MockHeater TestHeater = new MockHeater();
            StubTempSensor TestSensor = new StubTempSensor(temperature);
            uut.TempSensor_ = TestSensor;
            uut.Heater_ = TestHeater;

            uut.Regulate();

            Assert.That(onCountResult, Is.EqualTo(TestHeater.TurnOnCount));
        }


        [TestCase(5, 10, 0)]
        [TestCase(-10, -5, 0)]
        [TestCase(-5, 5, 0)]
        public void Regulate_TemperatureOverThreshold_HeaterTurnOnNotCalled(int threshold, int temperature, int onCountResult)
        {
            uut = new ECS(threshold);

            MockHeater TestHeater = new MockHeater();
            StubTempSensor TestSensor = new StubTempSensor(temperature);
            uut.TempSensor_ = TestSensor;
            uut.Heater_ = TestHeater;

            uut.Regulate();

            Assert.That(onCountResult, Is.EqualTo(TestHeater.TurnOnCount));
        }



    }
}
