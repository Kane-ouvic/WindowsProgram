using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int size;
            int amount;
            int bomb_x;
            int bomb_y;
            int[,] direction = new int[8,2]{ {-1,-1}, {0,-1}, {1,-1}, {-1,0}, {1,0}, {-1,1}, {0,1}, {1,1}};
            Console.Write("地圖大小(1~10):");
            try
            {
                size = int.Parse(Console.ReadLine());
            } catch(FormatException e)
            {
                Console.WriteLine("請輸入範圍內的整數");
                Console.ReadKey();
                return;
            }

            if(size >= 11 || size <= 0)
            {
                Console.WriteLine("超出範圍");
                Console.ReadKey();
                return;
            }
            Console.Write("地雷數量(1~10):");
            try
            {
                amount = int.Parse(Console.ReadLine());
            } catch (FormatException e)
            {
                Console.WriteLine("請輸入範圍內的整數");
                Console.ReadKey();
                return;
            }

            if (amount >= 11 || amount <= 0)
            {
                Console.WriteLine("超出範圍");
                Console.ReadKey();
                return;
            }
            int[,] map = new int[size, size];

            for (int i = 0; i < amount; i++)
            {
                Console.Write("第 " + i + " 個地雷的位置(以空白區隔):");
                string bomb = Console.ReadLine();
                string[] bomb_location_s = bomb.Split(' ');
                int[] bomb_location = new int[2];
                try
                {
                    bomb_location[0] = Convert.ToInt32(bomb_location_s[0]);
                    bomb_location[1] = Convert.ToInt32(bomb_location_s[1]);
                } catch (FormatException e)
                {
                    Console.WriteLine("請輸入兩個以空白區隔的整數");
                    Console.ReadKey();
                    return;
                }

                if (!checkOver(bomb_location[0], bomb_location[1], size))
                {
                    Console.WriteLine("地雷位置超出範圍");
                    Console.ReadKey();
                    return;
                }

                bomb_x = bomb_location[0];
                bomb_y = bomb_location[1];

                map[bomb_x, bomb_y] = 9;

                for(int j = 0; j < 8; j++)
                {
                    if(checkOver(bomb_x+direction[j,0], bomb_y+direction[j,1], size))
                    {
                        map[bomb_x + direction[j, 0], bomb_y + direction[j, 1]]++;
                    }
                }
            }
            Console.WriteLine("---");
            for(int i=0; i < size; i++)
            {
                for(int j=0; j < size; j++)
                {
                    if(map[j,i] < 9)
                    {
                        Console.Write(map[j, i]);
                    } else
                    {
                        Console.Write("X");
                    }
                }
                Console.WriteLine();
            }

            //Console.WriteLine(map[0,1]);

            Console.ReadKey();
        }

        static bool checkOver(double x, double y, int size)
        {
            if(x >= 0 && y >= 0 && x < size && y < size)
            {
                return true;
            } else {
                return false;
            }
            
        }
  
        /*static bool checkFloat(double x, double y)
        {
            if(x%1 == 0 && y%1 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
    }
}
