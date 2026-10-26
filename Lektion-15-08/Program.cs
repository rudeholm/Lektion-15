/*
Uppgift 8: Rollbaserad dörrvakt (Minsta behörighet i logik)
Koncept: Principen om minsta behörighet, Inkapsling.
Beskrivning: Skapa ett system för att starta fartygets länspump. Endast användare
med rollen "Kapten" eller "Maskinist" får anropa startmetoden.
Krav:
Metoden StartaLänspump(string användarRoll) ska kontrollera parametern mot
godkända strängvärden.
Om rollen är "Gäst" eller tom ska ett UnauthorizedAccessException kastas.
*/

namespace Lektion_15_08;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Försöker starta länspumpen...");
        StartaLänspump("Kapten");
        StartaLänspump("Maskinist");
        StartaLänspump("Mask");
        // StartaLänspump("Kapten ");
        // StartaLänspump("Gäst");
        // StartaLänspump("");
    }

    static void StartaLänspump(string användarRoll)
    {
        string[] auktoriseradeRoller = ["Kapten", "Maskinist"];
        if (auktoriseradeRoller.Contains(användarRoll) is not true)
            throw new UnauthorizedAccessException();

        Console.WriteLine($"{användarRoll} får starta länspumpen");
    }
}
