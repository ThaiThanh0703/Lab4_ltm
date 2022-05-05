namespace lab4_ltm
{
    partial class lab4_bai3
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
            this.btnSave = new System.Windows.Forms.Button();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(653, 57);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 42);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // tbContent
            // 
            this.tbContent.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContent.Location = new System.Drawing.Point(31, 125);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbContent.Size = new System.Drawing.Size(738, 537);
            this.tbContent.TabIndex = 5;
            // 
            // tbFilePath
            // 
            this.tbFilePath.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilePath.Location = new System.Drawing.Point(32, 62);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(576, 34);
            this.tbFilePath.TabIndex = 2;
            // 
            // tbURL
            // 
            this.tbURL.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbURL.Location = new System.Drawing.Point(32, 10);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(576, 34);
            this.tbURL.TabIndex = 1;
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(624, 5);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(145, 42);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            // 
            // lab4_bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 673);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.tbURL);
            this.Name = "lab4_bai3";
            this.Text = "Download HTML từ web";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Button btnDownload;
    }
}