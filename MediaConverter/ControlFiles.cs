/*
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
    class FilesForCovert : MediaFiles
    {
        public readonly int Id;             //プロセス中でユニークなID
        public Boolean IsDummy, IsDeleted;  //ダミーデータか、削除済みデータか

        public FilesForCovert(int NewId)
        {
            Id = NewId;
            IsDummy = false;
            IsDeleted = false;
            return;
        }

    }

    enum DataTypes : int
    {
        Standby = 100,          //処理待ち
        Proccessing,            //処理中
        Finished,               //フィルタの処理中
        Filtering               //終了
    }

    class ControlFiles
    {
        private List<FilesForCovert> Data;       //ファイルデータ
        private int Count;                       //ファイルを連続しての参照用

        public ControlFiles()
        {
            Data = new List<FilesForCovert>();

            Count = 0;
        }

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
            int RefData = Count;
            Count++;

            if(c != 0)
            {
                Count = c;
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

    }
}
