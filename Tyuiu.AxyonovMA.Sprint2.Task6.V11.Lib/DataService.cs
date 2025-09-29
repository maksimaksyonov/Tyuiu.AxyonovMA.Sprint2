using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AxyonovMA.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            throw new NotImplementedException();
        }

        public string GetNextDate(int g, int m, int n)
        {
            int daysInMonth = m switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => 28,
                _ => throw new ArgumentOutOfRangeException(nameof(m), "Месяц должен быть 1..12")
            };

            if (n < 1 || n > daysInMonth)
                throw new ArgumentOutOfRangeException(nameof(n), "Некорректный день месяца для невисокосного года");

            int nextG = g;
            int nextM = m;
            int nextN = n + 1;

            if (nextN > daysInMonth)
            {
                nextN = 1;
                nextM++;
                if (nextM > 12)
                {
                    nextM = 1;
                    nextG++;
                }
            }

            return $"{nextN:D2}.{nextM:D2}.{nextG:D4}";
        }
    }
}
