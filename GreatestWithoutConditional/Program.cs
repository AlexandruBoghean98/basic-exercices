public class GreatestWithoutConditionl
{
    public static void Main()
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("The greatest number is: " + (num1 > num2 ? num1 : num2));
    }
}