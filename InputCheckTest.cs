using System;
using Commontools;

class InputCheckTest
{
    static int rMin = 1;   //半径の最小値
    static int rMax = 100; //半径の最大値
    static int hMin = 1;   //高さの最小値
    static int hMax = 300; //高さの最大値
    static void Main(string[] args)
    {
        float r = InputCheck.GetNumber("半径", rMin, rMax);
        float h = InputCheck.GetNumber("高さ", hMin, hMax);
        float s = 0; //底面積
        float v = 0; //体積
        s = GetCircleSurface(r);
        v = GetCylinderVolume(r, h);
        Console.WriteLine("底面積は{0},体積は{1}", s, v);
    }

    static float GetCircleSurface(float radius)
    {  //半径から円の面積を求める
        float surface = 0;
        //　ここに処理を追加
        surface = (float)Math.PI * radius * radius;
        return surface;
    }
    static float GetCylinderVolume(float radius, float height)
    {  //半径と高さから円柱の体積を求める
        float volume = GetCircleSurface(radius) * height;
        return volume;
    }
}

