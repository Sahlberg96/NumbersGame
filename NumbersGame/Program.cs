namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Hej välj en svårighetsgrad");
            int selectDiff = int.Parse(Console.ReadLine());

            int numberToSend = 0;
            
            switch (selectDiff)
            {
                case 1:
                    numberToSend = random.Next(1, 21);
                    break;
                case 2:
                    numberToSend = random.Next(1, 41);
                    break;
                case 3:
                    numberToSend = random.Next(50, 61);
                    break;
            }

            Console.WriteLine("Välkommen! jag tänker på ett nummer. Kan du gissa vilket?");
            Console.WriteLine("Du får fem försök");
            
            CheckGuess(numberToSend);
        }

        

        public static void CheckGuess(int numberToGuess)
        {

            
            int wrongGuess = 0;

            while (wrongGuess < 5)
            {
                int guess = int.Parse(Console.ReadLine()); ;
                if (guess == numberToGuess)
                {
                    Console.WriteLine("Du gissade rätt!");
                    break;
                }
                if(guess < numberToGuess)
                {
                    Console.WriteLine("Tyvärr du gissade för lågt!");
                    Console.WriteLine("Försök igen");
                    wrongGuess++;

                }
                if (guess > numberToGuess)
                {
                    Console.WriteLine("Tyvärr du gissade för högt!");
                    wrongGuess++;
                }
                if (wrongGuess == 5)
                {
                    Console.WriteLine($"Tyvärr du färlorade rätt nummer va: {numberToGuess}");
                }
            }

            
        }
    }
}
