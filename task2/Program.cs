Console.WriteLine("Введите трёхзначное число");

int number = 456;

if (number / 100 == 0)
{
    System.Console.WriteLine("Третьей цифры нет");
    return;
}

    while (number > 999)
    {
        number /= 10; 
    }

System.Console.WriteLine(number % 10);
