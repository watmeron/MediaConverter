using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

/*
 * コマンド実行を管理
 */

namespace MediaConverter
{
    class CommandList
    {
        //コマンドの基本的な情報を格納するクラス
        private class CommandBaseData
        {
            public String CommandBaseExpression;    //基本的なコマンド
        }

        public List<String> Commands;               //実行するコマンドの元の文字列

        //必要な置換をする正規表現リスト
        public List<Tuple<String, String>> ReplaceRegulExpress;

        public CommandList()
        {
            Commands = new List<string>();
            Commands.Add("sleep");

            ReplaceRegulExpress = new List<Tuple<string, string>>();
        }

        //置換済みのコマンドを返す
        public String ReplacedCommand(int CommandIndex)
        {
            if(CommandIndex < Commands.Count)
            {
                return "";
            }

            String OutCommand = Commands[CommandIndex];

            foreach(Tuple<String, String> str in ReplaceRegulExpress)
            {
                OutCommand = Regex.Replace(OutCommand, str.Item1, str.Item2);
            }

            return OutCommand;
        }

        public int ReadRegexFromFile(String name)
        {
            System.Diagnostics.Debug.WriteLine(System.IO.Directory.GetCurrentDirectory());

            if (!File.Exists(name))
            {
                //存在しないファイルが指定されたら例外を投げる
                throw new FileNotFoundException();
            }

            using (StreamReader r = new StreamReader(name))
            {
                //1行ずつ
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    System.Diagnostics.Debug.WriteLine(line);

                    //MatchCollection matche = Regex.Matches(line, "\".*?\"");
                    Match m = Regex.Match(line, "(?<rep>(\".*?\"|^\"*?)):(?<torep>\".*?\"|^\"*?)");
                    System.Diagnostics.Debug.WriteLine(m.Groups["rep"].ToString());
                    System.Diagnostics.Debug.WriteLine(m.Groups["torep"].ToString());
                }
            }

            return 0;
        }
    }
}
