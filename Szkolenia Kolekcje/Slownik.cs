using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkolenia_Kolekcje
{
    internal class Slownik
    {
        /*
 Dictionary<TKey, TValue> pozwala na mapowanie wartości na klucze. 
 Jest to szybka struktura danych, szczególnie wtedy, gdy często
 potrzebujemy uzyskać dostęp do elementów na podstawie unikalnych identyfikatorów (kluczy).

Klucz: Musi być unikalny dla każdego elementu w słowniku.
Wartość: Może być dowolną wartością powiązaną z danym kluczem.
Podstawowe operacje na słowniku:
Dodawanie par klucz-wartość.
Usuwanie elementów na podstawie klucza.
Wyszukiwanie wartości na podstawie klucza.
        */

        public void TworzenieSlownika()
        {
            // Tworzenie słownika, gdzie kluczem jest typ string, a wartością int
            Dictionary<string, int> ages = new Dictionary<string, int>();

            // Dodawanie elementów do słownika
            ages.Add("Anna", 25);
            ages.Add("Piotr", 30);
            ages.Add("Jan", 45);

            // Wyświetlanie elementów w słowniku
            foreach (KeyValuePair<string, int> entry in ages)
            {
                Console.WriteLine($"{entry.Key} ma {entry.Value} lat");
            }

            // Dodanie elementów
            ages.Add("Magdalena", 29); // Dodaje nową parę klucz-wartość
            int ageOfAnna = ages["Anna"];
            Console.WriteLine("Anna ma " + ageOfAnna + " lat.");

            // Sprawdzanie istnienia klucza
            if (ages.ContainsKey("Jan"))
            {
                Console.WriteLine("Klucz 'Jan' istnieje w słowniku.");
            }
            else
            {
                Console.WriteLine("Klucz 'Jan' nie istnieje w słowniku.");
            }

            //Usuwanie elementu
            ages.Remove("Piotr");
            Console.WriteLine("Piotr został usunięty ze słownika.");

            //Operacje na słowniku
            //Iterowanie przez słownik
            foreach (KeyValuePair<string, int> entry in ages)
            {
                Console.WriteLine($"{entry.Key} ma {entry.Value} lat");
            }

            // luczba elementów w słowniku
            Console.WriteLine("Liczba elementów w słowniku: " + ages.Count);

            // Aktualizacja wartości
            ages["Jan"] = 50; // Zmieniamy wiek Jana
        }

        public void DictonaryPrzykladPraktyczny()
        {
            // Tworzymy słownik z uczniami i ich ocenami
            Dictionary<string, double> studentGrades = new Dictionary<string, double>();

            // Dodawanie uczniów i ich ocen
            studentGrades.Add("Anna", 4.5);
            studentGrades.Add("Piotr", 3.7);
            studentGrades.Add("Magdalena", 5.0);
            studentGrades.Add("Kasia", 4.0);

            // Wyświetlamy oceny uczniów, których imię ma więcej niż 4 znaki
            Console.WriteLine("Oceny uczniów o imionach dłuższych niż 4 znaki:");
            foreach (KeyValuePair<string, double> entry in studentGrades)
            {
                if (entry.Key.Length > 4)
                {
                    Console.WriteLine($"{entry.Key}: {entry.Value}");
                }
            }

            // Aktualizacja oceny dla Piotra
            studentGrades["Piotr"] = 4.2;
            Console.WriteLine("\nZaktualizowana ocena dla Piotra: " + studentGrades["Piotr"]);

            // Usunięcie ucznia z listy
            studentGrades.Remove("Kasia");
            Console.WriteLine("\nKasia została usunięta.");

            // Wyświetlamy wszystkie pozostałe oceny
            Console.WriteLine("\nPozostałe oceny:");
            foreach (KeyValuePair<string, double> entry in studentGrades)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }

            //próbuje uzyskać wartość na podstawie klucza. Zwraca true, jeśli klucz istnieje, lub false, jeśli klucz nie istnieje.
            double grade;
            if (studentGrades.TryGetValue("Anna", out grade))
            {
                Console.WriteLine("Ocena Anny: " + grade);
            }
            else
            {
                Console.WriteLine("Nie znaleziono Anny w słowniku.");
            }

            // Keys zwraca kolekcje wszystkich kluczy
            foreach (string student in studentGrades.Keys)
            {
                Console.WriteLine("Uczeń: " + student);
            }
            
            //Values  zwraca kolekcję wszystkich wartości.
            foreach (double grade1 in studentGrades.Values)
            {
                Console.WriteLine("Ocena: " + grade1);
            }
        }

    }
}
