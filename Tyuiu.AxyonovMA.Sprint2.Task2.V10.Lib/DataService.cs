using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AxyonovMA.Sprint2.Task2.V10.Lib
{
    public class DataService : ISprint2Task2V10
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            // Анализ заштрихованной области по координатам от 1 до 15
            // Заштрихованные области обычно представляют собой прямоугольники или комбинации фигур

            // Область 1: большой прямоугольник (x от 3 до 5, y от 3 до 7)
            bool area1 = (x >= 3 && x <= 5) && (y >= 3 && y <= 7);

            // Область 2: правый прямоугольник (x от 9 до 12, y от 6 до 8)  
            bool area2 = (x >= 9 && x <= 12) && (y >= 6 && y <= 8);

            // Область 3: нижний прямоугольник (x от 6 до 9, y от 11 до 13)
            bool area3 = (x >= 6 && x <= 9) && (y >= 11 && y <= 13);

            // Область 4: левый вертикальный прямоугольник (x от 2 до 4, y от 10 до 12)
            bool area4 = (x >= 2 && x <= 4) && (y >= 10 && y <= 12);

            // Область 5: центральный квадрат (x от 6 до 8, y от 7 до 9)
            bool area5 = (x >= 6 && x <= 8) && (y >= 7 && y <= 9);

            return area1 || area2 || area3 || area4 || area5;
        }
    }
}