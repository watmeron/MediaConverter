namespace MediaConverter
{
    partial class OptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_ParrallelNum = new System.Windows.Forms.ComboBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ShowFileName = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "最大並列数";
            // 
            // comboBox_ParrallelNum
            // 
            this.comboBox_ParrallelNum.Location = new System.Drawing.Point(15, 46);
            this.comboBox_ParrallelNum.Name = "comboBox_ParrallelNum";
            this.comboBox_ParrallelNum.Size = new System.Drawing.Size(121, 20);
            this.comboBox_ParrallelNum.TabIndex = 1;
            this.comboBox_ParrallelNum.SelectedIndexChanged += new System.EventHandler(this.comboBox_ParrallelNum_SelectedIndexChanged);
            // 
            // button_OK
            // 
            this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_OK.Location = new System.Drawing.Point(12, 391);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 2;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(132, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "キャンセル";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ShowFileName
            // 
            this.ShowFileName.AutoSize = true;
            this.ShowFileName.Location = new System.Drawing.Point(15, 85);
            this.ShowFileName.Name = "ShowFileName";
            this.ShowFileName.Size = new System.Drawing.Size(150, 16);
            this.ShowFileName.TabIndex = 4;
            this.ShowFileName.Text = "ファイル名をフルパスで表示";
            this.ShowFileName.UseVisualStyleBackColor = true;
            this.ShowFileName.CheckedChanged += new System.EventHandler(this.ShowFileName_CheckedChanged);
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 426);
            this.Controls.Add(this.ShowFileName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.comboBox_ParrallelNum);
            this.Controls.Add(this.label1);
            this.Name = "OptionForm";
            this.Text = "コマンド設定";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_ParrallelNum;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ShowFileName;
    }
}