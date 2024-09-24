using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Crie um programa que leia 10 números do usuário e os classifique em três categorias:
            positivos, negativos e zeros. Utilize um vetor para armazenar os números e for para iterar
            sobre eles */

            int[] vetor = new int[10];

            Console.WriteLine("Por favor digite somente números, se não vai dar erro. Digite 10 números para eu classificar eles entre positivos, negativos e zeros: ");

            for (int i = 0; i < vetor.Length; i++)
            {
                    vetor[i] = Convert.ToInt32(Console.ReadLine());
               
                


                    if (vetor[i] > 0)
                    {
                        Console.WriteLine(vetor[i] + " é positivo.");
                    }

                    else if (vetor[i] < 0)
                    {
                        Console.WriteLine(vetor[i] + " é negativo.");
                    }

                    else
                    {
                        Console.WriteLine(vetor[i] + " faz parte dos zeros.");
                    }
        
            }

            Console.WriteLine("Aperte qualquer tecla para fechar...");
            Console.ReadKey();
        }
    }
}
