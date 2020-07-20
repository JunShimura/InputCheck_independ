using System;

namespace Commontools
{
    public class InputCheck
    {
        public static float GetNumber(string meaning, float min, float max)
        {
            float value;
            // 入力処理
            while (true)
            {
                Console.WriteLine("{0}は幾つですか？\n範囲は{1}から{2}", meaning, min, max);
                value = int.Parse(Console.ReadLine());
                if (value >= min && value < max)
                { //値は適正
                    break;
                }
                else
                {
                    Console.WriteLine("入力エラー");
                }
            }
            return value;
        }

        public static int GetNumber(string meaning, int min, int max)
        {
            int value;
            // 入力処理
            while (true)
            {
                Console.WriteLine("{0}は幾つですか？\n範囲は{1}から{2}", meaning, min, max);
                value = int.Parse(Console.ReadLine());
                if (value >= min && value < max)
                { //値は適正
                    break;
                }
                else
                {
                    Console.WriteLine("入力エラー");
                }
            }
            return value;
        }
    }
}

