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
    public partial class Form : System.Windows.Forms.Form
    {
        int parrallel_num = 1;

        public Form()
        {
            InitializeComponent();
        }

        private void InputBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach(string file in files)
            {
                InputBox.Items.Insert(0, System.IO.Path.GetFileName(file));
                InputBox.Update();
            }
        }

        private void InputBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void timer_for_test_Tick(object sender, EventArgs e)
        {
            if(InputBox.Items.Count > 0)
            {
                label_Progress.Text = "実行中: "
                    + System.IO.Path.GetFileName(InputBox.Items[InputBox.Items.Count - 1].ToString());
                InputBox.Items.RemoveAt(InputBox.Items.Count - 1);
            }
            else
            {
                label_Progress.Text = "実行中: ";
            }
            InputBox.Update();
        }

        private void button_CommandOption_Click(object sender, EventArgs e)
        {
            OptionForm form2 = new OptionForm();
            form2.ShowDialog();

            this.parrallel_num = form2.parrallel_num;
            MessageBox.Show(this.parrallel_num.ToString());
            form2.Dispose();
        }
    }
}