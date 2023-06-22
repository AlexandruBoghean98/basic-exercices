public class AreaAndPerimeter
{
    public static void Main()
    {
        Console.Write("Enter the circle radius: ");
        float radius = float.Parse(Console.ReadLine());

        float area = (float)(Math.PI * radius * radius);
        float perimeter = (float)(Math.PI * radius * 2);

        Console.WriteLine("The area of circle is: " + area);
        Console.WriteLine("The perimeter of circle is: " + perimeter);
    }
}