using System;

public class Program
{
    // Перечисление для дней недели
    public enum Weekday
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    // Перечисление для времени суток
    public enum Time
    {
        Morning,
        Day,
        Evening,
        Night
    }

    public static void Main()
    {
        Weekday day;
        int time;

        // Запрашиваем у пользователя день недели
        Console.Write("Enter the day of the week (0-6): ");
        int inputDay = int.Parse(Console.ReadLine());
        day = (Weekday)inputDay;

        // Запрашиваем у пользователя время
        Console.Write("Enter the time of the day (0-23): ");
        time = int.Parse(Console.ReadLine());

        //Получение строкового представления выбранного дня недели с помощью метода GetName класса Enum.
        string dayString = Enum.GetName(typeof(Weekday), day);

        Time timeOfDay;
        // Определяем время суток на основе введенного времени
        if (time >= 7 && time <= 12)
        {
            timeOfDay = Time.Morning;
        }
        else if (time >= 13 && time <= 18)
        {
            timeOfDay = Time.Day;
        }
        else if (time >= 18 && time <= 23)
        {
            timeOfDay = Time.Evening;
        }
        else
        {
            timeOfDay = Time.Night;
        }

        // Получаем строковое представление времени суток
        string timeString = Enum.GetName(typeof(Time), timeOfDay);

        // Выводим сообщение о текущем дне недели и времени суток
        Console.WriteLine($"Currently it is {dayString}, {timeString}");
    }
}
