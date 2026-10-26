/*
Uppgift 9: Maskerat databasundantag (Säker felhantering)
Koncept: Felhantering och informationsläckage.
Beskrivning: Skapa en simulerad metod HämtaPassagerarData(). Metoden kastar
internt ett System.Data.Common.DbException som innehåller känsliga tabellnamn och
IP-adresser.
Krav:
Fånga databasundantaget.
Kasta ett nytt, eget definierat undantag (DataHämtningsException) som bara innehåller
ett säkert felmeddelande, men bifoga det gamla undantaget som en dold
InnerException för administratörens ögon.
*/

using System.Data;
using System.Data.Common;

namespace Lektion_15_09;

class Program
{
    static void Main(string[] args)
    {
        var db = new PassagerarDatabas();

        try
        {
            db.HämtaPassagerarData();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine();
            Console.WriteLine($"({e.InnerException!.Message})");
        }
    }
}

public class PassagerarDatabas
{
    public void HämtaPassagerarData()
    {
        try
        {
            // Simulera kritiskt fel
            throw new DataException("Känsliga tabellnamn och IP-adresser");
        }
        catch (Exception e)
        {
            throw new DataHämtningsException("Kunde inte hämta passagerarlistan.", e);
        }

    }

}

public class DataHämtningsException : Exception
{
    public DataHämtningsException()
    {
    }

    public DataHämtningsException(string? message) : base(message)
    {
    }

    public DataHämtningsException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}