using System;

class Program
{

    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("----------Welcome to Grade calculation program!----------");
        Console.ResetColor();

        Console.WriteLine("Please insert your first exam grade: ");
        double grade1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please insert your second exam grade: ");
        double grade2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please insert your third exam grade: ");
        double grade3 = Convert.ToDouble(Console.ReadLine());


        //Burada herbir not için geçersiz bir sayı girerse tekrardan girmemizi sağlayan bir kod yazılmalı.
        if (grade1 > 100 || grade2 >100 || grade3 > 100 && grade1 < 0 || grade2 < 0 || grade3 < 0)
        {
            Console.WriteLine("You cannot enter a number greater than 100.");
        }

        double average = (grade1 + grade2 + grade3) / 3.0;

        // Ortalamaya göre değişen renkler
        if (average >= 90 && average <= 100)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Average grade: AA - Excellent! Keep up the great work!");
        }
        else if (average >= 85 && average <= 89)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Average grade: BA - Very Good! You're doing really well!");
        }
        else if (average >= 80 && average <= 84)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Average grade: BB - Good job! Keep pushing to improve!");
        }
        else if (average >= 75 && average <= 79)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Average grade: CB - Not bad! You can do better with more effort!");
        }
        else if (average >= 70 && average <= 74)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Average grade: CC - You passed, but there's room for improvement.");
        }
        else if (average >= 65 && average <= 69)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Average grade: DC - You're close, but you need to study more.");
        }
        else if (average >= 60 && average <= 64)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Average grade: DD - You need to work harder to understand the material.");
        }
        else if (average >= 55 && average <= 59)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Average grade: FD - You're almost there, but serious effort is needed.");
        }
        else if (average >= 0 && average <= 54)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Average grade: FF - You need to work much harder. Study more!");
        }

        // renkeleri resetle
        Console.ResetColor();


    }
}