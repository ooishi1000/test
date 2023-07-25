// paiza問題集 文字列の重複カウント C#

using System;
class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var s = Console.ReadLine();
        var t = Console.ReadLine();
        int sum = 0;
        
        for(var i = 0; i < t.Length - (s.Length - 1); i++) {
            
            
            if(t.Substring(i, s.Length) == s) {
                sum++;
            }
            else {
                continue;
            }
        }
        
        Console.WriteLine(sum);
    }
}