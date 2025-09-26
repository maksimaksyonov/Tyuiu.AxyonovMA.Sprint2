using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AxyonovMA.Sprint2.Task0.V1.Lib
{
    public class DataService : ISprint2Task0V1
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] results = new bool[6];

            // Операции сравнения в заданной последовательности
            // для получения (True, False, True, False, True, False)
            results[0] = x == y + 111;       // 233 == 122 + 111 → 233 == 233 → True
            results[1] = x != x;             // 233 != 233 → False
            results[2] = y < x;              // 122 < 233 → True
            results[3] = x > x + 1;          // 233 > 234 → False
            results[4] = y <= x;             // 122 <= 233 → True
            results[5] = x >= x + 1;         // 233 >= 234 → False

            return results;
        }
    }
}