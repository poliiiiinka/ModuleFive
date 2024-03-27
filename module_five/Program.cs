using System.Net.WebSockets;
using System.Reflection.Metadata.Ecma335;

namespace module_five
{
    internal class Program
    {
        static int num1 = 667;
        static void Main(string[] args)
        {
            Console.WriteLine(num1);
            Console.WriteLine(Sum());

            if (num1 > 0)
            {
                var num3 = 5;
                Console.WriteLine(num1 + num3);
            }
        }

        static int Sum()
        {
            var num2 = 1;
            return num1 + num2;
        }
    }

}

