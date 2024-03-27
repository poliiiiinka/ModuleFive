using System.Net.WebSockets;
using System.Reflection.Metadata.Ecma335;

namespace module_five
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PowerUp(5, 4));
        }
                
        private static int PowerUp(int N, byte pow)
        {
            if (N != 0 && pow == 0)
                return 1;

            else if (pow == 1)
                return N;

            else return N * PowerUp(N, --pow);
        }
    }

}

