using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    Console.WriteLine("請輸入你的分數 數字 ");
            //    //double score = 0;
            //    bool tranNum = double.TryParse(Console.ReadLine(), out double score);
            //    //布林定義 1 0放進布林陣列 看是ABC第幾個的符合 
            //    //bool A = (score >= 80) && (score <= 100);
            //    //bool B = (score >= 70) && (score <= 79);
            //    //bool C = (score >= 60) && (score <= 69);



            //    //我原本是用布林定義 1 0放進布林陣列 看是ABC第幾個的符合 用index去找出位置 給int 然後丟給switch 
            //    //bool[] iii = { A, B, C};
            //    //int turelevel = Array.IndexOf(iii, true);

            //    //如果轉型成功且非例外範圍負數 或大於100的分數
            //    //用三元運算子 passLevel給值   執行switch判定
            //    if (tranNum && !((score <= 0) || (score > 100)))
            //    {
            //        string passLevel = "";

            //        passLevel = ((score >= 80) && (score <= 100)) ? "A" : ((score >= 70) && (score < 80)) ? "B" : ((score >= 60) && (score < 70)) ? "C" : "D";
            //        //用三元運算子 去給等級


            //        switch (passLevel)
            //        {
            //            case "A":
            //                Console.WriteLine("你輸入的分數 " + score + " A   >= 80) && (score <= 100");
            //                break;

            //            case "B":
            //                Console.WriteLine("你輸入的分數 " + score + " B   >= 70) && (score < 80");
            //                break;

            //            case "C":
            //                Console.WriteLine("你輸入的分數 " + score + " C   >= 60) && (score < 70");
            //                break;

            //            case "D":
            //                Console.WriteLine("你輸入的分數 " + score + " ，GG! 不及格");
            //                break;
            //            default:
            //                Console.WriteLine("ohoh");
            //                break;

            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("請輸入數字   範圍0-100");
            //    }
            //    Console.ReadLine();
            //}

            //測試Func Llamda 寫今天是今年的第幾天 也許可以寫是今年的第幾周
            Console.WriteLine("請輸入deadline日期 如 2022-1-31");
            Func<DateTime, double> spantime = dt => Math.Ceiling((dt-DateTime.Now ).TotalDays);
           
            DateTime settime;
            bool isDateTime = DateTime.TryParse(Console.ReadLine(),out settime);
            if (isDateTime)
            {
                double manyDay = spantime(settime);
                if (manyDay>=0)
                {
                    Console.WriteLine("今天是今年的第 "+ DateTime.Now.DayOfYear+
                        "天,現在距離您目標完成的天數還有 "+manyDay++ +" 天");
                }
                else Console.WriteLine("格式不正確");
            }
            else Console.WriteLine("格式不正確");

            Console.ReadKey();
                
        }

     
    }
}
