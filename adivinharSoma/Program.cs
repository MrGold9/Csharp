using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adivinharSoma
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            char continuar = 's';

            int respostaPessoal = 0;
            int resultado = 0;
            int pontosPlayer = 0;

            while (continuar == 's')
            {
                int num1 = rnd.Next(1, 11);
                int num2 = rnd.Next(1, 11);

                resultado = num1 + num2;

                Console.WriteLine("Quanto é: " + num1 + " + " + num2 + " ?");

                respostaPessoal = int.Parse(Console.ReadLine());

                if (respostaPessoal == resultado)
                {
                    pontosPlayer++;
                    Console.WriteLine("Parabéns! Você acertou!" +
                        "\nPontos: " + pontosPlayer);
                    Console.WriteLine("");
                }
                else if (respostaPessoal != resultado)
                {
                    Console.WriteLine("Você errou... Tente novamente!");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Digite um número válido");
                }


                if(continuar != 's')
                {
                    break;
                }

                Console.WriteLine("Deseja tentar novamente? Digite 's' para continuar e 'n' para sair");
                continuar = char.Parse(Console.ReadLine());
            }
        }
    }
}
