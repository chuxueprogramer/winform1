using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
                //判断字串是否为空
            {
                MessageBox.Show("信息禁止为空！", "登录提示");//winform环境下的弹出对话框
                textBox1.Focus();
                //使用户名称文本框获得焦点
                return; 
            }
            if (!textBox1.Text.Equals("admin") || !textBox2.Text.Equals("admin")) 
            {
                MessageBox.Show("用户名称或密码错误！", "登录提示");
                clear();//清空文本框并且使用户名称文本框获得焦点
                return;
            }
            else
            {
                MessageBox.Show("欢迎您登录本系统！", "消息提示");
                clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
            //将具有共性的代码通过方法进行封装以提高执行效率
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
    }
}
