namespace HEncrypt
{
    partial class EncForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Text1 = new System.Windows.Forms.RichTextBox();
            this.Text2 = new System.Windows.Forms.RichTextBox();
            this.BtnEnc = new System.Windows.Forms.Button();
            this.btndec = new System.Windows.Forms.Button();
            this.txt_Key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Text1
            // 
            this.Text1.Location = new System.Drawing.Point(78, 82);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(229, 325);
            this.Text1.TabIndex = 0;
            this.Text1.Text = "";
            // 
            // Text2
            // 
            this.Text2.Location = new System.Drawing.Point(432, 47);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(266, 360);
            this.Text2.TabIndex = 1;
            this.Text2.Text = "";
            // 
            // BtnEnc
            // 
            this.BtnEnc.Location = new System.Drawing.Point(326, 207);
            this.BtnEnc.Name = "BtnEnc";
            this.BtnEnc.Size = new System.Drawing.Size(75, 23);
            this.BtnEnc.TabIndex = 2;
            this.BtnEnc.Text = "加密>>";
            this.BtnEnc.UseVisualStyleBackColor = true;
            this.BtnEnc.Click += new System.EventHandler(this.BtnEnc_Click);
            // 
            // btndec
            // 
            this.btndec.Location = new System.Drawing.Point(326, 282);
            this.btndec.Name = "btndec";
            this.btndec.Size = new System.Drawing.Size(75, 23);
            this.btndec.TabIndex = 3;
            this.btndec.Text = "<<解密";
            this.btndec.UseVisualStyleBackColor = true;
            this.btndec.Click += new System.EventHandler(this.btndec_Click);
            // 
            // txt_Key
            // 
            this.txt_Key.Location = new System.Drawing.Point(78, 47);
            this.txt_Key.Name = "txt_Key";
            this.txt_Key.Size = new System.Drawing.Size(229, 21);
            this.txt_Key.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "加密KEY:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "明文:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "秘文:";
            // 
            // EncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Key);
            this.Controls.Add(this.btndec);
            this.Controls.Add(this.BtnEnc);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Text1);
            this.Name = "EncForm";
            this.Text = "文本加密";
            this.Load += new System.EventHandler(this.EncForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Text1;
        private System.Windows.Forms.RichTextBox Text2;
        private System.Windows.Forms.Button BtnEnc;
        private System.Windows.Forms.Button btndec;
        private System.Windows.Forms.TextBox txt_Key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

