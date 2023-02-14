using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            char ans;
            do
            {
                
                int[] one = new int[100];
                int[] strs= new int[100];
                int sumA = 0;
                int sumB = 0;
                Random random = new Random();
                for (int i = 0; i < 4; i++)
                {
                    one[i] = random.Next(0, 10);
                    for(int k = 0; k < i; k++)
                    {
                        if (one[i] == one[k])
                        {
                            i--;
                        }
                    }

                }
                for(int i = 0; i < 4; i++)
                {
                    Console.WriteLine(one[i]);
                }
                Console.WriteLine("歡迎來到 1A2B 猜數字的遊戲～");
                do
                {
                    sumA = 0;
                    sumB = 0;
                    Console.WriteLine("-------------------------\n");
                    Console.Write("請輸入 4 個數字：");
                    string str = Console.ReadLine();
                    //text
                    for(int i = 0; i < 4; i++)
                    {
                        strs[i] = Convert.ToInt32(str[i]) - '0';
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < str.Length; j++)
                        {
                            
                            if ((int)one[i] == (int)strs[j] && (int)one[i] != (int)strs[i])
                            {
                                sumB++;
                            }
                        }
                        if ((int)one[i] == (int)strs[i])
                        {
                            sumA++;
                        }

                    }
                    Console.WriteLine($"判定結果是 {sumA}A  {sumB}B \n");
                    
                } while (sumA < 4);
                Console.WriteLine("恭喜你！猜對了！！\r\n");
                Console.WriteLine("你要繼續玩嗎？(y/n): ");
                ans = (char)Console.Read();
            } while (ans == 'y');
            
            Console.WriteLine("遊戲結束，下次再來玩喔～\r\n");
            
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
