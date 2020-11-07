using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_2020_HW01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                MD5 md5 = MD5.Create();//建立一個MD5
                byte[] source = Encoding.Default.GetBytes(tbInput.Text);//將字串轉為Byte[]
                byte[] crypto = md5.ComputeHash(source);//進行MD5加密
                string result = Convert.ToBase64String(crypto);//把加密後的字串從Byte[]轉為字串
                label7.Text=("MD5加密:  " + result);//輸出結果
            }
            catch (Exception)
            {
                MessageBox.Show($"不要亂輸入", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
