namespace M2L4
{
    internal class Program
    {
        static void Main(string[] args)
        {
     //Moduł 2
     //Zadanie 1 Deklaracja zmiennych z danymi pracownika
            string name, surname;
            byte age;
            char gender;
            ulong pesel,id;

     //Zadanie 2 
            char a, b, c;
            a = 'a';
            b = 'b';
            c = 'c';
            Console.WriteLine("Moduł 2, zadanie 2 - zmienne z jedną literą w kolejności odwrotnej");
            Console.WriteLine($"{c} {b} {a}");
            Console.WriteLine("\r\nWciśnij enter aby przejść do Zadania 3");
            Console.ReadLine();
     // Zadanie 3 Przekątna prostokąta
            //double Math.Sqrt()  Math.Pow()
            double length, width;
            string lth, wth;
            Console.WriteLine("Moduł 2, zadanie 3  Przekątna prostokąta");
            Console.WriteLine("Podaj długość");
            lth=Console.ReadLine();
            Console.WriteLine("Podaj szerokość");
            wth = Console.ReadLine();
            Double.TryParse(lth, out length);
            Double.TryParse(wth, out width);
            Console.WriteLine($"Przekątna wynosi {Math.Sqrt(Math.Pow(length,2)+ Math.Pow(width,2))}");
            Console.WriteLine("\r\nWciśnij enter aby przejść do Zadania 4");
            Console.ReadLine();
         // Zadanie 4 
            byte byteNumZ4 = 10;
            string stringZ4 = "Szkoła Dotneta";
            float intNumZ4 = 12.5f;
            // Zadanie 5
            /*
               Console.WriteLine("Podaj długość");
               lth = Console.ReadLine();
            */
            string answer;
            Console.WriteLine("\r\nPodaj imię");
            name = Console.ReadLine();
            Console.WriteLine("\r\nPodaj nazwisko");
            surname = Console.ReadLine();
            Console.WriteLine("\r\nPodaj numer telefonu");
            answer = Console.ReadLine();
            uint.TryParse(answer, out uint phoneNr);
            Console.WriteLine("\r\nPodaj email");
            string email = Console.ReadLine();
            Console.WriteLine("\r\nPodaj wzrost w cm");
            answer = Console.ReadLine();
            byte.TryParse(answer, out byte height);
            Console.WriteLine("\r\nPodaj swoją wagę w kg");
            answer = Console.ReadLine() ;
            byte.TryParse(answer, out byte weight);

            Console.WriteLine("Dziękuję, to już koniec. Wciśnij enter.");
            Console.ReadLine() ;
           

        }
    }
}
