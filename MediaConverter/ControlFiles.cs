﻿/*
 * 
 * 処理ファイルリストを管理するクラス
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MediaConverter
{
    public class FilesForCovert : MediaFiles
    {
        public readonly int Id;             //プロセス中でユニークなID
        public Boolean IsDummy, IsDeleted;  //ダミーデータか、削除済みデータか
        public readonly int Status;         //データのステータス

        public FilesForCovert(int NewId)
        {
            Id = NewId;
            IsDummy = false;
            IsDeleted = false;

            Status = (int)DataTypes.Standby;
            return;
        }

    }

    public enum DataTypes : int
    {
        Standby = 100,          //処理待ち
        Proccessing,            //処理中
        Finished,               //フィルタの処理中
        Filtering               //終了
    }

    public class ControlFiles
    {
        private List<FilesForCovert> Data;       //ファイルデータ
        private int RefCount;                    //ファイルを連続しての参照用
        public int Count;                        //データ数

        private CommandList cdl;                         //コマンド関連クラス
        public FilterData fd;

        public ControlFiles()
        {
            Data = new List<FilesForCovert>();

            Count = 0;

            RefCount = 0;

            //iniファイル読み込み
            cdl = new CommandList();
            cdl.ReadRegexFromFile("..\\..\\ReplaceExpressions.txt");
            cdl.ReadCommandsFromFile("..\\..\\Transcode.ini");

            //デフォルトのコマンドを設定
            fd = new FilterData();
            fd.cmd = cdl.CmData[0];
        }

        /*
         * データ数を返す
         */

        /*
         *  ファイルを新規に追加する
         */
        public int AddFile(String Path)
        {
            FilesForCovert NewData = new FilesForCovert(Data.Count + 1);

            NewData.Name = Path;
            if (!File.Exists(Path))
            {
                //存在しないファイルが指定されたら例外を投げる
                throw new FileNotFoundException();
            }

            Data.Add(NewData);

            Count = Data.Count;

            return 0;
        }

        /*
         * IDからデータを取得する関数
         */
        private FilesForCovert FindDataFromId(int SearchId)
        {
            return Data.Find(x => x.Id == SearchId);
        }

        /*
         * 全データを取得する関数
         * c: 参照するインデックス
         */
         public FilesForCovert GetNextData(int c = 0)
        {
             int RefData = RefCount;
             RefCount++;

             if(c != 0)
             {
                 RefCount = c;
             }

             return Data[RefData];
        }

        /*
         * リストの最後のデータを返す
         */
         public FilesForCovert GetLastData()
         {
             if (Data.Count > 0)
             {
                 return Data.Last();
             }
             else
             {
                 return null;
             }
         }

        /*
         * 一致する条件のデータを検索
         */
        public List<FilesForCovert> GetMatchList(Func<FilesForCovert, Boolean> func)
        {
            return Data.Where(func).ToList();
        }

        /*
         * コマンドリストを返す
         */
        public List<String> GetAllCommandScreenName()
        {
            return cdl.GetAllCommandsName();
        }

        /*
         * フィルタリストを返す
         */
        public List<String> GetAllFilterName()
        {
            List<String> l = new List<String>();
            l.Add(fd.cmd.ToString());
            return l;
        }

    }
}
