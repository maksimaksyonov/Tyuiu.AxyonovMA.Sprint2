using Tyuiu.AxyonovMA.Sprint2.Task5.V4.Lib;

Console.Title = "Спринт #2 | Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Оператор switch                                                   *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #4                                                              *");
Console.WriteLine("* Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* По номеру масти m (1..4) вывести её название:                           *");
Console.WriteLine("* 1 - пики, 2 - трефы, 3 - бубны, 4 - червы.                              *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите m (1..4): ");
int m = int.Parse(Console.ReadLine() ?? "0");

var ds = new DataService();
string suit = ds.FindCardSuit(m);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine($"Масть: {suit}");

Console.WriteLine("Нажмите любую клавишу для выхода...");
Console.ReadKey();
