using System.Text;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Hej välj en svårighetsgrad");
            Console.WriteLine("Tryck 1 för lätt");
            Console.WriteLine("Tryck 2 för mellan");
            Console.WriteLine("Tryck 3 för svårt");
            
            int diff;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out diff))
                {

                    if (diff <= 3 && diff > 0)
                    {
                        int numberToSend = 0;
                        switch (diff)
                        {
                            case 1:
                                numberToSend = random.Next(1, 21);
                                break;
                            case 2:
                                numberToSend = random.Next(1, 41);
                                break;
                            case 3:
                                numberToSend = random.Next(1, 61);
                                break;
                        }
                        Console.WriteLine("Välkommen! jag tänker på ett nummer. Kan du gissa vilket?");
                        Console.WriteLine("Du får fem försök");

                        CheckGuess(numberToSend);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("välj mellan 1 och 3");
                    }
                }
                else
                {
                    Console.WriteLine("inte ett gilltigt tal");
                }
            }
            

            
        }

        

        public static void CheckGuess(int numberToGuess)
        {

            
            int wrongGuess = 0;

            while (wrongGuess < 5)
            {
                int guess;
                bool numberGuessed = int.TryParse(Console.ReadLine(), out guess);
                if (numberGuessed)
                {
                    if (guess == numberToGuess)
                    {
                        Console.WriteLine("Du gissade rätt!");
                        break;
                    }
                    if (guess < numberToGuess)
                    {
                        wrongGuess++;
                        Console.WriteLine("Tyvärr du gissade för lågt!");
                        Console.WriteLine("Försök igen");

                    }
                    else
                    {
                        wrongGuess++;
                        Console.WriteLine("Tyvärr du gissade för högt!");
                        Console.WriteLine("Försök igen");
                    }
                    if (wrongGuess == 5)
                    {
                        Console.WriteLine($"Tyvärr du färlorade rätt nummer va: {numberToGuess}");
                        Console.WriteLine("Tack för att du spelade!");
                    }
                }
                else
                {
                    Console.WriteLine("skriv ett tal tack");
                }
                
            }

            
        }
       
    }
}
