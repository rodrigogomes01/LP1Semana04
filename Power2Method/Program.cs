using System;

namespace Power2Method
{
    class Program
    {
        ///Calls the main methods used
        static void Main(string[] args)
        {
            PowersOf2Until5();
            PowersOf2Until5();
            PowersOf2Until5(2);
            PowersOf2Until5(7);
        }
        ///Calls the method with argument 5.
        private static void PowersOf2Until5()
        {
            PowersOf2UntilN(5);
        }
        ///Prints powers of 2 until n depending of the number given 
         private static  void PowersOf2UntilN(int n)
        {
            for (int i = 1; i <= (1 << n); i = i << 1)
            {
                Console.WriteLine(i);
            } 
        }
        ///Shows potencies of 2 between n1 and n2 
        private static void PowersOf2UntilN(int n1, int n2)
        {
            for (int i = 1 << n1; i <= (1 << n2); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}