


 // Oppg 1 - if/else - Lag en metode som tar imot to tall og returnerer true dersom tallene er like. 



namespace If_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv inn det første tallet: ");
            int tall1 = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Skriv inn det andre tallet: ");
            int tall2 = int.Parse(Console.ReadLine());

            bool AreAlike = NumbersAreAlike(tall1, tall2);


            if (AreAlike)
            {
                Console.WriteLine("Tallene er like.");
            }
            else
            {
                Console.WriteLine("Tallene er ikke like.");
            }
        }

        static bool NumbersAreAlike(int tall1, int tall2) 
        {
            if(tall1 == tall2)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
    }
}