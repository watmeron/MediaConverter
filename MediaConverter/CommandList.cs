using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;

/*
 * コマンド実行を管理
 */

namespace MediaConverter
{
    class CommandData
    {
        String TitleLocal, DescriptionLocal;        //説明
        String TitleEn, DescriptionEn;              //英語の説明
        List<String> CommandList;                   //コマンドリスト

        CommandData()
        {
            CommandList = new List<string>();
        }

        public override string ToString()
        {
            String OutStr = "";

            OutStr += "Title Local: " + TitleLocal + "\n";
            OutStr += "Discription Local: " + DescriptionLocal + "\n";
            OutStr += "Title English: " + TitleEn + "\n";
            OutStr += "Discription English: " + DescriptionEn + "\n";

            OutStr += CommandList.ToString();

            return OutStr;
        }
    }
    
    class CommandList
    {

        public List<String> Commands;               //実行するコマンドの元の文字列

        public List<CommandData> CmData;            //コマンドデータ

        //必要な置換をする正規表現リスト
        public List<Tuple<String, String>> ReplaceRegulExpress;


        public CommandList()
        {
            Commands = new List<String>();
            Commands.Add("sleep");

            ReplaceRegulExpress = new List<Tuple<string, string>>();

            CmData = new List<CommandData>();

            //デフォルトで置換する表現のリストをあらかじめ入れておく
            ReplaceRegulExpress.Add(new Tuple<string, string>("<%InputFile%>", "None"));
            ReplaceRegulExpress.Add(new Tuple<string, string>("<%OutputFolder%>", "None"));
            ReplaceRegulExpress.Add(new Tuple<string, string>("<%OutputFile%>", "Out"));
        }

        //入力ファイルのパスをセットする
        public void SetInputFileName(MediaFiles mf)
        {
            if (!File.Exists(mf.Name))
            {
                //存在しないファイルが指定されたら例外を投げる
                throw new FileNotFoundException();
            }

            int Index = (int)ReplaceRegulExpress.FindIndex(Dat => Dat.Item1 == "<%InputFile%>");
            if(Index >= 0)
            {
                ReplaceRegulExpress.RemoveAt(Index);
            }

            ReplaceRegulExpress.Add(new Tuple<String, String>("<%InputFile%>", mf.Name));

            return;
        }

        //出力ファイルのファイル名をセットする
        public void SetOutputFileName(String OutFileName)
        {
            int Index = (int)ReplaceRegulExpress.FindIndex(Dat => Dat.Item1 == "<%OutputFile%>");
            if (Index >= 0)
            {
                ReplaceRegulExpress.RemoveAt(Index);
            }
            ReplaceRegulExpress.Add(new Tuple<String, String>("<%OutputFile%>", OutFileName));

            return;
        }

        //出力するフォルダ名をセットする
        public void SetOutputFolder(String FolderPath)
        {
            if (!File.Exists(FolderPath))
            {
                //再帰的にディレクトリを作成する
                try
                {
                    Directory.CreateDirectory(FolderPath);
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);

                    //エラーダイアログを出す
                    //MessageBox.Show("間違ったパス指定です\n" + e.ToString(), "エラー",
                    //    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;

                    //または例外を投げる
                    throw e;
                }
            }

            int Index = (int)ReplaceRegulExpress.FindIndex(Dat => Dat.Item1 == "<%OutputFolder%>");
            if (Index >= 0)
            {
                ReplaceRegulExpress.RemoveAt(Index);
            }
            ReplaceRegulExpress.Add(new Tuple<String, String>("<%OutputFolder%>", FolderPath));

            return;
        }

        //置換済みのコマンドを返す
        public String ReplacedCommand(int CommandIndex)
        {
            String OutCommand = Commands[CommandIndex];

            //ファイルに関する置換


            //その他の置換
            foreach(Tuple<String, String> str in ReplaceRegulExpress)
            {
                OutCommand = Regex.Replace(OutCommand, str.Item1, str.Item2);
            }

            return OutCommand;
        }

        public List<String> GetAllCommandsName()
        {
            List<String> return_list = new List<string>();
            foreach(var c in Commands)
            {
                return_list.Add(c.Split(' ')[0]);
            }
            return return_list;
        }

        //コマンドをiniファイルから読み込む
        public int ReadCommandsFromFile(String FileName)
        {
            System.Diagnostics.Debug.WriteLine(System.IO.Directory.GetCurrentDirectory());
            System.Diagnostics.Debug.WriteLine(FileName);

            if (!File.Exists(FileName))
            {
                //存在しないファイルが指定されたら例外を投げる
                System.Diagnostics.Debug.WriteLine("Unknown File.");
                throw new FileNotFoundException();
            }

            HandmadeIniFile iniFile = new HandmadeIniFile(FileName);

            String infoTitle = iniFile.Read("Info", "Title");
            System.Diagnostics.Debug.WriteLine(infoTitle);

            infoTitle = iniFile.Read("Item0", "Title");
            System.Diagnostics.Debug.WriteLine(infoTitle);

            String Command0 = iniFile.Read("Item0", "Command0");
            System.Diagnostics.Debug.WriteLine(Command0);

            return 0;
        }

        // 置換する文字列をファイルから読み込む
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
                    //Match m = Regex.Match(line, "(?<rep>(\".*?\"|^\"*?)):(?<torep>\".*?\"|^\"*?)");
                    Match m = Regex.Match(line, "(?<rep>.*):(?<torep>.*)");
                    System.Diagnostics.Debug.WriteLine(m.Groups["rep"].ToString());
                    System.Diagnostics.Debug.WriteLine(m.Groups["torep"].ToString());
                }
            }

            return 0;
        }
    }
}
