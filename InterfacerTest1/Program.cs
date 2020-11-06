using System;

namespace InterfacerTest1
{

    public interface ICarStandar
    {
        void Left();
    }
    abstract class KS
    {
        public abstract void Back();
        public void Fly() => Console.WriteLine("날다");
            
    }
    partial class MyCar : KS
    {
        public override void Back()
        {
            Console.WriteLine("후진");
        }
    }
    partial class MyCar : KS 
    {
        public void Right() => Console.WriteLine("우회전");
        
    }
    sealed class Car : MyCar, ICarStandar  //봉인클래스
    {
        public void Left()
        {
            Console.WriteLine("좌회전");
        }

        public void Run()
        {
            Console.WriteLine("직진");
        }
    }
    //class SpyCar : Car { }

    class InterfacerTest1
    {
        static void Main()
        {
            Car car = new Car();
            car.Run();
            car.Right();
            car.Back();
            car.Left();
            car.Fly();
        //     SpyCar spy = new SpyCar();
        //    spy.Run();

        }
    }
}
