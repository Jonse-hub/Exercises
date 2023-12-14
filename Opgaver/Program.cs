using System;

namespace Opgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            float flot_virker = 100;
            Console.WriteLine(flot_virker);

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WindowHeight = 50; // max 50
            Console.WindowWidth = 213; // max 213
            Console.Beep(4000, 1000);
            int a = 2;
            int b = 4;
            Console.WriteLine(a==b); // false
            Console.WriteLine(a>b); // false
            Console.WriteLine(a<=b); // true
            Console.WriteLine(a-b>0); //false
            Console.WriteLine(a+b>0); //true
            Console.WriteLine(a>1-b); // true

            Console.WriteLine("\nopgave 8:\n");

            Console.WriteLine(a==b || a > 0); // true
            Console.WriteLine(a+b>0 && a>0); // true
            Console.WriteLine(a!=5 && a>0); //true
            Console.WriteLine((true||false)&& a>b); // false
            Console.WriteLine(3>5&&true || a==b); // false
            Console.WriteLine(b>a && true || false || b>4); //true
            Console.WriteLine(b<4 && a<b || a+b>4 && true); //true
            Console.WriteLine(true && true || false); // true
            Console.WriteLine(true && false && true); // false
            Console.WriteLine(true || false || false); // fejl? true
            Console.WriteLine(false && false); // true - var rent faktisk false
            Console.WriteLine(a==3 && b>4 || a+3>b); // true
            Console.WriteLine(a>b && b<a && a+a==b); // false

            a = 1;
            b = 2;
            int c = 3;
            int x = 0;
            if (a==2)
            {
                x = 1;
                if(b==2)
                {
                    x = 2;
                }

            }
            else if (c==1)
            {
                x = 3;
            }
            Console.WriteLine("X er: "+x);

            Console.Write("Tast fornavn: ");
            string fornavn = Console.ReadLine();
            Console.WriteLine(fornavn);
            Console.Write("Tast efternavn: ");
            string efternavn = Console.ReadLine();
            Console.WriteLine("Velkommen " + fornavn +" "+ efternavn);

            Console.Write("Skriv din alder: ");
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine($"din alder er {age}");


            Console.Write("indtask første side på firkant: ");
            int side1 = int.Parse(Console.ReadLine());
            Console.Write("indtask anden side på firkant: ");
            int side2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"arealet er: {side1*side2}");

            Console.Write("indtast float: ");
            float flot = float.Parse(Console.ReadLine());
            Console.WriteLine("din float er: "+flot);

            Console.Write("indtast byte: ");
            byte byt = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("din byte er: " + byt);
        }
    }
}
