using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace TestChange
{
    public partial class Scr : Form
    {
        public Scr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "图片路径";
            sfd.InitialDirectory = @"C:\";
            sfd.Filter = "图片| *.jpeg";
            sfd.ShowDialog();
            string path = sfd.FileName;
            Bitmap catchBmp = new Bitmap(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height);
            var sc = Graphics.FromImage(catchBmp);
            sc.CopyFromScreen(Point.Empty, Point.Empty, catchBmp.Size);
            catchBmp.Save(path,ImageFormat.Jpeg);

        }
    }
}
