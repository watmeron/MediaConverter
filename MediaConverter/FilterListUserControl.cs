using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaConverter
{
    public partial class FilterListUserControl : UserControl
    {
        public FilterListUserControl()
        {
            InitializeComponent();
        }

        //イベントハンドラ
        public delegate void MyEventHandler(EventArgs e);
        public event MyEventHandler MyProgressEvent;

        public void SomethingChanged()
        {
            MyProgressEvent(new EventArgs());
            return;
        }

        public void SetCommandData(List<String> list)
        {
            CommandBox.Items.Clear();

            foreach(String str in list)
            {
                CommandBox.Items.Add(str);
            }
        }

        public void SetBranchType(List<String> list)
        {
            BranchTypeBox.Items.Clear();

            foreach (String str in list)
            {
                BranchTypeBox.Items.Add(str);
            }
        }

        private void BranchTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("BranchTypeBox changed : " + BranchTypeBox.Text);

            if(BranchTypeBox.SelectedIndex == 0)
            {
                // コマンドのコマンドボックスを選べるようにするか
                CommandBox.SelectedIndex = -1;
                CommandBox.Enabled = true;
            }
            else
            {
                CommandBox.Enabled = false;

                // 新しいコントロールの追加
            }

            SomethingChanged();
            return;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("TextBox changed : " + textBox1.Text);

            SomethingChanged();
        }

        private void CommandBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Command changed : " + CommandBox.SelectedIndex);

            // Tooltipの文字列を変更
            if(CommandBox.SelectedIndex >= 0)
            {
                toolTip1.SetToolTip(CommandBox, CommandBox.Items[CommandBox.SelectedIndex].ToString());
            }
            else
            {
                toolTip1.SetToolTip(CommandBox, "");
            }

            SomethingChanged();
            return;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            if(CommandBox.SelectedIndex >= 0 && CommandBox.SelectedIndex >= 0)
            {
                System.Diagnostics.Debug.WriteLine(CommandBox.Items[CommandBox.SelectedIndex].ToString());
                System.Diagnostics.Debug.WriteLine(toolTip1.ToString());
            }

            SomethingChanged();
            return;
        }
    }
}
