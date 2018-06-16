﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SCSS
{
    class DragControl : Component
    {
        private Control handleControl;

        public Control SelectControl
        {
            get
            {
                return this.handleControl;
            }

            set
            {
                this.handleControl = value;
                this.handleControl.MouseDown += new MouseEventHandler(this.DragForm_MouseDown);
            }
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr a, int mgs, int wParam, int IParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void DragForm_MouseDown(object sender, MouseEventArgs e)
        {
            bool flag = e.Button == MouseButtons.Left;
            if (flag)
            {
                DragControl.ReleaseCapture();
                DragControl.SendMessage(this.SelectControl.FindForm().Handle, 161, 2, 0);
            }
        }
    }
}