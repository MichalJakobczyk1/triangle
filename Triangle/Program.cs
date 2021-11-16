using System.Globalization;
using System;

namespace Triangle

{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            var data = Console.ReadLine().Split("; ");

            double a = double.Parse(data[0]);
            double b = double.Parse(data[1]);
            double c = double.Parse(data[2]);

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Błędne dane. Długości boków muszą być dodatnie!");
                return;
            }


            if (a >= b && a >= c && a < b + c || b >= a && b >= c && b < a + c || c >= b && c >= a && c < a + b)
            {
                double circuit = a + b + c;
                double halfCircuit = circuit / 2;
                var area = Math.Sqrt(halfCircuit * (halfCircuit - a) * (halfCircuit - b) * (halfCircuit - c));

                var circuitRounded = Math.Round(circuit, 2);
                var areaRounded = Math.Round(area, 2);

                if (circuit % 1 == 0)
                {
                    Console.WriteLine($"obwód = {circuit}.00");
                }
                else
                {
                    Console.WriteLine($"obwód = {circuitRounded}");
                }

                if (area % 1 == 0)
                {
                    Console.WriteLine($"pole = {area}.00");
                }
                else 
                {
                    Console.WriteLine($"pole = {areaRounded}");
                }

                if (a < b && a < c && (a*a+b*b > c*c) || b < c && b < a && (b*b+c*c > a*a) || c < a && c < b && (a*a+c*c > b*b))
                {
                    if (a == b || a == c || b == c)
                    {
                        Console.WriteLine("trójkąt jest ostrokątny");
                        Console.WriteLine("trójkąt równoramienny");
                    }
                    else
                    {
                        Console.WriteLine("trójkąt jest ostrokątny");
                    }
                }

                else if (a < b && a < c && (a * a + b * b == c * c) || b < c && b < a && (b * b + c * c == a * a) || c < a && c < b && (a * a + c * c == b * b))
                {
                    Console.WriteLine("trójkąt jest prostokątny");
                }

                else if (a < b && a < c && (a * a + b * b < c * c) || b < c && b < a && (b * b + c * c < a * a) || c < a && c < b && (a * a + c * c < b * b))
                {
                    Console.WriteLine("trójkąt jest rozwartokątny");
                }

                if (a < c && b < c && a == b || a < b && c < b && a == c || b < a && c < a && b == c || c < a && b < a && c == b || c < b && a < b && c == a)
                {
                    if (a == b && (a * a + b * b < c * c) || b == c && (b * b + c * c < a * a) || c == a && (a * a + c * c < b * b))
                    {
                        Console.WriteLine("trójkąt jest rozwartokątny");
                        Console.WriteLine("trójkąt równoramienny");
                    }

                    else 
                    {
                        Console.WriteLine("trójkąt równoramienny");
                    }
                }

                if (a == b & a == c & b == c)
                {
                    Console.WriteLine("trójkąt jest ostrokątny");
                    Console.WriteLine("trójkąt równoboczny");
                }

            }

            else if (c > a && c > b && a + b < c || b > a && b > c && a + c < b || c > a && c > b && b + a < c || a > b && a > c && b + c < a || b > a && b > c && c + a < b || a > c && a > b && c + b < a)
            {
                Console.WriteLine("Błędne dane. Trójkąta nie można zbudować!");
                return;
            }
            else if (a + b == c || a + c == b || c + b == a)
            {
                double circuit = a + b + c;
                var circuitRounded = Math.Round(circuit, 2);

                if (circuit % 1 == 0)
                {
                    Console.WriteLine($"obwód = {circuit}.00");
                }
                else
                {
                    Console.WriteLine($"obwód = {circuitRounded}");
                }
                Console.WriteLine($"pole = 0.00");
                Console.WriteLine("trójkąt jest rozwartokątny");
            }
        }
    }
}
