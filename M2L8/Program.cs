namespace M2L8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PROGRES (0/10)
            //Wybór zadania .
            uint ex = 1; // numer zadania zainicjowany jako 1 żeby 0 użyć do wyjścia 
            Console.WriteLine("\r\nWitaj w Module 2 Lekcja 8  ZADANIA dot. pętli. \r\n Wpisz numer zadania lub 0 (zero) aby zakończyć: ");
            UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
            Console.WriteLine($" ZADANIE {ex} ");
            while (ex != 0)
            {
                //Realizacja kolejnych zadań w case.
                string answer;
                switch (ex)
                {
                    case 1: // ile liczb pierwszych w zakresie 0-100
                        /*
                         * Najprostszą metodą aby zbadać czy liczba jest pierwsza  jest sprawdzenie jej dzielników.
                         * Aby zbadać liczbę n sprawdzamy kolejne liczby naturalne należące do 
                         * przedziału [2,..., √n]. Jeżeli okazało by się,że któraś z tych liczb jest dzielnikiem
                         * naszej liczby n, oznacza to, że nasza liczba nie jest pierwsza.
                         * */
                        //n = 100 , √n = 10
                        uint i,x1,ile=0;
                        bool dzielnik ;                     // 0 i 1 nie są pierwsze z definicji
                        for (x1 = 2; x1 <= 100; x1++)      // każda liczba 2-100 jest sprawdzana czy jest liczbą pierwszą
                        {
                            dzielnik = false;   // przed każdym szukaniem dzielników 
                            for (i = 2; i <= Math.Truncate(Math.Sqrt(x1)); i++)   //spr. każdej l. od 2 do √x1 czy jest dzielnikiem
                            {
                                    if (x1 % i == 0 && x1 / i > 1) dzielnik = true;    
                            }
                            ile = dzielnik ? ile:ile+1;
                        }
                        Console.WriteLine($"Liczb pierwszych w przedziale 0 -100 jest {ile}");
                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                        if (ex != 0) { Console.WriteLine($"\r\nZADANIE {ex}"); }
                        break;
                    //EXIT gdy od razu wpisano 0
                    case 0:
                        break;
                }
            }
            Console.Write(" KONIEC PROGRAMU. Do widzenia. Naciśnij Enter.");
            Console.ReadLine();
        }
    }
}
