using Tyuiu.AxyonovMA.Sprint2.Task4.V11.Lib;

Console.Title = "Спринт #2 | Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Тернарный оператор                                                *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #11                                                             *");
Console.WriteLine("* Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Введите x и y. Если x - 20 * 2 < y + 4,                                 *");
Console.WriteLine("*  z = (3 + 8/x)^y, иначе z = y - ((x + 1)/(y + 2))^x.                    *");
Console.WriteLine("* Ответ округлён до 3 знаков после запятой.                               *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите x: ");
int x = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите y: ");
int y = int.Parse(Console.ReadLine() ?? "0");

var ds = new DataService();
double z = ds.Calculate(x, y);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine($"z = {z}");

Console.WriteLine("Нажмите любую клавишу для выхода...");
Console.ReadKey();
