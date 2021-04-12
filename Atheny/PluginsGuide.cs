using Atheny.Extensions;
using DarkUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atheny
{
    public partial class PluginsGuide : Form
    {
        public PluginsGuide()
        {
            InitializeComponent();
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
        private void savePlugin_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Plugin File (.pl)|*.pl";
            sfd.SupportMultiDottedExtensions = false;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, codeBox.Text.Base64Encode());
                DarkMessageBox.ShowInformation($"Plugin saved - {sfd.FileName}", "Plugin Manager", DarkDialogButton.Ok);
            }
        }

        private void clearB_Click(object sender, EventArgs e)
        {
            codeBox.Clear();
        }

        private void undoB_Click(object sender, EventArgs e)
        {
            codeBox.Undo();
        }

        private void redoB_Click(object sender, EventArgs e)
        {
            codeBox.Redo();
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void minimizeB_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
