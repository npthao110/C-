using System;
using static System.Console;

namespace Delegate
{
    public delegate void ShowLog(string message);
    class Program
    {
        static void Info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
            Console.ResetColor();
        }

        static void Warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
            Console.ResetColor();
        }

        static int Tong(int a, int b) => a + b;
        static void Main(string[] args)
        {
            // ShowLog log = null;

            // log += Info;
            // log += Info;
            // log += Info;
            // log += Warning;
            // log += Warning;

            // log?.Invoke("Xin chao");

            // action

            // Action action;
            // Action<string> action2;

            // action2 = Warning;
            // action2 += Info;
            // action2?.Invoke("Thong bao");
            // Func<int> f1; //delegate int func()

            Func<int, int, int> tinhtoan;
            int a = 5;
            int b = 10;

            tinhtoan = Tong;
            Console.WriteLine($"KQ:  {tinhtoan(a, b)}");
        }
    }
}

