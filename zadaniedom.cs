using System;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Zadanie 1

            /*Console.Write("Podaj liczbę pierwszą: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Podaj liczbę drugą: ");
            int y = int.Parse(Console.ReadLine());
            string sum = ((x + y) % 2 == 0) ? "Suma obu liczb jest parzysta" : "Suma obu liczb jest nieparzysta";
            Console.WriteLine(sum);*/

            //Zadanie 2

            /*Console.Write("Podaj liczbę pierwszą: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Podaj liczbę drugą: ");
            int y = int.Parse(Console.ReadLine());
            double art = x + y / 2;
            double geo = Math.Pow(x + y, 1/2);
            string text = (art > geo) ? "Artmetyczna średnia liczb jest mniejsza" : "Artmetyczna średnia liczb jest większa";
            Console.WriteLine(text);*/

            //Zadanie 3

            /*Console.Write("Podaj liczbe pierwszą : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Podaj liczbe drugą : ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Podaj liczbe trzecią : ");
            int z = int.Parse(Console.ReadLine());

            if (x == y && x != z) Console.WriteLine($"{x} == {y}");
            else if (x == z && x != y) Console.WriteLine($"{x} == {z}");
            else if (y == z && x != z) Console.WriteLine($"{y == z}");
            else Console.WriteLine("Ani jedna z liczb nie jest równa innej");*/

            //Zadanie 4

            /*int[] numas = new int[4];
            for(int i = 0; i < 4; i++)
            {
                Console.Write($"Podaj {i+1} liczbe: ");
                numas[i] = int.Parse(Console.ReadLine());
            }
            int minutes  = numas[0];
            for(int i = 1; i < 4; i++) 
            {
                if (numas[i] < minutes) min = numas[i];
            }
            Console.WriteLine($"Najmniejsza liczba to {minutes}");*/

            //Zadanie 5

            /*Console.Write("Podaj długość boku pierwszego trójkąta: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Podaj długość boku drugiego trójkąta: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Podaj długość boku trzeciego trójkąta: ");
            int z = int.Parse(Console.ReadLine());

            if (x<y+z && y<x+z && z<x+y) Console.WriteLine("Trójkąt spełnia nierówności trójkąta");
            else Console.WriteLine("Trójkąt nie spełnia nierówności trójkąta");*/

            //Zadanie 6

            /*Console.Write("Podaj długość pierwszego boku trójkąta: ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("Podaj długość drugiego boku trójkąta: ");
            float y = float.Parse(Console.ReadLine());
            Console.Write("Podaj długość trzeciego boku trójkąta: ");
            float z = float.Parse(Console.ReadLine());

            if (x>0 && y>0 && z>0 && x+y>z && y+z>x && x+z>y)
            {
                Console.Write("Liczby są w stanie być bokami trójkąta i jest to  ");

                if (x*x + y*y > z*z) Console.Write("trójkąt ostrokątny");

                else if ((x*x + y*y == z*z) || (x*x + z*z == y*y) || (z*z + y*y == x*x)) Console.WriteLine("trójkąt prostokątny");

                else Console.WriteLine("trójkąt rozwartokątny");
            }
            else Console.WriteLine("Te liczby nie są w stanie stworzyć trójkąta");*/
        }
    }
}