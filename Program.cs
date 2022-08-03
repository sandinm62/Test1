using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    //Сандин Михаил
    //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
    //б) Сделать задание, только вывод организовать в центре экрана.
    //в) * Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, city;
            Console.Write("Enter you first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter you last name: ");
            lastName = Console.ReadLine();
            Console.Write("Enter you city: ");
            city = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"{firstName} {lastName} \nYou city: {city}");
            //Console.SetCursorPosition();

            Console.ReadKey();

        }
    }
}
