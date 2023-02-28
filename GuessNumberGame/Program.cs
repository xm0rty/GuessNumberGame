using System;


namespace GuessNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int max;
            int min;
            int guess;
            int nbguess;
            int nbguessMax;
            bool GameEnCours = true;
            while (GameEnCours)
            {
                max = 100;
                min = 0;
                guess = 0;
                nbguess = 0;
                nbguessMax = 10;
                int number = random.Next(min, max + 1);
                while (guess != number)
                {
                    if (nbguess>nbguessMax)
                    {
                        Console.WriteLine("VOUS AVEZ PERDU");
                        break;
                    }
                    Console.WriteLine("Trouve le Numero random entre 0 et 100 avec maximum 10 essais");

                    guess = int.Parse(Console.ReadLine());

                    Console.WriteLine("Choix:" + guess);

                    if (guess < number) Console.WriteLine("Trop petit");

                    else if (guess > number) Console.WriteLine("Trop grand");

                    nbguess++;
                }
                Console.WriteLine("LE NOMBRE ETAIT " + number + " cela vous pris " + nbguess + " essais");
                
                Console.WriteLine("VOULEZ VOUS REJOUER (Y/N)");
                string reponse = Console.ReadLine();
                if (reponse == "Y") GameEnCours = true;
                else break;
                
            
            }
            Console.WriteLine("MERCI D'AVOIR JOUER");

        }
    }
}
