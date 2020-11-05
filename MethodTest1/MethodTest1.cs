using System;

namespace MethodTest1
{

    class Car
    {

        public void Map(params string[] title)
        {
            foreach (var t in title)
            {
                Console.WriteLine(t);
            }
        }

    }

    class MathodAndParamter
    {
        static void Main()
        {   
            var car = new Car();
            car.Map("홍길동", "백두산");

        }
    }
}
