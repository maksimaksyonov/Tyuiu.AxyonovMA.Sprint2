using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AxyonovMA.Sprint2.Task1.V16.Lib
{
    public class DataService : ISprint2Task1V16
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] results = new bool[6];

            results[0] = (a < b) | (c > d);
            results[1] = (a == c + 1) & (b != d);
            results[2] = (c <= a) || (d >= a);
            results[3] = (b > c) && (a < d);
            results[4] = !(d > c);
            results[5] = (a != b) ^ (c == d);

            return results;
        }
    }
}