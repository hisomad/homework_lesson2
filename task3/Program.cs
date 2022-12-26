Console.WriteLine("Введите число от 1 до 7 для вывода выходного дня недели");

int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 7)
{
    System.Console.WriteLine($"{number} это число не является днём недели");
}

else if (number <= 5)
{
    System.Console.WriteLine($"{number} это число является будним днём недели");
}

else
{
    System.Console.WriteLine($"{number} это число является выходным днём недели");
}