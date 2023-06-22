using System;

public class RandomOrderList
{
    public static void Main()
    {
        Console.Write("Enter a positive number: ");
        int endPoint = int.Parse(Console.ReadLine());

        int[] numberList = CreateNumberList(endPoint);
        Randomize(numberList);
        PrintNumbers(numberList);

    }

    public static int[] CreateNumberList(int endPoint)
    {
        int[] numbers = new int[endPoint];

        for (int i = 1; i <= endPoint; i++)
        {
            numbers[i] = i;
        }
        return numbers;
    }

    public static void Randomize(int[] numbers)
    {
        
    }

    public static void PrintNumbers(int[] numbers)
    {
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
