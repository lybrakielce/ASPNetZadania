namespace M2L8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PROGRES (3/10)
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
                        //-------------------------------------------------------------------------
                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                        if (ex != 0) { Console.WriteLine($"\r\nZADANIE {ex}"); }
                        break;
                    case 2:     //za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z zakresu 0 – 1000
                        i = 0;
                        Console.WriteLine("Liczby parzyste z zakresu 0 - 1000 :");
                        do 
                        {
                            if (i % 2 == 0) Console.Write(i + " ; ");
                            i++;
                        }
                        while (i<=1000);

                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                        if (ex != 0) { Console.WriteLine($"\r\nZADANIE {ex}"); }
                        break;
                    case 3:     // CIĄG FIBONACCIEGO
                        uint x3 = 0,a3=0,b3=1,suma3;  // x3 - wprowadzana ilość liczb ; a3,b3 - sumowane liczby ciągu
                        i = 3;
                        Console.WriteLine("Ciąg Fibonacciego. Podaj ilość liczb ciągu :");
                        UInt32.TryParse(Console.ReadLine(), out x3);
                        Console.WriteLine(x3 + " pierwszych liczb Ciągu Fibonacciego : ");
                        Console.Write("0 ; 1 ; ");
                        do
                        {
                            suma3 = a3 + b3;
                            Console.Write(suma3+" ; ");
                            a3 = b3;    b3 = suma3;
                            i++;
                        }
                        while (i <= x3);

                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                        if (ex != 0) { Console.WriteLine($"\r\nZADANIE {ex}"); }

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 7:

                        break;
                    case 8:

                        break;
                    case 9:

                        break;
                    case 10:

                        break;
                    //EXIT gdy od razu wpisano 0
                    case 0:
                        break;
                }
            }
            Console.Write("\r\n KONIEC PROGRAMU. Do widzenia. Naciśnij Enter.");
            Console.ReadLine();
        }
    }
}
