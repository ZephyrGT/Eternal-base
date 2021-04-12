using Atheny.Extensions;
using DarkUI.Forms;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atheny
{
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
        }

        private void minimizeB_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            Hide();
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

        private string SendPCoin(string addr, string amount)
        {
            try
            {
                NameValueCollection post = new NameValueCollection();
                post["username"] = Variables.Username;
                post["password"] = Variables.Password.Hash();
                post["hwid"] = Variables.Hwid;
                post["from"] = Variables.PCoinAddress;
                post["sendto"] = addr;
                post["amount"] = amount;

                return Program.client.UploadValues("https://pollery.eu/api/pcoin/pcoin-send.php", post).Byte2String();
            }
            catch
            {
                DarkMessageBox.ShowWarning("Please select a valid account node.", "Invalid Node", DarkDialogButton.Ok);
            }
            return "none";
        }

        private void sendPCoin_Click(object sender, EventArgs e)
        {
            string result = SendPCoin(addressNum.Text, amountNum.Value.ToString());
            Console.WriteLine(result);
            switch (result)
            {
                case "invalid":
                    DarkMessageBox.ShowWarning("The following p-coin address is invalid or you don't have enough P-Coin.", "Invalid Address", DarkDialogButton.Ok);
                    break;
                case "success":
                    DarkMessageBox.ShowInformation($"Successfully sent {amountNum.Value} PCoin to {addressNum.Text}", "Successful Transaction!", DarkDialogButton.Ok);
                    break;
                case "haha no":
                    DarkMessageBox.ShowInformation($"bruh try harder", "bruh", DarkDialogButton.Ok);
                    break;
            }
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            NameValueCollection reward = new NameValueCollection();
            reward["username"] = Variables.Username;
            string update = Program.client.UploadValues("https://pollery.eu/api/pcoin/pcoin-check.php", reward).Byte2String();
            amountNum.Value = decimal.Parse(update);
        }

        private void addressNum_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(addressNum.Text, "^[A-z0-9]+$"))
                sendPCoin.Enabled = true;
            else
                sendPCoin.Enabled = false;
        }
    }
}
