using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeatnono
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>();

            // 決定要產生幾個號碼
            Console.WriteLine("請輸入想抽出的號碼數量");
            string amount = Console.ReadLine();
            int amount2 = int.Parse(amount);

            
                // 在List裡放入1~42     
                for (int i = 1; i < 43; i++)
            {
                number.Add(i);
            }

            // 隨機
            Random rand = new Random();
            
            // 迴圈印出數個
            for (int i = 0; i < amount2; i++)
            {
                int r = rand.Next(1, number.Count);
                Console.Write(number[r] + " ");

                // 每印一個就從List中刪除
                number.RemoveAt(r);
            }

            // 暫停畫面
            Console.ReadLine();
        }
    }
}
