


 // Oppg 1 - if/else - Lag en metode som tar imot to tall og returnerer true dersom tallene er like. 



namespace If_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Konsollen viser brukeren en tekst
             Vi sier at int-en er lik int.Parse() og sender inn Console.ReadLine
             Det gjør at tall1 og tall2 er lik det vi skriver inn i konsollen
             Det vi skrev inn blir nå tolka som en int verdi (heltall) og ikke string, pga int.Parse()
            */

            Console.WriteLine("Skriv inn det første tallet: "); 
            int tall1 = int.Parse(Console.ReadLine());          
            
            Console.WriteLine("Skriv inn det andre tallet: ");
            int tall2 = int.Parse(Console.ReadLine());

            bool AreAlike = NumbersAreAlike(tall1, tall2); // Lager en bool som er lik funksjonen vår for å kalle den enklere.


            if (AreAlike) // Hvis det brukeren skriver inn som tall1 er lik det som blir lik tall2
            {
                Console.WriteLine("Tallene er like."); // Så vil konsollen skrive at tallene er like.
            }
            else 
            {
                Console.WriteLine("Tallene er ikke like."); // Om tallene ikke er like vil konsollen skrive det.
            }
        }

        static bool NumbersAreAlike(int tall1, int tall2) // Sjekker om tallene man skriver inn er like. Tar imot to parametre.
        {
            if(tall1 == tall2) 
            {
                return true; // Er tall1 likt tall2 returneres true og konsollen skriver at tallene er like.
            }
            else
            {
                return false; // Hvis tallene ikke er like så vil konsollen si det og returnere false.
            }
        } 
    }
}