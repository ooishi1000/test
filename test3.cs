//paizaC＃練習問題　連想配列のキー指定で値取り出し

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = Console.ReadLine();
        var N = int.Parse(Console.ReadLine());
        
        var Table = new Dictionary<string, string>();
        
        for(var i = 0; i < N; i++) {
            var name = Console.ReadLine().Trim().Split(' ');
            
            Table.Add(name[0], name[1]);
        }
        Console.WriteLine("{0} {1}", line, Table[line]);
    }
}