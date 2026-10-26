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

using System.Data.Common;

namespace Lektion_15_09;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            HämtaPassagerarData();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    static void HämtaPassagerarData()
    {
        throw new DataHämtningsException("Något gick fel.", new Exception("Känsliga tabellnamn och IP-adresser"));
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