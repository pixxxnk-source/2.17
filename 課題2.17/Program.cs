using System;

class Program
{
    static void Main()
    {
        //Hello Worldを出力する
        Console.WriteLine("Hello, World!");

        //文字列の結合
        Console.Write("文字列１を入力：");
        string str1 = Console.ReadLine();

        Console.Write("文字列２を入力：");
        string str2 = Console.ReadLine();

        string result = str1 + str2;
        Console.WriteLine("出力：" + result);
    }
}
