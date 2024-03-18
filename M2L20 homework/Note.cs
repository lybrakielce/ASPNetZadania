using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2L20_homework
{
    internal class Note
    {
        //string id;    MOŻE USUNĄC POLA module i lesson ????????? 
        string module;
        string lesson;
        string title;
        public string notePath;
        public string noteFile;     // nazwa bez rozszerzenia

        public string NoteTitle() 
        {
            return title;
        }

        public Note(string fileName, string titleGiven)  // tworzenie obiektu nowej notatki z KONSOLI dla listy
        {
            module = fileName[1..fileName.IndexOf('L')];    // module = fileName.Substring(1, fileName.IndexOf('L')-1);  
            lesson = fileName[(fileName.IndexOf('L') + 1)..];
            title = titleGiven;
            noteFile = fileName;        // bez rozszerzenia .txt
 /*TEST konstruktor Note 2PAR*/
            //Console.WriteLine($"TEST konstruktor Note 2 PAR. noteFile = {noteFile}");
            notePath = Globals.path;
        }
        

        public Note(string mod,string less, string consoleTitle)  // obiekt z konsoli  
        {
            module = mod;  
            lesson = less; 
            title = consoleTitle;
            noteFile = "M" + mod + "L" + less;
  /*TEST konstruktor Note 3 PAR*/
           // Console.WriteLine($"TEST konstruktor Note 3 PAR fileName = {noteFile}");
          
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
 
            /* TEST kontruktor Note */
           // Console.WriteLine($"TEST kontruktor Note  title = {title}");
            r.Close();
            noteFile = file[0..file.IndexOf('.')];        // bez rozszerzenia .txt
/*TEST konstruktor Note 1 PAR*/
           // Console.WriteLine($"TEST konstruktor Note 1 PAR fileName = {noteFile}");
            notePath = Globals.path;
        }
            public void SaveNote(string path)   // z konsoli do pliku txt
        {
            string readConsole;
            noteFile = "M" + module + "L" + lesson + ".txt";
            notePath = path; // zapis w obiekcie ścieżki do pliku txt
            Console.Write($"Zapis pliku {noteFile} do folderu : ");
            //Console.Read();
            Console.WriteLine($"{notePath}");
            Console.WriteLine("Treść :");
            string textCheck;
            StreamWriter outputFile = new(Path.Combine(path, noteFile));   //StreamWriter outputFile = new StreamWriter(Path.Combine(path, noteFile));
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
                    Console.WriteLine($"Notatka została zapisana w pliku : {notePath}{noteFile}");
                    Console.ReadKey();
                    break;
                }
            }
            
        }      

        public void ViewNoteTxt()   // wyswietla w konsoli notatke z pliku txt na zlecenie ListOfNotes.ViewNote
        {
            int count = 0;
            //Console.WriteLine($"TEST ViewNoteTxt notePath = {notePath}");
           // Console.WriteLine($"TEST ViewNoteTxt noteFile = {noteFile}");
            //using (StreamReader r = new(notePath+noteFile+".txt"))
            try
            {
                using (StreamReader r = File.OpenText(notePath + noteFile+".txt"))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
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
                // Console.WriteLine("Tworzę plik {0}", listFile);
               // this.SaveList();
                // goto Start;
            }

        }
    }
}
/*public void SetModule (string modNr)
        {
            if (module!=null)
            {
                module += modNr;
            }
            else { Console.WriteLine("Notatka już ma tytuł"); }
        }*/
/*public void SetLesson(string lessonNr)
{
    if (lesson != null)
    {
        lesson += lessonNr;
    }
    else { Console.WriteLine("Notatka już ma tytuł"); }
}*/

//  using (StreamReader r = File.OpenText(pathAndFile))
// Console.WriteLine("Podaj nr modułu");
// int.TryParse(Console.ReadLine(), out int chosenSubject);
// StreamReader r = new StreamReader(filename)
// StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt"))
// r.ReadLine()
// outputFile.WriteLine(line);
//----------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------
/*  WCZYTANIE PLIKU
 ---------------------------------------------------
   {
        string path = @"c:\temp\MyTest.txt";

        if (!File.Exists(path))
        {
            // Create the file.
            using (FileStream fs = File.Create(path))
            {
                Byte[] info =
                    new UTF8Encoding(true).GetBytes("This is some text in the file.");

                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }

        // Open the stream and read it back.
        using (StreamReader sr = File.OpenText(path))
        {
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
 --------------------------------------
 static long CountLinesInFile(string f)
{
long count = 0;
using (StreamReader r = new StreamReader(f))
{
    string line;
    while ((line = r.ReadLine()) != null)
    {
    count++;
    }
}
return count;
}
--------------------------------------------------------------------
-------------------------------------------------------------------
    ZAPIS DO PLIKU
----------------------
// Create a string array with the lines of text
        string[] lines = { "First line", "Second line", "Third line" };

        // Set a variable to the Documents path.
        string docPath =
          Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        // Write the string array to a new file named "WriteLines.txt".
        using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt")))
        {
            foreach (string line in lines)
                outputFile.WriteLine(line);
        }
 */
