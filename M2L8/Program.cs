using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Security.Cryptography;

namespace M2L8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PROGRES (9/10)
            //Wybór zadania .
            uint ex = 1; // numer zadania zainicjowany jako 1 żeby 0 użyć do wyjścia 
            Console.WriteLine("\r\nWitaj w Module 2 Lekcja 8  ZADANIA dot. pętli. \r\n Wpisz numer zadania lub 0 (zero) aby zakończyć: ");
            UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
            Console.WriteLine($" ZADANIE {ex} ");
            while (ex != 0)
            {
                //Realizacja kolejnych zadań w case.
                //string answer;
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
                        uint x4,y4=1,column4=1;
                        Console.WriteLine("Piramida z liczb. Podaj ostatnią liczbę :");
                        UInt32.TryParse(Console.ReadLine(), out x4);
                        Console.WriteLine("");
                        do
                        {
                            for (i=1;i<(column4+1);i++)  // column+1 to nowa ilosc kolumn dla nastepnego wiersza
                            {
                                Console.Write(y4+" ");
                                y4++;
                            }
                            Console.WriteLine("");
                            column4++;
                        }
                        while(y4 <= x4);

                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                        if (ex != 0) { Console.WriteLine($"\r\nZADANIE {ex}"); }
                        break;

                    case 5:      /* dla liczb od 1 do 20 wyświetli na ekranie ich 3 POTĘGĘ.
                                 */
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
                        /* diament o krótszej
                         przekątnej o długości wprowadzonej przez użytkownika
                         */
                        int x7,row7=1;
                        int spaces7;
                        Console.WriteLine("Diament. Podaj długość krótszej przekątnej :");
                        Int32.TryParse(Console.ReadLine(), out x7);
                        x7 = Math.Abs(x7);
                        Console.WriteLine("");
                        // Dla nieparzystej dlugosci przekatnej 'x7'
                        // tyle samo wierszy ('row7') i kolumn ('column7')
                        // spaces7 - ilość spacji do wpisania w wierszu
                        spaces7=(x7 - 1) / 2; 
                        do
                        {
                            if (spaces7 != 0)
                            {
                                for (i = 1; i <= Math.Abs(spaces7); i++)
                                { 
                                    Console.Write(" ");
                                }
                            }

                            for (i = 1; i <= ( x7 - (Math.Abs(spaces7) * 2) ); i++)
                            {
                                Console.Write("*");
                            }
                                spaces7--;

                            Console.WriteLine("");
                            row7++;                          
                        }
                        while (row7 <= x7);

                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                        if (ex != 0) { Console.WriteLine($"\r\nZADANIE {ex}"); }
                        break;
                    case 8: /*odwróci wprowadzony przez użytkownika ciąg znaków. Np.
                                Testowe dane:
                                Abcdefg
                                Rezultat
                                Gfedcba
                             * */
                        Console.WriteLine("\r\nWpisz ciąg znaków do odwrócenia :");
                       string read8= Console.ReadLine();
                       int i8 ;
                        Console.WriteLine($"WYNIK : ");
                        for (i8 = read8.Length-1; i8>=0; i8--)
                        {
                            Console.Write(read8[i8]);
                            //string answer = ""+read8[i8-1];
                        }

                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                        if (ex != 0) { Console.WriteLine($"\r\nZADANIE {ex}"); }
                        break;
                    case 9:     //program, który zamieni liczbę dziesiętną na liczbę binarną.
                                // tylko CAŁKOWITE dodatnie (naturalne)
                        uint x9;
                        Console.WriteLine("Podaj liczbę naturalną do konwersji na system binarny : ");
                        uint.TryParse(Console.ReadLine(), out x9);
                        uint remainder9,decimalNr=x9;
                        string binaryNr="";
                        while (x9>0) {
                           
                            remainder9 = x9 % 2;
                            binaryNr = remainder9 + binaryNr;
                            x9 /= 2;
                        }

                        Console.WriteLine($"Zapis binarny liczby {decimalNr} to : {binaryNr} ");

                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                        if (ex != 0) { Console.WriteLine($"\r\nZADANIE {ex}"); }
                        break;
                    case 10:    // program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.
                                // NWW dotyczy liczb naturalnych
                        /*   NWD :
                            1.Wprowadź wartość zmiennej a.
                            2.Wprowadź wartość zmiennej b.
                            3.Zmiennej r przypisz wartość reszty z dzielnie a przez b (operacja -> r=a%b).
                            4.Jeżeli r=0 przejdź do punktu 5, w przeciwnym wypadku przejdź do punktu 7.
                            5.Wyprowadź wynik - zmienna b.
                            6.Zakończ program.
                            7.Zmiennej a przypisz wartość zmiennej b (operacja -> a=b)
                            8.Zmiennej b przypisz wartość zmiennej r (operacja -> b=r)
                            9.Przejdź do punktu 3.
                             NWW = a*b/NWD
                         * */
                        uint a10, b10, remainder10, nww;
                        Console.WriteLine("NWW - najmniejsza wspólna wielokrotność dla zadanych 2 liczb");
                        Console.WriteLine("Wprowadż pierwszą liczbę :");
                        uint.TryParse(Console.ReadLine(), out a10);
                        Console.WriteLine("Wprowadż drugą liczbę :");
                        uint.TryParse(Console.ReadLine(), out b10);
                         nww = a10 * b10;
                        do
                        {
                            remainder10 = a10 % b10;
                            if (remainder10 != 0)
                            { 
                            a10 = b10;
                            b10 = remainder10;
                            }
                        }
                        while (remainder10 != 0);
                        nww = nww / b10;
                        Console.WriteLine($"\r\n NWW = {nww}");
                            Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                        if (ex != 0) { Console.WriteLine($"\r\nZADANIE {ex}"); }
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
