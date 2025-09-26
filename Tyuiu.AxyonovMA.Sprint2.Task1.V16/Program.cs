using Tyuiu.AxyonovMA.Sprint2.Task1.V16.Lib;

Console.Title = "Спринт #2 | Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Логические операции                                               *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #16                                                             *");
Console.WriteLine("* Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений и логических операций,         *");
Console.WriteLine("* которая вернет логическую последовательность (массив):                  *");
Console.WriteLine("* (True, True, True, False, True, False), при a = 145, b = 716, c = 144, d = 137");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int a = 145;
int b = 716;
int c = 144;
int d = 137;

Console.WriteLine("A = " + a);
Console.WriteLine("B = " + b);
Console.WriteLine("C = " + c);
Console.WriteLine("D = " + d);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
bool[] result = ds.GetLogicOperations(a, b, c, d);

Console.WriteLine("Результат:");
for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine($"Операция {i + 1}: {result[i]}");
}

Console.ReadKey();