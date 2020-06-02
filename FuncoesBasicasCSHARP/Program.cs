using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FuncoesBasicasCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o codigo para utilizar");
            Console.WriteLine("1 - Exemplo 'DO' \n" +
                "2 - Exemplo 'FOR' \n" +
                "3 - Exemplo 'Foreach' \n" +
                "4 - Exemplo 'While' \n" +
                "5 - Exemplo '???' \n" +
                "6 - Exemplo 'Maior/Menor'");
            string codigo = Console.ReadLine();
            int codigoN = 0;
            while (!int.TryParse(codigo, out codigoN))
            {
                Console.WriteLine("CODIGO DIGITADO NÃO É UM NUMERO INTEIRO");
                Console.WriteLine("1 - Exemplo 'DO' \n" +
                "2 - Exemplo 'FOR' \n" +
                "3 - Exemplo 'Foreach' \n" +
                "4 - Exemplo 'While' \n" +
                "5 - Exemplo '???' \n" +
                "6 - Exemplo 'Maior/Menor'");
                codigo = Console.ReadLine();
            }
            Console.Clear();
            switch (codigoN)
            {
                case 1:
                    Console.WriteLine("Executando 'do' ");
                    int n = 1;
                    do
                    {
                        Console.WriteLine($"{n}");
                        n++;
                    } while (n <= 10);
                    break;
                case 2:
                    Console.WriteLine("Executando 'for' ");
                    for (int i = 0; i <= 10; i++)
                    {
                        Console.WriteLine($"{i}");
                    }
                    break;
                case 3:
                    Console.WriteLine("Executando 'foreach' ");
                    int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                    foreach (var numero in numeros)
                    {
                        Console.WriteLine($"{numero}");
                    }
                    break;
                case 4:
                    Console.WriteLine("Executando 'While' ");
                    int nn = 1;
                    while(nn <= 500000)
                    {
                        Console.WriteLine($"{nn}");
                        nn++;
                    }
                    break;
                case 5:
                    Console.WriteLine("Executando '???' ");
                    Console.WriteLine("Escreva uma frase");
                    string frase = Console.ReadLine();
                    char[] letras = frase.ToArray();
                    Console.WriteLine("\n");
                    foreach (var letra in letras)
                    {
                        Console.Write(letra);
                        Thread.Sleep(65);
                    }
                    Console.WriteLine("\n");
                    for (int i = letras.Length -1; i > 0 - 1; i--)
                    {
                        Console.Write($"{letras[i]}");
                        Thread.Sleep(65);
                    }
                    Console.WriteLine("\n");
                    break;
                case 6:
                    Console.WriteLine("Executando 'Maior/Menor'");
                    Console.WriteLine("Escolha um numero e mostrará se é maior ou menor que o numero aleatório");
                    int numeroUsuario = int.Parse(Console.ReadLine());
                    Random rnd = new Random();
                    int rand = rnd.Next(500);
                    Console.WriteLine($"Numero gerado aleatoriamente: {rand}");
                    string result = numeroUsuario < rand ? "menor que o aleatório" : "maior que o aleatório";
                    Console.WriteLine($"Seu numero é {result}");
                    break;
                default:
                    Console.WriteLine("Codigo indisponivel");
                    break;
            }

            Console.WriteLine("Aperte qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
