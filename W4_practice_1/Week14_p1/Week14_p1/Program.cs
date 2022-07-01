using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1_Money;
            int player2_Money;

           
            List<string> player1_card_color = new List<string>();
            List<string> player2_card_color = new List<string>();

            List<int> player1_card_number = new List<int>();
            List<int> player2_card_number = new List<int>();


            string[] poker_color = new string[4];
            poker_color[0] = "Spade"; poker_color[1] = "Heart";
            poker_color[2] = "Diamond"; poker_color[3] = "Club";
            int[] poker_number = new int[13] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            Random card = new Random();

            Console.Write("玩家1初始金錢: ");
            try
            {
                player1_Money = int.Parse(Console.ReadLine());
            } catch (FormatException e)
            {
                Console.WriteLine("請輸入正確格式");
                Console.ReadKey();
                return;
            }
            Console.Write("玩家2初始金錢: ");
            try
            {
                player2_Money = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("請輸入正確格式");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("-------------------------");

            //Console.WriteLine("{0}", card.Next(1,13));

            while (player1_Money > 0 && player2_Money > 0)
            {
                string color;
                int number;
                int player1_gamb;
                int player2_gamb;

                //
                for(int i=0; i < 2; i++)
                {
                    color = poker_color[card.Next(0, 3)];
                    number = poker_number[card.Next(0, 12)];
                    while(checkRepeat(player1_card_color, player1_card_number, color, number))
                    {
                        color = poker_color[card.Next(0, 3)];
                        number = poker_number[card.Next(0, 12)];
                    }
                    player1_card_color.Add(color);
                    player1_card_number.Add(number);

                }
                Console.Write("玩家1手牌: ");
                printCard(player1_card_color, player1_card_number);
                Console.WriteLine();
                Console.Write("玩家1目前點數: ");
                Console.WriteLine(getPoint(player1_card_number));
                Console.Write("玩家1目前金錢: ");
                Console.WriteLine(player1_Money);
                do
                {
                    Console.Write("請輸入下注金額: ");
                    try
                    {
                        player1_gamb = int.Parse(Console.ReadLine());
                    } catch (FormatException e)
                    {
                        Console.WriteLine("請輸入正確格式");
                        Console.ReadKey();
                        return;
                    }
      
                    if (player1_gamb <= 0)
                    {
                        Console.WriteLine("金錢不能為零，請重新輸入!");
                    }
                    if(player1_gamb > player1_Money)
                    {
                        Console.WriteLine("金錢不足，請重新輸入!");
                    }
                } while (player1_gamb <= 0 || player1_gamb > player1_Money);

                //

                //
                for (int i = 0; i < 2; i++)
                {
                    color = poker_color[card.Next(0, 3)];
                    number = poker_number[card.Next(0, 12)];
                    while (checkRepeat(player2_card_color, player2_card_number, color, number))
                    {
                        color = poker_color[card.Next(0, 3)];
                        number = poker_number[card.Next(0, 12)];
                    }
                    player2_card_color.Add(color);
                    player2_card_number.Add(number);

                }
                Console.Write("玩家2手牌: ");
                printCard(player2_card_color, player2_card_number);
                Console.WriteLine();
                Console.Write("玩家2目前點數: ");
                Console.WriteLine(getPoint(player2_card_number));
                Console.Write("玩家2目前金錢: ");
                Console.WriteLine(player2_Money);
                Console.Write("請輸入下注金額: ");
                do
                {
                    Console.Write("請輸入下注金額: ");
                    try
                    {
                        player2_gamb = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("請輸入正確格式");
                        Console.ReadKey();
                        return;
                    }

                    if (player1_gamb <= 0)
                    {
                        Console.WriteLine("金錢不能為零，請重新輸入!");
                    }
                    if (player2_gamb > player2_Money)
                    {
                        Console.WriteLine("金錢不足，請重新輸入!");
                    }
                } while (player2_gamb <= 0 || player2_gamb > player2_Money);
                //
                char choice;
                bool win = false;

                    do
                    {
                        Console.Write("玩家1行動(輸入1抽1張牌、輸入P停止抽牌)");
                        choice = char.Parse(Console.ReadLine());
                        if (choice == 'P' ) break;
                        Console.WriteLine("-------------");
                        color = poker_color[card.Next(0, 3)];
                        number = poker_number[card.Next(0, 12)];
                        while (checkRepeat(player1_card_color, player1_card_number, color, number))
                        {
                            color = poker_color[card.Next(0, 3)];
                            number = poker_number[card.Next(0, 12)];
                        }
                        player1_card_color.Add(color);
                        player1_card_number.Add(number);
                        Console.Write("玩家1手牌: ");
                        printCard(player1_card_color, player1_card_number);
                        Console.WriteLine();
                        Console.WriteLine("玩家1目前點數: " + getPoint(player1_card_number));

                        if (checkOver21(getPoint(player1_card_number)))
                        {
                            player1_Money -= player1_gamb;
                            player2_Money += player1_gamb;
                            Console.WriteLine("玩家1爆了，玩家2獲勝!");
                            Console.WriteLine();
                            Console.WriteLine("玩家2獲勝，獲得" + player1_gamb + "金錢");
                            Console.WriteLine("-------------");
                            win = true;
                            break;
                        }

                    } while (choice == '1');


                    do
                    {
                        if (win) break;
                        Console.Write("玩家2行動(輸入1抽1張牌、輸入P停止抽牌)");
                        choice = char.Parse(Console.ReadLine());
                        if (choice == 'P') break;
                        Console.WriteLine("-------------");
                        color = poker_color[card.Next(0, 3)];
                        number = poker_number[card.Next(0, 12)];
                        while (checkRepeat(player2_card_color, player2_card_number, color, number))
                        {
                            color = poker_color[card.Next(0, 3)];
                            number = poker_number[card.Next(0, 12)];
                        }
                        player2_card_color.Add(color);
                        player2_card_number.Add(number);
                        Console.Write("玩家2手牌: ");
                        printCard(player2_card_color, player2_card_number);
                        Console.WriteLine();
                        Console.WriteLine("玩家2目前點數: " + getPoint(player2_card_number));
                        if (checkOver21(getPoint(player2_card_number)))
                        {
                            player1_Money += player2_gamb;
                            player2_Money -= player2_gamb;
                            Console.WriteLine("玩家2爆了，玩家1獲勝!");
                            Console.WriteLine();
                            Console.WriteLine("玩家1獲勝，獲得" + player2_gamb + "金錢");
                            Console.WriteLine("-------------");
                            win = true;
                            break;
                        }

                    } while (choice == '1');

                if (!win)
                {
                    if(getPoint(player1_card_number) > getPoint(player2_card_number))
                    {
                        player1_Money += player2_gamb;
                        player2_Money -= player2_gamb;
                        Console.WriteLine("玩家1獲勝，獲得" + player2_gamb + "金錢");
                        Console.WriteLine("-------------");
                    } else if(getPoint(player1_card_number) < getPoint(player2_card_number))
                    {
                        player1_Money -= player1_gamb;
                        player2_Money += player1_gamb;
                        Console.WriteLine("玩家2獲勝，獲得" + player1_gamb + "金錢");
                        Console.WriteLine("-------------");
                    } else
                    {
                        Console.WriteLine("平手! 拿回各自的錢");
                        Console.WriteLine("-------------");
                    }
                }

                player1_card_color.RemoveRange(0, player1_card_color.Count);
                player1_card_number.RemoveRange(0, player1_card_number.Count);
                player2_card_color.RemoveRange(0, player2_card_color.Count);
                player2_card_number.RemoveRange(0, player2_card_number.Count);

                //player1_card_color.Add(poker_color[card.Next(0, 3)]);
                //player1_card_number.Add(poker_number[card.Next(0, 12)]);

            }

            Console.ReadKey();
        }

        static bool checkRepeat(List<string> color, List<int> number, string random_color, int random_number)
        {
            for(int i = 0; i < color.Count; i++)
            {
                if(color[i].Equals(random_color) &&  number[i] == random_number)
                {
                    return true;
                }
            }
            return false;
        }

        static void printCard(List<string> color, List<int> number)
        {
            for(int i = 0; i < color.Count; i++)
            {
                Console.Write(color[i] + " " + number[i]);
                if(i != color.Count - 1 ) Console.Write(", ");
            }


        }

        static bool checkOver21(int point)
        {
            if(point > 21)
            {
                return true;
            }
            return false;
        }

        static int getPoint(List<int> number)
        {
            int one_count = 0;
            int sum = 0;
            for(int i = 0; i < number.Count; i++)
            {
                if (number[i] == 1) one_count++;

                if(number[i] < 11)
                {
                    sum += number[i];
                } else {
                    sum += 10;
                }
  
            }

            for (int i = 0; i < one_count; i++)
            {
                if (sum + 10 <= 21)
                {
                    sum += 10;
                }
                else
                {
                    break;
                }
            }
            return sum;
        }
        
    }
}
