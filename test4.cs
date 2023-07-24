// paiza　C#練習問題
// 10000 以上かつ 13 で割り切れるような最小の自然数を求める。

using System;
class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = Console.ReadLine();
        int N = 10000 / 13;
        int check = N + 1;
        
        Console.WriteLine(13 * check);
    }
}