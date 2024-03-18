namespace M2L20_homework
{
    internal class Program
    {
        static void Main()     // IN PROGRESS
        {
            // Klasa (obiekt) ListOfNotes wczytuje plik txt z listą lekcji
            
            ListOfNotes contentsList = new(Globals.path, Globals.file);
 /*TEST MAIN*/     //    Console.WriteLine("TEST MAIN Obiekt ListOfNotes : ",contentsList);
            string controler = "progress";
            do
            {
                Console.WriteLine("*** NOTATKI z kursu Zostań programistą ASP .NET");
                Console.WriteLine("*** Spis treści wg kolejnych lekcji :");
                contentsList.ViewListOfNotes();
                Console.WriteLine("\n*** OPCJE : 1-Wyświetl notatkę ; 2-Napisz nową notatkę ; 3-Dodaj notatkę z pliku ; 4..7-in progress ; 0-ZAKOŃCZ");
                // Opcje do wykonania : 1 Wyświetl notatkę ; 2 Pisz nową ; 3 Dodaj z pliku ; 4 Usuń notatkę ; 5 Wyczyść notatkę ;
                // 6 Dopisz na końcu notatki ; 7 Dopisz na początku notatki ; 0 Zakończ
                Console.Write("*** Wybierz nr opcji : ");
                //int.TryParse(Console.ReadLine(), out int chosenNr);
                string chosenNr = Console.ReadLine();
                switch (chosenNr)
                {
                    case "1":   // Wyswietl notatke z listy
                        Console.Write("*** Podaj nr lekcji : ");
                        // zamiana ReadLine na obiekt typu Note - wywołanie metody ListOfNotes.ViewNote(nr_lekcji_ze_spisu)
                        // a ta utworzy obiekt Note
                        chosenNr = Console.ReadLine();
                        Console.WriteLine(">>> Zawartość notatki :");
                        contentsList.ViewNote(chosenNr);
                        Console.WriteLine("\nEnter aby kontynuować do menu głównego.");
                        Console.ReadLine();
                        break;
                    case "2":  // nowa notatka z konsoli
                               // nowy obiekt klasy Note
                               //contentsList.WriteListFile();
                        Console.WriteLine("Podaj nr modułu :");
                        string moduleNr = Console.ReadLine();
                        Console.WriteLine("Podaj nr lekcji :");
                        string lessonNr = Console.ReadLine();
                        Console.WriteLine("Podaj tytuł notatki :");
                        string newTitle = Console.ReadLine();
                        Note newNote = new(moduleNr, lessonNr, newTitle);
                        //newNote.notePath = Globals.path;

                        Console.WriteLine("Wpisz treść notatki, aby zakończyć wpisz w nowej linii END :");
                        // ZAPIS kilku linii txt DO PLIKU
                        newNote.SaveNote(Globals.path);
                        //ZROBIONE: DODANIE nowej notatki DO LISTY notatek i zapisanie listy w PLIKU
                        contentsList.AddNote(newNote);
                        contentsList.SaveList();
                        break;
                    //case 3    NOTATKA Z PLIKU DO LISTY
                    case "3":
                        contentsList.AddFileNote();
                            break;   
                    //case 4
                    //case 5
                    //case 6
                    //case 7
                    case "0":
                         Console.WriteLine("KONIEC. Naciśnij enter.");
                            Console.ReadKey();
                            controler = "exit";
                            break;
                    default:
                        Console.WriteLine("KONIEC.");
                        controler = "exit";
                        break;
                }
                Console.WriteLine("_____________________________________________________________________________");
            }
            while (controler != "exit");
           
           
            /* char chosenSubject = Console.ReadKey();
            // 1. Metoda pobierając readkey zwróci obiekt klasy Note 
            // Konsola wyswietli ten obiekt
            // i na końcu poda opcje : Usuń , Wyczyść, Dopisz na końcu, Dopisz na początku
            //* Potrzebna jest klasa z w/w metodą. Np ListOfNotes. Będzie tam pole typu List
            //  z Id i tytułami lekcji
            // 
            //* Klasa Note definiuje cechy notatki i metody do jej modyfikacji lub usunięcia ...
            // pole Title , Created , LastEdited , Autor , 
            //* Wyświetl notatkę - metoda w klasie note do wyswietlenia tresci albo wywołanie obiekt.pole_tresci
            //  w console.writeline
            //* (Edycja notatki - nie bo można w pliku tekstowym)
            //* Tworzenie nowej notatki - metoda w klasie ListOfLessons dodająca pozycję/element pola listowego
            //  i tworząca obiekt klasy Note
            //  treść musi być pobrana np z pliku lub z konsoli -- najpierw string do zmiennej a potem nowy obiekt
            //  klasy Note z tą zmienną 
            //* Usunięcie notatki - metoda w klasie ListOfLessons usuwająca element listy i usuwająca obiekt klasy note
            */
        }

        
    }
}
