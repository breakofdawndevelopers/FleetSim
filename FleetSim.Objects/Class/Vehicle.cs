using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects.Enum;
using FleetSim.Objects.Interface;

namespace FleetSim.Objects

{
    public class Vehicle
    {
        private Guid _vin;
        private int _mileage;
        private string _lastServicedDate;
        private int _lastServicedMileage;

        public Vehicle()
        {
            _mileage = 0;
            _lastServicedMileage = 0;
        }

        public Guid vin
        {
            get { return _vin; }
            set { _vin = value; }
        }
        public int mileage
        {
            get { return _mileage; }
            set
            {
                _mileage = value;
                TuneUp();
            }
        }
        public string color //enum
        {
            get { return color; }
            set { color = value; }
        }
        public string lastServicedDate
        {
            get { return _lastServicedDate; }
            set { _lastServicedDate = value; }
        }
        public int lastServicedMileage
        {
            get { return _lastServicedMileage; }
            set { _lastServicedMileage = value; }
        }

        public void TuneUp()
        {
            if ((mileage - lastServicedMileage) >= 30000)
            {
                lastServicedMileage = mileage;
                lastServicedDate = DateTime.Now.ToString(" M/d/yyyy hh:mm:ss");
                Console.WriteLine("Vehicle tuned up at " + lastServicedMileage + lastServicedDate);

            }
            if (mileage >= 100000)
            {
                lastServicedDate = DateTime.Now.ToString(" M/d/yyyy hh:mm:ss");
                lastServicedMileage = mileage;
                Console.WriteLine("Vehicle tuned up at " + lastServicedMileage + lastServicedDate);

                RebuildEngine();
            }
        }

        public void RebuildEngine()
        {
            mileage = 0;
            lastServicedMileage = 0;
            Console.WriteLine("Engine rebuilt on " + lastServicedDate);
        }
    }
}
