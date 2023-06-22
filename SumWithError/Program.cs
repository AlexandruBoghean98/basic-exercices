public class SumWithError
{
    public static void Main()
    {
        int limit = 5;
        int[] numbers = new int[limit];

        do
        {
            numbers[limit-1] = ValidateInput();
            limit--;
        }while (limit > 0);

        int sum = 0;
        foreach (int i in numbers)
        {
            sum += i;
        }

        Console.WriteLine(sum);
    }

    public static int ValidateInput()
    {

        try
        {
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        catch
        {
            Console.WriteLine("You entered an invalid number. Try again!");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
    }
}