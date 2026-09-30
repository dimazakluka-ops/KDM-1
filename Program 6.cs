using System;

class SetOperations
{
    static void Main()
    {
      
        bool A = false;
        bool B = false;
        bool V = true;
        bool G = false;
        bool D = false;
        bool E = false;

        // (В ∪ Г) \ (Д ∪ Е)
        bool firstPart = (V || G) && !(D || E);

       
        bool secondPart = D && E;


        bool result = firstPart || secondPart;

        Console.WriteLine("((В U Г) \\ (Д U Е)) U (Д n Е):");
        Console.WriteLine(result);
    }
}