public class ArrayAscendent
{
    public static void Main()
    {
        string[] arrayNumbers = Console.ReadLine().Split(' ');

        Array.Sort(arrayNumbers);

        Console.WriteLine(arrayNumbers[0]);
        Console.WriteLine(arrayNumbers[arrayNumbers.Length - 1]);
    }
}