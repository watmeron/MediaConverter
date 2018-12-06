using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaConverter
{
    class MediaFiles
    {
        public String Name;         //ファイル名
        public String ScreenName;   //リストに表示する名前
        public Boolean IsDummy;     //ダミーデータか
        public Boolean IsDeleted;   //データ削除されたか
        public Boolean IsFinished;  //データ処理が完了したか

        public MediaFiles()
        {
            Name = "";
            ScreenName = "";
            IsDummy = true;
            IsDeleted = false;
        }

    }
}
