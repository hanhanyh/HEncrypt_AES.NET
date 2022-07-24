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
    public partial class FileEncForm : Form
    {
        public FileEncForm()
        {
            InitializeComponent();
        }
        //委托
        public delegate void SetProgress(int value);
        public SetProgress m_SetProgress = null;
        private void btnEncFile_Click(object sender, EventArgs e)
        {
            Thread thr = new Thread(new ThreadStart(() =>
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
                FileStream fs = new FileStream(filepath, FileMode.Open);
                ////输出加密后文件 
                string filepathoutput = filepath + ".HEncrypt";
                FileStream fsoutput = new FileStream(filepathoutput, FileMode.Append);
                //字节缓冲
                byte[] buffer = new byte[1];
                //统计进度
                long count = 0;
                FileInfo fileInfo = new FileInfo(filepath);

                int i = 0;
                while ((i=fs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    count += i;

                    byte[] encryptedByte = AESHelper.EncryptCore(key, buffer);
                    fsoutput.Write(encryptedByte, 0, encryptedByte.Length);
                    //fsoutput.Write(buffer, 0, 1);
                    //设置进度条 
                    double x = (double)((double)count / (double)fileInfo.Length);
                    int val = (int)(x * 100);
                    Progress.Invoke(m_SetProgress, new object[] { (object)val });
                    //m_SetProgress.BeginInvoke(val, null, null);
                    ///
                }
                fs.Close();
                fsoutput.Close();
                //MessageBox.Show("加密完成");
            }));
            thr.Start();

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
            FileStream fs = new FileStream(filepath, FileMode.Open);
            ///
            string filepathoutput = filepath.Replace(".HEncrypt", "");
            FileStream fsoutput = new FileStream(filepathoutput, FileMode.Append);
            byte[] buffer = new byte[16];
            while (fs.Read(buffer, 0, buffer.Length) > 0)
            {
                byte[] encryptedByte = AESHelper.DecryptCore(key, buffer);
                fsoutput.Write(encryptedByte, 0, encryptedByte.Length);
                //fsoutput.Write(buffer, 0, 1);
            }
            fs.Close();
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
            // Control.CheckForIllegalCrossThreadCalls = false;
            m_SetProgress = new SetProgress((x) =>
            {
                Progress.Value = x;
            });
        }
    }
}
