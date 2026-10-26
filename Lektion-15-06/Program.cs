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
        var bokning = new BokningsReferens("BÅT-1234");
        var referens2 = new BokningsReferens("BIL-1234");
    }
}

class BokningsReferens
{
    public BokningsReferens(string kod)
    {
        if (kod.StartsWith("BÅT-") is false || kod.Length != 8)
            throw new FormatException("Bokningsnummer måste ha formatet  \"BÅT-\" följt av fyra siffror, t.ex. \"BÅT-1234\"");

        Nummer = kod;
    }

    public string Nummer { get; private set; }
    
}