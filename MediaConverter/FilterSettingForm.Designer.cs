namespace MediaConverter
{
    partial class FilterSettingForm
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
            this.filterListUserControl1 = new MediaConverter.FilterListUserControl();
            this.SuspendLayout();
            // 
            // filterListUserControl1
            // 
            this.filterListUserControl1.Location = new System.Drawing.Point(12, 12);
            this.filterListUserControl1.Name = "filterListUserControl1";
            this.filterListUserControl1.Size = new System.Drawing.Size(692, 27);
            this.filterListUserControl1.TabIndex = 0;
            // 
            // FilterSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filterListUserControl1);
            this.Name = "FilterSettingForm";
            this.Text = "FilterSettingForm";
            this.ResumeLayout(false);

        }

        #endregion

        private FilterListUserControl filterListUserControl1;
    }
}