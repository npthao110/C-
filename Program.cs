using System;
using MyNameSpace;
using static System.Console;

namespace my_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Sanpham.Product product = new Sanpham.Product();

            product.name = "Ipad";
            product.price = 1000;
            product.description = "Day la ipad";

            product.manufactory = new Sanpham.Product.Manufactory();
            product.manufactory.name = "zzzz";
            product.manufactory.addr = "123 li tu trong";

            WriteLine(product.manufactory.getInfoManu());
        }
    }
}

