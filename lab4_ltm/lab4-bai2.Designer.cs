namespace lab4_ltm
{
    partial class lab4_bai2
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
            this.btnPUSH = new System.Windows.Forms.Button();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.tbPushContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPUSH
            // 
            this.btnPUSH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPUSH.Location = new System.Drawing.Point(652, 32);
            this.btnPUSH.Name = "btnPUSH";
            this.btnPUSH.Size = new System.Drawing.Size(117, 52);
            this.btnPUSH.TabIndex = 3;
            this.btnPUSH.Text = "PUSH";
            this.btnPUSH.UseVisualStyleBackColor = true;
            // 
            // tbContent
            // 
            this.tbContent.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContent.Location = new System.Drawing.Point(31, 130);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbContent.Size = new System.Drawing.Size(738, 537);
            this.tbContent.TabIndex = 4;
            // 
            // tbURL
            // 
            this.tbURL.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbURL.Location = new System.Drawing.Point(32, 15);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(595, 34);
            this.tbURL.TabIndex = 1;
            // 
            // tbPushContent
            // 
            this.tbPushContent.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPushContent.Location = new System.Drawing.Point(32, 67);
            this.tbPushContent.Name = "tbPushContent";
            this.tbPushContent.Size = new System.Drawing.Size(595, 34);
            this.tbPushContent.TabIndex = 2;
            // 
            // lab4_bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 682);
            this.Controls.Add(this.btnPUSH);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.tbPushContent);
            this.Controls.Add(this.tbURL);
            this.Name = "lab4_bai2";
            this.Text = "Đẩy dữ liệu lên web";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPUSH;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.TextBox tbPushContent;
    }
}