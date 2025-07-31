using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.WriteLine("Enter the lengths of the three sides of the triangle:");

        Console.Write("Side 1: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Side 2: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Side 3: ");
        int c = int.Parse(Console.ReadLine());

        if (a == b && b == c)
            Console.WriteLine("The triangle is Equilateral.");
        else if (a == b || b == c || a == c)
            Console.WriteLine("The triangle is Isosceles.");
        else
            Console.WriteLine("The triangle is Scalene.");
    }
}