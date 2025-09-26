using Tyuiu.AxyonovMA.Sprint2.Task2.V10.Lib;

Console.Title = "Спринт #2 | Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Логические операции                                               *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #10                                                             *");
Console.WriteLine("* Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры и   *");
Console.WriteLine("* вычисляет находится ли точка с координатами X,Y в заштрихованной области*");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите координату X (целое число от 1 до 15):");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y (целое число от 1 до 15):");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
bool result = ds.CheckDotInShadedArea(x, y);

if (result)
{
    Console.WriteLine($"Точка с координатами ({x},{y}) находится в заштрихованной области");
}
else
{
    Console.WriteLine($"Точка с координатами ({x},{y}) НЕ находится в заштрихованной области");
}

Console.ReadKey();