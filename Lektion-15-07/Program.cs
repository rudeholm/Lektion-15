/*
Uppgift 7: Säkrad API-parser (TryParse-mönstret)
Koncept: Defensiv programmering, Felhantering.
Beskrivning: Ett simulerat API returnerar väderdata som textsträngar. Du ska bygga en
metod TolkaVindhastighet(string apiData) som gör om texten till ett decimaltal.
Krav:
Använd double.TryParse() istället för Parse.
Om konverteringen misslyckas ska metoden returnera ett standardvärde (0.0) och
skriva en dold varning till systemloggen (System.Diagnostics.Debug.WriteLine).
*/

namespace Lektion_15_07;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Vindhastighet: {TolkaVindhastighet("29.2")} m/s");
    }

    public static double TolkaVindhastighet(string apiData)
    {
        double vindhastighet = 0.0;

        if (double.TryParse(apiData, out vindhastighet) is false)
        {
            System.Diagnostics.Debug.WriteLine($"Varning --- felaktig indata: apiData = \"{apiData}\"");
            // Console.WriteLine($"Varning --- felaktig indata: apiData = \"{apiData}\"");            
        }

        return vindhastighet;
    }
}
