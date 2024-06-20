using System;

class AgeCalculator
{
    static void Main()
    {
        Console.WriteLine("Введите вашу дату рождения в формате (гггг-мм-дд):");
        string input = Console.ReadLine();
        DateTime birthDate;
        if (DateTime.TryParse(input, out birthDate))
        {
            TimeSpan age = DateTime.Now - birthDate;
            int years = (int)(age.Days / 365.25);
            int months = (int)((age.Days % 365.25) / 30.44);
            int days = (int)(age.Days % 30.44);

            Console.WriteLine($"Ваш возраст: {years} лет, {months} месяцев, {days} дней");
        }
        else
        {
            Console.WriteLine("Некорректный формат даты. Пожалуйста, используйте формат (гггг-мм-дд).");
        }
    }
}
