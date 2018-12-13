/*
 * 
 * ファイルの基本的な情報を保持するクラス
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaConverter
{
    public class MediaFiles
    {
        public String Name;         //ファイル名

        private String ScreenName;   //リストに表示する名前

        public MediaFiles()
        {
            Name = "";
            ScreenName = "";
        }

        /*
         *  拡張子を除いた名前を返す
         */
        public String GetBasename()
        {
            return System.IO.Path.GetFileNameWithoutExtension(Name);
        }

        /*
         * ScreenNameを返す
         */
         public String GetScreenName()
        {
            if(ScreenName.Length > 0)
            {
                return ScreenName;
            }
            else
            {
                return GetBasename();
            }
        }

        /*
         *  BasenameでないScreenNameをセットする
         */
         public void SetScreenName(String Name)
        {
            ScreenName = Name;
            return;
        }

    }
}
