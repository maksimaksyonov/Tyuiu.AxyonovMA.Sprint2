using Tyuiu.AxyonovMA.Sprint2.Task6.V11.Lib;

Console.Title = "Спринт #2 | Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Оператор switch (сокращённая форма)                               *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #11                                                             *");
Console.WriteLine("* Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дата задаётся: g (год), m (месяц), n (день). Год невисокосный.          *");
Console.WriteLine("* Определить дату следующего дня.                                         *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите g (год): ");
int g = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите m (месяц 1..12): ");
int m = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите n (день): ");
int n = int.Parse(Console.ReadLine() ?? "0");

var ds = new DataService();
string next = ds.GetNextDate(g, m, n);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(next);

Console.WriteLine("Нажмите любую клавишу для выхода...");
Console.ReadKey();
