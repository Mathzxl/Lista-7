using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vt1 = new int[10];
            int[] vt2 = new int[10];
            int[,] m = new int[10, 10];
            Random rnd = new Random();
            for (int i = 0; i < vt1.Length; i++)
            {
                vt1[i] = rnd.Next(0,10);
                vt2[i] = rnd.Next(0,10);
            }
            for (int i = 0; i < vt1.Length; i++)
            {
                Console.Write(" " + vt1[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < vt2.Length; i++)
            {
                Console.Write(" " + vt2[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = vt1[i] * vt2[j];
                    Console.Write(m[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
