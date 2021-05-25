using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Car
    {
        public int Speed { get; set; }
        public float WheelRotation { get; set; }
        public bool IsStarted { get; set; }

        const int AccelerationSpeed = 8;
        const int MaxSpeed = 100;
        const float RotationSpeed = 11.5f;
        const float MaxWheelAxis = 40;

        public Car()
        {
            IsStarted = false;
            Speed = 0;
            WheelRotation = 0;
        }
        public void Start()
        {
            IsStarted = true;
            Console.WriteLine("Car started");
        }

        public bool ShutDown()
        {
            if (Math.Abs(Speed) > 10)
                return false;

            IsStarted = false;
            Speed = 0;
            Console.WriteLine("Car shut downed");
            return true;
        }

        public void SpeedUp()
        {
            if(IsStarted)
            {
                Speed = Math.Min(Speed + AccelerationSpeed, MaxSpeed);
                Console.WriteLine("Car gain speed: " + Speed);
            }
        }
        public void SpeedDown()
        {
            if(IsStarted)
            {
                Speed = Math.Max(Speed - AccelerationSpeed, -MaxSpeed);
                Console.WriteLine("Car sped down: " + Speed);
            }
        }
        public void TurnRight()
        {
            WheelRotation = Math.Min(WheelRotation + RotationSpeed, MaxWheelAxis);
        }

        public void TurnLeft()
        {
            WheelRotation = Math.Max(WheelRotation - RotationSpeed, -MaxWheelAxis);
        }

    }
}
