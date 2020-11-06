//특성 튜닝 Attribute 

//#define RELEASE 

using System;
using System.Diagnostics;
using System.Reflection;

namespace AttributeTest1
{
    //특성만들기
    public class LuxuryAttribute : Attribute {
        public LuxuryAttribute()
        {
            Console.WriteLine("럭셔리!!!!");
        }
    } 

    [Luxury]
    class Car
    {
        //[Obsolete("다음 버전에 제거될 예정이니 Auto() 를 사용하세요.")] //더이상 사용하지 않음 표시 
        //public void Manual() => Console.WriteLine("수동운전"); // 1.0 
        public void Auto() => Console.WriteLine("자동운전"); // 1.0 

        [Conditional("DEBUG")] //DEBUG RELEASE 
        public void Test() => Console.WriteLine("테스트운전"); // 1.0 

        [Conditional("RELEASE")] //DEBUG RELEASE 
        public void Test2() => Console.WriteLine("테스트2 운전"); // 1.0 


    }
    class Program
    {
        static void Main()
        {
            Car car = new Car();
            Attribute.GetCustomAttributes(typeof(Car));
            typeof(Car).GetCustomAttributes(false);

            //car.Manual();//현재버전 사용할 수 없음 Obsolete 지정시 , 실행은됨 
            car.Test();
            car.Test2();
            car.Auto();//car.Manual();
            car.Auto();

            //리플렉션
            //동적으로 읽어옮 

            var carType = (new Car());
            Type myCar = (new Car()).GetType();
            MethodInfo info = myCar.GetMethod("Auto");
            info.Invoke(carType, null);

        }
    }
}
