using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getDay
{
    class Program
    {
        static void Main(string[] args)
        {

            //測試Func Llamda 寫今天是今年的第幾天 也許可以寫是今年的第幾周
            Console.WriteLine("請輸入deadline日期 如 2022-1-31");
            Func<DateTime, double> spantime = dt => Math.Ceiling((dt - DateTime.Now).TotalDays);

            DateTime settime;
            bool isDateTime = DateTime.TryParse(Console.ReadLine(), out settime);
            if (isDateTime)
            {
                double manyDay = spantime(settime);
                if (manyDay >= 0)
                {
                    Console.WriteLine("今天是今年的第 " + DateTime.Now.DayOfYear +
                        "天,現在距離您目標完成的天數還有 " + manyDay++ + " 天");
                }
                else Console.WriteLine("格式不正確");
            }
            else Console.WriteLine("格式不正確");

            Console.ReadKey();

        }
    }
}
