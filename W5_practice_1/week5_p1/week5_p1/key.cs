using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5_p1
{
    class Key
    {
        public String Alphabet(String alphabet)
        {
            char[] alphabet_chars = alphabet.ToCharArray();
            char[] temp = new char[alphabet_chars.Length];
            int[] choose = new int[alphabet_chars.Length];
            Random rand = new Random();

            /*for(int i = 0; i < temp.Length; i++)
            {
                temp[i] = alphabet_chars[i];
            }*/

            for(int i = 0; i < temp.Length; i++)
            {
                int x, y;
                char t;
                x = rand.Next(0, temp.Length);
                do
                {
                    y = rand.Next(0, temp.Length);
                    temp[i] = alphabet_chars[y];
                } while (temp[i] == alphabet_chars[i] || choose[y] > 0);
                choose[y]++;
                
            }

            String result = new String(temp);

            return result;
        }
        public String Substitution;
        public String Generate;

        public bool IsValid(String alphabet, String alphabet_transform)
        {
            char[] alphabet_chars = alphabet.ToCharArray();
            char[] alphabet_transform_chars = alphabet_transform.ToCharArray();
            int[] checklist = new int[alphabet_chars.Length];
            char check_alpha;

            if (alphabet_chars.Length != alphabet_transform_chars.Length) //檢查大小
            {
                return false;
            }

            check_alpha = alphabet_transform_chars[0];

            for(int i = 0; i < alphabet_transform_chars.Length; i++) //檢查有沒有重複
            {
                /*check_alpha = alphabet_transform_chars[i];
                for (int j = i+1; j < alphabet_transform_chars.Length; j++)
                {
                    if (alphabet_transform_chars[j] == check_alpha) return false;
                }*/
                for(int j = 0; j < alphabet_chars.Length; j++)
                {
                    if (alphabet_transform_chars[i] == alphabet_chars[j]) checklist[j]++;
                }
                
            }

            for(int i = 0; i < checklist.Length; i++)
            {
                if (checklist[i] != 1) return false;
            }

            for(int i = 0; i < alphabet_transform_chars.Length ; i++) //檢查有沒有相對應的字母一樣
            {
                if (alphabet_chars[i] == alphabet_transform_chars[i])
                {
                    return false;
                }
            }

            return true;

        }
        public String Encrypt(String alphabet, String alphabet_transform, String message)
        {
            char[] alphabet_chars = alphabet.ToCharArray();
            char[] alphabet_transform_chars = alphabet_transform.ToCharArray();
            char[] message_chars = message.ToCharArray();

            for(int i = 0; i < message_chars.Length; i++)
            {
                for(int j = 0; j < alphabet_chars.Length; j++)
                {
                    if(message_chars[i] == alphabet_chars[j])
                    {
                        message_chars[i] = alphabet_transform_chars[j];
                        break; //關鍵
                    }
                }
            }
            String result = new String(message_chars);
            return result;

        }
        public String Decrypt(String alphabet, String alphabet_transform, String message)
        {
            char[] alphabet_chars = alphabet.ToCharArray();
            char[] alphabet_transform_chars = alphabet_transform.ToCharArray();
            char[] message_chars = message.ToCharArray();

            for (int i = 0; i < message_chars.Length; i++)
            {
                for (int j = 0; j < alphabet_transform_chars.Length; j++)
                {
                    if (message_chars[i] == alphabet_transform_chars[j])
                    {
                        message_chars[i] = alphabet_chars[j];
                        break;
                    }
                }
            }
            String result = new String(message_chars);
            return result;
        }

       

     

    }
}
