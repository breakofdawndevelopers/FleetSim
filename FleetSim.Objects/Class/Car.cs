using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects;
using FleetSim.Objects.Interface;
using FleetSim.Objects.Enum;

namespace FleetSim.Objects.Class
{
        public class Car : Vehicle
        {
            public int year;
            public string make;
            public string model;
        

        public string Make { get; }

        public string Model { get; }

        public int Year { get; }
        private ColorType _color;

       public Car (int year, string make, string model, ColorType color )
        { this.Model = model;
            this._color = color;
        }

        public Car(int year, string make, string model )
            {

                if (make == null)
                    throw new ArgumentNullException("The make cannot be null.");
                else if (String.IsNullOrWhiteSpace(make))
                    throw new ArgumentException("make cannot be an empty string or have space characters only.");
                Make = make;

                if (model == null)
                    throw new ArgumentNullException("The model cannot be null.");
                else if (String.IsNullOrWhiteSpace(model))
                    throw new ArgumentException("model cannot be an empty string or have space characters only.");
                Model = model;

                if (year < 1857 || year > DateTime.Now.Year + 2)
                    throw new ArgumentException("The year is out of range.");
                Year = year;
            }

            public override string ToString() => $"{Year} {Make} {Model}";
        }
    }
