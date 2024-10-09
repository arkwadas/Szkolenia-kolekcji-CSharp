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
     Stack<T> to struktura danych typu LIFO (Last In, First Out), 
    co oznacza, że element, który zostanie dodany jako ostatni, 
    jest usuwany jako pierwszy. Stos jest często wykorzystywany 
    do rozwiązywania problemów związanych z rekurencją, nawigacją 
    (np. cofnij/przywróć), a także w systemach przetwarzania wyrażeń arytmetycznych.

 Czym jest Stack?
Stack<T> to kolekcja, która przechowuje elementy w taki sposób, że:

Push(T item) – dodaje element na szczyt stosu.
Pop() – usuwa i zwraca element z wierzchołka stosu.
Peek() – zwraca element z wierzchołka stosu bez jego usuwania.
     */
    internal class Stos
    {
        public void ProgramStos()
        {
            // Tworzenie stosu liczb całkowitych
            Stack<int> stack = new Stack<int>();

            // Dodawanie elementów na stos
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            // Wyświetlanie elementów stosu
            Console.WriteLine("Elementy na stosie:");
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }

            // Operacja na stosie
            // Metoda Push(T item) dodaje element na szczyt stosu.
            stack.Push(40); // Dodajemy liczbę 40 na szczyt stosu


            //Metoda Pop() usuwa i zwraca element z wierzchołka stosu. Jeśli stos jest pusty, metoda ta rzuca wyjątek.
            int topItem = stack.Pop(); // Usuwa i zwraca element (30)
            Console.WriteLine("Usunięto element: " + topItem);

            //Metoda Peek() zwraca element z wierzchołka stosu, ale go nie usuwa.
            int peekItem = stack.Peek(); // Zwraca element na szczycie (20)
            Console.WriteLine("Wierzchołek stosu: " + peekItem);

            //Właściwość Count zwraca liczbę elementów w stosie.
            Console.WriteLine("Liczba elementów na stosie: " + stack.Count);
        }

        public void PrzykladPraktycznyStos()
        {
            // Tworzymy stos odwiedzonych stron
            Stack<string> browserHistory = new Stack<string>();

            // Symulacja odwiedzania stron
            browserHistory.Push("Strona główna");
            browserHistory.Push("Strona o nas");
            browserHistory.Push("Kontakt");

            // Wyświetlanie historii przeglądania
            Console.WriteLine("Historia przeglądania:");
            foreach (string page in browserHistory)
            {
                Console.WriteLine(page);
            }

            // Cofnięcie się do poprzedniej strony
            Console.WriteLine("\nCofnięcie do poprzedniej strony...");
            string currentPage = browserHistory.Pop(); // Usuwa stronę "Kontakt"
            Console.WriteLine("Obecna strona: " + browserHistory.Peek()); // Pokazuje stronę "Strona o nas"

            // Wyświetlenie pozostałych stron w historii
            Console.WriteLine("\nPozostałe strony w historii:");
            foreach (string page in browserHistory)
            {
                Console.WriteLine(page);
            }

            //Inne przykłady
            // Metoda Contains(T item) sprawdza, czy dany element znajduje się na stosie.
            bool containsHomePage = browserHistory.Contains("Strona główna");
            Console.WriteLine("Czy Strona główna znajduje się w historii? " + containsHomePage);

            //Metoda Clear() usuwa wszystkie elementy ze stosu.
            browserHistory.Clear(); // Usuwa wszystkie elementy
            Console.WriteLine("Stos wyczyszczony, liczba elementów: " + browserHistory.Count);
        }

        /*
          Zastosowanie stosu w rzeczywistości
Stos jest często używany w wielu rzeczywistych scenariuszach:

Rekurencja – Stosy są używane do śledzenia stanu wywołań funkcji rekurencyjnych.
Cofanie operacji (Undo) – W edytorach tekstu lub programach graficznych stosy są 
        wykorzystywane do implementacji funkcji cofania.
Nawigacja w przeglądarkach – Stos pozwala na przechowywanie odwiedzanych stron, a 
        funkcja cofania umożliwia powrót do poprzednich stron.
        
         Przykład z życia: Cofanie operacji
Stworzymy program, który symuluje funkcję cofania operacji (Undo). 
        Każda operacja jest zapisywana na stosie, a użytkownik może cofnąć ostatnie operacje.
         */
        public void ProgramZZyciaStos()
        {
            Stack<string> actions = new Stack<string>();

            // Dodajemy operacje
            actions.Push("Dodano tekst");
            actions.Push("Zmiana koloru");
            actions.Push("Usunięto obrazek");

            // Wyświetlanie wykonanych operacji
            Console.WriteLine("Wykonane operacje:");
            foreach (string action in actions)
            {
                Console.WriteLine(action);
            }

            // Cofnięcie ostatniej operacji
            Console.WriteLine("\nCofnięcie ostatniej operacji...");
            string lastAction = actions.Pop();
            Console.WriteLine("Cofnięto: " + lastAction);

            // Wyświetlenie pozostałych operacji
            Console.WriteLine("\nPozostałe operacje:");
            foreach (string action in actions)
            {
                Console.WriteLine(action);
            }
        }
    }
}
