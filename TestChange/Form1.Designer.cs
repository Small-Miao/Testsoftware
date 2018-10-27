namespace TestChange
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.TestMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TestMenuSetName = new System.Windows.Forms.ToolStripMenuItem();
            this.StartTest = new System.Windows.Forms.ToolStripMenuItem();
            this.EndTest = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.WatchHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.PrtscMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Prtsc = new System.Windows.Forms.ToolStripMenuItem();
            this.deBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileTest = new System.Windows.Forms.ToolStripMenuItem();
            this.选项卡生成测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(12, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 407);
            this.tabControl1.TabIndex = 1;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TestMenu,
            this.HelpMenu,
            this.PrtscMenu,
            this.deBugToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // TestMenu
            // 
            this.TestMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TestMenuSetName,
            this.StartTest,
            this.EndTest});
            this.TestMenu.Name = "TestMenu";
            this.TestMenu.Size = new System.Drawing.Size(81, 24);
            this.TestMenu.Text = "考试选项";
            // 
            // TestMenuSetName
            // 
            this.TestMenuSetName.Name = "TestMenuSetName";
            this.TestMenuSetName.Size = new System.Drawing.Size(174, 26);
            this.TestMenuSetName.Text = "设置姓名学号";
            this.TestMenuSetName.Click += new System.EventHandler(this.TestMenuSetName_Click);
            // 
            // StartTest
            // 
            this.StartTest.Name = "StartTest";
            this.StartTest.Size = new System.Drawing.Size(174, 26);
            this.StartTest.Text = "开始考试";
            this.StartTest.Click += new System.EventHandler(this.StartTest_Click);
            // 
            // EndTest
            // 
            this.EndTest.Name = "EndTest";
            this.EndTest.Size = new System.Drawing.Size(174, 26);
            this.EndTest.Text = "结束考试";
            this.EndTest.Click += new System.EventHandler(this.EndTest_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WatchHelp});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(51, 24);
            this.HelpMenu.Text = "帮助";
            // 
            // WatchHelp
            // 
            this.WatchHelp.Name = "WatchHelp";
            this.WatchHelp.Size = new System.Drawing.Size(174, 26);
            this.WatchHelp.Text = "查看帮助窗口";
            // 
            // PrtscMenu
            // 
            this.PrtscMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Prtsc});
            this.PrtscMenu.Name = "PrtscMenu";
            this.PrtscMenu.Size = new System.Drawing.Size(81, 24);
            this.PrtscMenu.Text = "快速操作";
            // 
            // Prtsc
            // 
            this.Prtsc.Name = "Prtsc";
            this.Prtsc.Size = new System.Drawing.Size(144, 26);
            this.Prtsc.Text = "快速截图";
            this.Prtsc.Click += new System.EventHandler(this.Prtsc_Click);
            // 
            // deBugToolStripMenuItem
            // 
            this.deBugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileTest,
            this.选项卡生成测试ToolStripMenuItem});
            this.deBugToolStripMenuItem.Name = "deBugToolStripMenuItem";
            this.deBugToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.deBugToolStripMenuItem.Text = "DeBug";
            this.deBugToolStripMenuItem.Visible = false;
            // 
            // FileTest
            // 
            this.FileTest.Name = "FileTest";
            this.FileTest.Size = new System.Drawing.Size(189, 26);
            this.FileTest.Text = "文件读取测试";
            this.FileTest.Click += new System.EventHandler(this.FileTest_Click);
            // 
            // 选项卡生成测试ToolStripMenuItem
            // 
            this.选项卡生成测试ToolStripMenuItem.Name = "选项卡生成测试ToolStripMenuItem";
            this.选项卡生成测试ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.选项卡生成测试ToolStripMenuItem.Text = "选项卡生成测试";
            this.选项卡生成测试ToolStripMenuItem.Click += new System.EventHandler(this.选项卡生成测试ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form1";
            this.Text = "考试系统 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem TestMenu;
        private System.Windows.Forms.ToolStripMenuItem TestMenuSetName;
        private System.Windows.Forms.ToolStripMenuItem StartTest;
        private System.Windows.Forms.ToolStripMenuItem EndTest;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem PrtscMenu;
        private System.Windows.Forms.ToolStripMenuItem Prtsc;
        private System.Windows.Forms.ToolStripMenuItem WatchHelp;
        private System.Windows.Forms.ToolStripMenuItem deBugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileTest;
        private System.Windows.Forms.ToolStripMenuItem 选项卡生成测试ToolStripMenuItem;
    }
}

