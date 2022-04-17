// прогрмма-проверка палиндрома
Console.Clear();
Console.WriteLine("Введите пятизначное число, которое необходимо проверить");
string number = Convert.ToString(Console.ReadLine());
if (number.Length != 5)
{
    Console.WriteLine($"Указаное число не является пятизначным");
}
else
{
    if (number[0] == number[4] & number[1] == number[3]) 
    {
        Console.WriteLine($"Указаное число - палиндром");
    }
    else
    {
        Console.WriteLine($"Указаное число - НЕ палиндром"); 
    }    
}