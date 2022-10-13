Console.WriteLine("Введите пятизначное число");
int number;
number = int.Parse(Console.ReadLine());
int temp = number;
if (number > 9999 && number < 100000)
{
    int reverted = 0;
    while (number > reverted) 
    {
        reverted = reverted * 10 + number % 10;
        number /= 10;
    }
    if (number == reverted / 10) 
    {
        Console.WriteLine($"Число {temp} полиндром");
    }
    else
    {
        Console.WriteLine($"Число {temp} не полиндром");
    }
}
else
{
    Console.WriteLine("Число не пятизначное");
}

Console.ReadKey();