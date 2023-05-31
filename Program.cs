using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            
            int[] valores = new int[10];
            int soma = 0;

            Console.WriteLine("Digite 10 valores inteiros:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Valor {0}: ", i+1);
                valores[i] = int.Parse(Console.ReadLine());
                soma += valores[i];
            }

            double media = (double)soma / 10;
            int contador = 0;

            for (int i = 0; i < 10; i++)
            {
                if (valores[i] > media)
                {
                    contador++;
                }
            }

            Console.WriteLine("A média aritmética é: {0}", media);
            Console.WriteLine("A quantidade de valores maiores que a média é: {0}", contador);
        }
    }
}
