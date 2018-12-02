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
        public int parrallel_num = 1;

        public OptionForm()
        {
            InitializeComponent();

            //コンボボックスへの追加
            for(int i = 1; i <= 16; i *= 2)
            {
                comboBox_ParrallelNum.Items.Add(i);
            }
            comboBox_ParrallelNum.SelectedIndex = 0;
        }

        private void comboBox_ParrallelNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            parrallel_num = (int)comboBox_ParrallelNum.Items[comboBox_ParrallelNum.SelectedIndex];
        }
    }
}
