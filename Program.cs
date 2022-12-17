using System;
using System.Xml.Schema;

namespace Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int shirochina = int.Parse(Console.ReadLine());
            int duljina = int.Parse(Console.ReadLine());

            int totalPiecec = shirochina * duljina;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "STOP")
                {
                    Console.WriteLine($"{totalPiecec} pieces are left.");
                    break;
                }
                int piecesEaten = int.Parse(command);

                if (piecesEaten > totalPiecec)
                {
                    Console.WriteLine($"No more cake left! You need {piecesEaten - totalPiecec} pieces more.");
                    break;
                }

                totalPiecec -= piecesEaten;

                if (totalPiecec == 0)
                {
                    Console.WriteLine($"No more cake left! You need {piecesEaten - totalPiecec} pieces more.");
                }
            }
            




        }


    }
}

