using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace M2L20_homework
{
    internal class ListOfNotes      
    {                                   
        public string ListPath { get; }
        private readonly string listFile;
        private readonly string pathAndFile;

        public List<Note> NotesList { get; }
        public ListOfNotes(string path, string file)    // obiekt listy powstaje z pliku txt
        {   ListPath = path;
            listFile = file;                        // nazwa pełna z rozszerzeniem .txt
            pathAndFile = path + file;           
            NotesList = [];                         //pusta lista ; NotesList = new List<Note>();
            ReadFile();                      // wypełnia listę obiektami na podstawie pliku txt
        }
        public List<Note> ViewListOfNotes()     // wyswietla tytuly notatek na liscie
        {
            int i;
            for (i = 1; i <= NotesList.Count;i++)
            {
                Console.WriteLine($"{i}. {NotesList[i-1].NoteTitle()} *** {NotesList[i - 1].noteFile}.txt");
            }
            return NotesList;
        }

        public void ViewNote(string stringNumber)   // wyswietla wybraną notatke (nr na liście) w konsoli
        {
            int.TryParse(stringNumber, out int numberOnList);
 /*TEST ViewNote */    // Console.WriteLine("TEST ViewNote Obiekt Note:  ", NotesList[numberOnList - 1]);
            NotesList[numberOnList - 1].ViewNoteTxt();
        }
        public void ReadFile()      // wczytanie pliku txt listy i wpisanie danych do obiektów listy
        {
        Start:
            try
            {
                if(File.Exists(pathAndFile))
                {
                    using (StreamReader r = File.OpenText(pathAndFile)) //using (StreamReader r = new(listFile))     //StreamReader r = new StreamReader(listFile);
                    {                                    // PĘTLA DO NAPOTKANIA eof
                        string line = "";
                        int lineNr = 1;
                        line = r.ReadLine();
                        if (line == null)           // spr. czy pierwsza linia jest pusta (pusty plik)
                        {
                            Console.WriteLine("Plik listy pusty. Czy chcesz utworzyć listę ? T/N");
                            char choice = Convert.ToChar(Console.ReadLine());
                            choice = char.ToUpper(choice);
                            if (choice.Equals('T'))
                            {
                                NewListFile();
                            }
                            else
                            {
                                Console.WriteLine("Operacja przerwana.");
                                r.Close();
                                goto End;   // pomiń dalsze instrukcje
                            }
                        }
                        do
                        {
                            string noteFile = line[..line.IndexOf('.')];    
                            string noteTitle = line[(line.IndexOf("*") + 3)..];
                            NotesList.Add(new Note(noteFile, noteTitle));
                            lineNr++;
                        }
                        while ((line = r.ReadLine()) != null);
                    }
                }
                else
                {
                    Console.WriteLine("******** Brak pliku listy.");
                    NewListFile();      // PROCEDURA TWORZENIA NOWEJ LISTY
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("******** Błąd pliku :");
                Console.WriteLine(e.Message);
                Console.WriteLine("******** Tworzę plik listy : {0}", listFile);
                this.SaveList();
                Console.ReadLine();
                goto Start;
            }
        End:;
        }
        public void NewListFile()
        {
            Console.WriteLine("1 - Pisz nową notatkę.   2 - Wczytaj notatkę z pliku.");
            // WYBÓR PROCEDURY
            char choice = Convert.ToChar(Console.ReadLine());
            Console.ReadLine();
            if (choice.Equals('1'))
            /*PROCEDURA 1*/
            {
                WriteNoteConsole();
            }
            else if (choice.Equals('2'))
            /*PROCEDURA 2*/
            {
                AddFileNote();
            }
        }
        public void AddNote(Note NoteToAdd) // dodanie obiektu nowej notatki z konsoli do obiektu listy (do listy w obiekcie ListOfNotes)
        {
            NoteToAdd.notePath ??= ListPath;  //if (NoteToAdd.notePath == null) { NoteToAdd.notePath = ListPath; }
            NotesList.Add(NoteToAdd);
            Console.WriteLine(">>>>>>>>> Notatka dodana <<<<<<<<<<");
            Console.ReadKey();
        }
        public void AddFileNote()   // wczytanie notatki z pliku txt podanego w konsoli
        {
            Console.WriteLine("Wpisz nazwę pliku : ");
            string noteTxtFile = Console.ReadLine();
            Note toAdd = new(noteTxtFile);
            AddNote(toAdd);
            SaveList();
        }
        public void SaveList()  // zapisuje listę do pliku txt
        {
            StreamWriter outputFile = new(Path.Combine(ListPath, listFile));
            for (int i=0; i < NotesList.Count; i++)
            {
                string line = NotesList[i].noteFile+ ".txt" + "***" + NotesList[i].NoteTitle();
                outputFile.WriteLine(line);
            }
            outputFile.Close();
        }
        public void RemoveNote(Note NoteToRemove) 
        {  NotesList.Remove(NoteToRemove);
            Console.WriteLine(">>>>>>>> Notatka usunięta z programu. Plik usuń ręcznie. <<<<<<<<<<<<<<");
            Console.WriteLine(">>>>> Press ENTER ... <<<<<<<<");
            Console.ReadKey();
            SaveList();
        }
        public void WriteNoteConsole()  //tworzenie - pisanie notatki z konsoli
        {
            Console.WriteLine("Podaj nr modułu :");
            string moduleNr = Console.ReadLine();
            Console.WriteLine("Podaj nr lekcji :");
            string lessonNr = Console.ReadLine();
            Console.WriteLine("Podaj tytuł notatki :");
            string newTitle = Console.ReadLine();
            Note newNote = new(moduleNr, lessonNr, newTitle); 
            Console.WriteLine("Wpisz treść notatki, aby zakończyć wpisz w nowej linii END .");
            newNote.SaveNote(Globals.path);     // ZAPIS kilku linii txt DO PLIKU
            this.AddNote(newNote);
            this.SaveList();        
        }
    }


         
}
