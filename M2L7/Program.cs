using System.Net;

namespace M2L7
{
    internal class Program
    {
        static void Main(string[] args)
        {                           // IN PROGRESS (6/13)
                                    //Wybór zadania .
            uint ex = 1;
            Console.WriteLine("\r\nWitaj w Module 2 Lekcja 7  ZADANIA\r\n Wpisz numer zadania lub 0 (zero) aby zakończyć: ");
            UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
            Console.WriteLine($" ZADANIE {ex} ");
          while (ex != 0) { 
                                    //Realizacja kolejnych zadań w case.
            switch (ex) 
            {
            case 1 : // czy równe - zmienne 'a' , 'b'
            int a, b;
            string check;
                        Console.WriteLine("Porównam 2 liczby całkowite czy są równe. Wpisz pierwszą liczbę :");
                        Int32.TryParse(Console.ReadLine(), out a);
                                            //Console.WriteLine("Enter second number and press enter key :");
                        Console.WriteLine("Wpisz drugą liczbę :");
                        Int32.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("\r\nDziękuję.");
            check = a == b ? "równe" : "inne czyli nie równe";
            Console.WriteLine($"{a} i {b} są {check}.");
                   //-------------------------------------------------------------------------------------------------------------------
                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear(); 
                        if (ex != 0) {  if (ex != 0) {   Console.WriteLine($"\r\nZADANIE {ex}"); } }
                                       
                        break;
            case 2: // parzysta czy nieparzysta - zmienna 'x'
                        int x,y;
                        Console.WriteLine("Sprawdzanie czy liczba jest parzysta. \r\nWpisz liczbę :  ");

                        Int32.TryParse(Console.ReadLine(), out x);
                        y = x%2;
                                                                                        // string answer = "";
                        string answer = y == 0 ? "parzystą" : "nieparzystą";
                                                                                        // Console.WriteLine($" Number {x} is {answer}");
                        Console.WriteLine($" {x} jest liczbą {answer}");
                 //-------------------------------------------------------------------------------------------------------------------
                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                       if (ex != 0) {   Console.WriteLine($"\r\nZADANIE {ex}"); }
                        
                        break;
             case 3:            // dodatnia czy ujemna - zmienna 'z'
                        float z ;
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
                                               
                       if (ex != 0) {   Console.WriteLine($"\r\nZADANIE {ex}"); }
                        
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
                            answer = year%4==0?"":"nie przestępnym";
                            //krok 2
                            if (answer == "") 
                            {  
                                answer = year % 100 == 0?"":"przestępnym";
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
                                               
                       if (ex != 0) {   Console.WriteLine($"\r\nZADANIE {ex}"); }
                        
                        break;
               case 5:      //WIEK minimalny posła, senatora itd., zmienna 'age'
                        //poseł i premier 21 , senator 30 , prezydent 35
                        Console.WriteLine("Czy twój wiek pozwala na to by zostać posłem, premierem, senatorem lub prezydentem ? ");
                        Console.WriteLine("Sprawdź, wpisując poniżej swój wiek liczony w pełnych latach :  ");
                        byte age;
                        answer = "";
                        if (byte.TryParse(Console.ReadLine(), out age)&&age>0)
                        {
                            if (age < 21) answer = "Jeszcze jesteś za młody/młoda.";
                            if (age > 20 &&age< 30) answer = "Możesz zostać posłem i premierem"; 
                            if (age >29&&age<35) answer = "Możesz zostać posłem, premierem i senatorem ";
                            if (age > 34) answer = "Możesz zostać posłem, premierem, senatorem a nawet prezydentem ";
                        }
                        else answer="Wpisałeś niepoprawny wiek.";
                        Console.WriteLine($" {answer}");
                        //-------------------------------------------------------------------------------------------------------------------
                        
                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                                               
                        if (ex != 0) {   Console.WriteLine($"\r\nZADANIE {ex}"); }
                        
                        break;
                case 6:  // WZROST zmienna 'tall'
                         // <123 HOBBITA, 123-150 krasnolud, 151-160 Ork, 161-185 człowiek, 186-220 elf, 221+ olbrzym
                        float tall;
                        answer = "";
                        Console.WriteLine(" Podaj swój wzrost w cm a dowiesz się do której rasy Śródziemia należysz : ");
                        if (float.TryParse(Console.ReadLine(), out tall))
                        {
                            if (tall < 123) answer = "hobbitą";
                            if (tall >= 123 && tall<=150) answer = "krasnoludem";
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
                       if (ex != 0) {   Console.WriteLine($"\r\nZADANIE {ex}"); }
                        
                        break;
                case 7: 
                        Console.WriteLine(" tekst ");

                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                       if (ex != 0) {   Console.WriteLine($"\r\nZADANIE {ex}"); }
                        
                        break;
                case 8:
                        
                        Console.WriteLine(" tekst ");

                                                    
                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                       if (ex != 0) {   Console.WriteLine($"\r\nZADANIE {ex}"); }
                        break;
                case 9:
                        Console.WriteLine(" tekst ");

                                                    
                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                                                   
                       if (ex != 0) {   Console.WriteLine($"\r\nZADANIE {ex}"); }
                        break;
                case 10:
                        
                        Console.WriteLine(" tekst ");

                                                    
                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                                                   
                       if (ex != 0) {   Console.WriteLine($"\r\nZADANIE {ex}"); }
                        break;
                case 11:
                        
                        Console.WriteLine(" tekst ");

                                                    
                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                                                   
                       if (ex != 0) {   Console.WriteLine($"\r\nZADANIE {ex}"); }
                        break;
                case 12:
                        
                        Console.WriteLine(" tekst ");

                                                    
                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                                                   
                       if (ex != 0) {   Console.WriteLine($"\r\nZADANIE {ex}"); }
                        break;
                case 13:
                        
                        Console.WriteLine(" tekst ");

                                                    
                        Console.WriteLine("\r\nWpisz numer następnego zadania lub 0 (zero) aby wyjść :");
                        UInt32.TryParse(Console.ReadLine(), out ex); Console.Clear();
                                                   
                       if (ex != 0) {   Console.WriteLine($"\r\nZADANIE {ex}"); }
                        break;
            //EXIT gdy od razu wpisano 0
                case 0:
                                                                // ex = 0;
                                                                 // Console.Write(" none. Good BYE,");
                    break;
                }

            }

            //Console.Write(" EXIT. Good BYE, press Enter.");
            Console.Write(" KONIEC PROGRAMU. Do widzenia. Naciśnij Enter.");
            Console.ReadLine();
        }
    }
    
}
