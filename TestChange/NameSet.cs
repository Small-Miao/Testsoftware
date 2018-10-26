using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace TestChange
{
    public partial class NameSet : Form
    {
        string TextName;
        int TextNameNumber;
        public string Name {
            get {
                if(TextName == null)
                {
                    return "Error";
                }else
                {
                    return TextName;
                }
             
            }
        }
        public int NameNumber
        { get
            {
                return TextNameNumber;
               
            }
        }
        public NameSet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == null)
            {
                MessageBox.Show("请输入信息","错误");
                textBox1.Text = null;
                textBox2.Text = null;
            }
            else
            {
                try
                {
                    TextName = textBox1.Text;
                 TextNameNumber =   Convert.ToInt32(textBox2.Text);
                    MessageBox.Show("考试人员信息保存成功");
                    this.Hide();
                }
                catch
                { 
                    MessageBox.Show("请输入正确的学号","错误");
                    textBox1.Text = null;
                    textBox2.Text = null;
                }
            }
        }
    }
}
