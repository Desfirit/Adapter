using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Train train = new Train();

            IVehicle vehicle = new TrainAdapter(train);
            vehicle.MoveForward();
            vehicle.MoveForward();
            vehicle.MoveBack();
            vehicle.MoveBack();
            vehicle.Leave();

            vehicle = new CarAdapter(car);
            vehicle.MoveBack();
            vehicle.MoveRight();
            vehicle.MoveRight();
            vehicle.MoveBack();
            vehicle.MoveBack();
            vehicle.Leave();

            Console.ReadKey();

        }
    }


}
