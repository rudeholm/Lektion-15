/*
Uppgift 10: Säkrad historik med historik-kopiering
(Immutabilitet med with)
Koncept: Immutabilitet, Records.
Beskrivning: En digital färdplan lagras som ett record. När kaptenen ändrar
destinationen mitt under resan, vill rederiet ha en ny, fristående instans av färdplanen
men behålla originalet intakt för revision.
Krav:
Skapa ett record Färdplan med RuttID, StartHamn och DestinationHamn.
Använd with-uttrycket i Main för att generera den uppdaterade rutten utan att mutera
det ursprungliga rutt-objektet.
*/

namespace Lektion_15_10;

class Program
{
    static void Main(string[] args)
    {
        var färdplan = new Färdplan(33, "Gävle","Stockholm");
        var nyFärdplan = färdplan with { DestinationHamn = "Helsinki "};
        Console.WriteLine(nyFärdplan);
    }
}

public record Färdplan(int RuttID, string StartHamn, string DestinationHamn);