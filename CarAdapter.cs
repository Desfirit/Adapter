using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class CarAdapter : IVehicle
    {
        Car _car;
        public CarAdapter(Car car)
        {
            _car = car;
        }

        public void Leave()
        {
            if(_car.ShutDown())
                Console.WriteLine("You leave the car");
            else
                Console.WriteLine("You jumped out of the car");
        }

        public void MoveBack()
        {
            if (!_car.IsStarted)
                _car.Start();


            _car.SpeedDown();
        }

        public void MoveForward()
        {
            if (!_car.IsStarted)
                _car.Start();


            _car.SpeedUp();
        }

        public void MoveLeft()
        {
            _car.TurnLeft();
        }

        public void MoveRight()
        {
            _car.TurnRight();
        }
    }
}
