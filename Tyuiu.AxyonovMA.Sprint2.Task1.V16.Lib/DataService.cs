using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AxyonovMA.Sprint2.Task1.V16.Lib
{
    public class DataService : ISprint2Task1V16
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] results = new bool[6];

            // Операции для получения (True, True, True, False, True, False)
            results[0] = (a < b) | (c > d);          // True | True → True
            results[1] = (a == c + 1) & (b != d);    // True & True → True
            results[2] = (c <= a) || (d >= a);       // True || False → True
            results[3] = (b > c) && (a < d);         // True && False → False
            results[4] = !(d > c);                   // !False → True
            results[5] = (a == b) ^ (c == d);        // False ^ False → False

            return results;
        }
    }
}