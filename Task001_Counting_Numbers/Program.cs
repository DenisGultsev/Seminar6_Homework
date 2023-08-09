using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите числа через пробел:");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        int count = 0;
        foreach (string number in numbers)
        {
            int num;
            if (Int32.TryParse(number.Trim(), out num)) // fixed error: use TryParse instead of Parse to handle invalid input
            {
                if (num > 0)
                {
                    count++;
                }
            }
        }

        Console.WriteLine("Количество чисел больше 0: " + count);
    }
}
