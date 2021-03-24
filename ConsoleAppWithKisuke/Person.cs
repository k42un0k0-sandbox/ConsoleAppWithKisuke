﻿namespace ConsoleAppWithKisuke
{
    internal class Person
    {
        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public Person()
        {
            this.Statement = "おはよう。";
        }
        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="statement">発言内容の初期値を指定します。</param>
        public Person(string statement)
        {
            this.Statement = statement;
        }
        /// <summary>
        /// 発言内容を取得または設定します。
        /// </summary>
        public string Statement { get; set; }
    }
}
