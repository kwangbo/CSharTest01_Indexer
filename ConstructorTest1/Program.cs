using System;

namespace ConstructorTest1
{
    public class Car
    {

        private readonly string name; //생성자가 최기화가능 readonly
        //기본 생성자 
        public Car() : this("기본자동차")
        {
        }

        public Car(string name) => this.name = name; //식본문생성자
        public void Go() => Console.WriteLine($"{name} 달리다.");
    }
    class Program
    {
        static void Main(string[] args)
        {
           (new Car()).Go();

           (new Car("좋은자동차")).Go();


        }
    }
}
