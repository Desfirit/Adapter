using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface IVehicle
    {
        void MoveForward();
        void MoveBack();
        void MoveRight();
        void MoveLeft();
        void Leave();

    }
}
