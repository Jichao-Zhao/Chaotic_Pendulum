using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ColorForm : Form
    {
        public ColorForm()
        {
            InitializeComponent();
        }

        private void ColorForm_MouseClick(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Black;
            //Form2 form2 = new Form2();
            //form2.Show();
        }

        private void ColorForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void ColorForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //label1.Text = textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if ("赵继超".Equals(username) && "zhaojichao".Equals(password))
            {
                MessageBox.Show("登录成功","登录界面",MessageBoxButtons.OK,MessageBoxIcon.Information); 
            }
            else
            {
                MessageBox.Show("登录失败，请重新尝试", "登录界面", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
