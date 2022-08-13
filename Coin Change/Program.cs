using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Change
{
    class Program
    {
        static void Main(string[] args)
        {
            string val = Console.ReadLine();
            string[] v2 = val.Split(' ');

            int n = Convert.ToInt32(v2[0]);
            int m = Convert.ToInt32(v2[1]);
            
            int[] arr = new int[m];

            string ArrVal = Console.ReadLine();

            string[] ValAR = ArrVal.Split(' ');
            for (int i = 0; i < m; i++)
            {
                arr[i] = Convert.ToInt32(ValAR[i]);
            }


            Console.Write(CoinChange(arr, m, n));
            Console.ReadLine();
        }
        /// <summary>
        /// Function To Get Coins Change 
        /// </summary>
        /// <param name="m">then number of coins </param>
        /// <param name="n">the amount of change</param>
        /// <returns></returns>
      
            static long CoinChange(int[] S, int m, int n)
            {
            if (n==0 || n<0)
            {
                return 0;
            }
                int[] Coin = new int[n + 1];

               
                for (int i = 0; i < Coin.Length; i++)
                {
                    Coin[i] = 0;
                }

                
                Coin[0] = 1;


                for (int i = 0; i < m; i++)
                    for (int j = S[i]; j <= n; j++)
                        Coin[j] += Coin[j - S[i]];

                return Coin[n];
            }
        }
    
}
