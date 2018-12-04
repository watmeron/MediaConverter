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
        OptionData od;

        //入力待ちファイル
        private Queue<MediaFiles> InputFiles = new Queue<MediaFiles>();

        //処理中ファイル
        private MediaFiles ProssesingFiles = new MediaFiles();

        //処理終了ファイル
        private Queue<MediaFiles> FinishFiles = new Queue<MediaFiles>();

        public Form()
        {
            InitializeComponent();

            od = new OptionData();
        }


        //DDされたファイルを入力待ちキューに追加
        private void InputBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach(string file in files)
            {
                MediaFiles pf = new MediaFiles
                {
                    Name = file,
                    ScreenName = System.IO.Path.GetFileName(file)
                };

                InputFiles.Enqueue(pf);

                ProssessWaitListBoxUpdate();

            }
        }

        //処理待ちファイルのリストを更新する関数
        private void ProssessWaitListBoxUpdate()
        {
            int beforeSelectedIndex = InputBox.SelectedIndex;

            InputBox.Items.Clear();

            //下から抜けていくように表示する処理
            Queue<MediaFiles> rInputFiles = new Queue<MediaFiles>(InputFiles);
            foreach (MediaFiles data in rInputFiles){
                InputBox.Items.Insert(0, System.IO.Path.GetFileName(data.ScreenName));
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
        }

        //処理済みファイルのリストを更新する関数
        private void ProssessFinishListBoxUpdate()
        {
            int beforeSelectedIndex = CompleteBox.SelectedIndex;

            CompleteBox.Items.Clear();

            foreach (MediaFiles data in FinishFiles)
            {
                CompleteBox.Items.Insert(0, System.IO.Path.GetFileName(data.ScreenName));
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
            if (ProssesingFiles.IsDummy == false)
            {
                FinishFiles.Enqueue(ProssesingFiles);
            }

            //ファイルを処理中に移動
            if (InputBox.Items.Count == 0)
            {
                ProssesingFiles = new MediaFiles { IsDummy = true };
            }
            else
            {
                ProssesingFiles = InputFiles.Dequeue();
            }

            //処理中表示を変更
            label_Progress.Text = "実行中: "
                + System.IO.Path.GetFileName(ProssesingFiles.ScreenName);

            //表示の更新
            ProssessWaitListBoxUpdate();
            ProssessFinishListBoxUpdate();

            //System.Diagnostics.Debug.WriteLine("Timer.");
        }

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
            else if(form2.DialogResult == DialogResult.Cancel){
                //キャンセル
                System.Diagnostics.Debug.WriteLine("Cencel Dialog");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine(this.DialogResult);
            }

            form2.Dispose();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Open MenuBox.");
        }

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

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Delete File. ");
        }

        private void MoveToLastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Move To Last. ");
        }

        private void label_InputBox_Click(object sender, EventArgs e)
        {

        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}