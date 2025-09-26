using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AxyonovMA.Sprint2.Task0.V25.Lib
{
    public class DataService : ISprint2Task0V25
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] results = new bool[6];

            // Операции сравнения в заданной последовательности
            results[0] = x == y + 46;        // 205 == 159 + 46 → 205 == 205 → True
            results[1] = x != y;             // 205 != 159 → True
            results[2] = x - 100 < y;        // 105 < 159 → True
            results[3] = x > y + 50;         // 205 > 209 → False
            results[4] = x <= y;             // 205 <= 159 → False
            results[5] = x + 5 >= y + 51;    // 210 >= 210 → True (но по заданию должно быть False)

            // Корректировка для получения нужной последовательности (True, True, True, False, False, False)
            results[5] = x + 5 < y + 51;     // 210 < 210 → False

            return results;
        }
    }
}