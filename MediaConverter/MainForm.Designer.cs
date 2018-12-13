namespace MediaConverter
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.checkButton_Continue = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip_DeleteInput.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.AllowDrop = true;
            this.InputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputBox.FormattingEnabled = true;
            this.InputBox.HorizontalScrollbar = true;
            this.InputBox.ItemHeight = 12;
            this.InputBox.Location = new System.Drawing.Point(3, 23);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(271, 52);
            this.InputBox.TabIndex = 0;
            this.InputBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.InputBox_DragDrop);
            this.InputBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.InputBox_DragEnter);
            this.InputBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InputBox_MouseDown);
            // 
            // label_InputBox
            // 
            this.label_InputBox.AutoSize = true;
            this.label_InputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_InputBox.Location = new System.Drawing.Point(3, 0);
            this.label_InputBox.Name = "label_InputBox";
            this.label_InputBox.Size = new System.Drawing.Size(271, 20);
            this.label_InputBox.TabIndex = 1;
            this.label_InputBox.Text = "変換待ち";
            this.label_InputBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Filter
            // 
            this.label_Filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_Filter.AutoSize = true;
            this.label_Filter.Location = new System.Drawing.Point(119, 107);
            this.label_Filter.Name = "label_Filter";
            this.label_Filter.Size = new System.Drawing.Size(38, 20);
            this.label_Filter.TabIndex = 2;
            this.label_Filter.Text = "フィルタ";
            this.label_Filter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Under1
            // 
            this.label_Under1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_Under1.AutoSize = true;
            this.label_Under1.Location = new System.Drawing.Point(130, 87);
            this.label_Under1.Name = "label_Under1";
            this.label_Under1.Size = new System.Drawing.Size(17, 20);
            this.label_Under1.TabIndex = 3;
            this.label_Under1.Text = "↓";
            this.label_Under1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilterBox
            // 
            this.FilterBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterBox.BackColor = System.Drawing.SystemColors.Window;
            this.FilterBox.FormattingEnabled = true;
            this.FilterBox.ItemHeight = 12;
            this.FilterBox.Location = new System.Drawing.Point(3, 130);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Size = new System.Drawing.Size(271, 52);
            this.FilterBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "↓";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.comboBox1, 3);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(63, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 20);
            this.comboBox1.TabIndex = 6;
            // 
            // label_Command
            // 
            this.label_Command.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_Command.AutoSize = true;
            this.label_Command.Location = new System.Drawing.Point(118, 214);
            this.label_Command.Name = "label_Command";
            this.label_Command.Size = new System.Drawing.Size(40, 20);
            this.label_Command.TabIndex = 7;
            this.label_Command.Text = "コマンド";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "↓";
            // 
            // CompleteBox
            // 
            this.CompleteBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompleteBox.FormattingEnabled = true;
            this.CompleteBox.HorizontalScrollbar = true;
            this.CompleteBox.ItemHeight = 12;
            this.CompleteBox.Location = new System.Drawing.Point(3, 334);
            this.CompleteBox.Name = "CompleteBox";
            this.CompleteBox.Size = new System.Drawing.Size(271, 52);
            this.CompleteBox.TabIndex = 9;
            // 
            // label_Complete
            // 
            this.label_Complete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_Complete.AutoSize = true;
            this.label_Complete.Location = new System.Drawing.Point(124, 311);
            this.label_Complete.Name = "label_Complete";
            this.label_Complete.Size = new System.Drawing.Size(29, 20);
            this.label_Complete.TabIndex = 10;
            this.label_Complete.Text = "完了";
            // 
            // label_Progress
            // 
            this.label_Progress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_Progress.AutoSize = true;
            this.label_Progress.BackColor = System.Drawing.SystemColors.Control;
            this.label_Progress.Location = new System.Drawing.Point(8, 0);
            this.label_Progress.Name = "label_Progress";
            this.label_Progress.Size = new System.Drawing.Size(43, 25);
            this.label_Progress.TabIndex = 11;
            this.label_Progress.Text = "実行中:";
            this.label_Progress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_for_test
            // 
            this.timer_for_test.Interval = 2500;
            this.timer_for_test.Tick += new System.EventHandler(this.timer_for_test_Tick);
            // 
            // button_CommandOption
            // 
            this.button_CommandOption.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_CommandOption.Location = new System.Drawing.Point(63, 28);
            this.button_CommandOption.Name = "button_CommandOption";
            this.button_CommandOption.Size = new System.Drawing.Size(69, 20);
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
            this.contextMenuStrip_DeleteInput.Size = new System.Drawing.Size(137, 48);
            this.contextMenuStrip_DeleteInput.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // DeleteFileToolStripMenuItem
            // 
            this.DeleteFileToolStripMenuItem.Name = "DeleteFileToolStripMenuItem";
            this.DeleteFileToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.DeleteFileToolStripMenuItem.Text = "削除";
            this.DeleteFileToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // MoveFileToLastToolStripMenuItem
            // 
            this.MoveFileToLastToolStripMenuItem.Name = "MoveFileToLastToolStripMenuItem";
            this.MoveFileToLastToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.MoveFileToLastToolStripMenuItem.Text = "最後にする";
            this.MoveFileToLastToolStripMenuItem.Click += new System.EventHandler(this.MoveToLastToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.InputBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label_InputBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.CompleteBox, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label_Under1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_Filter, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.FilterBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label_Complete, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label_Command, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(277, 398);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label_Progress, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_CommandOption, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkButton_Continue, 2, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 237);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(271, 51);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // checkButton_Continue
            // 
            this.checkButton_Continue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkButton_Continue.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkButton_Continue.AutoSize = true;
            this.checkButton_Continue.Location = new System.Drawing.Point(138, 28);
            this.checkButton_Continue.Name = "checkButton_Continue";
            this.checkButton_Continue.Size = new System.Drawing.Size(64, 20);
            this.checkButton_Continue.TabIndex = 13;
            this.checkButton_Continue.Text = "停止中";
            this.checkButton_Continue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkButton_Continue.UseVisualStyleBackColor = true;
            this.checkButton_Continue.CheckedChanged += new System.EventHandler(this.checkButton_Continue_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 422);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(291, 460);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form";
            this.contextMenuStrip_DeleteInput.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox checkButton_Continue;
    }
}

