
namespace Lab03
{
    partial class Lab03_Bai3_Server
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
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.btnListen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbData
            // 
            this.rtbData.Location = new System.Drawing.Point(31, 43);
            this.rtbData.Name = "rtbData";
            this.rtbData.ReadOnly = true;
            this.rtbData.Size = new System.Drawing.Size(407, 182);
            this.rtbData.TabIndex = 5;
            this.rtbData.Text = "";
            this.rtbData.TextChanged += new System.EventHandler(this.rtbData_TextChanged);
            // 
            // btnListen
            // 
            this.btnListen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListen.Location = new System.Drawing.Point(476, 78);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(163, 100);
            this.btnListen.TabIndex = 4;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // Lab03_Bai3_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 283);
            this.Controls.Add(this.rtbData);
            this.Controls.Add(this.btnListen);
            this.Name = "Lab03_Bai3_Server";
            this.Text = "Lab03_Bai3_Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbData;
        private System.Windows.Forms.Button btnListen;
    }
}