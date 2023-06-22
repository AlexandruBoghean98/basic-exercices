using System.Drawing;

public class AmPiramide
{
    public static void Main()
    {
        int piramidHeight = int.Parse(Console.ReadLine());

        PrintTriangle(piramidHeight);
    }

    public static void PrintTriangle(int limita)
    {
        for (int i = 1; i <= limita; i++)
        {
            string linie = new string('*', i);
            Console.WriteLine(linie);
        }

        for (int i = limita - 1; i >= 1; i--)
        {
            string linie = new string('*', i);
            Console.WriteLine(linie);
        }
    }
}