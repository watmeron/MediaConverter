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

        public OptionData()
        {
            parrallel_num = 1;
        }

        
        public override string ToString()
        {
            String str = "";

            str += "parrallel_num: " + parrallel_num.ToString();

            return str;
        }
    }
}
