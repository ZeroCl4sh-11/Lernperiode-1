using System;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        string zeichen = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        string passwort = "";
        Random zufall = new Random();

        Console.WriteLine("Wie viele Zeichen soll dein Passwort haben?");
        int x = Convert.ToInt32(Console.ReadLine());

        if (x > 12)
        {
            Console.WriteLine("Dein Passwort ist zu lang!");
            return;
        }

        Console.WriteLine("Welche Option willst du?");
        Console.WriteLine("1 - Normales Passwort");
        Console.WriteLine("2 - Nur Kleinbuchstaben");
        Console.WriteLine("3 - Zahlen und Sonderzeichen");
        Console.WriteLine("4 - Aussprechbare Wörter");

        int y = Convert.ToInt32(Console.ReadLine());

        if (y == 1)
        {
            Console.WriteLine("Grossbuchstaben? ja/nein");

            if (Console.ReadLine() == "nein")
                zeichen = zeichen.ToLower();
        }

        if (y == 2)
            zeichen = "abcdefghijklmnopqrstuvwxyz";

        if (y == 3)
            zeichen = "0123456789!§$%&/()=?";

        if (y == 4)
        {
            string[] woerter = { "Haus", "Auto", "Baum", "Apfel", "Katze" };

            for (int i = 0; i < 3; i++)
                passwort += woerter[zufall.Next(woerter.Length)];
        }
        else
        {
            for (int i = 0; i < x; i++)
                passwort += zeichen[zufall.Next(zeichen.Length)];
        }
        
        if (passwort.Length >= 16)
            Console.WriteLine("Passwortstärke: Stark");
        else
            Console.WriteLine("Passwortstärke: Mittel");

        Console.WriteLine("Das Passwort: " + passwort);
    }
}
