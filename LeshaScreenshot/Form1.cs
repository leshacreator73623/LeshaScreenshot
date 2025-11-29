using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeshaScreenshot
{
    public partial class Form1 : Form
    {
        public static Bitmap img = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Opacity = .0;
            Graphics gr = Graphics.FromImage(img as Image);
            gr.CopyFromScreen(0, 0, 0, 0, img.Size);

            screenshot scr = new screenshot();
            scr.ShowDialog();
            this.Opacity = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
