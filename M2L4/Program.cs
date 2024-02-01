namespace M2L4
{
    internal class Program
    {
        static void Main(string[] args)
        {
     //Moduł 2
        //Zadanie 1. Deklaracja zmiennych z danymi pracownika.
            string name, surname,pesel,id;
            byte age;
            char gender;
            Console.WriteLine("Zadanie 1. Deklaracja zmiennych z danymi pracownika:");
            Console.WriteLine("string name, surname;");
            Console.WriteLine("byte age;");
            Console.WriteLine("char gender;");
            Console.WriteLine("ulong pesel,id;");
            Console.WriteLine("\r\nNaciśnij enter by przejść do zadania 2");
            Console.ReadLine();

        //Zadanie 2. Zmienne z jedną literą w kolejności odwrotne.
            Console.WriteLine("Moduł 2, zadanie 2 - zmienne z jedną literą w kolejności odwrotnej");
            Console.WriteLine("char a='a', b='b', c='c';");
            Console.WriteLine("Console.WriteLine($\"{c} {b} {a}\");");
            char a ='a', b='b', c='c'; //a = 'a';  b = 'b'; c = 'c';  
            Console.WriteLine($"{c} {b} {a}");
                 
            Console.WriteLine("\r\nWciśnij enter aby przejść do Zadania 3.");
            Console.ReadLine();
        // Zadanie 3. Przekątna prostokąta.
            //double Math.Sqrt()  Math.Pow()
            double length, width;
            string lth, wth;
            Console.WriteLine("Moduł 2, zadanie 3.  Przekątna prostokąta.");
            Console.WriteLine("Podaj długość");
            lth=Console.ReadLine();
            Console.WriteLine("Podaj szerokość");
            wth = Console.ReadLine();
            Double.TryParse(lth, out length);
            Double.TryParse(wth, out width);
            Console.WriteLine($"Przekątna wynosi {Math.Sqrt(Math.Pow(length,2)+ Math.Pow(width,2))}");
            Console.WriteLine("\r\nWciśnij enter aby przejść do Zadania 4");
            Console.ReadLine();
            // Zadanie 4. Stwórz 2 zmienne liczbowe i 1 tekstową.
            Console.WriteLine("Moduł 2, zadanie 4. Stwórz 2 zmienne liczbowe i 1 tekstową.");
            byte byteNumZ4 = 10;
            string stringZ4 = "Szkoła Dotneta";
            float intNumZ4 = 12.5f;
            Console.WriteLine("byte byteNumZ4 = 10");
            Console.WriteLine("string stringZ4 = \"Szkoła Dotneta\";");
            Console.WriteLine("float intNumZ4 = 12.5f;");
        // Zadanie 5. Wprowadzanie danych pracownika.
            /*
               Console.WriteLine("Podaj długość");
               lth = Console.ReadLine();
            */
            Console.WriteLine("\r\nModuł 2, zadanie 5. Wprowadzanie danych pracownika.");
            string answer;
            Console.WriteLine("\r\nPodaj imię i wciśnij enter");
            name = Console.ReadLine();
            Console.WriteLine("\r\nPodaj nazwisko i wciśnij enter");
            surname = Console.ReadLine();
            Console.WriteLine("\r\nPodaj numer telefonu i wciśnij enter");
            string phoneNr = Console.ReadLine();
                                //uint.TryParse(answer, out uint phoneNr);
            Console.WriteLine("\r\nPodaj email i wciśnij enter");
            string email = Console.ReadLine();
            Console.WriteLine("\r\nPodaj wzrost w cm i wciśnij enter");
            answer = Console.ReadLine();
            byte.TryParse(answer, out byte height);
            Console.WriteLine("\r\nPodaj swoją wagę w kg i wciśnij enter");
            answer = Console.ReadLine() ;
            byte.TryParse(answer, out byte weight);

            Console.WriteLine("Dziękuję, to już koniec. Wciśnij enter.");
            Console.ReadLine() ;
           

        }
    }
}
