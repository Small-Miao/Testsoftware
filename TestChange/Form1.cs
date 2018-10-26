using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;


namespace TestChange
{
    public partial class Form1 : Form
    {

        NameSet nameSet = new NameSet();
        string TestGet;
        public Form1()
        {
            InitializeComponent();
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
        #if DEBUG
            deBugToolStripMenuItem.Visible = true;
        #endif
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(tabControl1.SelectedIndex);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("一定要点击选项卡的结束考试，否则答案不会保存","提示");
        }

        private void StartTest_Click(object sender, EventArgs e)
        {
            int q = 0;
            MessageBox.Show("考试开始,读取题目中。", "提示");
            var item = TestGet.Split('@');
            foreach (var qu in item)
            {
                q++;
            }
            q = q - 1;  
            for (int i = 1; i < q; i++) { 
            TabPage First = new TabPage();
            First.Name = "Test" + i;
            First.Text = "第" + i + "题";
            nameSet.TopLevel = false;
            tabControl1.TabPages.Add(First);
          }
        }
        private void TestMenuSetName_Click(object sender, EventArgs e)
        {
            if (nameSet != null)
            {
                if (nameSet.IsDisposed)
                {
                    nameSet = new NameSet();//如果已经销毁，则重新创建子窗口对象
                }
                nameSet.Show();
                nameSet.Focus();
            }
            else
            {
                nameSet = new NameSet();
                nameSet.Show();
                nameSet.Focus();
            }
        }

        private void FileTest_Click(object sender, EventArgs e)
        {
            string filepatch;
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            filepatch = file.FileName;
            StreamReader sr = new StreamReader(filepatch, Encoding.UTF8);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                TestGet += line ;
            }
            Console.WriteLine(TestGet);
        }

    }
}
