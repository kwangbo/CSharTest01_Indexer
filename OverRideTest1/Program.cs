namespace OverRideTest1
{

    class Parent
    {
         protected void Say() => System.Console.WriteLine("부모_안녕하세요");
         protected void Run() => System.Console.WriteLine("부모_. 달리다");
        public virtual void Work() => System.Console.WriteLine("부모_프로게이머");
        public virtual void Walk() => System.Console.WriteLine("부모_걷다");
    }

    class Child : Parent
    {
        public new void Say() => System.Console.WriteLine("자식_안녕하세요");
        public new void Run() => System.Console.WriteLine("자식_. 달리다");
        public override void Work()
        {
            base.Work();
        }

        public override void Walk()
        {
            System.Console.WriteLine("자식_걷다");
        }
    }
    class OverRideDemo
    {
        static void Main()
        {
            Child child = new Child();
            child.Say();
            child.Run();
            child.Work();
            child.Walk();
        }
    }
}
