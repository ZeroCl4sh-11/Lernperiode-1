
using System;


class Programm


{
    static void Main()
    {
        
        string zeichen = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvexyz0123456789";
        string passwort = "";
        Random zufall = new Random();

        for (int i = 0; i < 10; i++)

        {
            int zufallsZahl = zufall.Next(zeichen.Length);
            char zufallsZeichenn = zeichen[zufallsZahl];
            passwort = passwort + zufallsZeichenn;
        }
        Console.WriteLine("Ihr passwort: " + passwort);

    }
}   


  