public class GreatestOfTheNumbers
{
    static void Main()
    {
        Console.Write("Enter the amount of numbers: ");
        int amountOfNumbers = int.Parse(Console.ReadLine());

        int[] numbers = PopulateNumbers(amountOfNumbers);

        PrintTheGreatest(numbers);
    }

    public static int[] PopulateNumbers(int amountOfNUmbers)
    {
        int[] numbers = new int[amountOfNUmbers];
        while (amountOfNUmbers > 0)
        {
            Console.Write("Enter a number: ");
            numbers[amountOfNUmbers - 1] = int.Parse(Console.ReadLine());

            amountOfNUmbers--;
        }

        return numbers;
    }

    public static void PrintTheGreatest(int[] numbers)
    {
        int greatest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > greatest)
            {
                greatest = number;
            }
        }

        Console.WriteLine("The greatest number is: " + greatest);
    }
}