using System.Numerics;
using System.Security.Cryptography;

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
                        uint x3 = 0,a3=0,b3=1,sum3;  // x3 - wprowadzana ilość liczb ; a3,b3 - sumowane liczby ciągu
                        i = 3;
                        Console.WriteLine("Ciąg Fibonacciego. Podaj ilość liczb ciągu :");
                        UInt32.TryParse(Console.ReadLine(), out x3);
                        Console.WriteLine(x3 + " pierwszych liczb Ciągu Fibonacciego : ");
                        Console.Write("0 ; 1 ; ");
                        do
                        {
                            sum3 = a3 + b3;
                            Console.Write(sum3+" ; ");
                            a3 = b3;    b3 = sum3;
                            i++;
                        }
                        while (i <= x3);

                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                        if (ex != 0) { Console.WriteLine($"\r\nZADANIE {ex}"); }

                        break;
                    case 4:     /* po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej
                                liczby w formie jak poniżej:
                                1
                                2 3
                                4 5 6
                                7 8 9 10
                                */
                        // x4 - podana liczba
                        // y4 - wyswietlana liczba
                        // column - liczba  kolumn 
                        uint row = 1,x4,y4=1,column=1,a4;
                        Console.WriteLine("Piramida z liczb. Podaj ostatnią liczbę :");
                        UInt32.TryParse(Console.ReadLine(), out x4);
                        Console.WriteLine("");
                        do
                        {
                            for (i=1;i<(column+1);i++)  // column+1 to nowa ilosc kolumn dla nastepnego wiersza
                            {
                                Console.Write(y4+" ");
                                y4++;
                            }
                            Console.WriteLine("");
                            column++;
                        }
                        while(y4 <= x4);

                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                        if (ex != 0) { Console.WriteLine($"\r\nZADANIE {ex}"); }
                        break;
                    case 5: /* dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.
                             * */
                        i = 1;
                        Console.WriteLine("Liczby 1 - 20 do potęgi 3 :");
                        do {
                            Console.WriteLine(i + ": " + Math.Pow(i,3));

                            i++;    
                        }
                        while (i <= 20);

                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                        if (ex != 0) { Console.WriteLine($"\r\nZADANIE {ex}"); }
                        break;
                    case 6:     /*dla liczb od 0 do 20 obliczy sumę wg wzoru:
                                1 + ½ +1 / 3 + ¼ itd.
                                1/1+...+1/n */
                        float sum6=0 , i6=0;
                        Console.Write("Częściowa suma szeregu harmonicznego - liczba harmoniczna H[20] = ");
                        do
                        {
                            sum6 = sum6 + (1 / (i6 + 1));
                                    //Console.Write("suma = "+sum6);
                            i6++;
                        }
                        while (i6 < 20);
                        Console.Write(sum6);

                       Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                        if (ex != 0) { Console.WriteLine($"\r\nZADANIE {ex}"); }
                        break;
                    case 7:

                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                        if (ex != 0) { Console.WriteLine($"\r\nZADANIE {ex}"); }
                        break;
                    case 8:

                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                        if (ex != 0) { Console.WriteLine($"\r\nZADANIE {ex}"); }
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
