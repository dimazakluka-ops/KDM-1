using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        
        HashSet<int> A1 = new HashSet<int> { -1, 1 };
        HashSet<int> N = new HashSet<int> { 1, 2, 3, 4, 5 };

        bool a = A1.IsSubsetOf(N) && A1.Count < N.Count;
        Console.WriteLine("а) {-1, 1} C N: " + a);

        bool b = false;
        Console.WriteLine("б) R \\ Q = Q: " + b);

        // в) (A \\ B) ∩ C = A \\ (B ∪ C)
        HashSet<int> A = new HashSet<int> { 1, 2, 3, 4 };
        HashSet<int> B = new HashSet<int> { 3, 4, 5 };
        HashSet<int> C = new HashSet<int> { 2, 3, 6 };

        //  (A \\ B) ∩ C
        HashSet<int> leftC = new HashSet<int>(A);
        leftC.ExceptWith(B);
        leftC.IntersectWith(C);

        // A \\ (B ∪ C)
        HashSet<int> unionBC = new HashSet<int>(B);
        unionBC.UnionWith(C);

        HashSet<int> rightC = new HashSet<int>(A);
        rightC.ExceptWith(unionBC);

        bool c = leftC.SetEquals(rightC);

        Console.WriteLine("в) (A \\ B) n C = A \\ (B U C): " + c);
        Console.WriteLine("   Ліва частина: " + string.Join(", ", leftC));
        Console.WriteLine("   Права частина: " + string.Join(", ", rightC));

        // г) A ∪ (A ∩ B) = A
        HashSet<int> A4 = new HashSet<int> { 1, 2, 3, 4 };
        HashSet<int> B4 = new HashSet<int> { 3, 4, 5, 6 };

        HashSet<int> intersection = new HashSet<int>(A4);
        intersection.IntersectWith(B4);

        HashSet<int> leftD = new HashSet<int>(A4);
        leftD.UnionWith(intersection);

        bool d = leftD.SetEquals(A4);

        Console.WriteLine("г) A U (A n B) = A: " + d);
        Console.WriteLine("   A U (A n B) = {" + string.Join(", ", leftD) + "}");

        // д) якщо A ⊆ B, то A ∩ C ⊆ B ∩ C
        HashSet<int> A5 = new HashSet<int> { 1, 2 };
        HashSet<int> B5 = new HashSet<int> { 1, 2, 3, 4 };
        HashSet<int> C5 = new HashSet<int> { 2, 4, 5 };

        HashSet<int> AC = new HashSet<int>(A5);
        AC.IntersectWith(C5);

        HashSet<int> BC = new HashSet<int>(B5);
        BC.IntersectWith(C5);

        bool d2 = A5.IsSubsetOf(B5) && AC.IsSubsetOf(BC);

        Console.WriteLine("д) якщо A C_ B, то A n C C_ B n C: " + d2);
        Console.WriteLine("   A n C = {" + string.Join(", ", AC) + "}");
        Console.WriteLine("   B n C = {" + string.Join(", ", BC) + "}");
    }
}