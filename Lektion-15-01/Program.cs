/*
Uppgift 1: Dörrvakten för båtnamn (Guard Clauses)
Koncept: Defensiv programmering, Validering av indata.
Beskrivning: Skapa en klass SäkerFarkost med egenskaperna Namn och
Registreringsnummer. Klassen ska ha en konstruktor som validerar att namnet inte är
tomt eller null.
Krav:
Använd string.IsNullOrWhiteSpace() i konstruktorn.
Kasta ett ArgumentException om valideringen misslyckas.
*/

namespace Lektion_15;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            var bil = new SäkerFarkost("", "foo");
            
        }
        catch (Exception e)
        {
        Console.WriteLine(e.Message);
        // Console.WriteLine(e.ToString());
        }
    }
}

class SäkerFarkost
{
    public SäkerFarkost(string namn, string registreringsnummer)
    {
        if (string.IsNullOrWhiteSpace(namn))
            throw new ArgumentException("Namn får inte vara tomt!");

        if (string.IsNullOrWhiteSpace(registreringsnummer))
            throw new ArgumentException("Registreringsnummer får inte vara tomt!");
        
        Namn = namn.Trim();
        Registreringsnummer = registreringsnummer.Trim();
    }

    string Namn { get; }
    string Registreringsnummer { get; }

    
}