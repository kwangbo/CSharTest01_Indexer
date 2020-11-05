using System;
using System.Net.NetworkInformation;

namespace EventAndDelegateDemo
{

    //게시자 
    class Car
    {
        private int _fuelGuage;
        public int FuelGage
        {
            get { return _fuelGuage; }
            set
            { _fuelGuage = value;
                OnFuelEmptyReached();            
            }
        }

        public Car()
        {
            _fuelGuage = 25;
        }


        public void Go()
        {
            Console.WriteLine("운전");
            FuelGage -= 5;
        }

        //public delegate void FuelEmptyNotification();
        //public event FuelEmptyNotification FuelEmptyReached;
        public event Action FuelEmptyReached;
        public void OnFuelEmptyReached()
        {

            Console.WriteLine("연료상태: {0}", _fuelGuage);
            if (_fuelGuage < 20)
            {
                if (FuelEmptyReached != null)
                {
                    //FuelEmptyReached();
                    FuelEmptyReached?.Invoke();
                }  
            }
        }

    }
}
