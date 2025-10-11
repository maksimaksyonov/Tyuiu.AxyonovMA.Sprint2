using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AxyonovMA.Sprint2.Task7.V13.Lib
{
    public class DataService : ISprint2Task7V13
    {
        
        public bool IsInShadedArea(double x, double y)
        {
            bool insideCircle = x * x + y * y <= 1.0 + 1e-12;
            bool condition = (x <= 0.0) || (y >= x - 1.0);
            return insideCircle && condition;
        }
        public bool CheckDotInShadedArea(double x, double y)
        {
            throw new NotImplementedException();
        }
    }
}
