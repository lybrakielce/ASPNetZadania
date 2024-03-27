using System.Security.Cryptography.X509Certificates;

namespace M2L20_homework
{
    internal class Program
    {
        static void Main()    
        {
                        // Klasa (obiekt) ListOfNotes wczytuje plik txt z listą notatek LUB tworzy nowy jeśli brak
            ListOfNotes contentsList = new(Globals.path, Globals.file);
            string controler = "progress";
            string nrtxt = "";
            int nr;
            do
            {
                Console.WriteLine("*** NOTATKI z kursu Zostań programistą ASP .NET");
                Console.WriteLine("*** Spis treści wg kolejnych lekcji :");
                contentsList.ViewListOfNotes();
                Console.WriteLine("\n*** OPCJE : 1-Wyświetl notatkę ; 2-Napisz nową notatkę ; 3-Dodaj notatkę z pliku ; 4-Usuń notatkę ; 0-ZAKOŃCZ");
                Console.Write("*** Wybierz nr opcji : ");
                string chosenNr = Console.ReadLine();
                switch (chosenNr)
                {
                    case "1":   // Wyswietl notatke z listy
                        Console.Write("*** Podaj nr lekcji : ");
                        chosenNr = Console.ReadLine();
                        Console.WriteLine(">>> Zawartość notatki :");
                        contentsList.ViewNote(chosenNr);
                        Console.WriteLine("\nEnter aby kontynuować do menu głównego.");
                        Console.ReadLine();
                        break;
                    case "2":  // nowa notatka z konsoli
                        Console.WriteLine("Podaj nr modułu :");
                        string moduleNr = Console.ReadLine();
                        Console.WriteLine("Podaj nr lekcji :");
                        string lessonNr = Console.ReadLine();
                        Console.WriteLine("Podaj tytuł notatki :");
                        string newTitle = Console.ReadLine();
                        Note newNote = new(moduleNr, lessonNr, newTitle);
                        Console.WriteLine("Wpisz treść notatki, aby zakończyć wpisz w nowej linii END :");
                        newNote.SaveNote(Globals.path);
                        contentsList.AddNote(newNote);
                        contentsList.SaveList();
                        break;
                    case "3":       //case 3   dodanie NOTATKI Z PLIKU DO LISTY
                        contentsList.AddFileNote();
                            break;
                    case "4":            //case 4    Usuń notatkę
                        nrtxt = ConsoleReadLessonNr();
                        Int32.TryParse(nrtxt, out nr); 
                        contentsList.RemoveNote(contentsList.NotesList[nr - 1]);
                        break;
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
        }
        static string ConsoleReadLessonNr()
        {
            Console.Write("Wpisz numer z listy : ");
            string nrtxt = Console.ReadLine();
            Console.WriteLine($">>>>>>>>>>> Wybrano notatkę nr {nrtxt} <<<<<<<<<<<<<<");
            return nrtxt;
        }
    }
}
