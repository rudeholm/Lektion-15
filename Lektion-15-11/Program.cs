/*
Uppgift 11: Det transaktionella passagerarregistret (Defensivt
tillståndsskydd)
Koncept: Defensiv programmering, Inkapsling.
Beskrivning: Skapa en klass PassagerarManifest som håller en lista över personer
ombord. Det finns en maxgräns på 12 personer.
Krav:
Metoden RegistreraGrupp(List<string> namnLista) måste validera hela gruppen
innan någon läggs till.
Om tillägget av gruppen gör att totala antalet överstiger 12, får ingen i gruppen läggs till
(allt eller inget-principen) och ett undantag ska kastas.
*/

namespace Lektion_15_11;

class Program
{
    static void Main(string[] args)
    {
        var manifest = new PassagerarManifest();
        manifest.RegistreraGrupp(["Li-Lo", "Nisse", "Eva", "Sandra","Kalle"]);
        manifest.SkrivUt();

        manifest.RegistreraGrupp(["Erik","Lina","Hanna","Sven","Knut"]);
        manifest.SkrivUt();

        manifest.RegistreraGrupp(["Stig","Marina","Calle"]); // Dessa läggs inte till!
        manifest.SkrivUt(); // Det här händer inte!
    }
}

class PassagerarManifest
{
    List<string> Personer = [];

    public void RegistreraGrupp(List<string> namnLista)
    {
        if (Personer.Count + namnLista.Count > 12)
            throw new ArgumentException("Det totala antalet passagerare får inte överstiga 12!");
        
        Personer.AddRange(namnLista);
    }

    public void SkrivUt()
    {
        Console.WriteLine();
        foreach (var namn in Personer)
        {
        Console.Write($"{namn} ");
        }
        Console.WriteLine();
    }
}