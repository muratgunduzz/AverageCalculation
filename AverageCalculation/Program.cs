using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("----------Welcome to Grade Calculation Program!----------");

        // Kullanıcıdan 3 sınav notu alma
        double[] grades = new double[3];
        for (int i = 0; i < grades.Length; i++)
        {
            grades[i] = GetValidGrade(i + 1);
        }

        // Notların ortalamasını hesaplama
        double average = CalculateAverage(grades);

        // Ortalama sonucuna göre mesaj görüntüleme
        DisplayGradeMessage(average);
    }

    // Kullanıcıdan geçerli bir not almayı sağlayan metot
    static double GetValidGrade(int examNumber)
    {
        while (true)
        {
            Console.Write($"Please insert your exam grade {examNumber}: ");
            if (double.TryParse(Console.ReadLine(), out double grade) && grade >= 0 && grade <= 100)
            {
                return grade; // Geçerli bir not döndürülür
            }
            Console.WriteLine("Invalid input. Please enter a number between 0 and 100."); // Geçersiz giriş uyarısı
        }
    }

    // Notların ortalamasını hesaplayan metot
    static double CalculateAverage(double[] grades)
    {
        double total = 0;
        foreach (var grade in grades)
        {
            total += grade;
        }
        return total / grades.Length;
    }

    // Ortalama sonucuna göre uygun mesajı görüntüleyen metot
    static void DisplayGradeMessage(double average)
    {
        // Ortalama aralıklarına göre mesaj seçimi
        string gradeMessage = average switch
        {
            >= 90 and <= 100 => "Average grade: AA - Excellent! Keep up the great work!",
            >= 85 and < 90 => "Average grade: BA - Very Good! You're doing really well!",
            >= 80 and < 85 => "Average grade: BB - Good job! Keep pushing to improve!",
            >= 75 and < 80 => "Average grade: CB - Not bad! You can do better with more effort!",
            >= 70 and < 75 => "Average grade: CC - You passed, but there's room for improvement.",
            >= 65 and < 70 => "Average grade: DC - You're close, but you need to study more.",
            >= 60 and < 65 => "Average grade: DD - You need to work harder to understand the material.",
            >= 55 and < 60 => "Average grade: FD - You're almost there, but serious effort is needed.",
            < 55 => "Average grade: FF - You need to work much harder. Study more!",
        };

        // Seçilen mesajı ekrana yazdırma
        Console.WriteLine(gradeMessage);
    }
}
