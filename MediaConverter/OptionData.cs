using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 変換に必要なオプションを格納する
 */

namespace MediaConverter
{
    public class OptionData
    {
        public int parrallel_num;      //バッチの並列実行数
        public Boolean IsScreenNameFullPath;    //ファイル名をフルパスで表示するか

        public OptionData()
        {
            parrallel_num = 1;
            IsScreenNameFullPath = false;
        }

        
        public override string ToString()
        {
            String str = "";

            str += "parrallel_num: " + parrallel_num.ToString();
            str += "screen name is full path: " + IsScreenNameFullPath.ToString();

            return str;
        }

        public OptionData Clone()   // 必須 ICloneableのMemberwiseClone();にてコピーを行う
        {
            return (OptionData)MemberwiseClone();
        }
    }
}
