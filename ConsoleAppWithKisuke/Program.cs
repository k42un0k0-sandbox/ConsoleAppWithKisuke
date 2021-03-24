using System;

namespace ConsoleAppWithKisuke
{
    /// <summary>
    /// クラス概要
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            Console.WriteLine(person.Statement);
            person.Statement = "こんにちは。" ;
            Console.WriteLine(person.Statement);

            Console.WriteLine("何かキーを押すと終了します。");
            Console.ReadKey();
        }
    }
}
