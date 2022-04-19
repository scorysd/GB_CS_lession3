// прогрмма-проверка палиндрома
Console.Clear();
Console.WriteLine("Введите число (слово), которое необходимо проверить");
string number = (Console.ReadLine());
int lastIndex = number.Length - 1;
bool palindrom (string number)
{
    for (int i = 0; i < number.Length / 2; i++)
        if (number[lastIndex -i] != number[0 +i])
            return false;
        return true;
}
    if (palindrom(number))
    {
        Console.WriteLine("Введеное Вами число (слово) является палиндромом");
    }
    else 
    {
        Console.WriteLine("Введеное Вами число (слово) не является палиндромом");
    }