using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Szkolenia_Kolekcje;

class Program
{
    static void Main(string[] args) // Możesz też dodać argumenty wejściowe, jeśli są potrzebne
    {
        // Tworzymy obiekt klasy Listy i wywołujemy metodę OdtworzListe      
        Listy listy = new Listy();
        listy.OdtworzListe();

        // Umożliwiamy użytkownikowi dodawanie elementów do listy
        listy.DodajElement();

        // Po zakończeniu dodawania, wyświetlamy zawartość listy
        listy.WyswietlListe();

        // Program z imionami
        listy.ProgramImiona();
        
        Console.ReadKey(); // Czekamy na naciśnięcie klawisza przed zamknięciem programu

        /*Slownik slownik = new Slownik();

        slownik.TworzenieSlownika();
        slownik.DictonaryPrzykladPraktyczny();

        Console.ReadKey();

        Kolejka kolejka = new Kolejka();

        kolejka.ProgramQueueKolejka();
        kolejka.PrzykladPraktycznyQueue();
        kolejka.SymulacjaKolejki();

        Console.ReadKey();

        Stos stos = new Stos();
        stos.ProgramStos();
        stos.PrzykladPraktycznyStos();
        stos.ProgramZZyciaStos();

        Console.ReadKey();*/
    }
}