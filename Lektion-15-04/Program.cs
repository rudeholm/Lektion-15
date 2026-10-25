/*
Uppgift 4: Det låsta loggboksinlägget (Immutabilitet med
Record)
Koncept: Immutabilitet som säkerhetsmekanism.
Beskrivning: Skapa en datastruktur för ett loggboksinlägg som absolut inte får gå att
manipulera i efterhand efter att det har skapats.
Krav:
Använd ett record med egenskaperna Tidsstämpel, Meddelande och Signatur.
Visa i Main att det blir kompileringsfel om man försöker ändra på egenskaperna direkt.
*/

namespace Lektion_15_04;

class Program
{
    static void Main(string[] args)
    {
        var anteckning = new Loggboksinlägg("Foo bar baz!", "###--- fslk sfl");
        Console.WriteLine($"{anteckning.Meddelande}\n{anteckning.Signatur}\n{anteckning.Tidsstämpel}");
        // anteckning.Tidsstämpel = DateTime.Parse("2022-01-01");

        var anteckning2 = new EnkeltLoggboksinlägg(DateTime.Now,"Foo bar baz!", "###--- fslk sfl");
        // anteckning2.Tidsstämpel = DateTime.Parse("2022-01-01");
    }
}

// NOT IMMUTABLE BY DEFAULT - must specify
public record Loggboksinlägg
{
    public DateTime Tidsstämpel { get; init; }
    public string Meddelande { get; init; }
    public string Signatur { get; init; }

    public Loggboksinlägg(string meddelande, string signatur)
    {
        Tidsstämpel = DateTime.Now;
        Meddelande = meddelande;
        Signatur = signatur;
    }
}

// IMMUTABLE BY DEFAULT
public record EnkeltLoggboksinlägg(DateTime Tidsstämpel, string Meddelande, string Signatur);