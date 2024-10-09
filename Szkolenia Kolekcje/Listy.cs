using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Szkolenia_Kolekcje
{
    internal class Listy
    {

        public void OdtworzListe()
        {
            // Tworzymy listę liczb całkowitych
            List<int> numbers = new List<int>();

            // Dodajemy elementy do listy
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            numbers.AddRange(new int[] { 4, 5, 6 });

            // Dostęp do elementów listy
            int firstElement = numbers[0]; // Zwraca pierwszy element

            // Wyświetlamy zawartość listy
            Console.WriteLine("Elementy listy:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Usuwanie elementów z listy
            numbers.Remove(2); // Usuwa pierwsze wystąpienie liczby 2
            numbers.RemoveAt(0); // Usuwa element o indeksie 0 (pierwszy element)

            // Sortowanie listy
            numbers.Sort();
            Console.WriteLine("Posortowana lista:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Znajdowanie elementu
            bool containsThree = numbers.Contains(3);
            Console.WriteLine("Lista zawiera 3: " + containsThree);

            // Znajdz jeżeli spełni warunek
            int foundNumber = numbers.Find(n => n > 3);
            Console.WriteLine("Pierwsza liczba większa od 3: " + foundNumber);
        }


        // Tworzymy listę liczb całkowitych jako pole klasy
        private List<int> numbers = new List<int>();

        // Metoda dodająca elementy do listy na podstawie wejścia użytkownika
        public void DodajElement()
        {
            Console.WriteLine("Podaj liczbę do dodania do listy (lub wpisz 'stop' aby zakończyć):");

            while (true)
            {
                string input = Console.ReadLine();

                // Jeśli użytkownik wpisze 'stop', przerywamy dodawanie
                if (input.ToLower() == "stop")
                {
                    break;
                }

                // Próbujemy zamienić wpisany tekst na liczbę całkowitą
                if (int.TryParse(input, out int number))
                {
                    numbers.Add(number); // Dodajemy liczbę do listy
                    Console.WriteLine($"Dodano {number} do listy.");
                }
                else
                {
                    Console.WriteLine("Podano nieprawidłową wartość, spróbuj ponownie.");
                }
            }
        }

        // Metoda do wyświetlania zawartości listy
        public void WyswietlListe()
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine("Lista jest pusta.");
            }
            else
            {
                Console.WriteLine("Elementy listy:");
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }
        }

        public void ProgramImiona()
        {
            List<string> names = new List<string>();

            // Dodawanie imion do listy
            names.Add("Anna");
            names.Add("Piotr");
            names.Add("Jan");
            names.Add("Magdalena");
            names.Add("Kasia");

            // Wyświetlamy wszystkie imiona
            Console.WriteLine("Wszystkie imiona:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // Sortujemy listę imion
            names.Sort();

            // Wyświetlamy posortowaną listę
            Console.WriteLine("\nPosortowane imiona:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // Filtrujemy imiona o długości większej niż 4 znaki
            List<string> longNames = names.FindAll(name => name.Length > 4);

            // Wyświetlamy imiona o długości większej niż 4 znaki
            Console.WriteLine("\nImiona dłuższe niż 4 litery:");
            foreach (string name in longNames)
            {
                Console.WriteLine(name);
            }

            // Inne przydatne metody
            // Insert(int index, T item) – wstawia element na określoną pozycję.
            // IndexOf(T item) – zwraca indeks pierwszego wystąpienia danego elementu.
            // Reverse() – odwraca kolejność elementów w liście.
            names.Insert(1, "Tomek"); // Wstawia "Tomek" na drugą pozycję
            int index = names.IndexOf("Piotr"); // Zwraca indeks "Piotra"
            names.Reverse(); // Odwraca kolejność
        }
    }
}

