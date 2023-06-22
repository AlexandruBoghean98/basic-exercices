public class NumsDivByFive
{
    public static void Main()
    {
        Console.Write("Enter the range start: ");
        int rangeStart = int.Parse(Console.ReadLine());

        Console.Write("Enter the range end: ");
        int rangeEnd = int.Parse(Console.ReadLine());

        int count = 0;
        for(int i = rangeStart; i <= rangeEnd; i++)
        {
            if (i%5 == 0)
            {
                count++;
            }
        }

        Console.WriteLine($"Between {rangeStart} and {rangeEnd} are {count} numbers that are divisible by 5.");
    }
}