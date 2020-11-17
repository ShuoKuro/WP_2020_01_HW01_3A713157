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
        private void Form1_Load(object sender, EventArgs e)
        {
            lb_show1.Text = ("");
            lb_show2.Text = ("");
            lb_show3.Text = ("");
            lb_show4.Text = ("");
            lb_show5.Text = ("");
            lb_show6.Text = ("");
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                MD5 md5 = MD5.Create();//建立一個MD5
                byte[] source = Encoding.Default.GetBytes(tbInput.Text);//將字串轉為Byte[]
                byte[] crypto = md5.ComputeHash(source);//進行MD5加密
                int result1 = crypto[0] % 100;
                int result2 = crypto[2] % 100;
                int result3 = crypto[4] % 100;
                int result4 = crypto[6] % 60;
                int result5 = crypto[8] % 100;
                int result6 = crypto[10] % 7;
                lb_show1.Text = (result1.ToString());
                lb_show2.Text = (result2.ToString());
                lb_show3.Text = (result3.ToString());
                lb_show4.Text = (result4.ToString());
                lb_show5.Text = (result5.ToString() + " %");
                switch (result6)
                {
                    case 0:
                        lb_show6.Text = ("黑色");
                        break;
                    case 1:
                        lb_show6.Text = ("白色");
                        break;
                    case 2:
                        lb_show6.Text = ("红色");
                        break;
                    case 3:
                        lb_show6.Text = ("黄色");
                        break;
                    case 4:
                        lb_show6.Text = ("绿色");
                        break;
                    case 5:
                        lb_show6.Text = ("蓝色");
                        break;
                    case 6:
                        lb_show6.Text = ("紫色");
                        break;
                    case 7:
                        lb_show6.Text = ("无色");
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"不要亂輸入", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
