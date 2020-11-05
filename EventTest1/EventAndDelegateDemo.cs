using System.Runtime.CompilerServices;

namespace EventAndDelegateDemo
{
    //구독자
    class EventAndDelegate
    {
        static void Main()
        {
            Car car = new Car();
            car.FuelEmptyReached += Car_FuelEmptyReached;
            //car.FuelEmptyReached -= Car_FuelEmptyReached;
            car.FuelEmptyReached += () =>
            {
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.BackgroundColor = System.ConsoleColor.Black;
                System.Console.WriteLine("연료부족");
                System.Console.ResetColor();
            };
            car.Go();
            //car.OnFuelEmptyReached();
            car.Go();

        }

        //이벤트 처리기 ( 핸들러 ) 
        private static void Car_FuelEmptyReached()
        {
            System.Console.WriteLine("연료부족");
        }
    }
}

