public class SumeFaraTrei
{
    public static void Main()
    {
        Console.Write("Enter a positive number: ");
        int limit = int.Parse(Console.ReadLine());

        AddingNUmbers(limit);
    }

    private static void AddingNUmbers(int limit)
    {
        int sum = 0;
        for (int i = 0; i <= limit; i++)
        {
            if (!((i%3 == 0) && (i%7 == 0)))
            {
                sum += i;
            }
        }

        Console.WriteLine(sum);
    }
}