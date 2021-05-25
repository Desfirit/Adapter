using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class TrainAdapter : IVehicle
    {
        Train _train;

        public TrainAdapter(Train train)
        {
            _train = train;
        }

        public void Leave()
        {
            if (_train.ShutDown())
                Console.WriteLine("You leave train");
            else
                Console.WriteLine("You jumped out of the train");
        }

        public void MoveBack()
        {
            if (!_train.IsStarted)
                _train.Start();

            _train.DownSpeed();
        }

        public void MoveForward()
        {
            if (!_train.IsStarted)
                _train.Start();

            _train.AddSpeed();
        }

        public void MoveLeft()
        {

        }

        public void MoveRight()
        {

        }
    }
}
