/*
Uppgift 5: Den SURRADE kompassen (Minsta behörighet)
Koncept: Principen om minsta behörighet (Least Privilege).
Beskrivning: Skapa en klass DigitalKompass som internt håller koll på en
_aktuellKurs (heltal). Omvärlden ska kunna läsa kursen, men absolut inte kunna
ändra den utifrån.
Krav:
Egenskapen Kurs ska ha en publik get men en private set.
Skapa en publik metod UppdateraKurs(int nyKurs) som verifierar att kursen ligger
mellan 0 och 359 innan den uppdateras.
*/

namespace Lektion_15_05;

class Program
{
    static void Main(string[] args)
    {
        var kompass = new DigitalKompass();
        kompass.UppdateraKurs(33);
        // kompass.UppdateraKurs(-33);
        Console.WriteLine("Hello, World!");
    }
}

class DigitalKompass
{
    public int _aktuellKurs { get; private set; }

    public void UppdateraKurs(int nyKurs)
    {
        if (nyKurs < 0 || nyKurs > 359)
            throw new ArgumentException();

        _aktuellKurs = nyKurs;
    }
}