namespace MediaConverter
{
    partial class Form
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.InputBox = new System.Windows.Forms.ListBox();
            this.label_InputBox = new System.Windows.Forms.Label();
            this.label_Filter = new System.Windows.Forms.Label();
            this.label_Under1 = new System.Windows.Forms.Label();
            this.FilterBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_Command = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CompleteBox = new System.Windows.Forms.ListBox();
            this.label_Complete = new System.Windows.Forms.Label();
            this.label_Progress = new System.Windows.Forms.Label();
            this.timer_for_test = new System.Windows.Forms.Timer(this.components);
            this.button_CommandOption = new System.Windows.Forms.Button();
            this.contextMenuStrip_DeleteInput = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoveFileToLastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_DeleteInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.AllowDrop = true;
            this.InputBox.FormattingEnabled = true;
            this.InputBox.HorizontalScrollbar = true;
            this.InputBox.ItemHeight = 12;
            this.InputBox.Location = new System.Drawing.Point(12, 34);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(251, 136);
            this.InputBox.TabIndex = 0;
            this.InputBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.InputBox_DragDrop);
            this.InputBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.InputBox_DragEnter);
            this.InputBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InputBox_MouseDown);
            // 
            // label_InputBox
            // 
            this.label_InputBox.AutoSize = true;
            this.label_InputBox.Location = new System.Drawing.Point(12, 19);
            this.label_InputBox.Name = "label_InputBox";
            this.label_InputBox.Size = new System.Drawing.Size(50, 12);
            this.label_InputBox.TabIndex = 1;
            this.label_InputBox.Text = "変換待ち";
            // 
            // label_Filter
            // 
            this.label_Filter.AutoSize = true;
            this.label_Filter.Location = new System.Drawing.Point(12, 187);
            this.label_Filter.Name = "label_Filter";
            this.label_Filter.Size = new System.Drawing.Size(38, 12);
            this.label_Filter.TabIndex = 2;
            this.label_Filter.Text = "フィルタ";
            // 
            // label_Under1
            // 
            this.label_Under1.AutoSize = true;
            this.label_Under1.Location = new System.Drawing.Point(117, 173);
            this.label_Under1.Name = "label_Under1";
            this.label_Under1.Size = new System.Drawing.Size(17, 12);
            this.label_Under1.TabIndex = 3;
            this.label_Under1.Text = "↓";
            // 
            // FilterBox
            // 
            this.FilterBox.BackColor = System.Drawing.SystemColors.Window;
            this.FilterBox.FormattingEnabled = true;
            this.FilterBox.ItemHeight = 12;
            this.FilterBox.Location = new System.Drawing.Point(12, 202);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Size = new System.Drawing.Size(251, 40);
            this.FilterBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "↓";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 279);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 20);
            this.comboBox1.TabIndex = 6;
            // 
            // label_Command
            // 
            this.label_Command.AutoSize = true;
            this.label_Command.Location = new System.Drawing.Point(12, 264);
            this.label_Command.Name = "label_Command";
            this.label_Command.Size = new System.Drawing.Size(40, 12);
            this.label_Command.TabIndex = 7;
            this.label_Command.Text = "コマンド";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "↓";
            // 
            // CompleteBox
            // 
            this.CompleteBox.FormattingEnabled = true;
            this.CompleteBox.HorizontalScrollbar = true;
            this.CompleteBox.ItemHeight = 12;
            this.CompleteBox.Location = new System.Drawing.Point(12, 362);
            this.CompleteBox.Name = "CompleteBox";
            this.CompleteBox.Size = new System.Drawing.Size(251, 52);
            this.CompleteBox.TabIndex = 9;
            // 
            // label_Complete
            // 
            this.label_Complete.AutoSize = true;
            this.label_Complete.Location = new System.Drawing.Point(12, 347);
            this.label_Complete.Name = "label_Complete";
            this.label_Complete.Size = new System.Drawing.Size(29, 12);
            this.label_Complete.TabIndex = 10;
            this.label_Complete.Text = "完了";
            // 
            // label_Progress
            // 
            this.label_Progress.AutoSize = true;
            this.label_Progress.BackColor = System.Drawing.SystemColors.Control;
            this.label_Progress.Location = new System.Drawing.Point(12, 302);
            this.label_Progress.Name = "label_Progress";
            this.label_Progress.Size = new System.Drawing.Size(43, 12);
            this.label_Progress.TabIndex = 11;
            this.label_Progress.Text = "実行中:";
            // 
            // timer_for_test
            // 
            this.timer_for_test.Enabled = true;
            this.timer_for_test.Interval = 2500;
            this.timer_for_test.Tick += new System.EventHandler(this.timer_for_test_Tick);
            // 
            // button_CommandOption
            // 
            this.button_CommandOption.Location = new System.Drawing.Point(186, 305);
            this.button_CommandOption.Name = "button_CommandOption";
            this.button_CommandOption.Size = new System.Drawing.Size(75, 22);
            this.button_CommandOption.TabIndex = 12;
            this.button_CommandOption.Text = "設定";
            this.button_CommandOption.UseVisualStyleBackColor = true;
            this.button_CommandOption.Click += new System.EventHandler(this.button_CommandOption_Click);
            // 
            // contextMenuStrip_DeleteInput
            // 
            this.contextMenuStrip_DeleteInput.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteFileToolStripMenuItem,
            this.MoveFileToLastToolStripMenuItem});
            this.contextMenuStrip_DeleteInput.Name = "contextMenuStrip_DeleteInput";
            this.contextMenuStrip_DeleteInput.Size = new System.Drawing.Size(181, 70);
            this.contextMenuStrip_DeleteInput.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // DeleteFileToolStripMenuItem
            // 
            this.DeleteFileToolStripMenuItem.Name = "DeleteFileToolStripMenuItem";
            this.DeleteFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeleteFileToolStripMenuItem.Text = "削除";
            this.DeleteFileToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // MoveFileToLastToolStripMenuItem
            // 
            this.MoveFileToLastToolStripMenuItem.Name = "MoveFileToLastToolStripMenuItem";
            this.MoveFileToLastToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.MoveFileToLastToolStripMenuItem.Text = "最後にする";
            this.MoveFileToLastToolStripMenuItem.Click += new System.EventHandler(this.MoveToLastToolStripMenuItem_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 422);
            this.Controls.Add(this.button_CommandOption);
            this.Controls.Add(this.label_Progress);
            this.Controls.Add(this.label_Complete);
            this.Controls.Add(this.CompleteBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Command);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilterBox);
            this.Controls.Add(this.label_Under1);
            this.Controls.Add(this.label_Filter);
            this.Controls.Add(this.label_InputBox);
            this.Controls.Add(this.InputBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form";
            this.contextMenuStrip_DeleteInput.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox InputBox;
        private System.Windows.Forms.Label label_InputBox;
        private System.Windows.Forms.Label label_Filter;
        private System.Windows.Forms.Label label_Under1;
        private System.Windows.Forms.ListBox FilterBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_Command;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox CompleteBox;
        private System.Windows.Forms.Label label_Complete;
        private System.Windows.Forms.Label label_Progress;
        private System.Windows.Forms.Timer timer_for_test;
        private System.Windows.Forms.Button button_CommandOption;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_DeleteInput;
        private System.Windows.Forms.ToolStripMenuItem DeleteFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MoveFileToLastToolStripMenuItem;
    }
}

