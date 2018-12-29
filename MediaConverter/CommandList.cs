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
        public String TitleLocal, DescriptionLocal;        //説明
        public String TitleEn, DescriptionEn;              //英語の説明
        public List<String> CommandList;                   //コマンドリスト

        public CommandData()
        {
            CommandList = new List<string>();

            TitleLocal = new String("none.".ToCharArray());
            DescriptionLocal = new String("none.".ToCharArray());
            TitleEn = new String("none.".ToCharArray());
            DescriptionEn = new String("none.".ToCharArray());
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
        public String TitleLocal, DescriptionLocal;        //説明
        public String TitleEn, DescriptionEn;              //英語の説明

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

            /*
            foreach(var c in Commands)
            {
                return_list.Add(c.Split(' ')[0]);
            }
            */

            foreach (var c in CmData)
            {
                return_list.Add(c.TitleLocal);
                System.Diagnostics.Debug.WriteLine(c.TitleLocal);
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

            TitleLocal = iniFile.Read("Info", "Title");
            TitleEn    = iniFile.Read("Info", "TitleE");
            DescriptionLocal = iniFile.Read("Info", "Description");
            DescriptionEn = iniFile.Read("Info", "DescriptionE");

            System.Diagnostics.Debug.WriteLine(TitleLocal);
            System.Diagnostics.Debug.WriteLine(TitleEn);
            System.Diagnostics.Debug.WriteLine(DescriptionLocal);
            System.Diagnostics.Debug.WriteLine(DescriptionEn);

            String infoTitle = "";
            for(int i = 0; ; i++)
            {
                String thisSection = "Item" + i.ToString();

                infoTitle = iniFile.Read(thisSection, "Title");
                if (infoTitle.Length == 0) break;

                CommandData commandData = new CommandData();

                commandData.TitleLocal = infoTitle;
                commandData.TitleEn    = iniFile.Read(thisSection, "TitleE");
                commandData.DescriptionLocal = iniFile.Read(thisSection, "Description");
                commandData.DescriptionEn    = iniFile.Read(thisSection, "DescriptionE");

                //System.Diagnostics.Debug.WriteLine("title : " + infoTitle);

                for (int j = 0; ; j++)
                {
                    String Command0 = iniFile.Read(thisSection, "Command" + j.ToString());
                    if (Command0.Length == 0) break;

                    commandData.CommandList.Add(Command0);

                    //System.Diagnostics.Debug.WriteLine("Command" + j.ToString() + " : " + Command0);
                }

                CmData.Add(commandData);
            }
            

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
