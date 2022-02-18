using System;

namespace provinha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sent = "N";

            Console.WriteLine("Quantas ordens o soldado deve obedecer?");
            string strquantasordens = Console.ReadLine();
            int quantidadeDeOrdens = Convert.ToInt32(strquantasordens);

            Console.Write("Quais ordens ele deve seguir?\n" +
                "Considere D para direita e E para esquerda.");
            string strOrdens = Console.ReadLine();
            char[] ordens = strOrdens.ToCharArray();

            for (int o = 0; o < quantidadeDeOrdens; o++)
            {
                if (ordens[o] == 'D' && sent == "N")
                {
                    sent = "L";
                }
                else if (ordens[o] == 'E' && sent == "N")
                {
                    sent = "O";
                }
                else if (ordens[o] == 'D' && sent == "L")
                {
                    sent = "N";
                }
                else if (ordens[o] == 'E' && sent == "L")
                {
                    sent= "S";
                }
                else if (ordens[o] == 'D' && sent == "S")
                {
                    sent= "O";
                }
                else if (ordens[o] == 'E' && sent == "S")
                {
                    sent = "L";
                }
                else if (ordens[o] == 'D' && sent == "O")
                {
                    sent = "N";
                }
                else if (ordens[o] == 'E' && sent == "O")
                {
                    sent = "S";
                }
            }
        }
}    }
