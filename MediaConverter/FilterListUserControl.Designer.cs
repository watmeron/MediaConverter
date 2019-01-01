namespace MediaConverter
{
    partial class FilterListUserControl
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CommandBox = new System.Windows.Forms.ComboBox();
            this.BranchTypeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // CommandBox
            // 
            this.CommandBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CommandBox.FormattingEnabled = true;
            this.CommandBox.Location = new System.Drawing.Point(488, 3);
            this.CommandBox.Name = "CommandBox";
            this.CommandBox.Size = new System.Drawing.Size(194, 20);
            this.CommandBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.CommandBox, "ほげ");
            this.CommandBox.SelectedIndexChanged += new System.EventHandler(this.CommandBox_SelectedIndexChanged);
            // 
            // BranchTypeBox
            // 
            this.BranchTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BranchTypeBox.FormattingEnabled = true;
            this.BranchTypeBox.Location = new System.Drawing.Point(262, 3);
            this.BranchTypeBox.Name = "BranchTypeBox";
            this.BranchTypeBox.Size = new System.Drawing.Size(174, 20);
            this.BranchTypeBox.TabIndex = 1;
            this.BranchTypeBox.SelectedIndexChanged += new System.EventHandler(this.BranchTypeBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "条件";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 19);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "コマンド";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // FilterListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BranchTypeBox);
            this.Controls.Add(this.CommandBox);
            this.Name = "FilterListUserControl";
            this.Size = new System.Drawing.Size(682, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.ComboBox CommandBox;
        public System.Windows.Forms.ComboBox BranchTypeBox;
        public System.Windows.Forms.TextBox textBox1;
    }
}
