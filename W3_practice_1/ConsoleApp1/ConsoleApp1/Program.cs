using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            int startDay;
            int day = 0;
            int startMonth;
            int count = 0;
            string[] weekDays = new string[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            string[] months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int[] months_day = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] count_day = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

            Console.Write("1月1日星期幾(1~7): ");
            startDay = int.Parse(Console.ReadLine());
            Console.Write("從幾月開始(1~12): ");
            startMonth = int.Parse(Console.ReadLine());

            for(int i = 1; i < 12; i++)
            {
                count_day[i] = count_day[i-1] + months_day[i-1];
                //Console.WriteLine(count_day[i]);
                //Console.WriteLine((startDay + count_day[i])%7);
            }
            //Console.WriteLine(count);
            //Console.WriteLine(count%7);
            for (int i = startMonth-1; i < 12; i++)
            {

                day = (startDay + count_day[i]) % 7;
                if (day == 0)
                {
                    day = 7;
                }
                Console.WriteLine(months[i]);
                for(int j=0; j < 7; j++)
                {
                    Console.Write(weekDays[j] + " ");
                }
                Console.WriteLine();

                for(int j=0; j < (day-1) ; j++)
                {
                    Console.Write("    ");
                }
                for(int j=0; j < months_day[i]; j++)
                {
                    Console.Write("{0,3:###}", j + 1);
                    Console.Write(" ");
                    if((((j + (startDay+count_day[i])%7))%7 == 0 || j == (months_day[i] - 1)))
                    {
                        Console.WriteLine("\n");
                    }
                }
                if (startMonth > 1)
                {
                    count += months_day[i - 1];
                }
            }
            Console.ReadKey();
        }
    }
}
