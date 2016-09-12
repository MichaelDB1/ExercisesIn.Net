namespace WindowsFormsViewDemo
{
    partial class FormOut
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
            this.LbxShow = new System.Windows.Forms.ListBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbxShow
            // 
            this.LbxShow.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbxShow.FormattingEnabled = true;
            this.LbxShow.ItemHeight = 18;
            this.LbxShow.Location = new System.Drawing.Point(3, 5);
            this.LbxShow.Name = "LbxShow";
            this.LbxShow.Size = new System.Drawing.Size(279, 238);
            this.LbxShow.TabIndex = 0;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(180, 278);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 1;
            this.BtnClear.Text = "&Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // FrmShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 302);
            this.ControlBox = false;
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.LbxShow);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmShow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "OUTPUT";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LbxShow;
        private System.Windows.Forms.Button BtnClear;
    }
}