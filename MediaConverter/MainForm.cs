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
    public partial class MainForm : Form
    {
        OptionData od;

        ShowFileList form_list;

        //すべてのファイル
        private ControlFiles cs;

        public MainForm()
        {
            InitializeComponent();

            od = new OptionData();

            //データ表示ウィンドウ
            form_list = new ShowFileList();
            form_list.Show();

            //すべてのファイルリストを確保
            cs = new ControlFiles();

            //コマンドリストを更新
            CommandListUpdate();
        }

        
        public MainForm(ControlFiles Ics, OptionData Iod)
        {
            InitializeComponent();

            od = Iod;

            //データ表示ウィンドウ
            form_list = new ShowFileList();
            form_list.Show();

            //すべてのファイルリストを確保
            cs = Ics;

            return;
        }



        //DDされたファイルを入力待ちキューに追加
        private void InputBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach(string file in files)
            {
                cs.AddFile(file);

                if (cs.GetLastData() != null)
                {
                    System.Diagnostics.Debug.WriteLine("File Input.");                    
                }
            }

            ProssessWaitListBoxUpdate();
            form_list.Update(cs);
        }

        //処理待ちファイルのリストを更新する関数
        private void ProssessWaitListBoxUpdate()
        {
            int beforeSelectedIndex = InputBox.SelectedIndex;

            InputBox.Items.Clear();

            //該当データをすべて表示
            List<FilesForCovert> item = cs.GetMatchList(
                p => p.Status == (int)DataTypes.Standby && p.IsDeleted == false);

            foreach (MediaFiles data in item){
                InputBox.Items.Insert(0, data.GetScreenName());
            }

            if (beforeSelectedIndex >= InputBox.Items.Count)
            {
                beforeSelectedIndex = -1;
            }
            else
            {
                InputBox.SelectedIndex = beforeSelectedIndex;
            }
            InputBox.Update();

            form_list.UpdateDeletedData(cs);
        }

        //処理済みファイルのリストを更新する関数
        private void ProssessFinishListBoxUpdate()
        {
            int beforeSelectedIndex = CompleteBox.SelectedIndex;

            CompleteBox.Items.Clear();

            //該当データをすべて表示
            List<FilesForCovert> item = cs.GetMatchList(
                p => p.Status == (int)DataTypes.Finished && p.IsDeleted == false);

            foreach (MediaFiles data in item)
            {
                CompleteBox.Items.Insert(0, data.GetScreenName());
            }

            CompleteBox.SelectedIndex = beforeSelectedIndex;
            CompleteBox.Update();
        }

        private void InputBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void timer_for_test_Tick(object sender, EventArgs e)
        {

            //処理済ファイルを移動
            //if (ProssesingFiles.IsDummy == false)
            if(true)
            {
                //FinishFiles.Enqueue(ProssesingFiles);
            }

            //ファイルを処理中に移動
            if (InputBox.Items.Count == 0)
            {
                //ProssesingFiles = new MediaFiles { IsDummy = true };
                //ProssesingFiles = new MediaFiles();
            }
            else
            {
                //ProssesingFiles = InputFiles.Dequeue();
            }

            //処理中表示を変更
            //label_Progress.Text = "実行中: "
            //    + System.IO.Path.GetFileName(ProssesingFiles.GetScreenName());

            //表示の更新
            ProssessWaitListBoxUpdate();
            ProssessFinishListBoxUpdate();
            form_list.Update(cs);

            //System.Diagnostics.Debug.WriteLine("Timer.");
        }

        //設定ボタンを押したとき
        private void button_CommandOption_Click(object sender, EventArgs e)
        {
            OptionForm form2 = new OptionForm();

            System.Diagnostics.Debug.WriteLine("Option Form is made.");

            form2.SetOptionData(od);

            form2.ShowDialog();

            if(form2.DialogResult == DialogResult.OK)
            {
                //オプションでOKを選択した場合
                od = form2.GetOptionData();
                System.Diagnostics.Debug.WriteLine("OK Dialog: " + od.ToString());
            }
            else if(form2.DialogResult == DialogResult.Cancel)
            {
                //キャンセル
                System.Diagnostics.Debug.WriteLine("Cencel Dialog");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine(this.DialogResult);
            }

            form2.Dispose();
        }

        //処理待ちファイル用のメニューが開かれたとき
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Open MenuBox.");
        }

        //処理待ちリストにポインタが載ったとき
        private void InputBox_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    System.Diagnostics.Debug.WriteLine("Right Click.");

                    //右クリックで選択できるようにする
                    int index = InputBox.IndexFromPoint(e.Location);
                    if (index >= 0)
                    {
                        InputBox.ClearSelected();
                        InputBox.SelectedIndex = index;
                    }

                    //右クリックメニューの表示
                    if (InputBox.SelectedIndex >= 0)
                    {
                        Point p = Cursor.Position;
                        this.contextMenuStrip_DeleteInput.Show(p);
                    }
                    break;

                default:
                    System.Diagnostics.Debug.WriteLine("わからん. " + e.Button.ToString());
                    break;
            }
        }

        //処理待ちファイルリストないで右クリックがあったとき
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(
                "SelectedIndex = " + InputBox.SelectedIndex.ToString());

            if (InputBox.SelectedIndex >= 0)
            {
                System.Diagnostics.Debug.WriteLine("Delete File. ");

                //該当ファイルを検索
                List<FilesForCovert> item = cs.GetMatchList(
                p => p.Status == (int)DataTypes.Standby && p.IsDeleted == false);
                item[item.Count - InputBox.SelectedIndex - 1].IsDeleted = true;

                form_list.Update(cs);

                ProssessWaitListBoxUpdate();
            }
        }

        private void MoveToLastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Move To Last. ");
        }

        private void checkButton_Continue_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton_Continue.Checked)
            {
                checkButton_Continue.Text = "実行中";
                timer_for_test.Enabled = true;
            }
            else
            {
                checkButton_Continue.Text = "停止中";
                timer_for_test.Enabled = false;
            }
        }

        private void CommandListUpdate()
        {
            CommandList.Items.Clear();

            foreach(var c in cs.GetAllCommandScreenName())
            {
                CommandList.Items.Add(c);
            }
            CommandList.Update();
        }
    }
}