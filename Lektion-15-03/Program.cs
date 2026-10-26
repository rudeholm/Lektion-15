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
        LäsKänsligFil(@"Filsökväg/som/inte/finns.txt");
    }

    static void LäsKänsligFil(string sökväg)
    {
        try
        {
            var data = File.ReadAllText(sökväg);
            Console.WriteLine(data);
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Ett internt systemfel uppstod. Åtgärden kunde inte slutföras.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Ett internt systemfel uppstod. Åtgärden kunde inte slutföras.");
        }
    }
}

