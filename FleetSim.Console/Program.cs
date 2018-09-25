using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects;
using FleetSim.Objects.Class;
using FleetSim.Objects.Enum;
using FleetSim.Objects.Interface;



namespace FleetSim.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> Cars = new List<Car>()
            {
            new Car(1989, "Ford", "Taurus", ColorType.Red),
            new Car(1998, "Toyota", "Camry", ColorType.Blue),
            new Car(2005, "Honda", "Accord", ColorType.White),
            new Car(2010, "GMC", "Suburban", ColorType.Red),
            new Car(2015, "Jeep", "Wrangler", ColorType.Blue),
            };

            int count = 1;
            {
                foreach (Car Car in Cars)
                {
                    for (count = 1; count <= 10; count++)
                        try
                        {
                            Random rnd = new Random();
                            int rndNum = rnd.Next(5000, 15000);
                            Car.mileage += rndNum;

                            Car.TuneUp();
                            System.Console.WriteLine("Iteration {0}", count);
                            System.Console.WriteLine((Car) + " Current mileage " + Car.mileage);
                        }

                        catch (Exception ex)
                        {
                            System.Console.WriteLine("General Exception Caught" + ex.Message);
                        }
                        finally
                        {
                            System.Console.WriteLine();
                        }
                }
            }
            System.Console.ReadLine();
        }
    }
}
