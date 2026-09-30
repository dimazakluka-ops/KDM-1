using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> A = new HashSet<int> { 1, 2, 3, 4 };
        HashSet<int> B = new HashSet<int> { 3, 4, 5, 6 };

        // A ∩ B
        HashSet<int> intersection = new HashSet<int>(A);
        intersection.IntersectWith(B);

        // A \ B
        HashSet<int> difference = new HashSet<int>(A);
        difference.ExceptWith(B);

        // (A ∩ B) ∪ (A \ B)
        HashSet<int> result = new HashSet<int>(intersection);
        result.UnionWith(difference);

        Console.WriteLine("A = {" + string.Join(", ", A) + "}");
        Console.WriteLine("B = {" + string.Join(", ", B) + "}");
        Console.WriteLine("A n B = {" + string.Join(", ", intersection) + "}");
        Console.WriteLine("A \\ B = {" + string.Join(", ", difference) + "}");
        Console.WriteLine("(A n B) U (A \\ B) = {" +
                          string.Join(", ", result) + "}");

        
        Console.WriteLine("Результат дорівнює A: " + result.SetEquals(A));
    }
}