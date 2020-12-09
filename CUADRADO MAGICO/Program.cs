using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUADRADO_MAGICO
{
    class Program
    {
  

        static void Main(string[] args)
        {

            int n = 0, fila = 0, colum = 0;
            int fila_ant = 0, colum_ant = 0, cont = 1;

            Console.WriteLine();
            Console.WriteLine("CUADRADO MAGIGO");
            do
            {
                Console.Write("CUADRADO IMPAR");
                n = Int32.Parse(Console.ReadLine());
            }
            while (n % 2 == 0);
            int[,] cuadrado = new int[n, n];
            cuadrado[fila, colum] = cont++;

            while (cont <= n * n) 
            {
                {
                    fila = fila - 1;
                    colum = colum + 1;

                    if (fila < 0) fila = n - 1;
                    if (colum > n - 1) colum = 0;
                    if (cuadrado[fila, colum] != 0)
                    {
                        colum = colum_ant;
                        fila = fila_ant+1;
                        if (fila == n) fila = 0;
                    }

                    cuadrado[fila,colum] = cont++;
                    fila_ant = fila;
                    colum_ant = colum;
                    {
                        Console.WriteLine("Cuadrado mágico de orden " + n + " :");
                        for (int i = 0; i < n; i++);
                    }
                   
                    for (int j = 0; j < n; j++)

                    Console.WriteLine(cuadrado[i, j] + "\t");
                    Console.WriteLine();
                }
            }  

        } 
    }
}
    

