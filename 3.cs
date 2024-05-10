using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] gab = { 1, 4, 2, 3, 3, 4, 1, 1, 3, 2 };
            int[,] p = new int[5, 10];
            Random rnd = new Random();
            int me;
            double mn = 0, soma = 0;
            for (int i = 0; i < p.GetLength(0); i++)
            {
                for (int j = 0; j < p.GetLength(1); j++)
                {
                    p[i, j] = rnd.Next(1,5);
                    Console.Write(p[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < p.GetLength(0); i++)
            {
                int cont = 0;
                for (int j = 0; j < p.GetLength(1); j++)
                {
                    if (p[i, j] == gab[j])
                    {
                        cont++;
                    }
                }
                soma += cont;
                Console.WriteLine($"Nota do {i+1} aluno: " + cont);
                if (cont > mn)
                {
                    mn = cont;
                }
            }
            Console.WriteLine($"A média de notas dos alunos foram: {soma /5}");
            Console.WriteLine($"A maior nota foi: {mn}");
            Console.ReadLine();
        }
    }
}
