﻿namespace MediaConverter
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
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 426);
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
    }
}