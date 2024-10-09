using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Szkolenia_Kolekcje
{
    /*
 Queue<T> w C# to struktura danych typu FIFO (First In, First Out), czyli 
    "pierwsze weszło, pierwsze wyszło". Oznacza to, że elementy 
    są usuwane w takiej kolejności, w jakiej zostały dodane. Kolejki są 
    przydatne w sytuacjach, gdzie dane muszą być przetwarzane w określonej 
    kolejności, np. w systemach obsługi zadań, buforach danych czy kolejce drukowania.

1. Czym jest Queue?
Queue<T> to generyczna kolejka w C#, która działa na zasadzie FIFO:

Enqueue(T item) – dodaje element na końcu kolejki.
Dequeue() – usuwa i zwraca element z początku kolejki.
Peek() – zwraca element z początku kolejki bez jego usuwania.
Kolejki nie mają dostępu losowego – nie można uzyskać elementu w
środku kolejki bez wcześniejszego usunięcia wszystkich elementów przed nim.
     */
    internal class Kolejka
    {
        public void ProgramQueueKolejka()
        {
            // Tworzymy kolejkę liczb całkowitych
            Queue<int> queue = new Queue<int>();

            // Dodajemy elementy do kolejki
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            // Wyświetlanie elementów kolejki
            Console.WriteLine("Elementy w kolejce:");
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }

            // Podstawowe operacje na kolejkach
            queue.Enqueue(40); // Dodajemy liczbę 40 do kolejki

            //Usuwanie elementu
            int firstItem = queue.Dequeue(); // Usuwa i zwraca pierwszy element (10)
            Console.WriteLine("Usunięto element: " + firstItem);

            // Peek zwraca elementy z poczatku kolejki ale go nie usuwa
            int nextItem = queue.Peek(); // Zwraca kolejny element bez usuwania (20)
            Console.WriteLine("Pierwszy element w kolejce to: " + nextItem);

            // Count zwraca liczbe elementów w kolejce
            Console.WriteLine("Liczba elementów w kolejce: " + queue.Count);


        }

        public void PrzykladPraktycznyQueue()
        {
            // Tworzymy kolejkę klientów
            Queue<string> customers = new Queue<string>();

            // Dodajemy klientów do kolejki
            customers.Enqueue("Anna");
            customers.Enqueue("Piotr");
            customers.Enqueue("Jan");
            customers.Enqueue("Magdalena");

            // Wyświetlamy początkowy stan kolejki
            Console.WriteLine("Klienci w kolejce:");
            foreach (string customer in customers)
            {
                Console.WriteLine(customer);
            }

            // Obsługa klientów
            Console.WriteLine("\nObsługujemy klientów...");
            while (customers.Count > 0)
            {
                string customer = customers.Dequeue(); // Usuwamy klienta z kolejki
                Console.WriteLine($"Obsługiwany klient: {customer}");
            }

            // Sprawdzamy, czy kolejka jest pusta
            if (customers.Count == 0)
            {
                Console.WriteLine("\nWszyscy klienci zostali obsłużeni.");
            }


            // Inne przydatne metody w Queue
            //Metoda Contains(T item) sprawdza, czy dany element znajduje się w kolejce.

            bool containsJan = customers.Contains("Jan");
            Console.WriteLine("Czy Jan jest w kolejce? " + containsJan);
            
            
                //Metoda Clear() usuwa wszystkie elementy z kolejki.
            customers.Clear(); // Usuwa wszystkie elementy
            Console.WriteLine("Kolejka wyczyszczona, liczba elementów: " + customers.Count);
        }

        /*
          Zastosowanie kolejki w rzeczywistości
            Kolejki są często używane w systemach, gdzie kolejność przetwarzania jest istotna, np.:

            Obsługa zgłoszeń klientów – klienci są obsługiwani w kolejności, w jakiej zgłosili się do systemu.
            Bufory w systemach sieciowych – dane są odbierane i przetwarzane w kolejności, w jakiej zostały odebrane.
            Kolejki drukowania – zadania są drukowane w kolejności zgłoszenia.
        

        Złożony przykład: Symulacja kolejki drukowania
            Przyjrzyjmy się przykładzie symulacji kolejki zadań drukowania. 
            Program będzie dodawał dokumenty do kolejki i przetwarzał je jeden po drugim.
         */
        public void SymulacjaKolejki()
        {
            Queue<string> printQueue = new Queue<string>();

            // Dodajemy zadania do kolejki drukowania
            printQueue.Enqueue("Dokument1.pdf");
            printQueue.Enqueue("Prezentacja.pptx");
            printQueue.Enqueue("Zdjęcie.jpg");

            // Wyświetlanie początkowego stanu kolejki
            Console.WriteLine("Zadania w kolejce drukowania:");
            foreach (string document in printQueue)
            {
                Console.WriteLine(document);
            }

            // Przetwarzanie zadań drukowania
            Console.WriteLine("\nRozpoczynamy drukowanie...");
            while (printQueue.Count > 0)
            {
                string document = printQueue.Dequeue();
                Console.WriteLine($"Drukowanie: {document}");
            }

            // Sprawdzamy, czy kolejka jest pusta
            if (printQueue.Count == 0)
            {
                Console.WriteLine("\nWszystkie zadania zostały wydrukowane.");
            }
        }
    }
}
