using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateNow = DateTime.Now;
            //Console.Write("{0}年 {1}月\n", dateNow.Year, dateNow.Month);
            //Console.ReadLine();

            DateTime dateFirst = DateTime.Parse(String.Format("{0}/{1}/1", dateNow.Year,
                dateNow.Month));
            //DisplayCalender(dateFirst);
            Console.ReadLine();
        }
        static void DisplayCalender(DateTime dateFirst)
        {
            int week;
            int month = dateFirst.Month;

            Console.Write("-----------------\n");
            Console.Write("日 月 火 水 木 金 土\n");

            for (week = 0; week < (int)dateFirst.DayOfWeek; week++) 
                Console.Write("   ");

            while(month==dateFirst.Month)
            {
                for(; week<7&&month==dateFirst.Month;week++)
                {
                    Console.Write("{0,2} ", dateFirst.Day);
                    dateFirst = dateFirst.AddDays(1);
                }
                Console.Write("\n");
                week = 0;
            }
            
        }
    }
}
