namespace HEncrypt
{
    partial class FileEncForm
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
            this.btnEncFile = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnSelFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEncFile
            // 
            this.btnEncFile.Location = new System.Drawing.Point(182, 181);
            this.btnEncFile.Name = "btnEncFile";
            this.btnEncFile.Size = new System.Drawing.Size(103, 23);
            this.btnEncFile.TabIndex = 0;
            this.btnEncFile.Text = "开始加密文件";
            this.btnEncFile.UseVisualStyleBackColor = true;
            this.btnEncFile.Click += new System.EventHandler(this.btnEncFile_Click);
            // 
            // btnDec
            // 
            this.btnDec.Location = new System.Drawing.Point(330, 181);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(102, 23);
            this.btnDec.TabIndex = 1;
            this.btnDec.Text = "开始解密文件";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Enabled = false;
            this.txtFilePath.Location = new System.Drawing.Point(168, 74);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(368, 21);
            this.txtFilePath.TabIndex = 2;
            // 
            // btnSelFile
            // 
            this.btnSelFile.Location = new System.Drawing.Point(555, 71);
            this.btnSelFile.Name = "btnSelFile";
            this.btnSelFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelFile.TabIndex = 3;
            this.btnSelFile.Text = "选择文件";
            this.btnSelFile.UseVisualStyleBackColor = true;
            this.btnSelFile.Click += new System.EventHandler(this.btnSelFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "请输入秘钥:(32字节)";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(168, 22);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(289, 21);
            this.txtKey.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "请选择文件:";
            // 
            // Progress
            // 
            this.Progress.Location = new System.Drawing.Point(45, 136);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(585, 23);
            this.Progress.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "加密/解密进度：";
            // 
            // FileEncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 380);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelFile);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnEncFile);
            this.MaximizeBox = false;
            this.Name = "FileEncForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件加密工具";
            this.Load += new System.EventHandler(this.FileEncForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncFile;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnSelFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.Label label3;
    }
}