using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _17._10._2022___Signs_of_the_Zodiac
{
    internal class Program
    {
   
       // DefineZodiac

        static string DefineZodiac(int month, int day)
        {
            string tempZodiac = "";

            // Овен
            if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
            {
                tempZodiac = "Овен";
                Console.WriteLine($"Ваш знак зодиака: {tempZodiac}");
            }

            // Телец
            if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
            {
                tempZodiac = "Телец";
                Console.WriteLine($"Ваш знак зодиака: {tempZodiac}");
            }

            // Близнецы
            if ((month == 5 && day >= 21) || (month == 5 && day <= 20))
            {
                tempZodiac = "Близнецы";
                Console.WriteLine($"Ваш знак зодиака: {tempZodiac}");
            }

            // Рак
            if ((month == 6 && day >= 21) || (month == 7 && day <= 22))
            {
                tempZodiac = "Рак";
                Console.WriteLine($"Ваш знак зодиака: {tempZodiac}");
            }

            // Лев
            if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
            {
                tempZodiac = "Лев";
                Console.WriteLine($"Ваш знак зодиака: {tempZodiac}");
            }

            // Дева

            if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
            {
                tempZodiac = "Дева";
                Console.WriteLine($"Ваш знак зодиака: {tempZodiac}");
            }

            // Весы

            if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
            {
                tempZodiac = "Весы";
                Console.WriteLine($"Ваш знак зодиака: {tempZodiac}");
            }

            // Скорпион

            if ((month == 10 && day >= 23) || (month == 10 && day <= 21))
            {
                tempZodiac = "Скорпион";
                Console.WriteLine($"Ваш знак зодиака: {tempZodiac}");
            }

            // Стрелец

            if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
            {
                tempZodiac = "Стрелец";
                Console.WriteLine($"Ваш знак зодиака: {tempZodiac}");
            }

            // Козерог

            if ((month == 12 && day >= 22) || (month == 01 && day <= 19))
            {
                tempZodiac = "Козерог";
                Console.WriteLine($"Ваш знак зодиака: {tempZodiac}");
            }

            // Водолей

            if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
            {
                tempZodiac = "Водолей";
                Console.WriteLine($"Ваш знак зодиака: {tempZodiac}");
            }

            // Рыбы

            if (((month == 2) && (day >= 19)) || ((month == 3) && (day <= 20)))
            {
                tempZodiac = "Рыбы";
                Console.WriteLine($"Ваш знак зодиака: {tempZodiac}");
            }

            return tempZodiac;
        }

        static void FindMatches(string text, string match)
        {

            if (text == match)
            {
                Console.WriteLine($"Ваш знак зодиака: {match}");
            }

        }

        void GetNextSign ()
        {


            
        }

        static void Main(string[] args)
        {
            // Zodiac

            Zodiac myZodiac = new Zodiac();


            Console.WriteLine("Введите месяц для поиска: ");
            int month = int.Parse(Console.ReadLine());

            if (month < 1 || month > 12)
            {
                Console.WriteLine("Wrong month");
                Console.ReadKey();
                return;
            }


            Console.WriteLine("Введите день для поиска: ");
            int day = int.Parse(Console.ReadLine());


            if (day < 1 || day > 31)
            {
                Console.WriteLine("Wrong day");
                Console.ReadKey();
                return;
            }

            string tempZodiac = DefineZodiac(month, day);




            foreach (var item in myZodiac)
            {
                FindMatches(tempZodiac, item.ToString());
            }
            Console.ReadKey();
        }
    }
}
