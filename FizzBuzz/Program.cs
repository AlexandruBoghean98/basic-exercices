public class FizzBuzz
{
    public static void Main()
    {
        int limit = int.Parse(Console.ReadLine());
        FindFizzBuzz(limit);
    }

    private static void FindFizzBuzz(int limit)
    {
        for(int i = 0; i <= limit; i++)
        {
            DisplayFizzBuzz(i);
        }
    }

    private static void DisplayFizzBuzz(int numar)
    {

        if((numar % 3 == 0) && (numar % 5 == 0))
        {
            Console.WriteLine("FizzBuzz");
        }
        else if(numar % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else if( numar % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else
            Console.WriteLine(numar);

    }
}