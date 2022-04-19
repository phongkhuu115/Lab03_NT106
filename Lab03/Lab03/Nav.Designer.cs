namespace Lab03
{
    partial class Nav
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbBai2 = new System.Windows.Forms.Label();
            this.btnClient1 = new System.Windows.Forms.Button();
            this.btnServer1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.svBtn4 = new System.Windows.Forms.Button();
            this.clnBtn4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bài 2:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnServe2_Click);
            // 
            // lbBai2
            // 
            this.lbBai2.AutoSize = true;
            this.lbBai2.Location = new System.Drawing.Point(16, 21);
            this.lbBai2.Name = "lbBai2";
            this.lbBai2.Size = new System.Drawing.Size(48, 17);
            this.lbBai2.TabIndex = 2;
            this.lbBai2.Text = "Bài 1: ";
            // 
            // btnClient1
            // 
            this.btnClient1.Location = new System.Drawing.Point(139, 21);
            this.btnClient1.Name = "btnClient1";
            this.btnClient1.Size = new System.Drawing.Size(75, 23);
            this.btnClient1.TabIndex = 3;
            this.btnClient1.Text = "Client";
            this.btnClient1.UseVisualStyleBackColor = true;
            this.btnClient1.Click += new System.EventHandler(this.btnClient1_Click);
            // 
            // btnServer1
            // 
            this.btnServer1.Location = new System.Drawing.Point(299, 21);
            this.btnServer1.Name = "btnServer1";
            this.btnServer1.Size = new System.Drawing.Size(75, 23);
            this.btnServer1.TabIndex = 4;
            this.btnServer1.Text = "Server";
            this.btnServer1.UseVisualStyleBackColor = true;
            this.btnServer1.Click += new System.EventHandler(this.btnServer1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bài 4: ";
            // 
            // svBtn4
            // 
            this.svBtn4.Location = new System.Drawing.Point(94, 154);
            this.svBtn4.Name = "svBtn4";
            this.svBtn4.Size = new System.Drawing.Size(75, 23);
            this.svBtn4.TabIndex = 6;
            this.svBtn4.Text = "Server";
            this.svBtn4.UseVisualStyleBackColor = true;
            this.svBtn4.Click += new System.EventHandler(this.svBtn4_Click);
            // 
            // clnBtn4
            // 
            this.clnBtn4.Location = new System.Drawing.Point(257, 154);
            this.clnBtn4.Name = "clnBtn4";
            this.clnBtn4.Size = new System.Drawing.Size(75, 23);
            this.clnBtn4.TabIndex = 7;
            this.clnBtn4.Text = "Client";
            this.clnBtn4.UseVisualStyleBackColor = true;
            this.clnBtn4.Click += new System.EventHandler(this.clnBtn4_Click);
            // 
            // Nav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 338);
            this.Controls.Add(this.clnBtn4);
            this.Controls.Add(this.svBtn4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnServer1);
            this.Controls.Add(this.btnClient1);
            this.Controls.Add(this.lbBai2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Nav";
            this.Text = "Nav";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbBai2;
        private System.Windows.Forms.Button btnClient1;
        private System.Windows.Forms.Button btnServer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button svBtn4;
        private System.Windows.Forms.Button clnBtn4;
    }
}