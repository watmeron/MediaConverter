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
    [Browsable(true)]
    public partial class FilterSettingForm : Form
    {
        public FilterSettingForm(ControlFiles cs)
        {
            InitializeComponent();

            filterListUserControl1.SetCommandData(cs.GetAllCommandScreenName());

            List<String> list = new List<string>();
            List<int> keyList = new List<int>(cs.fd.ConditionStr.Keys);
            foreach(int key in keyList)
            {
                System.Diagnostics.Debug.WriteLine(key + " : " + cs.fd.ConditionStr[key]);

                list.Add(cs.fd.ConditionStr[key]);
            }
            filterListUserControl1.SetBranchType(list);
        }
    }
}
