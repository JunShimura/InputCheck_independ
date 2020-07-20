using System;

class InputCheck
{
    static public int GetNumber(string meaning = null, int min = 0, int max = int.MaxValue)
    {   //int型で動く
        int value;
        // 入力処理
        while (true)
        {
            Console.WriteLine("{0}は幾つですか？\n範囲は{1}から{2}", meaning, min, max);
            bool success = int.TryParse(Console.ReadLine(), out value);
            if (success && value >= min && value < max)
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
    static public float GetNumber(string meaning = null, float min = 0, float max = float.MaxValue)
    {  //float型で動く
        float value;
        // 入力処理
        while (true)
        {
            Console.WriteLine("{0}は幾つですか？\n範囲は{1}から{2}", meaning, min, max);
            bool success = float.TryParse(Console.ReadLine(), out value);
            if (success && value >= min && value < max)
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
    static public double GetNumber(string meaning = null, double min = 0, double max = double.MaxValue)
    {  //float型で動く
        double value;
        // 入力処理
        while (true)
        {
            Console.WriteLine("{0}は幾つですか？\n範囲は{1}から{2}", meaning, min, max);
            bool success = double.TryParse(Console.ReadLine(), out value);
            if (success && value >= min && value < max)
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
