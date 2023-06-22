public class DecimalToBinary
{
    public static void Main()
    {
        int decimalNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(BinaryCast(decimalNumber));
    }

    public static int BinaryCast(int decimalNumber)
    {
        if (decimalNumber == 0)
        {
            return 0;
        }
        else
        {

            return (decimalNumber % 2 + 10 * BinaryCast(decimalNumber / 2));
        }
    }
}