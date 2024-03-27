using System.Net.WebSockets;
using System.Reflection.Metadata.Ecma335;

namespace module_five
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задание 5.3.13

            int[] arraysort = new int[] { -9, 5, 64, 37, -54, 0 };
            SortArray(arraysort, out arraysort, out arraysort);
        }

        // module 5, unit 3
        // задание 5.3.13
        static int[] GetArrayFromConsole(int num)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }

        static void SortArray(int[] array, out int[] sorteddesc, out int[] sortedasc)
        {
            sorteddesc = SortArrayDesc(array);
            Console.WriteLine();
            sortedasc = SortArrayAsc(array);
        }

        // сортировка массива от большего к меньшему
        static int[] SortArrayDesc(int[] result)
        {
            int temp = 0;
            for (int i = 0; i < result.Length; i++)
                for (int j = i + 1; j < result.Length; j++)
                    if (result[i] < result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
            foreach (int i in result)
                Console.WriteLine(i);

            return result;
        }

        // сортировка массива от меньшего к большему
        static int[] SortArrayAsc(int[] result)
        {
            int temp = 0;
            for (int i = 0; i < result.Length; i++)
                for (int j = i + 1; j < result.Length; j++)
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
            foreach (int i in result)
                Console.WriteLine(i);

            return result;
        }
    }

}

