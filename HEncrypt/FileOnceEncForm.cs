using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace HEncrypt
{
    public partial class FileOnceEncForm : Form
    {
        public FileOnceEncForm()
        {
            InitializeComponent();
        }

        private void btnEncFile_Click(object sender, EventArgs e)
        { 
            if (txtKey.Text.Length != 32)
            {
                MessageBox.Show("请输入32位秘钥！");
                return;
            }
            if (txtFilePath.Text.Length <= 0)
            {
                MessageBox.Show("请选择加密文件！");
                return;
            }
            string key = txtKey.Text;
            //待加密文件
            string filepath = txtFilePath.Text;
            ////输出加密后文件 
            string filepathoutput = filepath + ".HEncrypt";
            FileStream fsoutput = new FileStream(filepathoutput, FileMode.Append); 
            //统计进度
            long count = 0;
            FileInfo fileInfo = new FileInfo(filepath);
            //读取所有字节
            byte[] byt = File.ReadAllBytes(filepath);
            byte[] encryptedByte = AESHelper.EncryptCore(key, byt);
            fsoutput.Write(encryptedByte, 0, encryptedByte.Length); 
            fsoutput.Close();
            MessageBox.Show("加密完成");


        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            if (txtKey.Text.Length != 32)
            {
                MessageBox.Show("请输入32位秘钥！");
                return;
            }
            if (txtFilePath.Text.Length <= 0)
            {
                MessageBox.Show("请选择需要解密的文件！");
                return;
            }
            string key = txtKey.Text;
            //等解密文件
            string filepath = txtFilePath.Text;

            string filepathoutput = filepath.Replace(".HEncrypt", "");
            FileStream fsoutput = new FileStream(filepathoutput, FileMode.Append);
            //读取所有字节
            byte[] byt = File.ReadAllBytes(filepath);
            byte[] encryptedByte = AESHelper.DecryptCore(key, byt);
            fsoutput.Write(encryptedByte, 0, encryptedByte.Length);

            fsoutput.Close();
            MessageBox.Show("解密完成！");
        }

        private void btnSelFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = dlg.FileName;
            }
        }

        private void FileEncForm_Load(object sender, EventArgs e)
        {

        }
    }
}
