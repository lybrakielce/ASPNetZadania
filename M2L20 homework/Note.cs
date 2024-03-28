using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2L20_homework
{
    internal class Note : IComparable<Note>
    {
        string module;
        string lesson;
        string title;
        public string notePath;
        public string noteFile;     // nazwa bez rozszerzenia
        public int CompareTo(Note note_)        // metoda niezbedna do sortowania, wskazuje że ma sortować wg noteFile

        {
            return this.noteFile.CompareTo(note_.noteFile);
        }
        public string NoteTitle() 
        {
            return title;
        }
        public Note(string fileName, string titleGiven)  // tworzenie obiektu nowej notatki z KONSOLI dla listy
        {
            module = fileName[1..fileName.IndexOf('L')];    
            lesson = fileName[(fileName.IndexOf('L') + 1)..];
            title = titleGiven;
            noteFile = fileName;        // bez rozszerzenia .txt
            notePath = Globals.path;
        }
        public Note(string mod,string less, string consoleTitle)  // obiekt z konsoli  
        {
            module = mod;  
            lesson = less; 
            title = consoleTitle;
            noteFile = "M" + mod + "L" + less;
            notePath = Globals.path;
        }
        public Note(string file)  // obiekt z pliku txt  
        {
            module = file[(file.IndexOf('M')+1) ..];    // module = fileName.Substring(1, fileName.IndexOf('L')-1);  
            module = module[0..module.IndexOf('L')];
            lesson = file[(file.IndexOf('L') + 1) ..];
            lesson = lesson[0..lesson.IndexOf('.')];
            string pathAndFile = Globals.path + file;
            StreamReader r = File.OpenText(pathAndFile);
            title = r.ReadLine();
            r.Close();
            noteFile = file[0..file.IndexOf('.')];        // bez rozszerzenia .txt
            notePath = Globals.path;
        }
        public void SaveNote(string path)   // z konsoli do pliku txt
        {
            string readConsole;
            noteFile = "M" + module + "L" + lesson ;
            notePath = path; // zapis w obiekcie ścieżki do pliku txt
            Console.Write($"Zapis pliku {noteFile}.txt do folderu : ");
            Console.WriteLine($"{notePath}");
            Console.WriteLine("Treść :");
            string textCheck;
            StreamWriter outputFile = new(Path.Combine(path, noteFile+".txt"));   //StreamWriter outputFile = new StreamWriter(Path.Combine(path, noteFile));
            while (true)
            {
                readConsole = Console.ReadLine();
                textCheck = readConsole.ToUpper();
                if (textCheck.Trim() != "END") 
                {
                    outputFile.WriteLine(readConsole);  // zapis notatki w pliku
                   }    
                else
                {
                    outputFile.Close();
                    Console.WriteLine($"Notatka została zapisana w pliku : {notePath}{noteFile}.txt");
                    Console.ReadKey();
                    break;
                }
            }
            
        }      
        public void ViewNoteTxt()   // wyswietla w konsoli notatke z pliku txt na zlecenie ListOfNotes.ViewNote
        {
            int count = 0;
            try
            {
                using (StreamReader r = File.OpenText(notePath + noteFile+".txt"))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        count++;
                        if (count == 10)    // pauza co 10 linii
                        {
                            Console.ReadLine();
                            count = 0;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("*** Błąd pliku Note :");
                Console.WriteLine(e.Message);
            }

        }
    }
}
