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
    internal class ListOfNotes      // in progress - wczytać z pliku lub utworzyć plik ListOFNotes.txt
    {   // nr porzadkowy, nazwa pliku, tytuł lekcji/notatki
        // ZAINICJOWAĆ TWORZENIE OBIEKTÓW NOTE I WSTAWIĆ JE DO LISTY 
        // format tekstu w ListOfNotes.txt : MxLy***Tytuł_lekcji
        public string ListPath { get; }
        private readonly string listFile;
        private readonly string pathAndFile;

        private List<Note> NotesList { get; }
        public ListOfNotes(string path, string file)    // obiekt listy powstaje z pliku txt
        {   ListPath = path;
            listFile = file;    // nazwa pełna z rozszerzeniem .txt
            pathAndFile = path + file;           
            NotesList = [];   //pusta lista ; NotesList = new List<Note>();
            // wczytaj z pliku :
            ReadFile();     // wypełnia listę obiektami na podstawie pliku txt
        }
        public List<Note> ViewListOfNotes()     // wyswietla tytuly notatek na liscie
        {
            int i;
            for (i = 1; i <= NotesList.Count;i++)
            {
 /*TEST */              // Console.WriteLine($"TEST ViewListOfNotes NotesList.Count = {NotesList.Count}");
                //Console.WriteLine($"TEST ViewListOfNotes i = {i}");
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
        public void ReadFile()  // wczytanie pliku txt listy i wpisanie danych do obiektów listy
        {
        Start:
            try
            {
                    /* TEST ReadFile *///Console.WriteLine("TEST OBIEKT LISTY***** pathAndFile = {0}", pathAndFile);
                if(File.Exists(pathAndFile))
                {
                    using (StreamReader r = File.OpenText(pathAndFile)) //using (StreamReader r = new(listFile))     //StreamReader r = new StreamReader(listFile);
                    {                                    // PĘTLA DO NAPOTKANIA eof
                        string line = "";
                        int lineNr = 1;
                        line = r.ReadLine();
                        /* TEST ReadFile*/
                        //Console.WriteLine("TEST OBIEKT LISTY****** wczytywanie linii nr {1} line : {0}", line, lineNr);
                        if (line == null)           // spr. czy pierwsza linia jest pusta (pusty plik)
                        {
                            // uzupełnianie pustego pliku listy txt zaczynając od tworzenia nowej notatki
                            // obiekt notatki 
                            // zapis pliku notatki 
                            // wpis do obiektu listy
                            // zapis pliku txt listy (czy bedzie zonk jeżeli plik już istnieje ??????????????? )
                            // 2 metody dla nowej notatki : jedna z konsoli , druga z pliku txt
                            Console.WriteLine("Plik listy pusty. Czy chcesz utworzyć listę ? T/N");
                            char choice = Convert.ToChar(Console.ReadLine());
                            /* test 1  */ //Console.WriteLine("TEST 1 choice readLine = {0}", choice);
                            choice = char.ToUpper(choice);
                            if (choice.Equals('T'))
                            {
                                // TWORZENIE LISTY
                                //Console.WriteLine("TEST 2 choice readLine = {0}", choice);
                                Console.WriteLine("1 - Pisz nową notatkę.   2 - Wczytaj notatkę z pliku.");
                                // WYBÓR PROCEDURY
                                choice = Convert.ToChar(Console.ReadLine());
                                /* test 2*/                // Console.WriteLine ("TEST 2 choice readLine = {0}",choice);
                                Console.ReadLine();

                                if (choice.Equals('1'))
                                /*PROCEDURA 1*/
                                {
                                    WriteNoteConsole();
                                }
                                else if (choice.Equals('2'))
                                /*PROCEDURA 2*/
                                {
                                    /* notatka z pliku */
                                    /*TEST */
                                   // Console.WriteLine("TEST ReadFile URUCHAMIAM AddFileNote");
                                    AddFileNote();
                                    // NAZWA pliku
                                    // tytuł notatki w pierwszej linii pliku notatki
                                    // spr czy plik istnieje i czy nie jest pusty, ewentualnie wtedy zapytać czy pisać nową i powrót do choice 1
                                    // jeśli plik jest ok to zrób nowy obiekt Note(filename,title)
                                    // dodać obiekt typu Note do obiektu typu ListOfNotes
                                    // zapisać plik txt listy
                                }
                                //{ WriteListFile(this); }    
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
                            /* TEST 3*/          //Console.WriteLine("TEST 3 do while - wyciąga nazwę pliku notatki");
                                                 // wyciąga nazwę pliku notatki bez rozszerzenia .txt (potrzebne do pól Note)
                            string noteFile = line[..line.IndexOf('.')];    //string noteFile = line.Substring(0, line.IndexOf("*"));
                                                                            // Console.WriteLine("TEST 3 noteFile = {0}",noteFile);                                       // wyciąga tytuł notatki z pliku txt :
                            string noteTitle = line[(line.IndexOf("*") + 3)..];
                            //Console.WriteLine("TEST 3 noteTitle = {0}", noteTitle);
                            // Console.WriteLine("TEST 3 lineNr = {0}", lineNr);
                            // nowy obiekt Note
                            // wstawic bezimienne nowe obiekty do List ???
                            NotesList.Add(new Note(noteFile, noteTitle));
                            lineNr++;
                            // Console.WriteLine("TEST 3 lineNr++ = {0}", lineNr);
                        }
                        while ((line = r.ReadLine()) != null);

                    }
                }
                else
                {

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Błąd pliku :");
                Console.WriteLine(e.Message);
                Console.WriteLine("Tworzę plik listy : {0}", listFile);
                this.SaveList();
/* TEST 4*/ //Console.WriteLine("*****TEST_4 ZA SAVELIST");
                Console.ReadLine();
                goto Start;
            }
        End:;
        }
   
        public void AddNote(Note NoteToAdd) // dodanie obiektu nowej notatki z konsoli do obiektu listy (do listy w obiekcie ListOfNotes)
        {
/*TEST A */
           // Console.WriteLine("***TEST A ***ListOfNotes.AddNote*** ");
           // Console.WriteLine("TEST A NoteToAdd.notePath = {0} ", NoteToAdd.notePath);
           // Console.WriteLine("TEST A  ListPath = {0} ", ListPath);
            NoteToAdd.notePath ??= ListPath;  //if (NoteToAdd.notePath == null) { NoteToAdd.notePath = ListPath; }
            NotesList.Add(NoteToAdd);
            //Console.WriteLine("TEST A ZA NotesList.Add ");
            // początkowe założenia :
            // dodajemy notatke pobraną z ekranu , zapisaną do obiektu Note
            // treść notatki tylko w pliku txt
            //NotesList.Sort();
           // Console.WriteLine("TEST A ZA NotesList.Sort ");
            //Trzeba jakoś zrobić podział na notatki z konkretnych modułów, może oddzielne listy ???????????????????
        }
        //------------------------------------------------------------------------------------------------
        public void AddFileNote() // wczytanie notatki z pliku txt podanego w konsoli
        {
            Console.WriteLine("Wpisz nazwę pliku : ");
            string noteTxtFile = Console.ReadLine();
  /*TEST*/ // Console.WriteLine("TEST AddFileNote wczytany noteFile = ", noteTxtFile);
            // nowy obiekt note
            Note toAdd = new(noteTxtFile);
            //noteFile = noteFile[0..noteFile.IndexOf('.')];
            
            // wpisac note do obiektu listy 
  /*TEST*/     //    Console.WriteLine("TEST AddFileNote okrojony noteFile = ", noteTxtFile);
            AddNote(toAdd);
           // Console.WriteLine("TEST AddFileNote ZA AddNote");
            // wpisac pozycje do pliku txt listy - zapisac obiekt listy do pliku
            SaveList();
           // Console.WriteLine("TEST AddFileNote ZA SaveList");
        }

        public void SaveList()  // zapisuje listę do pliku txt
        {
            StreamWriter outputFile = new(Path.Combine(ListPath, listFile));
            for (int i=0; i < NotesList.Count; i++)
            {
                string line = NotesList[i].noteFile+ ".txt" + "***" + NotesList[i].NoteTitle();
                outputFile.WriteLine(line);
 /*TEST 5*/             //  Console.WriteLine("******TEST5 SaveList WPISANO line DO {0}{1}", ListPath,listFile);
              //  Console.WriteLine("****** line = {0}", line);
            }
            outputFile.Close();
        }
        public void RemoveNote(Note NoteToRemove) 
        {  NotesList.Remove(NoteToRemove);
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
            // ZAPIS kilku linii txt DO PLIKU
            newNote.SaveNote(Globals.path);
            //ZROBIONE: DODANIE nowej notatki DO LISTY notatek i zapisanie listy w PLIKU
            this.AddNote(newNote);
            this.SaveList();        // czy wpisuje *** ?
        }

    }


         
}
