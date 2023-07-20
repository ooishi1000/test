using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        Dictionary<string, string> Obj = new Dictionary<string, string>();
        var N = int.Parse(Console.ReadLine());
        
        for(var i = 0; i < N; i++) {
            var line = Console.ReadLine().Trim().Split(' ');
            Obj.Add(line[0], line[1]);
        }
        
        foreach(KeyValuePair<string, string> pair in Obj)
        {
            Console.WriteLine("{0} {1}", pair.Key, pair.Value);
        }
        
        
        
    }
}