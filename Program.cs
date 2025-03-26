// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;
            double soma, diferenca, produto, divisao;
            string respostaUsuario;

            Console.WriteLine("Digite um número inteiro:");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número inteiro:");
            numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Aqui está o resultado das operações com os números digitados:");

            soma = (double)numero1 + numero2;
            Console.WriteLine("Soma = " + soma.ToString(CultureInfo.InvariantCulture));
            diferenca = (double)numero1 - numero2;
            Console.WriteLine("Diferença = " + diferenca.ToString(CultureInfo.InvariantCulture));
            produto = (double)numero1 * numero2;
            Console.WriteLine("Multiplicação = " + produto.ToString(CultureInfo.InvariantCulture));

            if (numero2 == 0)
            {
                Console.WriteLine("Divisão = Impossível calcular!");
            }
            else
            {
                divisao = (double)numero1 / numero2;
                Console.WriteLine("Divisão = " + divisao.ToString("F4", CultureInfo.InvariantCulture));
            }

            Console.WriteLine("Deseja repetir o processo com outros valores? Se sim, digite SIM");
            respostaUsuario = Console.ReadLine();

            while (respostaUsuario == "SIM")
            {
                Console.WriteLine("Digite um número inteiro:");
                numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite outro número inteiro:");
                numero2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Aqui está o resultado das operações com os números digitados:");

                soma = (double)numero1 + numero2;
                Console.WriteLine("Soma = " + soma.ToString(CultureInfo.InvariantCulture));
                diferenca = (double)numero1 - numero2;
                Console.WriteLine("Diferença = " + diferenca.ToString(CultureInfo.InvariantCulture));
                produto = (double)numero1 * numero2;
                Console.WriteLine("Multiplicação = " + produto.ToString(CultureInfo.InvariantCulture));

                if (numero2 == 0)
                {
                    Console.WriteLine("Divisão = Impossível calcular!");
                }
                else
                {
                    divisao = (double)numero1 / numero2;
                    Console.WriteLine("Divisão = " + divisao.ToString("F4", CultureInfo.InvariantCulture));
                }

                Console.WriteLine("Deseja repetir o processo com outros valores? Se sim, digite SIM");
                respostaUsuario = Console.ReadLine();
            }

            if (respostaUsuario != "SIM")
            {
                Console.WriteLine("Fim do programa 👋");
            }
        }
    }
}