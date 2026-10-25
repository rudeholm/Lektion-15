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
        reg.AktuellKnop = 33;
        Console.WriteLine(reg.AktuellKnop);
    }
}

class HastighetsRegulator
{
    public int AktuellKnop
    {
        get;
        internal set
        {
            if (value < 0 || value > 30)
                throw new ArgumentOutOfRangeException("Tillåtna värden är 0-30");
        }
    }
}