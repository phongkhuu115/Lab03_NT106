
namespace Lab03
{
    partial class Lab03_Bai4_Client
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
            this.chatBox = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.sendBox = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chatBox
            // 
            this.chatBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatBox.HideSelection = false;
            this.chatBox.Location = new System.Drawing.Point(29, 28);
            this.chatBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(546, 192);
            this.chatBox.TabIndex = 13;
            this.chatBox.UseCompatibleStateImageBehavior = false;
            this.chatBox.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 279);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Khung chat";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên";
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.Location = new System.Drawing.Point(29, 245);
            this.nameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(73, 23);
            this.nameBox.TabIndex = 10;
            // 
            // sendBox
            // 
            this.sendBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendBox.Location = new System.Drawing.Point(29, 299);
            this.sendBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendBox.Multiline = true;
            this.sendBox.Name = "sendBox";
            this.sendBox.Size = new System.Drawing.Size(368, 38);
            this.sendBox.TabIndex = 9;
            // 
            // sendBtn
            // 
            this.sendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendBtn.Location = new System.Drawing.Point(443, 279);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(118, 59);
            this.sendBtn.TabIndex = 8;
            this.sendBtn.Text = "Gửi";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // Lab03_Bai4_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.sendBox);
            this.Controls.Add(this.sendBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Lab03_Bai4_Client";
            this.Text = "Lab03_Bai4_Client";
            this.Load += new System.EventHandler(this.Lab03_Bai4_Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView chatBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox sendBox;
        private System.Windows.Forms.Button sendBtn;
    }
}