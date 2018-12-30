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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("TextBox changed : " + textBox1.Text);
        }

        private void CommandBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Command changed : " + CommandBox.SelectedIndex);
            return;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            if(CommandBox.SelectedIndex >= 0)
            {
                System.Diagnostics.Debug.WriteLine(CommandBox.Items[CommandBox.SelectedIndex].ToString());

                /*
                toolTip1.SetToolTip(e.AssociatedControl,
                    CommandBox.Items[CommandBox.SelectedIndex].ToString());*/
            }
        }
    }
}
