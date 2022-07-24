using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HEncrypt
{
    public partial class EncForm : Form
    {
        public EncForm()
        {
            InitializeComponent();
        }

        private void EncForm_Load(object sender, EventArgs e)
        {
         
        }

        private void BtnEnc_Click(object sender, EventArgs e)
        {
            if (txt_Key.Text.Length != 32)
            {
                MessageBox.Show("key必须32长度");
                return;
            }
            AESHelper.PublicKey = txt_Key.Text;
            string k=  AESHelper.Encrypt(Text1.Text);
            Text2.Text = k;
        }

        private void btndec_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Key.Text.Length != 32)
                {
                    MessageBox.Show("key必须32长度");
                    return;
                }
                AESHelper.PublicKey = txt_Key.Text;
                string k = AESHelper.Decrypt(Text2.Text);
                Text1.Text = k;
            }
            catch (Exception ex)
            {
                MessageBox.Show("解密失败：" + ex.ToString());
            }
          
        }
    }
}
