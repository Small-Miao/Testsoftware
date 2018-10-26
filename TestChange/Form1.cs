using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;


namespace TestChange
{
    public partial class Form1 : Form
    {

        NameSet nameSet = new NameSet();
        string TestGet;
        string TestGet1;
        string TestGet2;
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
            int a=0;
            MessageBox.Show("考试开始,读取题目中。", "提示");
            var s1p = TestGet.Split('@');
            foreach (var s2p in s1p)
            {
             
                var s3p = s2p.Split('/');
                if (a > 0)
                {
                    if(s3p[0]!="") { 
                    TabPage First = new TabPage();
                    Label lab = new Label()
                    {
                        Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
                        Location = new System.Drawing.Point(25, 38),
                        Name = "label1",
                        Size = new System.Drawing.Size(244, 31),
                        Text = s3p[0]
                    };
                    RadioButton chooseA = new System.Windows.Forms.RadioButton()
                    {
                        Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
                        Location = new System.Drawing.Point(31, 96),
                        Name = "radioButton1",
                        Size = new System.Drawing.Size(66, 31),
                        TabStop = true,
                        Text = s3p[1]
                    };
                    RadioButton chooseB = new System.Windows.Forms.RadioButton()
                    {
                        Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
                        Location = new System.Drawing.Point(31, 133),
                        Name = "radioButton2",
                        Size = new System.Drawing.Size(66, 31),
                        TabStop = true,
                        Text = s3p[2]
                    };
                    RadioButton chooseC = new System.Windows.Forms.RadioButton()
                    {
                        Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
                        Location = new System.Drawing.Point(31, 170),
                        Name = "radioButton2",
                        Size = new System.Drawing.Size(66, 31),
                        TabStop = true,
                        Text = s3p[3]
                    };
                    RadioButton chooseD = new System.Windows.Forms.RadioButton()
                    {
                        Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
                        Location = new System.Drawing.Point(31, 207),
                        Name = "radioButton2",
                        Size = new System.Drawing.Size(66, 31),
                        TabStop = true,
                        Text = s3p[4]
                    };
                    First.Name = "test" + a ;
                    First.Text = "第" +a + "题";
                    tabControl1.TabPages.Add(First);
                    tabControl1.TabPages[a-1].Controls.Add(lab);
                    tabControl1.TabPages[a-1].Controls.Add(chooseA);
                    tabControl1.TabPages[a-1].Controls.Add(chooseB);
                    tabControl1.TabPages[a-1].Controls.Add(chooseC);
                    tabControl1.TabPages[a-1].Controls.Add(chooseD);
                    }
                }
                a++;
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

        private void 选项卡生成测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage First = new TabPage();
            Label lab = new Label()
            {
                Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
                Location = new System.Drawing.Point(25, 38),
                Name = "label1",
                Size = new System.Drawing.Size(244, 31),
                Text = "第一题:1+1 等于多少"
            };
             RadioButton  chooseA = new System.Windows.Forms.RadioButton()
            {
                 Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
                 Location = new System.Drawing.Point(31, 96),
                 Name = "radioButton1",
                 Size = new System.Drawing.Size(66, 31),
                 TabStop = true,
                 Text = "A.1",
             };
            RadioButton chooseB = new System.Windows.Forms.RadioButton()
            {
                Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
                Location = new System.Drawing.Point(31, 133),
                Name = "radioButton2",
                Size = new System.Drawing.Size(66, 31),
                TabStop = true,
                Text = "B.1",
            };
            RadioButton chooseC = new System.Windows.Forms.RadioButton()
            {
                Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
                Location = new System.Drawing.Point(31, 170),
                Name = "radioButton2",
                Size = new System.Drawing.Size(66, 31),
                TabStop = true,
                Text = "C.1",
            };
            RadioButton chooseD = new System.Windows.Forms.RadioButton()
            {
                Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
                Location = new System.Drawing.Point(31, 207),
                Name = "radioButton2",
                Size = new System.Drawing.Size(66, 31),
                TabStop = true,
                Text = "D.1",
            };
            First.Name = "Test";
            First.Text = "SummonTest";
            tabControl1.TabPages.Add(First);
            tabControl1.TabPages[0].Controls.Add(lab);
            tabControl1.TabPages[0].Controls.Add(chooseA);
            tabControl1.TabPages[0].Controls.Add(chooseB);
            tabControl1.TabPages[0].Controls.Add(chooseC);
            tabControl1.TabPages[0].Controls.Add(chooseD);

        }
    }
}
