using System;
using static System.Console;

namespace Lambda
{
    class Program
    {

        static void Main(string[] args)
        {
            // (int a, int b) =>
            // {
            //     int kq = a + b;
            //     return kq;
            // }
            // Action<string> thongbao;
            // thongbao = (string s) => Console.WriteLine(s);

            // for (int i = 0; i < 10; i++)
            // {
            //     thongbao?.Invoke("xin chao");
            // }


            // Action<string, string> welcome;
            // welcome = (string msg, string name) => Console.WriteLine(msg + " " + name);
            // welcome?.Invoke("xin chao", "cac ban");
            // welcome?.Invoke("xinchao", "Nguyen van A");

            Func<int, int, int> tinhtoan;

            tinhtoan = (a, b) =>
            {
                int kq = a + b;
                return kq;
            };

            Console.WriteLine(tinhtoan.Invoke(5, 6));


        }
    }
}

