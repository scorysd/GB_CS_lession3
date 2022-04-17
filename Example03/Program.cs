// программа на вывод таблицы кубов от 1 до N
Console.Clear();
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int i = 1;
while (i < number)
{
    Console.Write($"{Math.Pow(i, 3)}, ");
    i++;
}
Console.WriteLine($"{Math.Pow(i, 3)}. ");