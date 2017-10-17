using System; //基础核心命名空间
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;//数据库访问控制
using System.Drawing; //绘图类
using System.Linq;
using System.Text; //文本类
using System.Threading.Tasks; 
using System.Windows.Forms;//大量的窗体和控件

namespace winform1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            listBox1.Enabled = true;
            comboBox1.Enabled = true; //设置可选状态
            comboBox1.SelectedIndex = 0; //设置组合框控件默认为第一个
            textBox1.Focus(); //设置第一个文本框后的焦点
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            listBox1.Enabled = false;
            comboBox1.Enabled = false; //都设置为不可选状态
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //通知所有消息泵必须终止，并且在处理消息后关闭所有的应用程序窗口
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
