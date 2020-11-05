using System;

namespace PropertyTest1
{
    class Car
    {
        public string Tire { get; set; } = "Good Tire";

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Name = "My Car";
            
            Console.WriteLine(car.Name);
            car.Tire = "good"; 
            Console.WriteLine(car.Tire);

            Car car2 = new Car() {Name = "Your Car" }; //object initialize
            Console.WriteLine(car2.Name);
            Console.WriteLine(nameof(car2.Name)+ "  :  " + car2.Name);

            //이름없는 classs
            var Person = new { Name = "Read", Age = 21 };
            Console.WriteLine(Person.Name + " " + Person.Age);

        }
    }
}
