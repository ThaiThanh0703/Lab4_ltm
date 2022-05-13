namespace lab4_ltm
{
    partial class lab4_bai1
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
            this.tbURL = new System.Windows.Forms.TextBox();
            this.btnGET = new System.Windows.Forms.Button();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbURL
            // 
            this.tbURL.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbURL.Location = new System.Drawing.Point(13, 13);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(640, 34);
            this.tbURL.TabIndex = 1;
            // 
            // btnGET
            // 
            this.btnGET.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGET.Location = new System.Drawing.Point(659, 13);
            this.btnGET.Name = "btnGET";
            this.btnGET.Size = new System.Drawing.Size(91, 46);
            this.btnGET.TabIndex = 2;
            this.btnGET.Text = "GET";
            this.btnGET.UseVisualStyleBackColor = true;
            this.btnGET.Click += new System.EventHandler(this.btnGET_Click);
            // 
            // tbContent
            // 
            this.tbContent.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContent.Location = new System.Drawing.Point(12, 89);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbContent.Size = new System.Drawing.Size(738, 576);
            this.tbContent.TabIndex = 3;
            // 
            // lab4_bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 677);
            this.Controls.Add(this.btnGET);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.tbURL);
            this.Name = "lab4_bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Button btnGET;
        private System.Windows.Forms.TextBox tbContent;
    }
}

