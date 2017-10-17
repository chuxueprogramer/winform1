using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //窗体初始化加载
            this.listBox1.Items.Add("软件部");
            this.listBox1.Items.Add("硬件部");
            this.listBox1.Items.Add("财务部");
            this.listBox1.Items.Add("人事部");  //通过Add方法实现对下拉列表控件的信息的添加
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("您选择的部门是：" + listBox1.SelectedItem.ToString() + ",位列第" + (listBox1.SelectedIndex+1).ToString(), "信息提示");
                
        }

    }
}
