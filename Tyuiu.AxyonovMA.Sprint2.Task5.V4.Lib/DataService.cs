using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AxyonovMA.Sprint2.Task5.V4.Lib
{
    public class DataService : ISprint2Task5V4
    {
        public string FindCardSuit(int m)
        {
            return m switch
            {
                1 => "пики",
                2 => "трефы",
                3 => "бубны",
                4 => "червы",
                _ => "неизвестно"
            };
        }
    }
}
