using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS_Legacy_Refactored
{
    public class ECS
    {
        private int _threshold;

        // PROPERTY INJECTION //
        public ITempSensor TempSensor_ { private get; set; }
        public IHeater Heater_ { private get; set; }

        public ECS(int thr)
        {
            SetThreshold(thr);
            TempSensor_ = new TempSensor();
            Heater_ = new Heater();
        }

        // CONSTRUCTOR INJECTION //
        public ECS(int thr, ITempSensor tempSensor)
        {
            SetThreshold(thr);
            TempSensor_ = tempSensor;
            Heater_ = new Heater();
        }
        public ECS(int thr, IHeater heater)
        {
            SetThreshold(thr);
            TempSensor_ = new TempSensor();
            Heater_ = heater;
        }
        public ECS(int thr, ITempSensor tempSensor, IHeater heater)
        {
            SetThreshold(thr);
            TempSensor_ = tempSensor;
            Heater_ = heater;
        }

        public void Regulate()
        {
            var t = TempSensor_.GetTemp();
            if (t < _threshold)
                Heater_.TurnOn();
            else
                Heater_.TurnOff();

        }

        public void SetThreshold(int thr)
        {
            _threshold = thr;
        }

        public int GetThreshold()
        {
            return _threshold;
        }

        public int GetCurTemp()
        {
            return TempSensor_.GetTemp();
        }
    }
}
