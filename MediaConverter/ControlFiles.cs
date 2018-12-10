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

        public ControlFiles()
        {
            Data = new List<FilesForCovert>();
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

        private FilesForCovert FindDataFromId(int SearchId)
        {
            return Data.Find(x => x.Id == SearchId);
        }

    }
}
