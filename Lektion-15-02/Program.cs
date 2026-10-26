/*
Uppgift 2: Fartbegränsaren i hamnen (Intervallvalidering)
Koncept: Defensiv programmering.
Beskrivning: Skapa en klass HastighetsRegulator med en egenskap AktuellKnop.
Hastigheten får aldrig sättas till ett negativt värde eller överstiga 30 knop.
Krav:
Valideringen ska ligga inuti propertyns set-block (inkapsling).
Kasta ett ArgumentOutOfRangeException om värdet ligger utanför intervallet 0–30.
*/

namespace Lektion_15_02;

class Program
{
    static void Main(string[] args)
    {
        var reg = new HastighetsRegulator();
        try
        {
            reg.AktuellKnop = 33;

        }
        catch (ArgumentOutOfRangeException e)
        {
        Console.WriteLine(e.Message);
        }
        Console.WriteLine(reg.AktuellKnop);
    }
}

class HastighetsRegulator
{
    private int _aktuellKnop;

    public int AktuellKnop
    {
        get => _aktuellKnop;

        internal set
        {
            if (value < 0 || value > 30)
                throw new ArgumentOutOfRangeException(nameof(value), "Tillåtna värden är 0-30");
        }
    }
}