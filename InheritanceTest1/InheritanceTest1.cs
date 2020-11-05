using System;

namespace InheritanceTest1
{
    public enum CarType { 전기, 내연기관 }

    public abstract class CarBase
    {
        public abstract void Left(); //추상메서드 표준 강제 인터페이스
        public void Back() => Console.WriteLine("후진하다.");
        protected string LeftMessage { get; set; } = "좌회전하다";

    }
    public class Car : CarBase
    {
        public CarType Style { get; private set; } // 공통
        public void Go() => Console.WriteLine("달리다");

        public Car(CarType carType)
        {
            this.Style = carType;
        }

        public override void Left()
        {
            Console.WriteLine("좌회전하다." + base.LeftMessage);
        }
    }

    public class Benz : Car
    {
        public Benz() : this(CarType.내연기관) { }
        public Benz(CarType carType) : base(carType) { }
    }

    public class Tesla : Car
    {
        public Tesla() : this(CarType.전기) { }
        public Tesla(CarType carType) : base(carType) { }
    }

    public sealed class Future : Car
    {
        public Future() : this(CarType.전기) { }
        public Future(CarType carType) : base(carType) { }
        public new void Go()
        {
            base.Go();
            Console.WriteLine("날다");
         }
    }

    //public class OtherFuture : Future
    //{

    //}
    class InheritanceTest1 :Object
    {
        static void Main()
        {
            //Car car = new Car();
            //(new Benz()).Go();
            //(new Tesla()).Go();

            Benz benz = new Benz();
            benz.Go();
            Console.WriteLine($"{benz.Style}");
            benz.Back();
            benz.Left();

            Tesla tesla = new Tesla();
            tesla.Go();
            Console.WriteLine($"{tesla.Style}");
            tesla.Back();
            tesla.Left();

            Future future = new Future();
            future.Go();



        }
    }
}
