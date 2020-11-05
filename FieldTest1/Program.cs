using System;
using System.Linq;

namespace FieldTest1
{

    public class Persion
    {
        private string name = "박용준";
        private const int m_age = 21; //필드  번역 멤버 
        private readonly string _NickName = "RedPlus";
        private string[] _websites = { "닷넷코리아","비주얼아카데미" };
        public void ShowProfile()
        {
            Console.WriteLine(string.Format(" 이름: {0}  {1}", name, m_age));
        }

    }
    public class Say
    {
        private string message = "반값습니다."; //필드  
        private string color = "red";
        public void Hi()
        {
            Console.WriteLine(this.message);
        }
        public string GetColor()
        {
            return this.color;
        }
    }  

    public class Program
    {
        private static string message = "안녕하세요"; //필드 전역변수
        public static void Hi() => Console.WriteLine(message);
        static void Main(string[] args)
        {
            int number = 1_234;//변수 지역변수 

            //Console.WriteLine(" {0}", string.Format(number.ToString()));
            //Console.WriteLine(message);
            //Hi();
            Say say = new Say(); say.Hi();
            Console.WriteLine( say.GetColor());

            Persion my = new Persion();
            my.ShowProfile();
        }
    }
}
