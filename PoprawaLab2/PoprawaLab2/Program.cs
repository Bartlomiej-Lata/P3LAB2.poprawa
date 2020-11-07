using System;

namespace Zadanie2
{

    public enum miejscaZerowe
    {
        dwa,
        jedno,
        zero
    }

    class Program
    {



        static double Parametry()
        {
            bool sprawdz = false;
            double konwersja = 0;

            while (sprawdz == false)
            {
                if ((double.TryParse(Console.ReadLine(), out konwersja)) == false)
                {
                    Console.WriteLine("Podano nieprawidlowa liczbe, sprobuj ponownie");

                }

                else
                {
                    sprawdz = true;
                }

            }

            return konwersja;
        }

        static void Main(string[] args)
        {


            Console.WriteLine("Witaj, prosze podaj parametry a,b i c dla funkcji w postaci " +
                "ax^2+bx+c w celu obliczenia ilosci miejsc zerowych" + Environment.NewLine);


            Console.WriteLine("Podaj a :");
            double a = Parametry();
            Console.WriteLine("Podaj b :");
            double b = Parametry();
            Console.WriteLine("Podaj c :");
            double c = Parametry();





            Console.WriteLine($"Twoje liczby to: " + a + ", " + b + ", " + c);

            double delta = (b * b) - (4 * a * c);

            Console.WriteLine("Delta wynosi:" + delta);


            miejscaZerowe miejscazerowe;

            if (delta == 0)
            {
                miejscazerowe = miejscaZerowe.jedno;
            }

            else if (delta > 0)
            {
                miejscazerowe = miejscaZerowe.dwa;

            }

            else
            {
                miejscazerowe = miejscaZerowe.zero;

            }

            switch (miejscazerowe)
            {
                case miejscaZerowe.dwa:
                    double x1 = ((-b + Math.Sqrt(delta)) / (2 * a));
                    double x2 = ((-b - Math.Sqrt(delta)) / (2 * a));
                    Console.WriteLine("Rownanie posiada dwa miejsca zerowe: x1=" + x1 + ", x2=" + x2);
                    break;
                case miejscaZerowe.jedno:
                    double x = (-b / (2 * a));
                    Console.WriteLine("Rownanie posiada jedno miejsce zerowe: x=" + x);
                    break;
                case miejscaZerowe.zero:
                    Console.WriteLine("Rownanie nie posiada miejsc zerowych");
                    break;
                default:
                    break;
            }



        }
    }
}
