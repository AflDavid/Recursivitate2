using System;

namespace Rec2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[] { 5, 6, 7, 8, 9 };
            Console.WriteLine(Rec.Maxim(vector, vector.Length - 1, int.MinValue));
        }
    }
}
