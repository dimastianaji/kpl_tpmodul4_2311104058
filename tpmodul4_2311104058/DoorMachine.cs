using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_2311104058
{
    public enum DoorState
    {
        Terkunci,
        Terbuka
    }

    public class DoorMachine
    {
        private DoorState _state;

        public DoorMachine()
        {
            _state = DoorState.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        public void BukaPintu()
        {
            if (_state == DoorState.Terkunci)
            {
                _state = DoorState.Terbuka;
                Console.WriteLine("Pintu tidak terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terbuka");
            }
        }

        public void KunciPintu()
        {
            if (_state == DoorState.Terbuka)
            {
                _state = DoorState.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terkunci");
            }
        }
    }

}


