using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SocialGame
{
    public partial class Form1 : Form
    {
        //Drug&Drop window on screen (start)

        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);

        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool ReleaseCapture();

        const uint WM_SYSCOMMAND = 0x0112;
        const uint DOMOVE = 0xF012;
        const uint DOSIZE = 0xF008;

        //Drug&Drop window on screen (end)

        public Form1()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(Form1_MouseDown); //Drug&Drop window on screen
            this.BackColor = ColorTranslator.FromHtml("#362c36");
        }

        //Drug&Drop window on screen (start)
        void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
        }
        //Drug&Drop window on screen (end)

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#4d4c59");
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#4d4c59");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#4d4c59");
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
