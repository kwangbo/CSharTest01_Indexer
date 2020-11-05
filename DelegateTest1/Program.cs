//[?] 대리자 delegate : 함수 포인터 ,메서드 대신 호출 , 대리운전 
using System;

class DelegateSample
{
    static void GoForward() => Console.WriteLine("직진");
    static void GoLeft() => Console.WriteLine("좌회전");
    static void GoFast() => Console.WriteLine("과속");
    static void GoRight() => Console.WriteLine("우회전");
    delegate void CarDriver(); //대리자 생성 
    static void Main()
    {
        //GoForward(); //[1]
        //CarDriver goHome = new CarDriver(GoForward);
        CarDriver goHome = GoForward;
        goHome += GoLeft;
        goHome += GoFast;
        goHome += GoRight;

        goHome += delegate () { Console.WriteLine("우회전 무명"); }; //무명 
        goHome += delegate () { Console.WriteLine("후진 무명"); }; //무명 익명메서드 
        //람다식 
        goHome += () => Console.WriteLine("후진 람다");  //람다식
        //anonymous method 

        goHome();

        //대리자 형식을 통해서 직접 대리자 개체 생성:Func<T>, Action<T>, Predicate<T>
        Action driver = GoForward;
        driver += GoLeft;
        driver += delegate () { Console.WriteLine("우회전 action"); };
        driver += () => Console.WriteLine("후진 action");
        driver(); // 트리거 방아쇠 


        Action go = () => Console.WriteLine("운전");
        go();

        RunLambda( () => Console.WriteLine("매개변수로 람다식 전달") );
    }

    static void RunLambda(Action action) => action();


}