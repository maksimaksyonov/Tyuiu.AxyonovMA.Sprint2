using Tyuiu.AxyonovMA.Sprint2.Task0.V1.Lib;

Console.Title = "Спринт #2 | Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Операции сравнения                                                *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #1                                                              *");
Console.WriteLine("* Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений и арифметических выражений,    *");
Console.WriteLine("* которая вернет логическую последовательность (массив):                  *");
Console.WriteLine("* (True, False, True, False, True, False), при x = 233, y = 122           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x = 233;
int y = 122;

Console.WriteLine("X = " + x);
Console.WriteLine("Y = " + y);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
bool[] result = ds.GetCompareOperations(x, y);

Console.WriteLine("Результат:");
for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine($"Операция {i + 1}: {result[i]}");
}

Console.ReadKey();