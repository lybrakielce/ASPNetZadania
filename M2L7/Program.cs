﻿using System.Net;

namespace M2L7
{
    internal class Program
    {
        static void Main(string[] args)
        {                           // PROGRES (13/13)
                                    //Wybór zadania .
            uint ex = 1; // numer zadania zainicjowany jako 1 żeby 0 użyć do wyjścia 
            Console.WriteLine("\r\nWitaj w Module 2 Lekcja 7  ZADANIA\r\n Wpisz numer zadania lub 0 (zero) aby zakończyć: ");
            UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
            Console.WriteLine($" ZADANIE {ex} ");
            while (ex != 0)
            {
                //Realizacja kolejnych zadań w case.
                string answer;
                switch (ex)
                {
                    case 1: // czy równe - zmienne 'a' , 'b'
                        int a, b;
                        answer = "";
                        Console.WriteLine("Porównam 2 liczby całkowite czy są równe. Wpisz pierwszą liczbę :");
                        Int32.TryParse(Console.ReadLine(), out a);
                        //Console.WriteLine("Enter second number and press enter key :");
                        Console.WriteLine("Wpisz drugą liczbę :");
                        Int32.TryParse(Console.ReadLine(), out b);
                        Console.WriteLine("\r\nDziękuję.");
                        answer = a == b ? "równe" : "inne czyli nie równe";
                        Console.WriteLine($"{a} i {b} są {answer}.");
                        //-------------------------------------------------------------------------------------------------------------------
                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                        if (ex != 0) { if (ex != 0) { Console.WriteLine($"\r\nZADANIE {ex}"); } }

                        break;
                    case 2: // parzysta czy nieparzysta - zmienna 'x'
                        int x, y;
                        answer = "";
                        Console.WriteLine("Sprawdzanie czy liczba jest parzysta. \r\nWpisz liczbę :  ");

                        Int32.TryParse(Console.ReadLine(), out x);
                        y = x % 2;
                        // string answer = "";
                        answer = y == 0 ? "parzystą" : "nieparzystą";
                        Console.WriteLine($" {x} jest liczbą {answer}");
                        //-------------------------------------------------------------------------------------------------------------------
                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                        if (ex != 0) { Console.WriteLine($"\r\nZADANIE {ex}"); }

                        break;
                    case 3:            // dodatnia czy ujemna - zmienna 'z'
                        float z;
                        answer = "";
                        Console.WriteLine("Sprawdzanie czy liczba jest dodatnia czy ujemna. \r\nWpisz liczbę. Części dziesiętne oddziel przecinkiem :  ");
                        if (float.TryParse(Console.ReadLine(), out z))
                        {
                            answer = z switch { < 0 => "ujemną", 0 => "nieujemną", > 0 => "dodatnią", _ => "źle wpisaną" };
                            Console.WriteLine($" {z} jest liczbą {answer} ");
                        }
                        else Console.WriteLine(" Zły format liczby. ");
                        //-------------------------------------------------------------------------------------------------------------------

                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();

                        if (ex != 0) { Console.WriteLine($"\r\nZADANIE {ex}"); }

                        break;
                    case 4:  // czy rok przestępny zmienna 'year'

                        /*  1. Jeśli rok jest równomiernie podzielny przez 4, przejdź do kroku 2.Jeśli nie, przejdź do kroku 5.
                            2. Jeśli rok jest równomiernie podzielny przez 100, przejdź do kroku 3.Jeśli nie, przejdź do kroku 4.
                            3. Jeśli rok jest równomiernie podzielny przez 400, przejdź do kroku 4.Jeśli nie, przejdź do kroku 5.
                            4. Rok jest rokiem przestępnym(ma 366 dni).
                            5. Rok NIE jest rokiem przestępnym(ma 365 dni).
                        */
                        Console.WriteLine("Sprawdzanie czy rok jest przestępny. \r\nWpisz rok :  ");
                        short year;
                        answer = "";
                        if (short.TryParse(Console.ReadLine(), out year))
                        {   // krok 1
                            answer = year % 4 == 0 ? "" : "nie przestępnym";
                            //krok 2
                            if (answer == "")
                            {
                                answer = year % 100 == 0 ? "" : "przestępnym";
                            };
                            //krok 3
                            if (answer == "")
                            {   // krok 4 i 5
                                answer = year % 400 == 0 ? "przestępnym" : "nie przestępnym";
                            };
                            Console.WriteLine($" {year} jest rokiem {answer} ");
                        }
                        else Console.WriteLine(" Zły format roku  . ");
                        //-------------------------------------------------------------------------------------------------------------------     
                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();

                        if (ex != 0) { Console.WriteLine($"\r\nZADANIE {ex}"); }

                        break;
                    case 5:      //WIEK minimalny posła, senatora itd., zmienna 'age'
                        //poseł i premier 21 , senator 30 , prezydent 35
                        Console.WriteLine("Czy twój wiek pozwala na to by zostać posłem, premierem, senatorem lub prezydentem ? ");
                        Console.WriteLine("Sprawdź, wpisując poniżej swój wiek liczony w pełnych latach :  ");
                        byte age;
                        answer = "";
                        if (byte.TryParse(Console.ReadLine(), out age) && age > 0)
                        {
                            if (age < 21) answer = "Jeszcze jesteś za młody/młoda.";
                            if (age > 20 && age < 30) answer = "Możesz zostać posłem i premierem";
                            if (age > 29 && age < 35) answer = "Możesz zostać posłem, premierem i senatorem ";
                            if (age > 34) answer = "Możesz zostać posłem, premierem, senatorem a nawet prezydentem ";
                        }
                        else answer = "Wpisałeś niepoprawny wiek.";
                        Console.WriteLine($" {answer}");
                        //-------------------------------------------------------------------------------------------------------------------

                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();

                        if (ex != 0) { Console.WriteLine($"\r\nZADANIE {ex}"); }

                        break;
                    case 6:  // WZROST zmienna 'tall'
                             // <123 HOBBITA, 123-150 krasnolud, 151-160 Ork, 161-185 człowiek, 186-220 elf, 221+ olbrzym
                        float tall;
                        answer = "";
                        Console.WriteLine(" Podaj swój wzrost w cm a dowiesz się do której rasy Śródziemia należysz : ");
                        if (float.TryParse(Console.ReadLine(), out tall))
                        {
                            if (tall < 123) answer = "hobbitą";
                            if (tall >= 123 && tall <= 150) answer = "krasnoludem";
                            if (tall > 150 && tall <= 160) answer = "Orkiem";
                            if (tall > 160 && tall <= 185) answer = "człowiekiem";
                            if (tall > 185 && tall <= 220) answer = "elfem";
                            if (tall > 220) answer = "olbrzymem nie z tej bajki :D";
                        }
                        else answer = "Wpisałeś niepoprawny wzrost.";

                        Console.WriteLine($"Jesteś {answer}");

                        //-------------------------------------------------------------------------------------------------------------------
                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                        if (ex != 0) { Console.WriteLine($"\r\nZADANIE {ex}"); }

                        break;
                    case 7: // NAJWIĘKSZA Z 3 LICZB zmienna 'maxNr'  "79 jest największa z podanych"
                        int i = 1;
                        float readNr, maxNr = 0;
                        Console.WriteLine(" Wskazanie największej z 3ech liczb. Czyli MAX. ");
                        while (i < 4)
                        {
                            Console.WriteLine($"\r\n{i}. Podaj liczbę :");
                            if (float.TryParse(Console.ReadLine(), out readNr))
                            {
                                //i++;
                                if (i == 1) maxNr = readNr;
                                else maxNr = maxNr > readNr ? maxNr : readNr;
                                i++;
                            }
                            else { Console.WriteLine("Wpisałeś niepoprawną liczbę."); i = 10; }
                        };
                        if (i == 4) Console.WriteLine($"\r\n{maxNr} jest największa z podanych");
                        else Console.WriteLine($"Możesz zacząć od nowa.");

                        //-------------------------------------------------------------------------------------------------------------------
                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                        if (ex != 0) { Console.WriteLine($"\r\nZADANIE {ex}"); }

                        break;
                    case 8:     //kwalifikacja NA STUDIA, zmienna do każdego przedmiotu, do sum i do maksimum (z dwóch przedmiotów)
                        /* Wynik z Matury z matematyki powyżej 70
                            Wynik z fizyki powyżej 55
                            Wynik z chemii powyżej 45
                            Łączny wynik z 3 przedmiotów powyżej 180
                            Albo
                            Wynik z matematyki i jednego przedmiotu powyżej 150
                        maxFizChem =fiz>chem? fiz:chem
                        sum= mat+fiz+chem ; sum2 = mat + maxFizChem ;
                        answer = "NIE dopuszczony";
                       if ((mat>70 && fiz>55 && chem>45 && sum>180 ) || (sum2>150)) answer = "dopuszczony";
                        */
                        int mat, fiz, chem, sum, sum2, maxFizChem;
                        answer = "NIE dopuszczony";
                        Console.WriteLine(" Sprawdźmy czy wyniki maturalne kandydata pozwolą mu się dostać na studia. \r\nPodaj wynik z matematyki : ");
                        if (Int32.TryParse(Console.ReadLine(), out mat))
                        {
                            Console.WriteLine("Podaj wynik z FIZYKI :");
                            if (Int32.TryParse(Console.ReadLine(), out fiz))
                            {
                                Console.WriteLine("Podaj wynik z CHEMII :");
                                if (Int32.TryParse(Console.ReadLine(), out chem))
                                {
                                    maxFizChem = fiz > chem ? fiz : chem;
                                    sum = mat + fiz + chem;
                                    sum2 = mat + maxFizChem;
                                    if (((mat > 70 && fiz > 55 && chem > 45) && sum > 180) || (sum2 > 150)) answer = "dopuszczony";
                                    Console.WriteLine($"Kandydat {answer} do rekrutacji");
                                }
                                else Console.WriteLine("Wpisałeś niepoprawną liczbę.");
                            }
                            else Console.WriteLine("Wpisałeś niepoprawną liczbę.");
                        }
                        else Console.WriteLine("Wpisałeś niepoprawną liczbę.");
                        //-----------------------------------------------------------------------------------------------
                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                        if (ex != 0) { Console.WriteLine($"\r\nZADANIE {ex}"); }
                        break;
                    case 9:     // TEMPERATURA, zmienna 'temp'
                        /*Temp < 0 – cholernie piździ
                            Temp 0 – 10 – zimno
                            Temp 10 – 20 – chłodno
                            Temp 20 – 30 – w sam raz
                            Temp 30 – 40 – zaczyna być słabo, bo gorąco
                            Temp >= 40 – a weź wyprowadzam się na Alaskę.
                         */
                        float temp;
                        answer = "";
                        Console.WriteLine("Ile stopni wynosi dziś temperatura ? :");
                        if (float.TryParse(Console.ReadLine(), out temp))
                        {
                            if (temp < 0) answer = "cholernie piździ";
                            if (temp < 10 && temp >= 0) answer = "zimno";
                            if (temp < 20 && temp >= 10) answer = "chłodno";
                            if (temp < 30 && temp >= 20) answer = "w sam raz";
                            if (temp < 40 && temp >= 30) answer = "zaczyna być słabo, bo gorąco";
                            if (temp >= 40) answer = "a weź wyprowadzam się na Alaskę.";
                        }
                        else answer = "Coś poszło nie tak, może źle wpisałeś temperaturę.";
                        Console.WriteLine(answer);
                        //-----------------------------------------------------------------------------------------------------
                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                        if (ex != 0) { Console.WriteLine($"\r\nZADANIE {ex}"); };
                        break;
                    case 10: // BOKI TRÓjKĄTA, a10,b10, c10
                             // a<b+c ; b<a+c ; c<a+b ;
                        float a10, b10, c10;
                        answer = "";
                        Console.WriteLine("Czy trójkąt można zbudować z boków o dowolnej długości ? Sprawdźmy. Podaj długość pierwszego boku :");
                        if (float.TryParse(Console.ReadLine(), out a10))
                        {
                            if (a10 > 0)
                            {
                                Console.WriteLine("Podaj długość drugiego boku :");
                                if (float.TryParse(Console.ReadLine(), out b10))
                                {
                                    if (b10 > 0)
                                    {
                                        Console.WriteLine("Podaj długość trzeciego boku :");
                                        if (float.TryParse(Console.ReadLine(), out c10))
                                        {
                                            if (c10 > 0)
                                            {
                                                if (a10 < (b10 + c10) && b10 < (a10 + c10) && c10 < (a10 + b10)) answer = "Można zbudować trójkąt.";
                                                else answer = "NIE można zbudować trójkąta.";
                                            }
                                            else answer = "Długość musi być większa od 0.";
                                        }
                                        else answer = "Coś poszło nie tak, może źle wpisałeś długość.";
                                    }
                                    else answer = "Długość musi być większa od 0.";
                                }
                                else answer = "Coś poszło nie tak, może źle wpisałeś długość.";
                            }
                            else answer = "Długość musi być większa od 0.";

                        }
                        else answer = "Coś poszło nie tak, może źle wpisałeś długość.";
                        Console.WriteLine($"{answer}");

                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                        if (ex != 0) { Console.WriteLine($"\r\nZADANIE {ex}"); }
                        break;
                    case 11: // OCENA SŁOWNIE, zmienna 'grade'
                        byte grade;
                        answer = "";
                        Console.WriteLine("Zamiana oceny liczbowej na słowną. Podaj wartość liczbową oceny :");
                        if (byte.TryParse(Console.ReadLine(), out grade))
                        {
                            answer = grade switch
                            {
                                1 => "Niedostateczny",
                                2 => "Dopuszczający",
                                3 => "Dostateczny",
                                4 => "Dobry",
                                5 => "Bardzo dobry",
                                6 => "Celujący",
                                _ => "Zła wartość"
                            };
                        }
                        else answer = "Zła wartość";
                        Console.WriteLine($"{answer}");

                            Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                        if (ex != 0) { Console.WriteLine($"\r\nZADANIE {ex}"); }
                        break;
                    case 12: // DNI TYGODNIA LICZBA NA SŁOWO, zmienna day

                        byte day;
                        answer = "";
                        Console.WriteLine("Zamiana nr dnia tygodnia na nazwę dnia. Podaj nr dnia tygodnia :");
                        if (byte.TryParse(Console.ReadLine(), out day))
                        {
                            answer = day switch
                            {
                                1 => "Poniedziałek",
                                2 => "Wtorek",
                                3 => "Środa",
                                4 => "Czwartek",
                                5 => "Piątek",
                                6 => "Sobota",
                                7 => "Niedziela",
                                _ => "Zła wartość"
                            } ;
                        }
                        else answer = "Zła wartość";
                        Console.WriteLine(answer);

                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                        if (ex != 0) { Console.WriteLine($"\r\nZADANIE {ex}"); }
                        break;
                    case 13:    // PROSTY KALKULATOR , zmienne a13,b13,nr13,result
                        float a13, b13;
                        byte nr13;
                            answer = "";
                        Console.WriteLine(" Prosty kalkulator. ");
                        Console.WriteLine(" Podaj pierwszą liczbę :");
                        if (float.TryParse(Console.ReadLine(), out a13)) 
                        {
                            Console.WriteLine(" Podaj drugą liczbę :");
                            if (float.TryParse(Console.ReadLine(), out b13))
                            {
                                Console.WriteLine(" Podaj nr operacji do wykonania : \r\n 1. Dodawanie \r\n 2. Odejmowanie \r\n 3. Mnożenie \r\n 4. Dzielenie");
                                if (byte.TryParse(Console.ReadLine(), out nr13))
                                {
                                    answer = nr13 switch
                                    {
                                        1 => ("Twój wynik to " + (a13 + b13)).ToString(),
                                        2 => ("Twój wynik to " + (a13 - b13)).ToString(),
                                        3 => ("Twój wynik to " + (a13 * b13)).ToString(),
                                        4 => ("Twój wynik to " + (a13 / b13)).ToString(),
                                        _ => "Zły wybór operacji."
                                    };
                                }
                                else answer = "Niepoprawna wartość";
                            }
                            else answer = "Niepoprawna wartość";
                        }
                        else answer = "Niepoprawna wartość";
                        Console.WriteLine(answer);

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
