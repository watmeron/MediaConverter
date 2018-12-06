using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaConverter
{
    enum DataTypes : int
    {
        Standby = 100,          //処理待ち
        Proccessing,            //処理中
        Finished,               //フィルタの処理中
        Filtering               //終了
    }

    class ListedFiles : MediaFiles{
        public ulong Status;
        public int id;                      //初期化

        public ListedFiles(int uniq_id)
        {
            id = uniq_id;
            Status = (int)DataTypes.Standby;
        }
    }


    class ControlFiles
    {
        //入力された全ファイル
        private List<ListedFiles> Files = new List<ListedFiles>();

        public int push(MediaFiles ls)
        {
            ListedFiles f = new ListedFiles(Files.Count);
            if (f is MediaFiles)
            {
                f = (ListedFiles)ls;        //ファイルのデータをコピー
                Files.Add(f);
                return 0;
            }
            else
            {
                return 1;
            }
        }

        /*
         *  該当するステータスコードのファイルを取得 
         *  返り値: リスト
         */
        public List<ListedFiles> GetList(int Status)
        {
            List<ListedFiles> selected;

            if (Enum.IsDefined(typeof(DataTypes), Status)) {
                selected = (from f in Files where f.id == (int)Status
                            orderby f.id select f).ToList();
            }
            else {
                selected = new List<ListedFiles>();
            }

            return selected;
        }

        /*
         *  該当するIDのデータを処理リストから外す
         *  返り値: 該当があれば1, なければ-1
         */
        public int DeleteFile(int DelId)
        {
           if(Files.Exists(f => f.id == DelId))
           {
               Files.Find(f => f.id == DelId).IsDeleted = true;
               return 1;
           }
           else
           {
               return -1;
           }
        }

        /*
         * 該当するIDのデータを取得
         */
        private ref ListedFiles GetData(int id)
        {
            if(Files.Exists(n => n.id == id)){
                ListedFiles lf = Files.Find(n => n.id == id);
                return ref lf;
            }
            else
            {
                return null;
            }
        }

        /*
        * 該当するIDのステータスを変更
        *
        */
        public int ChangeStatus(int id, int NewStatus) {
            if(Enum.IsDefined(typeof(DataTypes), NewStatus))
            {

            }
        }
}
