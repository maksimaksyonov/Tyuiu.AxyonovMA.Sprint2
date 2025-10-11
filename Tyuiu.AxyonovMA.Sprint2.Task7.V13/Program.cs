using System.Globalization;
using Tyuiu.AxyonovMA.Sprint2.Task7.V13.Lib;

Console.Title = "Спринт #2 | Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Геометрические вычисления                                         *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #13                                                             *");
Console.WriteLine("* Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Проверить, лежит ли точка (x, y) в заштрихованной области рисунка.      *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите x: ");
double x = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
Console.Write("Введите y: ");
double y = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

var ds = new DataService();
bool ok = ds.IsInShadedArea(x, y);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(ok ? "Да, точка входит в область." : "Нет, точка вне области.");

Console.WriteLine("Нажмите любую клавишу для выхода...");
Console.ReadKey();
