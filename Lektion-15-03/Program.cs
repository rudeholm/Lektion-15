/*
Uppgift 3: Det anonyma felmeddelandet (Säker felhantering)
Koncept: Felhantering och informationsläckage.
Beskrivning: Skapa en metod LäsKänsligFil(string sökväg) som försöker läsa en
fil. Om filen inte finns, får programmet inte krascha, och det råa felmeddelandet från
operativsystemet får inte läcka ut.
Krav:
Använd try-catch.
Skriv ut ett helt generellt, sterilt meddelande till användaren: "Ett internt systemfel
uppstod. Åtgärden kunde inte slutföras."
*/

namespace Lektion_15_03;

class Program
{
    static void Main(string[] args)
    {
        LäsKänsligFil("Filsökväg/som/inte/finns.txt");
    }

    static void LäsKänsligFil(string sökväg)
    {
        try
        {
            File.ReadAllText(sökväg);
        }
        catch (Exception)
        {
            Console.WriteLine("Ett internt systemfel uppstod. Åtgärden kunde inte slutföras.");
        }
    }
}

