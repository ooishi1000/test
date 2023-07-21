//paiza問題集　連想配列

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var Object = new Dictionary<string, string>()
        {
            {"Kyoko", "B"},
            {"Rio", "O"},
            {"Tsubame", "AB"},
            {"KurodaSensei", "A"},
            {"NekoSensei", "A"}
        };
        
        foreach(KeyValuePair<string, string>item in Object) {
            Console.WriteLine("{0} {1}", item.Key, item.Value);
        }
        
    }
}