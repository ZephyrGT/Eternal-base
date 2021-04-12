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
using Atheny.Extensions;
using Microsoft.VisualBasic;
using Microsoft.Win32;

namespace Atheny
{
    public partial class TeamManager : Form
    {
        public TeamManager()
        {
            InitializeComponent();
        }

        private void minimizeB_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void exitB_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void leaveTeam_Click(object sender, EventArgs e)
        {
            using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default).CreateSubKey("Pollery"))
            {
                if (key != null)
                {
                    if (key.GetValueNames().Contains("Teams"))
                    {
                        key.DeleteValue("Teams");
                        Variables.Teams.Clear();
                        teamList.Items.Clear();
                    }
                }
            }
        }

        private void joinTeam_Click(object sender, EventArgs e)
        {
            string[] teamcode = teamCode.Text.Split(':');
            string pattern = @"^[A-z0-9]*:[A-z0-9]*";
            if (Regex.IsMatch(teamCode.Text, pattern))
            {
                NameValueCollection join = new NameValueCollection();
                join["username"] = teamcode[0];
                join["code"] = teamcode[1];
                byte[] rawresponse = Program.client.UploadValues("https://pollery.eu/api/team/team-check.php", join);
                string response = rawresponse.Byte2String();
                switch (response)
                {
                    case "success":
                        using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default).CreateSubKey("Pollery"))
                        {
                            if (key != null)
                            {
                                if (key.GetValueNames().Contains("Teams"))
                                {
                                    Variables.Teams.Clear();
                                    string[] val = (string[])key.GetValue("Teams");
                                    Variables.Teams.AddRange(val);
                                    Variables.Teams.Add(teamCode.Text);
                                    key.SetValue("Teams", Variables.Teams.ToArray(), RegistryValueKind.MultiString);
                                }
                                else
                                {
                                    Variables.Teams.Add(teamCode.Text);
                                    key.SetValue("Teams", Variables.Teams.ToArray(), RegistryValueKind.MultiString);
                                }
                            }
                        }
                        MessageBox.Show("Joined successfully! Renew your data sources in the account browser to proceed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        teamList.Items.Add(teamCode.Text);
                        break;
                    case "overuse":
                        MessageBox.Show("This team name already exists!", "Multiple teams are not allowed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "noteam":
                        MessageBox.Show("Unknown team code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        MessageBox.Show("There is an error with our database. Please contact the developers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Unknown team format.", "No team selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void createTeam_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("How would you like your team to be named?", "Team Creator");
            if (!Regex.IsMatch(name, @"^[A-z]+$"))
            {
                MessageBox.Show("You can only use letters in your team name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            NameValueCollection register = new NameValueCollection();
            register["username"] = name;

            string response = Program.client.UploadValues("https://pollery.eu/api/team/team-register.php", register).Byte2String();
            Console.WriteLine(response);
            switch (response)
            {
                case "success":
                    MessageBox.Show("Registered Successfully! Click the join button to join your new team!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    teamCode.Text = name + ":" + name.CreateMD5();
                    break;
                case "overuse":
                    MessageBox.Show("This team name already exists!", "Think of something original", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case "fail":
                    MessageBox.Show("There is an error with our database. Please contact the developers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show("There is an error with our database. Please contact the developers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void TeamManager_Load(object sender, EventArgs e)
        {
            using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default).OpenSubKey("Pollery"))
            {
                if (key != null)
                {
                    if (key.GetValueNames().Contains("Teams"))
                    {
                        Variables.Teams.Clear();
                        string[] val = (string[])key.GetValue("Teams");
                        Variables.Teams.AddRange(val);
                        teamList.Items.AddRange(val);
                    }
                }
            }
        }
    }
}
