using System;

class Program
{
    static void Main()
    {
        HashSet<int> A = new HashSet<int> { 1, 2, 3, 4 };
        HashSet<int> B = new HashSet<int> { 3, 4, 5, 6 };
        HashSet<int> C = new HashSet<int> { 1, 3, 5, 7 };
        HashSet<int> U = new HashSet<int> { 1,2, 3,4, 5,6, 7 };
        HashSet<int> result1 = new HashSet<int> (A);
        result1.IntersectWith (B);
        HashSet<int> negaC = new HashSet<int>(U);
        negaC.ExceptWith(C);
        HashSet<int> result2 = new HashSet<int>(result1);
        result2.UnionWith(negaC);
        Console.WriteLine("A)");
        foreach (int x in result2)
           
            Console.Write(  x + " ");
        Console.WriteLine();
        HashSet<int> negaB = new HashSet<int>(U);
        negaB.ExceptWith(B);
        HashSet<int> result3 = new HashSet<int>(negaB);
        result3.UnionWith(C);
        HashSet<int> negaBC = new HashSet<int>(U);
        negaBC.ExceptWith(result3);
        HashSet<int> result4 = new HashSet<int>(A);
        result4.IntersectWith(negaBC);
        Console.WriteLine("B)");
        foreach (int x in result4)

            Console.WriteLine(x + " ");
        HashSet<int> D = new HashSet<int>(result4);
        int power = (int)Math.Pow(2, D.Count);
        Console.WriteLine("Потужність D = " + D.Count);
        Console.WriteLine("Потужність булеана = " + power);
    }
}
//IntersectWith() ∩ ExceptWith() ' UnionWith() ∪ SymmetricExceptWith() Δ  ExceptWith() \
