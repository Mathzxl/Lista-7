using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m;
            Console.WriteLine("Dê o tamanho de linhas");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("Dê o tamanho das colunas");
            int c = int.Parse(Console.ReadLine());
            m = new int[l, c];
            Random rnd = new Random();
            int[] somal = new int[l];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = rnd.Next(0, 10);
                    Console.Write(m[i, j] + " ");
                    somal[i] += m[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nSoma das linhas:\n");
            for(int i = 0; i < somal.Length; i++)
            {
                Console.WriteLine($"Soma da linha {i + 1}: " + somal[i]);
            }
            Console.ReadLine();
        }
    }
}
