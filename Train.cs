using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Train
    {
        public int Speed { get; set; }
        public bool IsStarted { get; set; }

        const int AccelerationSpeed = 10;
        const int MaxSpeed = 80;

        public Train()
        {
            IsStarted = false;
            Speed = 0;
        }

        public void Start()
        {
            IsStarted = true;
            Console.WriteLine("Train started");
        }

        public bool ShutDown()
        {
            if (Math.Abs(Speed) > 10)
                return false;

            IsStarted = false;
            Speed = 0;
            Console.WriteLine("Train shut downed");
            return true;
        }

        public void AddSpeed()
        {
            if (IsStarted)
            {
                Speed = Math.Min(Speed + AccelerationSpeed, MaxSpeed);
                Console.WriteLine("The train sped up: " + Speed);
            }
        }
        public void DownSpeed()
        {
            if (IsStarted && Speed > 0)
            {
                Speed = Math.Max(Speed - AccelerationSpeed, -MaxSpeed);
                Console.WriteLine("The train sped down: " + Speed);
            }
        }
    }
}
