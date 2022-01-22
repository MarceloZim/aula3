using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayDeInteiros = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
            
            for (int i = 0; i < arrayDeInteiros.Length; i++)
            {
                Console.WriteLine(arrayDeInteiros);
            }
        }
    }
}
