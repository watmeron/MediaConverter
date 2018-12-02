using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaConverter
{
    public partial class OptionForm : System.Windows.Forms.Form
    {
        private OptionData od;
        private IDictionary<int, int> map = new Dictionary<int, int>();

        public OptionForm()
        {
            InitializeComponent();

            //オプション用クラスの生成
            od = new OptionData();

            //コンボボックスへの追加
            for (int i = 0; i <= 4; i++)
            {
                int parrallelNum = (int)Math.Round(Math.Pow(2,i));
                System.Diagnostics.Debug.WriteLine(parrallelNum);

                map.Add(parrallelNum, i);
                
                comboBox_ParrallelNum.Items.Add(parrallelNum);
            }
            //comboBox_ParrallelNum.SelectedIndex = od.parrallel_num - 1;
            comboBox_ParrallelNum.SelectedIndex = map[od.parrallel_num];

        }

        public void SetOptionData(OptionData op_input)
        {
            od = op_input;
            comboBox_ParrallelNum.SelectedIndex = map[od.parrallel_num];
        }

        public OptionData GetOptionData()
        {
            return od;
        }

        private void comboBox_ParrallelNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            od.parrallel_num = (int)comboBox_ParrallelNum.Items[comboBox_ParrallelNum.SelectedIndex];
        }
    }
}
