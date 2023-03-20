using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laufen();
        }

        static void Laufen()
        {
            Console.Clear();
            Speisekarte();
            int auswahl = int.Parse(Console.ReadLine());
            switch (auswahl)
            {
                case 1:
                    summe();
                    Console.WriteLine("wybierz dowolny klawisz by kontynuować");
                    Console.ReadLine();
                    Laufen();
                    break;
                case 2:
                    unterschied();
                    Console.WriteLine("wybierz dowolny klawisz by kontynuować");
                    Console.ReadLine();
                    Laufen();
                    break;
                case 3:
                    produkt();
                    Console.WriteLine("wybierz dowolny klawisz by kontynuować");
                    Console.ReadLine();
                    Laufen();
                    break;
                case 4:
                    quotient();
                    Console.WriteLine("wybierz dowolny klawisz by kontynuować");
                    Console.ReadLine();
                    Laufen();
                    break;
                case 5:
                    leistung();
                    Console.WriteLine("wybierz dowolny klawisz by kontynuować");
                    Console.ReadLine();
                    Laufen();
                    break;
                case 6:
                    element();
                    Console.WriteLine("wybierz dowolny klawisz by kontynuować");
                    Console.ReadLine();
                    Laufen();
                    break;
                case 7:
                    trigonometrischefunktion();
                    Console.WriteLine("wybierz dowolny klawisz by kontynuować");
                    Console.ReadLine();
                    Laufen();
                    break;
                case 8:
                    break;
                default:
                    Console.WriteLine("błąd(wybierz dowolny klawisz aby kontynuować)");
                    Console.ReadKey();
                    Laufen();
                    break;
            }
        }
        static void Speisekarte()
        {
            Console.WriteLine("wybierz działanie lub zakończ:");
            Console.WriteLine("I.suma");
            Console.WriteLine("II.różnica");
            Console.WriteLine("III.iloczyn");
            Console.WriteLine("IV.iloraz");
            Console.WriteLine("V.potęga");
            Console.WriteLine("VI.pierwiastek");
            Console.WriteLine("VII.funkcje trygonometryczne");
            Console.WriteLine("VIII.zakończ");
            Console.WriteLine();
        }
        static void summe()
        {
            Console.Write("pierwsza liczba: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("druga liczba: ");
            double y = double.Parse(Console.ReadLine());
            double ergebnis = x + y;
            Console.WriteLine("suma liczb {0} i {1}: " + ergebnis, x, y);
        }
        static void unterschied()
        {
            Console.Write("liczba od której odejmujemy: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("liczba odejmowana: ");
            double y = double.Parse(Console.ReadLine());
            double ergebnis = x - y;
            Console.WriteLine("różnica  {0} i {1}: " + ergebnis, x, y);
        }
        static void produkt()
        {
            Console.Write("pierwszy czynnik: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("drugi czynnik: ");
            double y = double.Parse(Console.ReadLine());
            double ergebnis = x * y;
            Console.WriteLine("iloczyn liczb {0} i {1}: " + ergebnis, x, y);
        }
        static void quotient()
        {
            Console.Write("dzielna: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("dzielnik: ");
            double y = double.Parse(Console.ReadLine());
            if (y == 0)
                Console.WriteLine("nie da się podzielić przez 0");
            else
            {
                double ergebnis = x / y;
                Console.WriteLine("iloraz {0} i {1}: " + ergebnis, x, y);
            }
        }
        static void leistung()
        {
            Console.Write("podstawa: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("wykładnik: ");
            double y = double.Parse(Console.ReadLine());
            double ergebnis = Math.Pow(x, y);
            Console.WriteLine("potęga {0} do {1}: " + ergebnis, x, y);
        }
        static void element()
        {
            Console.Write("podaj liczbę: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("stopień pierwiastka: ");
            double y = double.Parse(Console.ReadLine());
            double ergebnis = Math.Pow(x, 1d / y);
            Console.WriteLine("pierwiastek z {0} stopnia {1}: " + ergebnis, x, y);
        }
        static void trigonometrischefunktion()
        {
            Console.Write("miara kąta: ");
            double x = double.Parse(Console.ReadLine());
            double ergebnis = Math.Sin(x);
            Console.WriteLine("sinus kąta {0}: " + ergebnis, x);
            ergebnis  = Math.Cos(x);
            Console.WriteLine("cosinus kąta {0}: " + ergebnis, x);
            ergebnis  = Math.Tan(x);
            Console.WriteLine("tangens kąta {0}: " + ergebnis, x);
        }
    }
}
