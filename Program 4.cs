using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

   
        HashSet<int> A = new HashSet<int> { 1, 2, 3, 4 };
        HashSet<int> B = new HashSet<int> { 3, 4, 5 };
        HashSet<int> C = new HashSet<int> { 3, 5, 6 };

       
        Console.Write("Введіть довільний елемент x: ");
        int x = int.Parse(Console.ReadLine());

        
        // x ∈ A \ (B ∩ C)
        bool left =
            A.Contains(x) &&
            !(B.Contains(x) && C.Contains(x));

      
        // x ∈ (A \ B) ∪ (A \ C)
        bool right =
            (A.Contains(x) && !B.Contains(x)) ||
            (A.Contains(x) && !C.Contains(x));

        Console.WriteLine();
        Console.WriteLine($"x = {x}");

        Console.WriteLine(
            $"x Є A \\ (B ∩ C): {left}");

        Console.WriteLine(
            $"x Є (A \\ B) U (A \\ C): {right}");


        if (left && right)
        {
            Console.WriteLine();
            Console.WriteLine(
                "x належить лівій і правій частинам.");
        }
        else if (!left && !right)
        {
            Console.WriteLine();
            Console.WriteLine(
                "x не належить ні лівій, ні правій частині.");
        }

      
        if (left == right)
        {
            Console.WriteLine();
            Console.WriteLine(
                "Для обраного x належність однакова.");
        }
    }
}