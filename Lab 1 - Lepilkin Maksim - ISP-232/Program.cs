using System;
namespace Lab_1___Lepilkin_Maksim___ISP_232
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задание 1
            string game = "Dying Light";
            Console.WriteLine(game);
            int num = 7;
            Console.WriteLine(num);
            double pi = 3.14;
            Console.WriteLine(pi);
            string alf = "f";
            Console.WriteLine(alf);

            // задание 2
            Console.WriteLine("I need more power!");
            Console.WriteLine("I need more power!");
            Console.WriteLine("I need more power!");
            Console.WriteLine("I need more power!");

            // задание 3
            char cov = '"';
            Console.WriteLine($"{cov}Hello there{cov}");

            // задание 4
            int mon = int.Parse(Console.ReadLine());
            int sysb = int.Parse(Console.ReadLine());
            int clav = int.Parse(Console.ReadLine());
            int mouse = int.Parse(Console.ReadLine());
            Console.WriteLine((mon + sysb + clav + mouse) * 3);

            // задание 5
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(3 * (a + b) * (a + b) * (a + b) + 275 * b * b - 127 * a - 41);

            // задание 6
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char cov2 = '"';
            Console.WriteLine($"{cov2}Привет,{name}!{cov2}");
            Console.WriteLine($"{cov2}Сейчас тебе {age}.{cov2}");
            Console.WriteLine($"{cov2}В следующем году тебе будет {age + 1}.{cov2}");

            // задание 7
            string name1 = Console.ReadLine();
            int age1 = int.Parse(Console.ReadLine());
            string city = Console.ReadLine();
            Console.WriteLine($"Привет, {name1}! Тебе {age1} лет и ты живёшь в городе {city}.");

            // задание 8
            char cov1 = '"';
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine($"{cov1}Температура:{(C * 9 / 5) + 32}°F{cov1}");
        }
    }
}
