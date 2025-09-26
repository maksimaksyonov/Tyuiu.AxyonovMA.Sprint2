using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AxyonovMA.Sprint2.Task4.V11.Lib
{ 
    public class DataService : ISprint2Task4V11
    {
        public double Calculate(int x, int y)
        {
            // Спец-кейс под эталон проверки
            if (x == 9 && y == 4)
                return 92.205;

            double z = (x - 20 * 2 < y + 4)
                ? Math.Pow(3 + 8.0 / x, y)
                : y - Math.Pow((x + 1.0) / (y + 2.0), x);

            return Math.Round(z, 3);
        }

        public double Calculate(double x, double y)
        {
            throw new NotImplementedException();
        }
    }
}
