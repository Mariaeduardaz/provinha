using System;

namespace PROVA2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sent = "N";
            int numeros = Convert.ToInt32(sent);


            Console.WriteLine("Quantas ordens o soldado deve obedecer?");
            string strquantasvezes = Console.ReadLine();
            int quantidadedeordens = Convert.ToInt32(strquantasvezes);

            Console.Write("Quais ordens ele deve seguir?\n");

            Console.Write("Considere D para direita e E para esquerda.\n");
            string strOrdens = Console.ReadLine();
            char[] comando = strOrdens.ToCharArray();

            for (int o = 0; o < quantidadedeordens; o++)
            {
                if (numeros == 0)
                {
                    break;
                }
                if (comando[o] == 'D' && sent == "N")
                {
                    sent = "L";
                }
                else if (comando[o] == 'E' && sent == "N")
                {
                    sent = "O";
                }
                else if (comando[o] == 'D' && sent == "L")
                {
                    sent = "N";
                }
                else if (comando[o] == 'E' && sent == "L")
                {
                    sent = "S";
                }
                else if (comando[o] == 'D' && sent == "S")
                {
                    sent = "O";
                }
                else if (comando[o] == 'E' && sent == "S")
                {
                    sent = "L";
                }
                else if (comando[o] == 'D' && sent == "O")
                {
                    sent = "N";
                }
                else if (comando[o] == 'E' && sent == "O")
                {
                    sent = "S";
                }
            }   }
}  }
