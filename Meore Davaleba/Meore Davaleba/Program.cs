using System;
using System.Linq;
using System.Collections.Generic;
namespace Meore_Davaleba
{
    class Program
    {
        public static int minSplit(int amount)
        {
            int[] Coins = new int[] { 1, 5, 10, 20, 50 }; // monetebis masivi
            int z = 0;// minimaluri monetebis sawyisi raodenoba aris 0 
            for (int i = Coins.Length - 1; i >= 0; i--)
            {
                if (amount / Coins[i] >= 1)
                {
                    int q = amount / Coins[i];
                    z = z + q;
                    amount = amount - Coins[i] * q;
                }
            }
            return z;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Shemovitanot Tanxa");
            int z = Convert.ToInt32(Console.ReadLine());
            int q = minSplit(z);
            Console.WriteLine("Monetebis Minimaluri Raodenobaa:" + q);
        }
    }
}
