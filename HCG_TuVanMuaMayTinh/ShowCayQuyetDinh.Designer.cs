namespace HCG_TuVanMuaMayTinh
{
    partial class ShowCayQuyetDinh
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
            this.pbxpaint = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxpaint)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxpaint
            // 
            this.pbxpaint.BackColor = System.Drawing.Color.White;
            this.pbxpaint.Location = new System.Drawing.Point(116, 12);
            this.pbxpaint.Margin = new System.Windows.Forms.Padding(4);
            this.pbxpaint.Name = "pbxpaint";
            this.pbxpaint.Size = new System.Drawing.Size(781, 592);
            this.pbxpaint.TabIndex = 1;
            this.pbxpaint.TabStop = false;
            // 
            // ShowCayQuyetDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 616);
            this.Controls.Add(this.pbxpaint);
            this.Name = "ShowCayQuyetDinh";
            this.Text = "ShowCayQuyetDinh";
            this.Load += new System.EventHandler(this.ShowCayQuyetDinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxpaint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxpaint;
    }
}