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
        class TreeForms
        {
            public FilterListUserControl it = null;       //このフォーム自体
            public TreeForms[] next = { null, null };

            // コントロールを検索
            public TreeForms FindInTree(FilterListUserControl fc)
            {                
                if(this.it == fc)
                {
                    return this;
                }
                else if(this.next[0] == null && this.next[1] == null)
                {
                    return null;
                }
                else
                {
                    TreeForms[] sai_tf = new TreeForms[2];

                    sai_tf[0] = this.next[0].FindInTree(fc);
                    sai_tf[1] = this.next[1].FindInTree(fc);

                    if(sai_tf[0] == null && sai_tf[1] == null)
                    {
                        return null;
                    }
                    else
                    {
                        if (sai_tf[0] != null && sai_tf[1] == null)
                        {
                            return sai_tf[0];
                        }
                        else if(sai_tf[0] == null && sai_tf[1] != null)
                        {
                            return sai_tf[1];
                        }
                        else
                        {
                            //なんかおかしいzo
                            return null;
                        }
                    }
                }
            }
        }

        TreeForms tform;
        ControlFiles cs;

        public FilterSettingForm(ControlFiles ics)
        {
            InitializeComponent();

            cs = ics;

            filterListUserControl1.SetCommandData(cs.GetAllCommandScreenName());

            List<String> list = new List<string>();
            List<int> keyList = new List<int>(cs.fd.ConditionStr.Keys);
            foreach(int key in keyList)
            {
                System.Diagnostics.Debug.WriteLine(key + " : " + cs.fd.ConditionStr[key]);

                list.Add(cs.fd.ConditionStr[key]);
            }
            filterListUserControl1.SetBranchType(list);

            //いい感じに
            tform = new TreeForms();
            tform.it = filterListUserControl1;
            //tform.it.MyProgressEvent += new FilterListUserControl.MyEventHandler(SomethingHappenInFilterForm);
            tform.it.BranchTypeBox_Changed += new FilterListUserControl.MyEventHandler2(BranchTypeBox_Changed);
        }

        public void SomethingHappenInFilterForm(EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e + ":" + "Something Happen.");
            return;
        }

        public void BranchTypeBox_Changed(object obj, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(obj + ":" + e + ":" + "BranchTypeBox Changed.");

            // 値を返してきたコントロールを検索
            TreeForms tf = tform.FindInTree((FilterListUserControl)obj);
            System.Diagnostics.Debug.WriteLine(obj);

            if (tf == null)
            {
                System.Diagnostics.Debug.WriteLine("No.");
                return;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Yes.");
            }

            //
            if(tf.it.BranchTypeBox.SelectedIndex > 0)
            {
                // コントロールを追加・削除する
                if (tf.next[0] == null && tf.next[1] == null)
                {
                    // 追加する

                    List<String> list = new List<string>();
                    List<int> keyList = new List<int>(cs.fd.ConditionStr.Keys);
                    foreach (int key in keyList) list.Add(cs.fd.ConditionStr[key]);
                    filterListUserControl1.SetBranchType(list);

                    for (int i = 0; i < 2; i++)
                    {
                        tform.next[i] = new TreeForms
                        {
                            it = new FilterListUserControl()
                        };
                        tform.next[i].it.Left = tform.it.Left + 30;
                        tform.next[i].it.Top = tform.it.Top + 30 * (i+1);
                        tform.next[i].it.SetCommandData(cs.GetAllCommandScreenName());
                        tform.next[i].it.SetBranchType(list);
                        this.Controls.Add(tform.next[i].it);
                        tform.next[i].it.BranchTypeBox_Changed
                            += new FilterListUserControl.MyEventHandler2(BranchTypeBox_Changed);
                    }
                }
            }
            else if (tf.next[0] != null && tf.next[1] != null)
            {
                //削除する
                this.Controls.Remove(tf.next[0].it);
                this.Controls.Remove(tf.next[1].it);
                tf.next[0] = tf.next[1] = null;
            }

            return;
        }
    }
}
