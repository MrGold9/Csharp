using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jokenpo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numAleatorio = new Random();

            int jogadaPlayer = 0;

            int pontosNPC = 0, pontosPlayer = 0;

            char continuar = 's';

            while (continuar != 'n')
            {
                int jogadaNPC = numAleatorio.Next(1, 4);

                Console.WriteLine("\n" +
                        "\n" +
                        "\n" +
                        "Você escolhe pedra, papel ou tesoura?" +
                        "\n Digite '1' para pedra" +
                        "\n Digite '2' para papel" +
                        "\n Digite '3' para tesoura");
                    jogadaPlayer = int.Parse(Console.ReadLine());


                while (jogadaPlayer != 1 && jogadaPlayer != 2 && jogadaPlayer != 3)
                {
                    Console.WriteLine("Digite '1', '2' ou '3'");
                    jogadaPlayer = int.Parse(Console.ReadLine());
                }


                //Empates
                if (jogadaPlayer == 1 && jogadaNPC == 1)
                {
                    Console.WriteLine("Ambos escolheram pedra! Houve um empate" +
                        "\n Placar do jogador: " + pontosPlayer +
                        "\n Placar do NPC: " + pontosNPC);
                }

                else if (jogadaPlayer == 2 && jogadaNPC == 2)
                {
                    Console.WriteLine("Ambos escolheram papel! Houve um empate" +
                        "\n Placar do jogador: " + pontosPlayer +
                        "\n Placar do NPC: " + pontosNPC);
                }

                else if (jogadaPlayer == 3 && jogadaNPC == 3)
                {
                    Console.WriteLine("Ambos escolheram tesoura! Houve um empate" +
                        "\n Placar do jogador: " + pontosPlayer +
                        "\n Placar do NPC: " + pontosNPC);
                }


                //Pedra contra papel (vice-versa)
                else if (jogadaPlayer == 1 && jogadaNPC == 2)
                {
                    pontosNPC++;

                    Console.WriteLine(" Jogador: Pedra!" +
                        "\n NPC: Papel!" +
                        "\n" +
                        "\nPapel vence pedra! Ponto para o NPC" +
                        "\n" +
                        "\n Placar do jogador: " + pontosPlayer +
                        "\n Placar do NPC: " + pontosNPC);
                }

                else if (jogadaPlayer == 2 && jogadaNPC == 1)
                {
                    pontosPlayer++;

                    Console.WriteLine(" Jogador: Papel!" +
                        "\n NPC: Pedra!" +
                        "\n" +
                        "\nPapel vence pedra! Ponto para o jogador" +
                        "\n" +
                        "\n Placar do jogador: " + pontosPlayer +
                        "\n Placar do NPC: " + pontosNPC);
                }


                //Pedra contra tesoura (vice-versa)
                else if (jogadaPlayer == 1 && jogadaNPC == 3)
                {
                    pontosPlayer++;

                    Console.WriteLine(" Jogador: Pedra!" +
                        "\n NPC: Tesoura!" +
                        "\n" +
                        "\nPedra vence tesoura! Ponto para o jogador" +
                        "\n" +
                        "\n Placar do jogador: " + pontosPlayer +
                        "\n Placar do NPC: " + pontosNPC);
                }

                else if (jogadaPlayer == 3 && jogadaNPC == 1)
                {
                    pontosNPC++;

                    Console.WriteLine(" Jogador: Tesoura!" +
                        "\n NPC: Pedra!" +
                        "\n" +
                        "\nPedra vence tesoura! Ponto para o NPC" +
                        "\n" +
                        "\n Placar do jogador: " + pontosPlayer +
                        "\n Placar do NPC: " + pontosNPC);
                }


                //Papel contra tesoura (vice-versa)
                else if (jogadaPlayer == 2 && jogadaNPC == 3)
                {
                    pontosNPC++;

                    Console.WriteLine(" Jogador: Papel!" +
                        "\n NPC: Tesoura!" +
                        "\n" +
                        "\nTesoura vence papel! Ponto para o NPC" +
                        "\n" +
                        "\n Placar do jogador: " + pontosPlayer +
                        "\n Placar do NPC: " + pontosNPC);
                }

                else if (jogadaPlayer == 3 && jogadaNPC == 2)
                {
                    pontosPlayer++;

                    Console.WriteLine(" Jogador: Tesoura!" +
                        "\n NPC: Papel!" +
                        "\n" +
                        "\nTesoura vence papel! Ponto para o jogador" +
                        "\n" +
                        "\n Placar do jogador: " + pontosPlayer +
                        "\n Placar do NPC: " + pontosNPC);
                }

                Console.WriteLine("\n" + 
                    "\n" +
                    "Deseja continuar jogando?" +
                    "\nDigite 's' para sim e 'n' para não");
                continuar = char.Parse(Console.ReadLine());

                while (continuar != 's' && continuar != 'n')
                {
                    Console.WriteLine("Digite 's' ou 'n'");
                    continuar = char.Parse(Console.ReadLine());
    
                    if (continuar == 'n')
                    {
                        break;
                    }

                    }
            }
        }
    }
}
