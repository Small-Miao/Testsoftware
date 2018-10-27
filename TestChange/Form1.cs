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
        Scr scr = new Scr();
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
            EndTest.Enabled = false;
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(tabControl1.SelectedIndex);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("一定要点击选项卡的结束考试，否则答案不会保存", "提示");
        }

        private void StartTest_Click(object sender, EventArgs e)
        {
            if (nameSet.Name != "Error")
            {
                int a = 0;
                StreamReader sr = new StreamReader("test1.test", Encoding.UTF8);
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    TestGet += line;
                }
                StreamReader srr = new StreamReader("test2.test", Encoding.UTF8);
                String linee;
                while ((linee = srr.ReadLine()) != null)
                {
                    TestGet1 += linee;
                }
                StreamReader srrr = new StreamReader("test3.test", Encoding.UTF8);
                string lineee;
                while ((lineee = srrr.ReadLine()) != null)
                {
                    TestGet2 += lineee;
                }
                MessageBox.Show("考试开始,读取题目中。", "提示");
                var s1p = TestGet.Split('@');//分割字符串 读取题文件
                foreach (var s2p in s1p)
                {

                    var s3p = s2p.Split('/');//分割字符串 读取题以及选项
                    if (a > 0)
                    {
                        if (s3p[0] != "")
                        {
                            TabPage First = new TabPage();
                            First.Name = "test" + a;
                            First.Text = "第" + a + "题";
                            tabControl1.TabPages.Add(First);
                            Label lab = new Label()
                            {
                                Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
                                Location = new System.Drawing.Point(25, 38),
                                Name = "label1",
                                Size = new System.Drawing.Size(244, 31),
                                Text = s3p[0]
                            };
                            for (int i = 1; i <= s3p.Length - 1; i++)
                            {

                                RadioButton chooseA = new System.Windows.Forms.RadioButton()//重复代码可以用for简化 比如你这ABCD选项
                                {
                                    Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
                                    Location = new System.Drawing.Point(31, 40 + (i * 40)),
                                    Name = "radioButton1",
                                    Size = new System.Drawing.Size(66, 31),
                                    TabStop = true,
                                    Text = s3p[i]
                                };

                                tabControl1.TabPages[a - 1].Controls.Add(chooseA);

                            }

                            tabControl1.TabPages[a - 1].Controls.Add(lab);
                        }

                    }
                    a++;
                }//选择题读取完毕
                var s4p = TestGet1.Split('@');
                foreach (var s5p in s4p)
                {

                    if (s5p != "")
                    {
                        TabPage First = new TabPage();
                        First.Name = "test" + a;
                        First.Text = "第" + a + "题";
                        tabControl1.TabPages.Add(First);
                        Label labt = new Label()
                        {
                            Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
                            Name = "Qusten",
                            Size = new System.Drawing.Size(317, 33),
                            Dock = DockStyle.Fill,
                            Width = this.Width - 317,
                            Location = new System.Drawing.Point(21, 13),
                            Text = s5p
                        };
                        TextBox textb = new TextBox()
                        {
                            Location = new System.Drawing.Point(27, 241),
                            Name = "textBox1",
                            Size = new System.Drawing.Size(410, 25),
                        };
                        tabControl1.TabPages[a - 1].Controls.Add(textb);
                        tabControl1.TabPages[a - 1].Controls.Add(labt);
                        a++;
                    }
                }
                var s6p = TestGet2.Split('@');
                foreach (var s7p in s6p)
                {
                    if (s7p != "")
                    {
                        TabPage First = new TabPage();
                        First.Name = "test" + a;
                        First.Text = "第" + a + "题";
                        tabControl1.TabPages.Add(First);
                        Label labt = new Label()
                        {
                            Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
                            Name = "Qusten",
                            Size = new System.Drawing.Size(317, 33),
                            Dock = DockStyle.Fill,
                            Width = this.Width - 317,
                            Location = new System.Drawing.Point(21, 13),
                            Text = s7p
                        };
                        tabControl1.TabPages[a - 1].Controls.Add(labt);
                        a++;
                    }
                }
                StartTest.Enabled = false;
                EndTest.Enabled = true;

            }//填空题读取Finish                     
            else
            {
                MessageBox.Show("请输入您的考试信息", "错误！");
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

        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount != tabControl1.SelectedIndex)
            {
                tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
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
                TestGet += line;
            }
            Console.WriteLine(TestGet);
        }

        private void 选项卡生成测试ToolStripMenuItem_Click(object sender, EventArgs e)//中文
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
            RadioButton chooseA = new System.Windows.Forms.RadioButton()
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

        private void Prtsc_Click(object sender, EventArgs e)
        {
            ;
            if (nameSet != null)
            {
                if (nameSet.IsDisposed)
                {
                    Scr scr = new Scr();//如果已经销毁，则重新创建子窗口对象
                }
                scr.Show();
                scr.Focus();
            }
            else
            {
                Scr scr = new Scr();
                scr.Show();
                scr.Focus();
            }
        }

        private void EndTest_Click(object sender, EventArgs e)
        {
            string rua = "";
            for (int j = 0; j < tabControl1.TabCount; j++)
            {
               
                for (int i = 0; i < tabControl1.TabPages[j].Controls.Count; i++)
                {
                    if (tabControl1.TabPages[j].Controls[i] is RadioButton)
                    {
                        if ((tabControl1.TabPages[j].Controls[i] as RadioButton).Checked)
                        {
                            switch (i)
                            {
                                case 0:
                                    rua += j + 1+".A\n";
                                    break;
                                case 1:
                                    rua += j + 1+".B\n";
                                    break;
                                case 2:
                                    rua += j + 1+".C\n";
                                    break;
                                case 3:
                                    rua += j + 1+".D\n";
                                    break;
                                case 4:
                                    rua += j + 1+ ".E\n";
                                    break;
                                default:
                                    rua += j + 1+".未填写";
                                    break;

                            }
                        }
                    }
               
                if (tabControl1.TabPages[j].Controls[i] is TextBox)
                {
                    if (String.IsNullOrEmpty(tabControl1.TabPages[j].Controls[i].Text.Trim()))
                    {
                            rua += j + 1+ ".未填写\n";
                    }
                    else
                    {
                        rua += tabControl1.TabPages[j].Controls[i].Text;
                    }

                }
                }

            }
            rua += "姓名:" + nameSet.Name + "学号:" + nameSet.NameNumber;
            if (!File.Exists(nameSet.Name + nameSet.NameNumber))
            {
                FileStream fs1 = new FileStream(nameSet.Name + nameSet.NameNumber, FileMode.Create, FileAccess.Write);//创建写入文件 
                StreamWriter sw = new StreamWriter(fs1);
                sw.WriteLine(rua);//开始写入值
                sw.Close();
                fs1.Close();
            }
            else
            {
                FileStream fs = new FileStream(nameSet.Name + nameSet.NameNumber, FileMode.Open, FileAccess.Write);
                StreamWriter sr = new StreamWriter(fs);
                sr.WriteLine(rua);//开始写入值
                sr.Close();
                fs.Close();
            }
            StartTest.Enabled = true;
            EndTest.Enabled = false;
        }

     
    }
}
