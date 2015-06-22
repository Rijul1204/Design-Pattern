using PrototypePattern.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern
{
    public class Client
    {
        public void Run()
        {
            Body blueBody = new Body { Color = "blue" };
            Body redBody = new Body { Color = "Red" };

            Car car = new Car {  Name = "car1 " , Body = blueBody };
            car.Wheel = new Wheel { Accessories = "test1" };

            Car newCar = (Car)car.Clone();

            car.Engine = new Engine { Accessories = "engine1" };
            newCar.Engine = new Engine { Accessories = "engine2" };
            newCar.Name = "Car2 ";

            Console.Out.WriteLine(car.ToString());
            Console.Out.WriteLine(newCar.ToString());

            newCar.Body = redBody;

            Console.Out.WriteLine(newCar.ToString());
        }
    }
}
