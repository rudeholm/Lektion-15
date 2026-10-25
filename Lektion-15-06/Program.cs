/*
Uppgift 6: Det robusta bokningsnumret
(Strängformatssäkring)
Koncept: Defensiv programmering.
Beskrivning: Ett system för att boka båtplatser kräver att bokningsnumret alltid har
exakt formatet "BÅT-" följt av fyra siffror (t.ex. "BÅT-1234").
Krav:
Skapa klassen BokningsReferens. Konstruktorn ska validera strängens längd samt att
den startar med rätt text.
Kasta ett FormatException om formatet är ogiltigt.
*/

namespace Lektion_15_06;

class Program
{
    static void Main(string[] args)
    {
        var referens = new BokningsReferens("BÅT-1234");
        // var referens2 = new BokningsReferens("BÅT12345");
    }
}

class BokningsReferens
{
    public BokningsReferens(string nummer)
    {
        if (nummer.StartsWith("BÅT-") is false || nummer.Length != 8)
            throw new FormatException();

        Nummer = nummer;
    }

    public string Nummer { get; private set; }
    
}