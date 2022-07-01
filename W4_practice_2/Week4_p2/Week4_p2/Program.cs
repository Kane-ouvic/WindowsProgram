using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_p2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[5] { 0, 1, 2, 3, 4 };
            int start_x = 0, start_y = 0;
            int end_x = 0, end_y = 0;
            int size_x = 0, size_y = 0;
            //Test tes = new Test(9999);

            try
            {
                Console.Write("請輸入迷宮大小(底,高): ");
                string input = Console.ReadLine();
                string[] inputnum = input.Split(',');
                size_y = Convert.ToInt32(inputnum[0]);
                size_x = Convert.ToInt32(inputnum[1]);
            } catch(FormatException e)
            {
                Console.WriteLine("請輸入正確格式");
                Console.ReadKey();
                return;
            }
            

            char[,] map = new char[size_x,size_y];
            Map result_map = new Map(size_x, size_y);
            Map test_map = new Map(size_x, size_y);

            //Console.WriteLine(map.GetLength(0) + " " + map.GetLength(1));

            Console.WriteLine("輸入迷宮地圖:");


            for (int i = 0; i < map.GetLength(0); i++)
            {
                string input_map = Console.ReadLine();
                char[] insert_map = input_map.ToCharArray();
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = insert_map[j];
                    if(map[i,j] == '0')
                    {
                        start_x = i;
                        start_y = j;
                    }
                    if(map[i,j] == 'X')
                    {
                        end_x = i;
                        end_y = j;
                    }
                }
                //Console.WriteLine();
            }
            //

            copyMap(test_map.Test_map_array, map);


            test_map.Test_map_array[start_x, start_y] = ' ';
            test_map.Test_map_array[end_x, end_y] = ' ';
            visit(test_map, result_map, start_x, start_y, end_x, end_y);

            //Console.WriteLine(start_x + " " + start_y);
            //Console.WriteLine(end_x + " " + end_y);

            //copyMap(result_map.Test_map_array, map);

            if(result_map.counter - 2 < 0)
            {
                printMap(map, start_x, start_y, end_x, end_y);
                Console.WriteLine("沒有路徑");
            } else
            {
                //Console.WriteLine("Output:");
                printMap(result_map.Test_map_array, start_x, start_y, end_x, end_y);
                Console.WriteLine(result_map.counter - 2);
            }

 

            //Console.WriteLine(size_x + " " + size_y);
            //changeValue(y);
            //Console.Write(tes.getX());
            Console.ReadKey();
        }

        static void printMap(char[,] map, int start_x, int start_y, int end_x, int end_y)
        {
            map[start_x, start_y] = '0';
            map[end_x, end_y] = 'X';

            Console.WriteLine("Output:");
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
            //Console.WriteLine("-------------------");
        }

        static void copyMap(char[,] map1, char[,] map2)
        {
            for (int i = 0; i < map2.GetLength(0); i++)
            {
                for (int j = 0; j < map2.GetLength(1); j++)
                {
                    map1[i, j] = map2[i, j];
                }
            }
        }

        static void visit(Map test_map, Map result_map, int start_x, int start_y, int end_x, int end_y)
        {
            if(test_map.Test_map_array[start_x,start_y] == ' ')
            {
                test_map.counter++;
                test_map.Test_map_array[start_x, start_y] = '*';
                if(start_x == end_x && start_y == end_y)
                {
                    if(result_map.counter == 0)
                    {
                        copyMap(result_map.Test_map_array, test_map.Test_map_array);
                        result_map.counter = test_map.counter;
                    } else if(test_map.counter < result_map.counter){
                        copyMap(result_map.Test_map_array, test_map.Test_map_array);
                        result_map.counter = test_map.counter;
                    }
                } else
                {
                    if (start_x + 1 < test_map.Test_map_array.GetLength(0)) visit(test_map, result_map, start_x + 1, start_y, end_x, end_y);
                    if (start_x - 1 >= 0) visit(test_map, result_map, start_x - 1, start_y, end_x, end_y);
                    if(start_y + 1 < test_map.Test_map_array.GetLength(1)) visit(test_map, result_map, start_x, start_y + 1, end_x, end_y);
                    if (start_y - 1 >= 0) visit(test_map, result_map, start_x, start_y - 1, end_x, end_y);
                }
                test_map.counter--;
                test_map.Test_map_array[start_x, start_y] = ' ';
            }
        }


    }

    public class Map
    {
        public int counter = 0;
        public char[,] Test_map_array;
        public Map(int size_x, int size_y)
        {
            Test_map_array = new char[size_x, size_y];
        }

    }
}
