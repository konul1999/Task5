#region Task1
//using System;

//namespace Task5
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            while (true)
//            {
//                Console.OutputEncoding = System.Text.Encoding.Unicode;

//                Console.WriteLine("4 reqemli eded daxil et");
//                string input = Console.ReadLine();

//                if (input.Length == 4 && int.TryParse(input, out int result))
//                {
//                    int sum = 0;

//                    for (int i = 0; i < input.Length; i++)
//                    {
//                        int reqem = int.Parse(input[i].ToString());
//                        sum += reqem;
//                    }

//                    Console.WriteLine($"Reqemlerin cemi: {sum}");
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Duzgun 4 reqemli eded daxil edin");
//                }
//            }
//        }
//    }
//}
#endregion


#region Task2
//using System;
//using System.Text;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Console.OutputEncoding = Encoding.Unicode;

//        while (true)
//        {
//            Console.WriteLine("6 reqemli eded daxil et");
//            string input = Console.ReadLine();

//            if (input.Length == 6)
//            {
//                int sum = 0;

//                for (int i = 0; i < 3; i++)
//                {
//                    sum += int.Parse(input[i].ToString());
//                }

//                Console.WriteLine($"Ilk 3 reqemin cemi: {sum}");
//                break; 
//            }
//            else
//            {
//                Console.WriteLine("Duzgun 6 reqemi eded daxil edin");
//            }
//        }
//    }
//}
#endregion


#region Task 3
//using System;
//using System.Text;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Console.OutputEncoding = Encoding.Unicode;

//        while (true)
//        {
//            Console.WriteLine("9 reqemli eded daxil et");
//            string input = Console.ReadLine();

//            if (input.Length == 9)
//            {
//                int cem = 0;
//                for (int i = 3; i < 6; i++)
//                {
//                    int eded = int.Parse(input[i].ToString());
//                    cem += eded;
//                }

//                Console.WriteLine("Tapilan 3 reqeminin cemi: " + cem);
//                break; 
//            }
//            else
//            {
//                Console.WriteLine("Daxil etdiyiniz eded 9 reqemli deyil");
//            }
//        }
//    }
//}
#endregion


#region Task 4
//using System;
//using System.Text;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Console.OutputEncoding = Encoding.Unicode;

//       l4:

//        Console.WriteLine("5 reqemli eded daxil et");
//        string input = Console.ReadLine();

//        if (input.Length == 5 && int.TryParse(input, out int sayi))
//        {
//            int ilkreqem = sayi / 10000;
//            int sonreqem = sayi % 10;
//            int cem = ilkreqem + sonreqem;
//            int kvadrati = cem * cem;

//            Console.WriteLine($"Ilk ve son reqemlerin cemi: {cem}");
//            Console.WriteLine($"Cemin kvadrati: {kvadrati}");
//        }
//        else
//        {
//            Console.WriteLine("Duzgun 5 reqemli eded daxil edin");
//            goto l4;
//        }
//    }
//}
#endregion


#region Task5
//using System;
//using System.Text;
//internal class program
//{
//    static void Main(string[] args)
//    {
//        Console.OutputEncoding = Encoding.Unicode;
//        Console.WriteLine("6 reqemli eded yaz");
//        string input = Console.ReadLine();

//        if (input.Length == 6)
//        {
//            int birincireqem = int.Parse(input[0].ToString());
//            string yenieded = input + birincireqem;
//            Console.WriteLine($"Ədədin 1-ci rəqəmi axıra əlavə edilmişdir: {yenieded}");
//        }
//        else
//        {
//            Console.WriteLine("Daxil etdiyiniz ədəd 6 rəqəmli deyil");
//        }

//    }
//}
#endregion


#region task6
//using System;

//class Program
//{
//    static void Main()
//    {
//        int number = 12345678;
//        Console.WriteLine(number);

//        number = number / 10;
//        int firstDigit = number / 1000000;
//        number = number - (firstDigit * 1000000);

//        Console.WriteLine(number);  
//    }
//}
#endregion


#region Task7
//using System;

//class Program
//{
//    static void Main()
//    {
//        l7:
//        Console.WriteLine("4 reqemli eded daxil edin:");


//        int eded = int.Parse(Console.ReadLine());


//        if (eded >= 1000 && eded <= 9999)
//        {

//            int terseded = 0;
//            int ededler = eded;


//            while (eded > 0)
//            {

//                int soneded = eded % 10;

//                terseded = terseded * 10 + soneded;

//                eded = eded / 10;
//            }

//            int yenieded = terseded * 10 + 8;
//            yenieded = yenieded * 10 + 8;



//            Console.WriteLine("Eded: " + ededler);
//            Console.WriteLine("Tersine Çevrilmiş ve evveline-sonuna 8 yazilmis eded: " + yenieded);
//        }
//        else
//        {
//            Console.WriteLine("Daxil etdiyiniz ədəd 4 rəqəmli deyil");
//            goto l7;
//        }
//    }
//}
#endregion


#region Task8
//using System;

//class Program
//{
//    static void Main()
//    {
//        int eded;
//        int axirdanUcuncuReqem;
//        int sonuncuReqem;
//        int cem;

//        l7:

//        Console.WriteLine("Bir 4 reqemli eded daxil edin:");
//        string input = Console.ReadLine();

//        if (input.Length == 4 && int.TryParse(input, out eded))
//        {
//            axirdanUcuncuReqem = (eded / 100) % 10;
//            sonuncuReqem = eded % 10;

//            cem = axirdanUcuncuReqem + sonuncuReqem;

//            if (cem == 4)
//            {
//                Console.WriteLine($"Axirdan 3-cü ve sonuncu reqemin cemi: {cem}");
//            }
//            else
//            {
//                Console.WriteLine($"Axirdan 3-cü ve sonuncu reqemin cemi: {axirdanUcuncuReqem} + {sonuncuReqem} = {cem}.");
//                goto l7;
//            }
//        }
//        else
//        {
//            Console.WriteLine("Daxil etdiyiniz eded 4 reqemli deyil ve ya duzgun formatda deyil.");
//            Console.WriteLine("Yeniden eded daxil edin:");
//            goto l7;
//        }
//    }
//}
#endregion


#region Task12
//        using System;

//class Program
//{
//    static void Main()
//    {
//          l12:

//        Console.WriteLine("Birinci ededi daxil edin:");
//        int eded1 = int.Parse(Console.ReadLine());

//        Console.WriteLine("Ikinci ededi daxil edin:");
//        int eded2 = int.Parse(Console.ReadLine());

//        int cem = 0;
//        int Eded1 = eded1;
//        while (Eded1 > 0)
//        {
//            int reqem = Eded1 % 10;
//            cem += reqem;
//            Eded1 /= 10;
//        }

//        int hasil = 1;
//        int Eded2 = eded2;
//        while (Eded2 > 0)
//        {
//            int reqem = Eded2 % 10;
//            hasil *= reqem;
//            Eded2 /= 10;
//        }

//        cem += eded1 % 10;

//        int sonReqem = eded1 % 10;
//        int netice = cem + hasil + sonReqem;

//        Console.WriteLine($"Neticenin axirina birinci ededin en axiinci reqemini artir: {netice}");

//        goto l12;
//    }
//}
#endregion

#region Task13
//using System;

//class Program
//{
//    static void Main()
//    {
//          l13:

//        Console.WriteLine("birinci 5 reqemli ededi daxil et:");
//        int say1 = 0;
//        if (int.TryParse(Console.ReadLine(), out say1) && say1 >= 10000 && say1 <= 99999)
//        {
//            Console.WriteLine("ikinci 5 reqemli ededi daxil et:");
//            int say2 = 0;
//            if (int.TryParse(Console.ReadLine(), out say2) && say2 >= 10000 && say2 <= 99999)
//            {
//                Console.WriteLine("ucuncu 5 reqemli ededi daxil et:");
//                int say3 = 0;
//                if (int.TryParse(Console.ReadLine(), out say3) && say3 >= 10000 && say3 <= 99999)
//                {

//                    int ilkSonReqemler1 = (say1 / 10000) + (say1 % 10);
//                    int ilkSonReqemler2 = (say2 / 10000) + (say2 % 10);
//                    int ilkSonReqemler3 = (say3 / 10000) + (say3 % 10);

//                    int cem = ilkSonReqemler1 + ilkSonReqemler2 + ilkSonReqemler3;

//                    int netice1 = say1 + cem/ 2;
//                    int netice2 = say2 + cem / 2;
//                    int netice3 = say3 + cem / 2;

//                    Console.WriteLine("Ilk ve son reqemlerin cemi:" + cem);
//                    Console.WriteLine("netice1: " + netice1);
//                    Console.WriteLine("netice2:" + netice2 );
//                    Console.WriteLine("netice3: " + netice3);
//                }
//                else
//                {
//                    Console.WriteLine("Duzgun 5 reqemli eded yazin");
//                    goto l13;
//                }
//            }
//            else
//            {
//                Console.WriteLine("Duzgun 5 reqemli eded yazin");
//                goto l13;
//            }
//        }
//        else
//        {
//            Console.WriteLine("Duzgun 5 reqemli eded yazin");
//            goto l13;
//        }
//    }
//}
#endregion