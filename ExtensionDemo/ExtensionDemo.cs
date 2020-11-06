using System;

namespace MyExtensions
{

    static class StringExtension
    {

        public static string Ten(this string msg)
        {
            return msg.Substring(0, 10);
        }

        public static string Five(this string msg) 
        { 
            return msg.Substring(0, 5); 
        }

        public static string AddElipsis(this string msg)
        {
            return msg + "..."; 
        }
        public static string AddElipsis(this string msg, string elipsis)
        {
            return msg + elipsis;
        }

    }
    class ExtensionDemo
    {
        static void Main()
        {
            string message = "안녕하세요 반값습니다. 또만나요, 즐거운 주말 되세요";
            Console.WriteLine(message.Ten().Five().AddElipsis());
            Console.WriteLine(message.Ten().Five().AddElipsis("_____"));
        }
    }
}
