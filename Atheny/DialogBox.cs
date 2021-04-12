using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atheny
{
    public partial class DialogBox : Form
    {
        private static DialogBox INSTANCE = null;

        public DialogBox()
        {
            InitializeComponent();
        }

        public static DialogBox getInstance()
        {
            if (INSTANCE == null)
                INSTANCE = new DialogBox();

            return INSTANCE;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DragMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void exitB_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void descriptionLabel_TextChanged(object sender, EventArgs e)
        {
            descriptionLabel.SelectionStart = descriptionLabel.Text.Length;
            descriptionLabel.ScrollToCaret();
        }
    }
}
