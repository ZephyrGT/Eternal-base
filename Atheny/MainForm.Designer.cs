using DarkUI.Controls;
using System;

namespace Atheny
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Start on Boot");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Steal Discord Token");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Steal Machine Name");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Steal Mac Addresses");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Take a Screenshot");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Steal Browser Credentials");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Run as Admin");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Hide Stealer");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Anti Task Manager");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Trace save.dat File");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Basic", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Disable Windows Defender !");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Mine P-Coin [Experimental]");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Advanced", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13});
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.mainCoinH = new System.Windows.Forms.Panel();
            this.otherPanelP = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mainBH = new System.Windows.Forms.Panel();
            this.builderPanelP = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainCH = new System.Windows.Forms.Panel();
            this.configPanelP = new System.Windows.Forms.Panel();
            this.splitPanel = new System.Windows.Forms.Panel();
            this.mainPH = new System.Windows.Forms.Panel();
            this.mainPanelP = new System.Windows.Forms.Panel();
            this.menuSelector = new System.Windows.Forms.Panel();
            this.TabControl = new Atheny.TablessControl();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.deserializeBrowser = new DarkUI.Controls.DarkButton();
            this.showDupes = new DarkUI.Controls.DarkCheckBox();
            this.teamManager = new DarkUI.Controls.DarkButton();
            this.renewB = new DarkUI.Controls.DarkButton();
            this.accProperty = new System.Windows.Forms.PropertyGrid();
            this.accTree = new DarkUI.Controls.DarkTreeView();
            this.accTreePanel = new System.Windows.Forms.Panel();
            this.configPage = new System.Windows.Forms.TabPage();
            this.darkGroupBox2 = new DarkUI.Controls.DarkGroupBox();
            this.removeSelected = new DarkUI.Controls.DarkButton();
            this.minePCoin = new DarkUI.Controls.DarkCheckBox();
            this.backupAdd = new DarkUI.Controls.DarkButton();
            this.backupWebhooks = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.useHttps = new DarkUI.Controls.DarkCheckBox();
            this.webhookTitle = new DarkUI.Controls.DarkTitle();
            this.webhookUrl = new DarkUI.Controls.DarkTextBox();
            this.sendtomoreBox = new DarkUI.Controls.DarkTextBox();
            this.sendtomoreCheck = new DarkUI.Controls.DarkCheckBox();
            this.smtpportTitle = new DarkUI.Controls.DarkTitle();
            this.smtpportBox = new DarkUI.Controls.DarkTextBox();
            this.smtpserverTItle = new DarkUI.Controls.DarkTitle();
            this.emailTitle = new DarkUI.Controls.DarkTitle();
            this.stmpserverBox = new DarkUI.Controls.DarkTextBox();
            this.emailBox = new DarkUI.Controls.DarkTextBox();
            this.teamsGroup = new DarkUI.Controls.DarkGroupBox();
            this.currentaccounts = new DarkUI.Controls.DarkTitle();
            this.currentUsers = new DarkUI.Controls.DarkTitle();
            this.verLabel = new DarkUI.Controls.DarkTitle();
            this.updateAv = new DarkUI.Controls.DarkTitle();
            this.teamConfig = new DarkUI.Controls.DarkButton();
            this.enableTeams = new DarkUI.Controls.DarkCheckBox();
            this.rpcOptions = new DarkUI.Controls.DarkGroupBox();
            this.lessCpu = new DarkUI.Controls.DarkCheckBox();
            this.appluRpc = new DarkUI.Controls.DarkButton();
            this.textRpc = new DarkUI.Controls.DarkTextBox();
            this.titleRpc = new DarkUI.Controls.DarkTextBox();
            this.intervalTitle = new DarkUI.Controls.DarkTitle();
            this.useRpc = new DarkUI.Controls.DarkCheckBox();
            this.intervalNum = new DarkUI.Controls.DarkNumericUpDown();
            this.gpuSelectPanel = new DarkUI.Controls.DarkGroupBox();
            this.useLightMode = new DarkUI.Controls.DarkCheckBox();
            this.cpuL = new DarkUI.Controls.DarkTitle();
            this.useGpu = new DarkUI.Controls.DarkCheckBox();
            this.amdRadio = new DarkUI.Controls.DarkRadioButton();
            this.nvidiaRadio = new DarkUI.Controls.DarkRadioButton();
            this.cpuNum = new DarkUI.Controls.DarkNumericUpDown();
            this.designOptions = new DarkUI.Controls.DarkGroupBox();
            this.saveConfig = new DarkUI.Controls.DarkButton();
            this.pingB = new DarkUI.Controls.DarkButton();
            this.conState = new DarkUI.Controls.DarkTitle();
            this.hostLabel = new DarkUI.Controls.DarkTitle();
            this.pingLabel = new DarkUI.Controls.DarkTitle();
            this.serverCon = new DarkUI.Controls.DarkTitle();
            this.rgbBox = new DarkUI.Controls.DarkCheckBox();
            this.builderPanel = new System.Windows.Forms.TabPage();
            this.teamgroupbox = new DarkUI.Controls.DarkGroupBox();
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.selectIcon = new DarkUI.Controls.DarkButton();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.selecticonlabel = new DarkUI.Controls.DarkLabel();
            this.teamSelector = new System.Windows.Forms.CheckedListBox();
            this.logsLabel = new DarkUI.Controls.DarkLabel();
            this.passDecodingSection = new DarkUI.Controls.DarkGroupBox();
            this.selectOptionLabel = new DarkUI.Controls.DarkTitle();
            this.testPass = new DarkUI.Controls.DarkButton();
            this.internalPass = new DarkUI.Controls.DarkRadioButton();
            this.externalPass = new DarkUI.Controls.DarkRadioButton();
            this.passDecLabel = new DarkUI.Controls.DarkTitle();
            this.pluginsSection = new DarkUI.Controls.DarkGroupBox();
            this.pluginsGuide = new DarkUI.Controls.DarkButton();
            this.removeBox = new DarkUI.Controls.DarkButton();
            this.importPlugins = new DarkUI.Controls.DarkButton();
            this.pluginsList = new System.Windows.Forms.CheckedListBox();
            this.buildB = new DarkUI.Controls.DarkButton();
            this.deliverySection = new DarkUI.Controls.DarkGroupBox();
            this.webhookDelivery = new DarkUI.Controls.DarkCheckBox();
            this.deliveryTitle = new DarkUI.Controls.DarkTitle();
            this.emailDelivery = new DarkUI.Controls.DarkCheckBox();
            this.serverDelivery = new DarkUI.Controls.DarkCheckBox();
            this.featuresSection = new DarkUI.Controls.DarkGroupBox();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.reportB = new DarkUI.Controls.DarkButton();
            this.featuresTree = new System.Windows.Forms.TreeView();
            this.otherPanel = new System.Windows.Forms.TabPage();
            this.transactionsB = new DarkUI.Controls.DarkButton();
            this.statL = new System.Windows.Forms.Label();
            this.coinChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.stopCoin = new System.Windows.Forms.Button();
            this.coinAddr = new System.Windows.Forms.Label();
            this.coinAmount = new System.Windows.Forms.Label();
            this.coinL2 = new System.Windows.Forms.Label();
            this.startCoin = new System.Windows.Forms.Button();
            this.coinL1 = new System.Windows.Forms.Label();
            this.titleL = new System.Windows.Forms.Label();
            this.sohard = new System.Windows.Forms.PictureBox();
            this.minimizeB = new System.Windows.Forms.Button();
            this.exitB = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bgPanel = new System.Windows.Forms.Panel();
            this.rgbTimer = new System.Windows.Forms.Timer(this.components);
            this.updateConn = new System.Windows.Forms.Timer(this.components);
            this.rpcTimer = new System.Windows.Forms.Timer(this.components);
            this.accMenu = new DarkUI.Controls.DarkContextMenu();
            this.checkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.growidpasswordFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel.SuspendLayout();
            this.mainCoinH.SuspendLayout();
            this.mainBH.SuspendLayout();
            this.mainCH.SuspendLayout();
            this.mainPH.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.mainPage.SuspendLayout();
            this.configPage.SuspendLayout();
            this.darkGroupBox2.SuspendLayout();
            this.teamsGroup.SuspendLayout();
            this.rpcOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNum)).BeginInit();
            this.gpuSelectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuNum)).BeginInit();
            this.designOptions.SuspendLayout();
            this.builderPanel.SuspendLayout();
            this.teamgroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.passDecodingSection.SuspendLayout();
            this.pluginsSection.SuspendLayout();
            this.deliverySection.SuspendLayout();
            this.featuresSection.SuspendLayout();
            this.otherPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coinChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sohard)).BeginInit();
            this.accMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.mainPanel.Controls.Add(this.mainCoinH);
            this.mainPanel.Controls.Add(this.panel4);
            this.mainPanel.Controls.Add(this.panel3);
            this.mainPanel.Controls.Add(this.mainBH);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.mainCH);
            this.mainPanel.Controls.Add(this.splitPanel);
            this.mainPanel.Controls.Add(this.mainPH);
            this.mainPanel.Controls.Add(this.menuSelector);
            this.mainPanel.Controls.Add(this.TabControl);
            this.mainPanel.Controls.Add(this.titleL);
            this.mainPanel.Controls.Add(this.sohard);
            this.mainPanel.Controls.Add(this.minimizeB);
            this.mainPanel.Controls.Add(this.exitB);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Location = new System.Drawing.Point(4, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(792, 496);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            // 
            // mainCoinH
            // 
            this.mainCoinH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainCoinH.Controls.Add(this.otherPanelP);
            this.mainCoinH.Location = new System.Drawing.Point(11, 325);
            this.mainCoinH.Name = "mainCoinH";
            this.mainCoinH.Size = new System.Drawing.Size(72, 75);
            this.mainCoinH.TabIndex = 8;
            this.mainCoinH.Click += new System.EventHandler(this.otherPanelP_Click);
            // 
            // otherPanelP
            // 
            this.otherPanelP.BackgroundImage = global::Atheny.Properties.Resources.coin;
            this.otherPanelP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.otherPanelP.Location = new System.Drawing.Point(19, 19);
            this.otherPanelP.Name = "otherPanelP";
            this.otherPanelP.Size = new System.Drawing.Size(35, 35);
            this.otherPanelP.TabIndex = 6;
            this.otherPanelP.Click += new System.EventHandler(this.otherPanelP_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panel4.Location = new System.Drawing.Point(787, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 434);
            this.panel4.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panel3.Location = new System.Drawing.Point(0, 491);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(792, 5);
            this.panel3.TabIndex = 12;
            // 
            // mainBH
            // 
            this.mainBH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainBH.Controls.Add(this.builderPanelP);
            this.mainBH.Location = new System.Drawing.Point(11, 244);
            this.mainBH.Name = "mainBH";
            this.mainBH.Size = new System.Drawing.Size(72, 75);
            this.mainBH.TabIndex = 9;
            this.mainBH.Click += new System.EventHandler(this.builderPanelP_Click);
            // 
            // builderPanelP
            // 
            this.builderPanelP.BackgroundImage = global::Atheny.Properties.Resources.build;
            this.builderPanelP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.builderPanelP.Location = new System.Drawing.Point(19, 19);
            this.builderPanelP.Name = "builderPanelP";
            this.builderPanelP.Size = new System.Drawing.Size(35, 35);
            this.builderPanelP.TabIndex = 6;
            this.builderPanelP.Click += new System.EventHandler(this.builderPanelP_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 5);
            this.panel1.TabIndex = 9;
            // 
            // mainCH
            // 
            this.mainCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainCH.Controls.Add(this.configPanelP);
            this.mainCH.Location = new System.Drawing.Point(11, 163);
            this.mainCH.Name = "mainCH";
            this.mainCH.Size = new System.Drawing.Size(72, 75);
            this.mainCH.TabIndex = 10;
            this.mainCH.Click += new System.EventHandler(this.configPanelP_Click);
            // 
            // configPanelP
            // 
            this.configPanelP.BackgroundImage = global::Atheny.Properties.Resources.settings;
            this.configPanelP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.configPanelP.Location = new System.Drawing.Point(19, 19);
            this.configPanelP.Name = "configPanelP";
            this.configPanelP.Size = new System.Drawing.Size(35, 35);
            this.configPanelP.TabIndex = 6;
            this.configPanelP.Click += new System.EventHandler(this.configPanelP_Click);
            // 
            // splitPanel
            // 
            this.splitPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.splitPanel.Location = new System.Drawing.Point(89, 62);
            this.splitPanel.Name = "splitPanel";
            this.splitPanel.Size = new System.Drawing.Size(5, 434);
            this.splitPanel.TabIndex = 8;
            // 
            // mainPH
            // 
            this.mainPH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainPH.Controls.Add(this.mainPanelP);
            this.mainPH.Location = new System.Drawing.Point(11, 82);
            this.mainPH.Name = "mainPH";
            this.mainPH.Size = new System.Drawing.Size(72, 75);
            this.mainPH.TabIndex = 7;
            this.mainPH.Click += new System.EventHandler(this.mainPanelP_Click);
            // 
            // mainPanelP
            // 
            this.mainPanelP.BackgroundImage = global::Atheny.Properties.Resources.menu;
            this.mainPanelP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainPanelP.Location = new System.Drawing.Point(19, 19);
            this.mainPanelP.Name = "mainPanelP";
            this.mainPanelP.Size = new System.Drawing.Size(35, 35);
            this.mainPanelP.TabIndex = 5;
            this.mainPanelP.Click += new System.EventHandler(this.mainPanelP_Click);
            // 
            // menuSelector
            // 
            this.menuSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.menuSelector.Location = new System.Drawing.Point(0, 84);
            this.menuSelector.Name = "menuSelector";
            this.menuSelector.Size = new System.Drawing.Size(5, 75);
            this.menuSelector.TabIndex = 0;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.mainPage);
            this.TabControl.Controls.Add(this.configPage);
            this.TabControl.Controls.Add(this.builderPanel);
            this.TabControl.Controls.Add(this.otherPanel);
            this.TabControl.ItemSize = new System.Drawing.Size(50, 20);
            this.TabControl.Location = new System.Drawing.Point(92, 62);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(695, 429);
            this.TabControl.TabIndex = 7;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // mainPage
            // 
            this.mainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.mainPage.Controls.Add(this.deserializeBrowser);
            this.mainPage.Controls.Add(this.showDupes);
            this.mainPage.Controls.Add(this.teamManager);
            this.mainPage.Controls.Add(this.renewB);
            this.mainPage.Controls.Add(this.accProperty);
            this.mainPage.Controls.Add(this.accTree);
            this.mainPage.Controls.Add(this.accTreePanel);
            this.mainPage.Location = new System.Drawing.Point(4, 24);
            this.mainPage.Name = "mainPage";
            this.mainPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainPage.Size = new System.Drawing.Size(687, 401);
            this.mainPage.TabIndex = 0;
            this.mainPage.Text = "Main Menu";
            // 
            // deserializeBrowser
            // 
            this.deserializeBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.deserializeBrowser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deserializeBrowser.ForeColor = System.Drawing.Color.White;
            this.deserializeBrowser.Location = new System.Drawing.Point(316, 239);
            this.deserializeBrowser.Name = "deserializeBrowser";
            this.deserializeBrowser.Padding = new System.Windows.Forms.Padding(5);
            this.deserializeBrowser.Size = new System.Drawing.Size(347, 34);
            this.deserializeBrowser.TabIndex = 5;
            this.deserializeBrowser.Text = "Deserialize Browser Credentials";
            this.deserializeBrowser.Click += new System.EventHandler(this.deserializeBrowser_Click);
            // 
            // showDupes
            // 
            this.showDupes.AutoSize = true;
            this.showDupes.BackColor = System.Drawing.Color.Transparent;
            this.showDupes.Checked = true;
            this.showDupes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showDupes.Enabled = false;
            this.showDupes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDupes.ForeColor = System.Drawing.Color.White;
            this.showDupes.Location = new System.Drawing.Point(284, 357);
            this.showDupes.Name = "showDupes";
            this.showDupes.Size = new System.Drawing.Size(124, 21);
            this.showDupes.TabIndex = 4;
            this.showDupes.Text = "Anti Duplicates";
            // 
            // teamManager
            // 
            this.teamManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.teamManager.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamManager.ForeColor = System.Drawing.Color.White;
            this.teamManager.Location = new System.Drawing.Point(413, 353);
            this.teamManager.Name = "teamManager";
            this.teamManager.Padding = new System.Windows.Forms.Padding(5);
            this.teamManager.Size = new System.Drawing.Size(146, 28);
            this.teamManager.TabIndex = 3;
            this.teamManager.Text = "Team Manager";
            this.teamManager.Click += new System.EventHandler(this.teamManager_Click);
            // 
            // renewB
            // 
            this.renewB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.renewB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renewB.ForeColor = System.Drawing.Color.White;
            this.renewB.Location = new System.Drawing.Point(567, 353);
            this.renewB.Name = "renewB";
            this.renewB.Padding = new System.Windows.Forms.Padding(5);
            this.renewB.Size = new System.Drawing.Size(109, 28);
            this.renewB.TabIndex = 2;
            this.renewB.Text = "Renew";
            this.renewB.Click += new System.EventHandler(this.renewB_Click);
            // 
            // accProperty
            // 
            this.accProperty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.accProperty.CategoryForeColor = System.Drawing.Color.White;
            this.accProperty.CategorySplitterColor = System.Drawing.Color.White;
            this.accProperty.CommandsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.accProperty.CommandsBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.accProperty.CommandsDisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.accProperty.CommandsForeColor = System.Drawing.Color.White;
            this.accProperty.DisabledItemForeColor = System.Drawing.Color.White;
            this.accProperty.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accProperty.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.accProperty.HelpBorderColor = System.Drawing.Color.White;
            this.accProperty.HelpForeColor = System.Drawing.Color.White;
            this.accProperty.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.accProperty.Location = new System.Drawing.Point(304, 17);
            this.accProperty.Name = "accProperty";
            this.accProperty.Size = new System.Drawing.Size(372, 330);
            this.accProperty.TabIndex = 1;
            this.accProperty.ToolbarVisible = false;
            this.accProperty.ViewBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.accProperty.ViewBorderColor = System.Drawing.Color.White;
            this.accProperty.ViewForeColor = System.Drawing.Color.White;
            // 
            // accTree
            // 
            this.accTree.AllowDrop = true;
            this.accTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.accTree.Cursor = System.Windows.Forms.Cursors.Cross;
            this.accTree.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accTree.ForeColor = System.Drawing.Color.White;
            this.accTree.Location = new System.Drawing.Point(11, 17);
            this.accTree.MaxDragChange = 20;
            this.accTree.Name = "accTree";
            this.accTree.ShowIcons = true;
            this.accTree.Size = new System.Drawing.Size(287, 330);
            this.accTree.TabIndex = 0;
            this.accTree.SelectedNodesChanged += new System.EventHandler(this.accTree_AfterSelect);
            this.accTree.Click += new System.EventHandler(this.accTree_Click);
            this.accTree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.accTree_MouseClick);
            // 
            // accTreePanel
            // 
            this.accTreePanel.BackColor = System.Drawing.Color.White;
            this.accTreePanel.Location = new System.Drawing.Point(9, 15);
            this.accTreePanel.Name = "accTreePanel";
            this.accTreePanel.Size = new System.Drawing.Size(291, 334);
            this.accTreePanel.TabIndex = 6;
            // 
            // configPage
            // 
            this.configPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.configPage.Controls.Add(this.darkGroupBox2);
            this.configPage.Controls.Add(this.teamsGroup);
            this.configPage.Controls.Add(this.rpcOptions);
            this.configPage.Controls.Add(this.gpuSelectPanel);
            this.configPage.Controls.Add(this.designOptions);
            this.configPage.Location = new System.Drawing.Point(4, 24);
            this.configPage.Name = "configPage";
            this.configPage.Padding = new System.Windows.Forms.Padding(3);
            this.configPage.Size = new System.Drawing.Size(687, 401);
            this.configPage.TabIndex = 1;
            this.configPage.Text = "Config Page";
            // 
            // darkGroupBox2
            // 
            this.darkGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.darkGroupBox2.Controls.Add(this.removeSelected);
            this.darkGroupBox2.Controls.Add(this.minePCoin);
            this.darkGroupBox2.Controls.Add(this.backupAdd);
            this.darkGroupBox2.Controls.Add(this.backupWebhooks);
            this.darkGroupBox2.Controls.Add(this.panel5);
            this.darkGroupBox2.Controls.Add(this.useHttps);
            this.darkGroupBox2.Controls.Add(this.webhookTitle);
            this.darkGroupBox2.Controls.Add(this.webhookUrl);
            this.darkGroupBox2.Controls.Add(this.sendtomoreBox);
            this.darkGroupBox2.Controls.Add(this.sendtomoreCheck);
            this.darkGroupBox2.Controls.Add(this.smtpportTitle);
            this.darkGroupBox2.Controls.Add(this.smtpportBox);
            this.darkGroupBox2.Controls.Add(this.smtpserverTItle);
            this.darkGroupBox2.Controls.Add(this.emailTitle);
            this.darkGroupBox2.Controls.Add(this.stmpserverBox);
            this.darkGroupBox2.Controls.Add(this.emailBox);
            this.darkGroupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkGroupBox2.ForeColor = System.Drawing.Color.White;
            this.darkGroupBox2.Location = new System.Drawing.Point(212, 207);
            this.darkGroupBox2.Name = "darkGroupBox2";
            this.darkGroupBox2.Size = new System.Drawing.Size(475, 209);
            this.darkGroupBox2.TabIndex = 5;
            this.darkGroupBox2.TabStop = false;
            this.darkGroupBox2.Text = "Builder configuration";
            // 
            // removeSelected
            // 
            this.removeSelected.Location = new System.Drawing.Point(394, 132);
            this.removeSelected.Name = "removeSelected";
            this.removeSelected.Padding = new System.Windows.Forms.Padding(5);
            this.removeSelected.Size = new System.Drawing.Size(68, 21);
            this.removeSelected.TabIndex = 36;
            this.removeSelected.Text = "Remove ";
            this.removeSelected.Click += new System.EventHandler(this.removeSelected_Click);
            // 
            // minePCoin
            // 
            this.minePCoin.AutoSize = true;
            this.minePCoin.BackColor = System.Drawing.Color.Transparent;
            this.minePCoin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minePCoin.ForeColor = System.Drawing.Color.White;
            this.minePCoin.Location = new System.Drawing.Point(290, 156);
            this.minePCoin.Name = "minePCoin";
            this.minePCoin.Size = new System.Drawing.Size(175, 20);
            this.minePCoin.TabIndex = 18;
            this.minePCoin.Text = "Mine P-Coin [Experimental]";
            // 
            // backupAdd
            // 
            this.backupAdd.Location = new System.Drawing.Point(405, 47);
            this.backupAdd.Name = "backupAdd";
            this.backupAdd.Padding = new System.Windows.Forms.Padding(5);
            this.backupAdd.Size = new System.Drawing.Size(57, 21);
            this.backupAdd.TabIndex = 35;
            this.backupAdd.Text = "Add";
            this.backupAdd.Click += new System.EventHandler(this.backupAdd_Click);
            // 
            // backupWebhooks
            // 
            this.backupWebhooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.backupWebhooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backupWebhooks.ForeColor = System.Drawing.Color.Gainsboro;
            this.backupWebhooks.FormattingEnabled = true;
            this.backupWebhooks.ItemHeight = 16;
            this.backupWebhooks.Location = new System.Drawing.Point(227, 78);
            this.backupWebhooks.Name = "backupWebhooks";
            this.backupWebhooks.Size = new System.Drawing.Size(235, 50);
            this.backupWebhooks.TabIndex = 33;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.panel5.Location = new System.Drawing.Point(212, 30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 160);
            this.panel5.TabIndex = 31;
            // 
            // useHttps
            // 
            this.useHttps.AutoSize = true;
            this.useHttps.BackColor = System.Drawing.Color.Transparent;
            this.useHttps.Checked = true;
            this.useHttps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useHttps.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useHttps.ForeColor = System.Drawing.Color.White;
            this.useHttps.Location = new System.Drawing.Point(230, 156);
            this.useHttps.Name = "useHttps";
            this.useHttps.Size = new System.Drawing.Size(58, 20);
            this.useHttps.TabIndex = 30;
            this.useHttps.Text = "HTTPS";
            // 
            // webhookTitle
            // 
            this.webhookTitle.AutoSize = true;
            this.webhookTitle.BackColor = System.Drawing.Color.Transparent;
            this.webhookTitle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webhookTitle.ForeColor = System.Drawing.Color.White;
            this.webhookTitle.Location = new System.Drawing.Point(229, 27);
            this.webhookTitle.Name = "webhookTitle";
            this.webhookTitle.Size = new System.Drawing.Size(74, 17);
            this.webhookTitle.TabIndex = 29;
            this.webhookTitle.Text = "Webhooks:";
            // 
            // webhookUrl
            // 
            this.webhookUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.webhookUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.webhookUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.webhookUrl.Location = new System.Drawing.Point(227, 47);
            this.webhookUrl.Name = "webhookUrl";
            this.webhookUrl.Size = new System.Drawing.Size(171, 21);
            this.webhookUrl.TabIndex = 28;
            // 
            // sendtomoreBox
            // 
            this.sendtomoreBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.sendtomoreBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sendtomoreBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.sendtomoreBox.Location = new System.Drawing.Point(90, 170);
            this.sendtomoreBox.Name = "sendtomoreBox";
            this.sendtomoreBox.Size = new System.Drawing.Size(111, 21);
            this.sendtomoreBox.TabIndex = 27;
            // 
            // sendtomoreCheck
            // 
            this.sendtomoreCheck.AutoSize = true;
            this.sendtomoreCheck.BackColor = System.Drawing.Color.Transparent;
            this.sendtomoreCheck.Checked = true;
            this.sendtomoreCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sendtomoreCheck.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendtomoreCheck.ForeColor = System.Drawing.Color.White;
            this.sendtomoreCheck.Location = new System.Drawing.Point(16, 171);
            this.sendtomoreCheck.Name = "sendtomoreCheck";
            this.sendtomoreCheck.Size = new System.Drawing.Size(72, 20);
            this.sendtomoreCheck.TabIndex = 26;
            this.sendtomoreCheck.Text = "Send to:";
            // 
            // smtpportTitle
            // 
            this.smtpportTitle.AutoSize = true;
            this.smtpportTitle.BackColor = System.Drawing.Color.Transparent;
            this.smtpportTitle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smtpportTitle.ForeColor = System.Drawing.Color.White;
            this.smtpportTitle.Location = new System.Drawing.Point(15, 121);
            this.smtpportTitle.Name = "smtpportTitle";
            this.smtpportTitle.Size = new System.Drawing.Size(68, 17);
            this.smtpportTitle.TabIndex = 25;
            this.smtpportTitle.Text = "SMTP Port:";
            // 
            // smtpportBox
            // 
            this.smtpportBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.smtpportBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smtpportBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.smtpportBox.Location = new System.Drawing.Point(13, 142);
            this.smtpportBox.Name = "smtpportBox";
            this.smtpportBox.Size = new System.Drawing.Size(188, 21);
            this.smtpportBox.TabIndex = 24;
            this.smtpportBox.Text = "587";
            // 
            // smtpserverTItle
            // 
            this.smtpserverTItle.AutoSize = true;
            this.smtpserverTItle.BackColor = System.Drawing.Color.Transparent;
            this.smtpserverTItle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smtpserverTItle.ForeColor = System.Drawing.Color.White;
            this.smtpserverTItle.Location = new System.Drawing.Point(15, 74);
            this.smtpserverTItle.Name = "smtpserverTItle";
            this.smtpserverTItle.Size = new System.Drawing.Size(83, 17);
            this.smtpserverTItle.TabIndex = 23;
            this.smtpserverTItle.Text = "SMTP Server:";
            // 
            // emailTitle
            // 
            this.emailTitle.AutoSize = true;
            this.emailTitle.BackColor = System.Drawing.Color.Transparent;
            this.emailTitle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTitle.ForeColor = System.Drawing.Color.White;
            this.emailTitle.Location = new System.Drawing.Point(15, 27);
            this.emailTitle.Name = "emailTitle";
            this.emailTitle.Size = new System.Drawing.Size(42, 17);
            this.emailTitle.TabIndex = 22;
            this.emailTitle.Text = "Email:";
            // 
            // stmpserverBox
            // 
            this.stmpserverBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.stmpserverBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stmpserverBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.stmpserverBox.Location = new System.Drawing.Point(13, 95);
            this.stmpserverBox.Name = "stmpserverBox";
            this.stmpserverBox.Size = new System.Drawing.Size(188, 21);
            this.stmpserverBox.TabIndex = 21;
            this.stmpserverBox.Text = "smtp.gmail.com";
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.emailBox.Location = new System.Drawing.Point(13, 47);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(187, 21);
            this.emailBox.TabIndex = 20;
            this.emailBox.Click += new System.EventHandler(this.emailBox_Click);
            // 
            // teamsGroup
            // 
            this.teamsGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.teamsGroup.Controls.Add(this.currentaccounts);
            this.teamsGroup.Controls.Add(this.currentUsers);
            this.teamsGroup.Controls.Add(this.verLabel);
            this.teamsGroup.Controls.Add(this.updateAv);
            this.teamsGroup.Controls.Add(this.teamConfig);
            this.teamsGroup.Controls.Add(this.enableTeams);
            this.teamsGroup.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamsGroup.ForeColor = System.Drawing.Color.White;
            this.teamsGroup.Location = new System.Drawing.Point(6, 207);
            this.teamsGroup.Name = "teamsGroup";
            this.teamsGroup.Size = new System.Drawing.Size(200, 209);
            this.teamsGroup.TabIndex = 4;
            this.teamsGroup.TabStop = false;
            this.teamsGroup.Text = "Teams & miscellaneous";
            // 
            // currentaccounts
            // 
            this.currentaccounts.AutoSize = true;
            this.currentaccounts.BackColor = System.Drawing.Color.Transparent;
            this.currentaccounts.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentaccounts.ForeColor = System.Drawing.Color.White;
            this.currentaccounts.Location = new System.Drawing.Point(28, 174);
            this.currentaccounts.Name = "currentaccounts";
            this.currentaccounts.Size = new System.Drawing.Size(137, 17);
            this.currentaccounts.TabIndex = 25;
            this.currentaccounts.Text = "Current accounts: null";
            // 
            // currentUsers
            // 
            this.currentUsers.AutoSize = true;
            this.currentUsers.BackColor = System.Drawing.Color.Transparent;
            this.currentUsers.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUsers.ForeColor = System.Drawing.Color.White;
            this.currentUsers.Location = new System.Drawing.Point(28, 153);
            this.currentUsers.Name = "currentUsers";
            this.currentUsers.Size = new System.Drawing.Size(110, 17);
            this.currentUsers.TabIndex = 24;
            this.currentUsers.Text = "Current users: null";
            // 
            // verLabel
            // 
            this.verLabel.AutoSize = true;
            this.verLabel.BackColor = System.Drawing.Color.Transparent;
            this.verLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verLabel.ForeColor = System.Drawing.Color.White;
            this.verLabel.Location = new System.Drawing.Point(28, 132);
            this.verLabel.Name = "verLabel";
            this.verLabel.Size = new System.Drawing.Size(75, 17);
            this.verLabel.TabIndex = 23;
            this.verLabel.Text = "Version: 5.0";
            // 
            // updateAv
            // 
            this.updateAv.AutoSize = true;
            this.updateAv.BackColor = System.Drawing.Color.Transparent;
            this.updateAv.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAv.ForeColor = System.Drawing.Color.White;
            this.updateAv.Location = new System.Drawing.Point(12, 108);
            this.updateAv.Name = "updateAv";
            this.updateAv.Size = new System.Drawing.Size(121, 17);
            this.updateAv.TabIndex = 22;
            this.updateAv.Text = "Pollery Information:";
            // 
            // teamConfig
            // 
            this.teamConfig.Location = new System.Drawing.Point(12, 57);
            this.teamConfig.Name = "teamConfig";
            this.teamConfig.Padding = new System.Windows.Forms.Padding(5);
            this.teamConfig.Size = new System.Drawing.Size(176, 35);
            this.teamConfig.TabIndex = 21;
            this.teamConfig.Text = "Teams Configuration";
            this.teamConfig.Click += new System.EventHandler(this.teamConfig_Click);
            // 
            // enableTeams
            // 
            this.enableTeams.AutoSize = true;
            this.enableTeams.Checked = true;
            this.enableTeams.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableTeams.Enabled = false;
            this.enableTeams.Location = new System.Drawing.Point(15, 24);
            this.enableTeams.Name = "enableTeams";
            this.enableTeams.Size = new System.Drawing.Size(65, 20);
            this.enableTeams.TabIndex = 0;
            this.enableTeams.Text = "Enable";
            // 
            // rpcOptions
            // 
            this.rpcOptions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.rpcOptions.Controls.Add(this.lessCpu);
            this.rpcOptions.Controls.Add(this.appluRpc);
            this.rpcOptions.Controls.Add(this.textRpc);
            this.rpcOptions.Controls.Add(this.titleRpc);
            this.rpcOptions.Controls.Add(this.intervalTitle);
            this.rpcOptions.Controls.Add(this.useRpc);
            this.rpcOptions.Controls.Add(this.intervalNum);
            this.rpcOptions.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpcOptions.ForeColor = System.Drawing.Color.White;
            this.rpcOptions.Location = new System.Drawing.Point(417, 12);
            this.rpcOptions.Name = "rpcOptions";
            this.rpcOptions.Size = new System.Drawing.Size(274, 189);
            this.rpcOptions.TabIndex = 3;
            this.rpcOptions.TabStop = false;
            this.rpcOptions.Text = "Discord rich presence";
            // 
            // lessCpu
            // 
            this.lessCpu.AutoSize = true;
            this.lessCpu.BackColor = System.Drawing.Color.Transparent;
            this.lessCpu.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessCpu.ForeColor = System.Drawing.Color.White;
            this.lessCpu.Location = new System.Drawing.Point(10, 154);
            this.lessCpu.Name = "lessCpu";
            this.lessCpu.Size = new System.Drawing.Size(111, 20);
            this.lessCpu.TabIndex = 21;
            this.lessCpu.Text = "Less CPU Usage";
            // 
            // appluRpc
            // 
            this.appluRpc.Location = new System.Drawing.Point(147, 106);
            this.appluRpc.Name = "appluRpc";
            this.appluRpc.Padding = new System.Windows.Forms.Padding(5);
            this.appluRpc.Size = new System.Drawing.Size(110, 42);
            this.appluRpc.TabIndex = 20;
            this.appluRpc.Text = "Apply";
            this.appluRpc.Click += new System.EventHandler(this.appluRpc_Click);
            // 
            // textRpc
            // 
            this.textRpc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textRpc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textRpc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textRpc.Location = new System.Drawing.Point(10, 77);
            this.textRpc.Name = "textRpc";
            this.textRpc.Size = new System.Drawing.Size(247, 21);
            this.textRpc.TabIndex = 19;
            this.textRpc.Text = "Prepare for v0.6!";
            // 
            // titleRpc
            // 
            this.titleRpc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.titleRpc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleRpc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.titleRpc.Location = new System.Drawing.Point(10, 50);
            this.titleRpc.Name = "titleRpc";
            this.titleRpc.Size = new System.Drawing.Size(247, 21);
            this.titleRpc.TabIndex = 18;
            this.titleRpc.Text = "https://pollery.eu";
            // 
            // intervalTitle
            // 
            this.intervalTitle.AutoSize = true;
            this.intervalTitle.BackColor = System.Drawing.Color.Transparent;
            this.intervalTitle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervalTitle.ForeColor = System.Drawing.Color.White;
            this.intervalTitle.Location = new System.Drawing.Point(10, 106);
            this.intervalTitle.Name = "intervalTitle";
            this.intervalTitle.Size = new System.Drawing.Size(131, 17);
            this.intervalTitle.TabIndex = 17;
            this.intervalTitle.Text = "Refresh interval: (ms)";
            // 
            // useRpc
            // 
            this.useRpc.AutoSize = true;
            this.useRpc.BackColor = System.Drawing.Color.Transparent;
            this.useRpc.Checked = true;
            this.useRpc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useRpc.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useRpc.ForeColor = System.Drawing.Color.White;
            this.useRpc.Location = new System.Drawing.Point(10, 24);
            this.useRpc.Name = "useRpc";
            this.useRpc.Size = new System.Drawing.Size(73, 20);
            this.useRpc.TabIndex = 12;
            this.useRpc.Text = "Enabled";
            this.useRpc.CheckedChanged += new System.EventHandler(this.useRpc_CheckedChanged);
            // 
            // intervalNum
            // 
            this.intervalNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.intervalNum.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervalNum.Location = new System.Drawing.Point(11, 127);
            this.intervalNum.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.intervalNum.Name = "intervalNum";
            this.intervalNum.Size = new System.Drawing.Size(130, 21);
            this.intervalNum.TabIndex = 16;
            this.intervalNum.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // gpuSelectPanel
            // 
            this.gpuSelectPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gpuSelectPanel.Controls.Add(this.useLightMode);
            this.gpuSelectPanel.Controls.Add(this.cpuL);
            this.gpuSelectPanel.Controls.Add(this.useGpu);
            this.gpuSelectPanel.Controls.Add(this.amdRadio);
            this.gpuSelectPanel.Controls.Add(this.nvidiaRadio);
            this.gpuSelectPanel.Controls.Add(this.cpuNum);
            this.gpuSelectPanel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuSelectPanel.ForeColor = System.Drawing.Color.White;
            this.gpuSelectPanel.Location = new System.Drawing.Point(212, 12);
            this.gpuSelectPanel.Name = "gpuSelectPanel";
            this.gpuSelectPanel.Size = new System.Drawing.Size(200, 189);
            this.gpuSelectPanel.TabIndex = 2;
            this.gpuSelectPanel.TabStop = false;
            this.gpuSelectPanel.Text = "P-Coin mining";
            // 
            // useLightMode
            // 
            this.useLightMode.AutoSize = true;
            this.useLightMode.BackColor = System.Drawing.Color.Transparent;
            this.useLightMode.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useLightMode.ForeColor = System.Drawing.Color.White;
            this.useLightMode.Location = new System.Drawing.Point(12, 144);
            this.useLightMode.Name = "useLightMode";
            this.useLightMode.Size = new System.Drawing.Size(88, 20);
            this.useLightMode.TabIndex = 15;
            this.useLightMode.Text = "Light Mode";
            this.useLightMode.CheckedChanged += new System.EventHandler(this.useLightMode_CheckedChanged);
            // 
            // cpuL
            // 
            this.cpuL.AutoSize = true;
            this.cpuL.BackColor = System.Drawing.Color.Transparent;
            this.cpuL.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuL.ForeColor = System.Drawing.Color.White;
            this.cpuL.Location = new System.Drawing.Point(10, 97);
            this.cpuL.Name = "cpuL";
            this.cpuL.Size = new System.Drawing.Size(72, 17);
            this.cpuL.TabIndex = 17;
            this.cpuL.Text = "CPU Cores:";
            // 
            // useGpu
            // 
            this.useGpu.AutoSize = true;
            this.useGpu.BackColor = System.Drawing.Color.Transparent;
            this.useGpu.Checked = true;
            this.useGpu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useGpu.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useGpu.ForeColor = System.Drawing.Color.White;
            this.useGpu.Location = new System.Drawing.Point(10, 24);
            this.useGpu.Name = "useGpu";
            this.useGpu.Size = new System.Drawing.Size(74, 20);
            this.useGpu.TabIndex = 12;
            this.useGpu.Text = "Use GPU";
            this.useGpu.CheckedChanged += new System.EventHandler(this.useGpu_CheckedChanged);
            // 
            // amdRadio
            // 
            this.amdRadio.AutoSize = true;
            this.amdRadio.BackColor = System.Drawing.Color.Transparent;
            this.amdRadio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amdRadio.ForeColor = System.Drawing.Color.White;
            this.amdRadio.Location = new System.Drawing.Point(18, 69);
            this.amdRadio.Name = "amdRadio";
            this.amdRadio.Size = new System.Drawing.Size(52, 20);
            this.amdRadio.TabIndex = 14;
            this.amdRadio.Text = "AMD";
            // 
            // nvidiaRadio
            // 
            this.nvidiaRadio.AutoSize = true;
            this.nvidiaRadio.BackColor = System.Drawing.Color.Transparent;
            this.nvidiaRadio.Checked = true;
            this.nvidiaRadio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvidiaRadio.ForeColor = System.Drawing.Color.White;
            this.nvidiaRadio.Location = new System.Drawing.Point(17, 46);
            this.nvidiaRadio.Name = "nvidiaRadio";
            this.nvidiaRadio.Size = new System.Drawing.Size(62, 20);
            this.nvidiaRadio.TabIndex = 13;
            this.nvidiaRadio.TabStop = true;
            this.nvidiaRadio.Text = "Nvidia";
            // 
            // cpuNum
            // 
            this.cpuNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpuNum.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuNum.Location = new System.Drawing.Point(11, 117);
            this.cpuNum.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.cpuNum.Name = "cpuNum";
            this.cpuNum.Size = new System.Drawing.Size(108, 21);
            this.cpuNum.TabIndex = 16;
            // 
            // designOptions
            // 
            this.designOptions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.designOptions.Controls.Add(this.saveConfig);
            this.designOptions.Controls.Add(this.pingB);
            this.designOptions.Controls.Add(this.conState);
            this.designOptions.Controls.Add(this.hostLabel);
            this.designOptions.Controls.Add(this.pingLabel);
            this.designOptions.Controls.Add(this.serverCon);
            this.designOptions.Controls.Add(this.rgbBox);
            this.designOptions.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designOptions.ForeColor = System.Drawing.Color.White;
            this.designOptions.Location = new System.Drawing.Point(6, 12);
            this.designOptions.Name = "designOptions";
            this.designOptions.Size = new System.Drawing.Size(200, 189);
            this.designOptions.TabIndex = 1;
            this.designOptions.TabStop = false;
            this.designOptions.Text = "General";
            // 
            // saveConfig
            // 
            this.saveConfig.Location = new System.Drawing.Point(12, 154);
            this.saveConfig.Name = "saveConfig";
            this.saveConfig.Padding = new System.Windows.Forms.Padding(5);
            this.saveConfig.Size = new System.Drawing.Size(88, 23);
            this.saveConfig.TabIndex = 23;
            this.saveConfig.Text = "Save Config";
            this.saveConfig.Click += new System.EventHandler(this.saveConfig_Click);
            // 
            // pingB
            // 
            this.pingB.Location = new System.Drawing.Point(113, 154);
            this.pingB.Name = "pingB";
            this.pingB.Padding = new System.Windows.Forms.Padding(5);
            this.pingB.Size = new System.Drawing.Size(75, 23);
            this.pingB.TabIndex = 22;
            this.pingB.Text = "Ping";
            this.pingB.Click += new System.EventHandler(this.pingB_Click);
            // 
            // conState
            // 
            this.conState.AutoSize = true;
            this.conState.BackColor = System.Drawing.Color.Transparent;
            this.conState.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conState.ForeColor = System.Drawing.Color.White;
            this.conState.Location = new System.Drawing.Point(29, 121);
            this.conState.Name = "conState";
            this.conState.Size = new System.Drawing.Size(140, 17);
            this.conState.TabIndex = 21;
            this.conState.Text = "Connection State: null";
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.BackColor = System.Drawing.Color.Transparent;
            this.hostLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostLabel.ForeColor = System.Drawing.Color.White;
            this.hostLabel.Location = new System.Drawing.Point(29, 77);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(98, 17);
            this.hostLabel.TabIndex = 20;
            this.hostLabel.Text = "Host: pollery.eu";
            // 
            // pingLabel
            // 
            this.pingLabel.AutoSize = true;
            this.pingLabel.BackColor = System.Drawing.Color.Transparent;
            this.pingLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pingLabel.ForeColor = System.Drawing.Color.White;
            this.pingLabel.Location = new System.Drawing.Point(29, 99);
            this.pingLabel.Name = "pingLabel";
            this.pingLabel.Size = new System.Drawing.Size(122, 17);
            this.pingLabel.TabIndex = 19;
            this.pingLabel.Text = "Estimated ping: null";
            // 
            // serverCon
            // 
            this.serverCon.AutoSize = true;
            this.serverCon.BackColor = System.Drawing.Color.Transparent;
            this.serverCon.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverCon.ForeColor = System.Drawing.Color.White;
            this.serverCon.Location = new System.Drawing.Point(12, 56);
            this.serverCon.Name = "serverCon";
            this.serverCon.Size = new System.Drawing.Size(126, 17);
            this.serverCon.TabIndex = 18;
            this.serverCon.Text = "Server Connection: ";
            // 
            // rgbBox
            // 
            this.rgbBox.AutoSize = true;
            this.rgbBox.Checked = true;
            this.rgbBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rgbBox.Location = new System.Drawing.Point(15, 24);
            this.rgbBox.Name = "rgbBox";
            this.rgbBox.Size = new System.Drawing.Size(113, 20);
            this.rgbBox.TabIndex = 0;
            this.rgbBox.Text = "Rainbow Border";
            this.rgbBox.CheckedChanged += new System.EventHandler(this.rgbBox_CheckedChanged);
            // 
            // builderPanel
            // 
            this.builderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.builderPanel.Controls.Add(this.teamgroupbox);
            this.builderPanel.Controls.Add(this.logsLabel);
            this.builderPanel.Controls.Add(this.passDecodingSection);
            this.builderPanel.Controls.Add(this.pluginsSection);
            this.builderPanel.Controls.Add(this.buildB);
            this.builderPanel.Controls.Add(this.deliverySection);
            this.builderPanel.Controls.Add(this.featuresSection);
            this.builderPanel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.builderPanel.Location = new System.Drawing.Point(4, 24);
            this.builderPanel.Name = "builderPanel";
            this.builderPanel.Size = new System.Drawing.Size(687, 401);
            this.builderPanel.TabIndex = 3;
            this.builderPanel.Text = "Builder Page";
            // 
            // teamgroupbox
            // 
            this.teamgroupbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.teamgroupbox.Controls.Add(this.iconBox);
            this.teamgroupbox.Controls.Add(this.selectIcon);
            this.teamgroupbox.Controls.Add(this.darkLabel1);
            this.teamgroupbox.Controls.Add(this.selecticonlabel);
            this.teamgroupbox.Controls.Add(this.teamSelector);
            this.teamgroupbox.Location = new System.Drawing.Point(496, 15);
            this.teamgroupbox.Name = "teamgroupbox";
            this.teamgroupbox.Size = new System.Drawing.Size(188, 188);
            this.teamgroupbox.TabIndex = 6;
            this.teamgroupbox.TabStop = false;
            this.teamgroupbox.Text = "Other";
            // 
            // iconBox
            // 
            this.iconBox.BackColor = System.Drawing.Color.Transparent;
            this.iconBox.Location = new System.Drawing.Point(129, 121);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(50, 50);
            this.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconBox.TabIndex = 1;
            this.iconBox.TabStop = false;
            // 
            // selectIcon
            // 
            this.selectIcon.Location = new System.Drawing.Point(53, 143);
            this.selectIcon.Name = "selectIcon";
            this.selectIcon.Padding = new System.Windows.Forms.Padding(5);
            this.selectIcon.Size = new System.Drawing.Size(49, 23);
            this.selectIcon.TabIndex = 7;
            this.selectIcon.Text = "...";
            this.selectIcon.Click += new System.EventHandler(this.selectIcon_Click);
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(12, 28);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(90, 16);
            this.darkLabel1.TabIndex = 6;
            this.darkLabel1.Text = "Send to Teams:";
            // 
            // selecticonlabel
            // 
            this.selecticonlabel.AutoSize = true;
            this.selecticonlabel.BackColor = System.Drawing.Color.Transparent;
            this.selecticonlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.selecticonlabel.Location = new System.Drawing.Point(14, 121);
            this.selecticonlabel.Name = "selecticonlabel";
            this.selecticonlabel.Size = new System.Drawing.Size(88, 16);
            this.selecticonlabel.TabIndex = 6;
            this.selecticonlabel.Text = "Select an icon:";
            // 
            // teamSelector
            // 
            this.teamSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.teamSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamSelector.ForeColor = System.Drawing.Color.Gainsboro;
            this.teamSelector.FormattingEnabled = true;
            this.teamSelector.Location = new System.Drawing.Point(15, 47);
            this.teamSelector.Name = "teamSelector";
            this.teamSelector.Size = new System.Drawing.Size(164, 66);
            this.teamSelector.TabIndex = 0;
            // 
            // logsLabel
            // 
            this.logsLabel.AutoSize = true;
            this.logsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.logsLabel.Location = new System.Drawing.Point(250, 366);
            this.logsLabel.Name = "logsLabel";
            this.logsLabel.Size = new System.Drawing.Size(57, 16);
            this.logsLabel.TabIndex = 5;
            this.logsLabel.Text = "Logs: Idle";
            // 
            // passDecodingSection
            // 
            this.passDecodingSection.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.passDecodingSection.Controls.Add(this.selectOptionLabel);
            this.passDecodingSection.Controls.Add(this.testPass);
            this.passDecodingSection.Controls.Add(this.internalPass);
            this.passDecodingSection.Controls.Add(this.externalPass);
            this.passDecodingSection.Controls.Add(this.passDecLabel);
            this.passDecodingSection.Location = new System.Drawing.Point(242, 210);
            this.passDecodingSection.Name = "passDecodingSection";
            this.passDecodingSection.Size = new System.Drawing.Size(224, 147);
            this.passDecodingSection.TabIndex = 4;
            this.passDecodingSection.TabStop = false;
            this.passDecodingSection.Text = "Password Decoding";
            // 
            // selectOptionLabel
            // 
            this.selectOptionLabel.AutoSize = true;
            this.selectOptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectOptionLabel.Location = new System.Drawing.Point(8, 106);
            this.selectOptionLabel.Name = "selectOptionLabel";
            this.selectOptionLabel.Size = new System.Drawing.Size(123, 32);
            this.selectOptionLabel.TabIndex = 7;
            this.selectOptionLabel.Text = "Select an option and\r\nclick test to check.";
            this.selectOptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // testPass
            // 
            this.testPass.BackColor = System.Drawing.Color.Transparent;
            this.testPass.Location = new System.Drawing.Point(137, 115);
            this.testPass.Name = "testPass";
            this.testPass.Padding = new System.Windows.Forms.Padding(5);
            this.testPass.Size = new System.Drawing.Size(75, 23);
            this.testPass.TabIndex = 6;
            this.testPass.Text = "Test";
            this.testPass.Click += new System.EventHandler(this.testPass_Click);
            // 
            // internalPass
            // 
            this.internalPass.AutoSize = true;
            this.internalPass.Checked = true;
            this.internalPass.Location = new System.Drawing.Point(19, 47);
            this.internalPass.Name = "internalPass";
            this.internalPass.Size = new System.Drawing.Size(182, 20);
            this.internalPass.TabIndex = 5;
            this.internalPass.TabStop = true;
            this.internalPass.Text = "Internal [new | undetected]";
            // 
            // externalPass
            // 
            this.externalPass.AutoSize = true;
            this.externalPass.Location = new System.Drawing.Point(19, 70);
            this.externalPass.Name = "externalPass";
            this.externalPass.Size = new System.Drawing.Size(172, 20);
            this.externalPass.TabIndex = 3;
            this.externalPass.Text = "External [ama | detected]";
            // 
            // passDecLabel
            // 
            this.passDecLabel.AutoSize = true;
            this.passDecLabel.BackColor = System.Drawing.Color.Transparent;
            this.passDecLabel.Location = new System.Drawing.Point(16, 25);
            this.passDecLabel.Name = "passDecLabel";
            this.passDecLabel.Size = new System.Drawing.Size(164, 16);
            this.passDecLabel.TabIndex = 2;
            this.passDecLabel.Text = "Password decoding method:";
            // 
            // pluginsSection
            // 
            this.pluginsSection.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pluginsSection.Controls.Add(this.pluginsGuide);
            this.pluginsSection.Controls.Add(this.removeBox);
            this.pluginsSection.Controls.Add(this.importPlugins);
            this.pluginsSection.Controls.Add(this.pluginsList);
            this.pluginsSection.Location = new System.Drawing.Point(241, 15);
            this.pluginsSection.Name = "pluginsSection";
            this.pluginsSection.Size = new System.Drawing.Size(261, 188);
            this.pluginsSection.TabIndex = 3;
            this.pluginsSection.TabStop = false;
            this.pluginsSection.Text = "Plugins [Experimental]";
            // 
            // pluginsGuide
            // 
            this.pluginsGuide.BackColor = System.Drawing.Color.Transparent;
            this.pluginsGuide.Location = new System.Drawing.Point(12, 153);
            this.pluginsGuide.Name = "pluginsGuide";
            this.pluginsGuide.Padding = new System.Windows.Forms.Padding(5);
            this.pluginsGuide.Size = new System.Drawing.Size(75, 23);
            this.pluginsGuide.TabIndex = 5;
            this.pluginsGuide.Text = "Guide";
            this.pluginsGuide.Click += new System.EventHandler(this.pluginsGuide_Click);
            // 
            // removeBox
            // 
            this.removeBox.BackColor = System.Drawing.Color.Transparent;
            this.removeBox.Location = new System.Drawing.Point(93, 153);
            this.removeBox.Name = "removeBox";
            this.removeBox.Padding = new System.Windows.Forms.Padding(5);
            this.removeBox.Size = new System.Drawing.Size(75, 23);
            this.removeBox.TabIndex = 4;
            this.removeBox.Text = "Remove";
            this.removeBox.Click += new System.EventHandler(this.removeBox_Click);
            // 
            // importPlugins
            // 
            this.importPlugins.BackColor = System.Drawing.Color.Transparent;
            this.importPlugins.Location = new System.Drawing.Point(174, 153);
            this.importPlugins.Name = "importPlugins";
            this.importPlugins.Padding = new System.Windows.Forms.Padding(5);
            this.importPlugins.Size = new System.Drawing.Size(75, 23);
            this.importPlugins.TabIndex = 3;
            this.importPlugins.Text = "Import";
            this.importPlugins.Click += new System.EventHandler(this.importPlugins_Click);
            // 
            // pluginsList
            // 
            this.pluginsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.pluginsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pluginsList.ForeColor = System.Drawing.Color.Gainsboro;
            this.pluginsList.FormattingEnabled = true;
            this.pluginsList.Location = new System.Drawing.Point(12, 33);
            this.pluginsList.Name = "pluginsList";
            this.pluginsList.Size = new System.Drawing.Size(237, 114);
            this.pluginsList.TabIndex = 0;
            // 
            // buildB
            // 
            this.buildB.BackColor = System.Drawing.Color.DimGray;
            this.buildB.Location = new System.Drawing.Point(600, 363);
            this.buildB.Name = "buildB";
            this.buildB.Padding = new System.Windows.Forms.Padding(5);
            this.buildB.Size = new System.Drawing.Size(75, 23);
            this.buildB.TabIndex = 2;
            this.buildB.Text = "Build";
            this.buildB.Click += new System.EventHandler(this.buildB_Click);
            // 
            // deliverySection
            // 
            this.deliverySection.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.deliverySection.Controls.Add(this.webhookDelivery);
            this.deliverySection.Controls.Add(this.deliveryTitle);
            this.deliverySection.Controls.Add(this.emailDelivery);
            this.deliverySection.Controls.Add(this.serverDelivery);
            this.deliverySection.Location = new System.Drawing.Point(472, 209);
            this.deliverySection.Name = "deliverySection";
            this.deliverySection.Size = new System.Drawing.Size(212, 148);
            this.deliverySection.TabIndex = 1;
            this.deliverySection.TabStop = false;
            this.deliverySection.Text = "Delivery";
            // 
            // webhookDelivery
            // 
            this.webhookDelivery.AutoSize = true;
            this.webhookDelivery.Location = new System.Drawing.Point(18, 71);
            this.webhookDelivery.Name = "webhookDelivery";
            this.webhookDelivery.Size = new System.Drawing.Size(91, 20);
            this.webhookDelivery.TabIndex = 2;
            this.webhookDelivery.Text = "Webhook(s)";
            // 
            // deliveryTitle
            // 
            this.deliveryTitle.AutoSize = true;
            this.deliveryTitle.BackColor = System.Drawing.Color.Transparent;
            this.deliveryTitle.Location = new System.Drawing.Point(15, 26);
            this.deliveryTitle.Name = "deliveryTitle";
            this.deliveryTitle.Size = new System.Drawing.Size(104, 16);
            this.deliveryTitle.TabIndex = 2;
            this.deliveryTitle.Text = "Delivery methods:";
            // 
            // emailDelivery
            // 
            this.emailDelivery.AutoSize = true;
            this.emailDelivery.Location = new System.Drawing.Point(18, 97);
            this.emailDelivery.Name = "emailDelivery";
            this.emailDelivery.Size = new System.Drawing.Size(55, 20);
            this.emailDelivery.TabIndex = 1;
            this.emailDelivery.Text = "Email";
            // 
            // serverDelivery
            // 
            this.serverDelivery.AutoSize = true;
            this.serverDelivery.Checked = true;
            this.serverDelivery.CheckState = System.Windows.Forms.CheckState.Checked;
            this.serverDelivery.Enabled = false;
            this.serverDelivery.Location = new System.Drawing.Point(18, 45);
            this.serverDelivery.Name = "serverDelivery";
            this.serverDelivery.Size = new System.Drawing.Size(102, 20);
            this.serverDelivery.TabIndex = 0;
            this.serverDelivery.Text = "Pollery Servers";
            // 
            // featuresSection
            // 
            this.featuresSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.featuresSection.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.featuresSection.Controls.Add(this.darkLabel2);
            this.featuresSection.Controls.Add(this.reportB);
            this.featuresSection.Controls.Add(this.featuresTree);
            this.featuresSection.Location = new System.Drawing.Point(13, 15);
            this.featuresSection.Name = "featuresSection";
            this.featuresSection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.featuresSection.Size = new System.Drawing.Size(223, 371);
            this.featuresSection.TabIndex = 0;
            this.featuresSection.TabStop = false;
            this.featuresSection.Text = "Features";
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(6, 294);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(189, 32);
            this.darkLabel2.TabIndex = 8;
            this.darkLabel2.Text = "Having an issue? Click report and\r\nsend the code to the developer.";
            // 
            // reportB
            // 
            this.reportB.BackColor = System.Drawing.Color.Transparent;
            this.reportB.Location = new System.Drawing.Point(133, 334);
            this.reportB.Name = "reportB";
            this.reportB.Padding = new System.Windows.Forms.Padding(5);
            this.reportB.Size = new System.Drawing.Size(75, 23);
            this.reportB.TabIndex = 7;
            this.reportB.Text = "Report";
            this.reportB.Click += new System.EventHandler(this.reportB_Click);
            // 
            // featuresTree
            // 
            this.featuresTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.featuresTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.featuresTree.CheckBoxes = true;
            this.featuresTree.ForeColor = System.Drawing.Color.LightGray;
            this.featuresTree.Location = new System.Drawing.Point(4, 25);
            this.featuresTree.Name = "featuresTree";
            treeNode1.Name = "startup";
            treeNode1.Text = "Start on Boot";
            treeNode2.Name = "token";
            treeNode2.Text = "Steal Discord Token";
            treeNode3.Name = "machinename";
            treeNode3.Text = "Steal Machine Name";
            treeNode4.Name = "mac";
            treeNode4.Text = "Steal Mac Addresses";
            treeNode5.Name = "screenshot";
            treeNode5.Text = "Take a Screenshot";
            treeNode6.Name = "browser";
            treeNode6.Text = "Steal Browser Credentials";
            treeNode7.Name = "runasadmin";
            treeNode7.Text = "Run as Admin";
            treeNode8.Name = "hide";
            treeNode8.Text = "Hide Stealer";
            treeNode9.Name = "antitaskmanager";
            treeNode9.Text = "Anti Task Manager";
            treeNode10.Name = "trace";
            treeNode10.Text = "Trace save.dat File";
            treeNode11.Name = "basicOpts";
            treeNode11.Text = "Basic";
            treeNode12.Name = "disablewindefender";
            treeNode12.Text = "Disable Windows Defender !";
            treeNode13.Name = "pcoin";
            treeNode13.Text = "Mine P-Coin [Experimental]";
            treeNode14.Name = "advancedOpts";
            treeNode14.Text = "Advanced";
            this.featuresTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode14});
            this.featuresTree.Size = new System.Drawing.Size(215, 260);
            this.featuresTree.TabIndex = 0;
            // 
            // otherPanel
            // 
            this.otherPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.otherPanel.Controls.Add(this.transactionsB);
            this.otherPanel.Controls.Add(this.statL);
            this.otherPanel.Controls.Add(this.coinChart);
            this.otherPanel.Controls.Add(this.stopCoin);
            this.otherPanel.Controls.Add(this.coinAddr);
            this.otherPanel.Controls.Add(this.coinAmount);
            this.otherPanel.Controls.Add(this.coinL2);
            this.otherPanel.Controls.Add(this.startCoin);
            this.otherPanel.Controls.Add(this.coinL1);
            this.otherPanel.Location = new System.Drawing.Point(4, 24);
            this.otherPanel.Name = "otherPanel";
            this.otherPanel.Size = new System.Drawing.Size(687, 401);
            this.otherPanel.TabIndex = 2;
            this.otherPanel.Text = "Other Page";
            // 
            // transactionsB
            // 
            this.transactionsB.Location = new System.Drawing.Point(566, 12);
            this.transactionsB.Name = "transactionsB";
            this.transactionsB.Padding = new System.Windows.Forms.Padding(5);
            this.transactionsB.Size = new System.Drawing.Size(110, 24);
            this.transactionsB.TabIndex = 21;
            this.transactionsB.Text = "Transactions";
            this.transactionsB.Click += new System.EventHandler(this.transactionsB_Click);
            // 
            // statL
            // 
            this.statL.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statL.ForeColor = System.Drawing.Color.White;
            this.statL.Location = new System.Drawing.Point(437, 328);
            this.statL.Name = "statL";
            this.statL.Size = new System.Drawing.Size(238, 26);
            this.statL.TabIndex = 6;
            this.statL.Text = "Status: idle";
            this.statL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // coinChart
            // 
            this.coinChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.Title = "Time";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LabelStyle.Enabled = false;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.Interval = 100D;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Straight;
            chartArea1.AxisY.ScaleBreakStyle.CollapsibleSpaceThreshold = 10;
            chartArea1.AxisY.ScaleBreakStyle.Enabled = true;
            chartArea1.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.ScaleBreakStyle.MaxNumberOfBreaks = 1;
            chartArea1.AxisY.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.No;
            chartArea1.AxisY.Title = "P-Coin";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.InterlacedColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY2.LabelStyle.Enabled = false;
            chartArea1.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Black;
            this.coinChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Century Gothic", 8F);
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.coinChart.Legends.Add(legend1);
            this.coinChart.Location = new System.Drawing.Point(14, 77);
            this.coinChart.Name = "coinChart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.LegendText = "P-Coin / Min";
            series1.Name = "Series1";
            series1.ShadowColor = System.Drawing.Color.Black;
            series1.ShadowOffset = 2;
            series1.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Transparent;
            this.coinChart.Series.Add(series1);
            this.coinChart.Size = new System.Drawing.Size(661, 277);
            this.coinChart.TabIndex = 5;
            title1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.Black;
            title1.ShadowOffset = 2;
            title1.Text = "Earned P-Coin";
            this.coinChart.Titles.Add(title1);
            // 
            // stopCoin
            // 
            this.stopCoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.stopCoin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.stopCoin.FlatAppearance.BorderSize = 0;
            this.stopCoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopCoin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopCoin.ForeColor = System.Drawing.Color.White;
            this.stopCoin.Location = new System.Drawing.Point(451, 360);
            this.stopCoin.Name = "stopCoin";
            this.stopCoin.Size = new System.Drawing.Size(109, 35);
            this.stopCoin.TabIndex = 4;
            this.stopCoin.Text = "Stop";
            this.stopCoin.UseVisualStyleBackColor = false;
            this.stopCoin.Click += new System.EventHandler(this.stopCoin_Click);
            // 
            // coinAddr
            // 
            this.coinAddr.AutoSize = true;
            this.coinAddr.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinAddr.ForeColor = System.Drawing.Color.White;
            this.coinAddr.Location = new System.Drawing.Point(11, 371);
            this.coinAddr.Name = "coinAddr";
            this.coinAddr.Size = new System.Drawing.Size(241, 17);
            this.coinAddr.TabIndex = 3;
            this.coinAddr.Text = "Your Address: <null> | Click to copy!";
            this.coinAddr.Click += new System.EventHandler(this.coinAddr_Click);
            // 
            // coinAmount
            // 
            this.coinAmount.AutoSize = true;
            this.coinAmount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinAmount.ForeColor = System.Drawing.Color.White;
            this.coinAmount.Location = new System.Drawing.Point(10, 13);
            this.coinAmount.Name = "coinAmount";
            this.coinAmount.Size = new System.Drawing.Size(76, 20);
            this.coinAmount.TabIndex = 10;
            this.coinAmount.Text = "P$: <null>";
            this.coinAmount.Click += new System.EventHandler(this.coinAmount_Click);
            // 
            // coinL2
            // 
            this.coinL2.AutoSize = true;
            this.coinL2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinL2.ForeColor = System.Drawing.Color.White;
            this.coinL2.Location = new System.Drawing.Point(213, 46);
            this.coinL2.Name = "coinL2";
            this.coinL2.Size = new System.Drawing.Size(267, 20);
            this.coinL2.TabIndex = 2;
            this.coinL2.Text = "The first Growtopia cryptocurrency.";
            // 
            // startCoin
            // 
            this.startCoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.startCoin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.startCoin.FlatAppearance.BorderSize = 0;
            this.startCoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startCoin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startCoin.ForeColor = System.Drawing.Color.White;
            this.startCoin.Location = new System.Drawing.Point(566, 360);
            this.startCoin.Name = "startCoin";
            this.startCoin.Size = new System.Drawing.Size(109, 35);
            this.startCoin.TabIndex = 1;
            this.startCoin.Text = "Start";
            this.startCoin.UseVisualStyleBackColor = false;
            this.startCoin.Click += new System.EventHandler(this.startCoin_Click);
            // 
            // coinL1
            // 
            this.coinL1.AutoSize = true;
            this.coinL1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinL1.ForeColor = System.Drawing.Color.White;
            this.coinL1.Location = new System.Drawing.Point(253, 17);
            this.coinL1.Name = "coinL1";
            this.coinL1.Size = new System.Drawing.Size(186, 22);
            this.coinL1.TabIndex = 0;
            this.coinL1.Text = "Introcuding: P-Coin";
            // 
            // titleL
            // 
            this.titleL.AutoSize = true;
            this.titleL.BackColor = System.Drawing.Color.Transparent;
            this.titleL.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleL.ForeColor = System.Drawing.Color.White;
            this.titleL.Location = new System.Drawing.Point(40, 26);
            this.titleL.Name = "titleL";
            this.titleL.Size = new System.Drawing.Size(57, 22);
            this.titleL.TabIndex = 2;
            this.titleL.Text = "ollery";
            this.titleL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            // 
            // sohard
            // 
            this.sohard.Image = global::Atheny.Properties.Resources.pog;
            this.sohard.Location = new System.Drawing.Point(8, 11);
            this.sohard.Name = "sohard";
            this.sohard.Size = new System.Drawing.Size(40, 35);
            this.sohard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sohard.TabIndex = 3;
            this.sohard.TabStop = false;
            this.sohard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            // 
            // minimizeB
            // 
            this.minimizeB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.minimizeB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeB.FlatAppearance.BorderSize = 0;
            this.minimizeB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.minimizeB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.minimizeB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeB.ForeColor = System.Drawing.Color.White;
            this.minimizeB.Location = new System.Drawing.Point(722, 0);
            this.minimizeB.Name = "minimizeB";
            this.minimizeB.Size = new System.Drawing.Size(35, 35);
            this.minimizeB.TabIndex = 1;
            this.minimizeB.Text = "_";
            this.minimizeB.UseVisualStyleBackColor = false;
            this.minimizeB.Click += new System.EventHandler(this.minimizeB_Click);
            // 
            // exitB
            // 
            this.exitB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.exitB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitB.FlatAppearance.BorderSize = 0;
            this.exitB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.exitB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.exitB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitB.ForeColor = System.Drawing.Color.White;
            this.exitB.Location = new System.Drawing.Point(757, 0);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(35, 35);
            this.exitB.TabIndex = 0;
            this.exitB.Text = "X";
            this.exitB.UseVisualStyleBackColor = false;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 434);
            this.panel2.TabIndex = 11;
            // 
            // bgPanel
            // 
            this.bgPanel.Location = new System.Drawing.Point(0, 0);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(800, 503);
            this.bgPanel.TabIndex = 1;
            // 
            // rgbTimer
            // 
            this.rgbTimer.Enabled = true;
            this.rgbTimer.Interval = 5;
            this.rgbTimer.Tick += new System.EventHandler(this.rgbTimer_Tick);
            // 
            // updateConn
            // 
            this.updateConn.Enabled = true;
            this.updateConn.Interval = 7500;
            this.updateConn.Tick += new System.EventHandler(this.updateCpu_Tick);
            // 
            // rpcTimer
            // 
            this.rpcTimer.Enabled = true;
            this.rpcTimer.Interval = 5000;
            this.rpcTimer.Tick += new System.EventHandler(this.rpcTimer_Tick);
            // 
            // accMenu
            // 
            this.accMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.accMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.accMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.accMenu.Name = "accMenu";
            this.accMenu.Size = new System.Drawing.Size(109, 70);
            // 
            // checkToolStripMenuItem
            // 
            this.checkToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.checkToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.checkToolStripMenuItem.Name = "checkToolStripMenuItem";
            this.checkToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.checkToolStripMenuItem.Text = "Check";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalFormatToolStripMenuItem,
            this.growidpasswordFormatToolStripMenuItem});
            this.exportToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // normalFormatToolStripMenuItem
            // 
            this.normalFormatToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.normalFormatToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.normalFormatToolStripMenuItem.Name = "normalFormatToolStripMenuItem";
            this.normalFormatToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.normalFormatToolStripMenuItem.Text = "Normal Format";
            this.normalFormatToolStripMenuItem.Click += new System.EventHandler(this.normalFormatToolStripMenuItem_Click);
            // 
            // growidpasswordFormatToolStripMenuItem
            // 
            this.growidpasswordFormatToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.growidpasswordFormatToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.growidpasswordFormatToolStripMenuItem.Name = "growidpasswordFormatToolStripMenuItem";
            this.growidpasswordFormatToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.growidpasswordFormatToolStripMenuItem.Text = "Id:Password Format";
            this.growidpasswordFormatToolStripMenuItem.Click += new System.EventHandler(this.growidpasswordFormatToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.bgPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Pollery";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.mainCoinH.ResumeLayout(false);
            this.mainBH.ResumeLayout(false);
            this.mainCH.ResumeLayout(false);
            this.mainPH.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.mainPage.ResumeLayout(false);
            this.mainPage.PerformLayout();
            this.configPage.ResumeLayout(false);
            this.darkGroupBox2.ResumeLayout(false);
            this.darkGroupBox2.PerformLayout();
            this.teamsGroup.ResumeLayout(false);
            this.teamsGroup.PerformLayout();
            this.rpcOptions.ResumeLayout(false);
            this.rpcOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNum)).EndInit();
            this.gpuSelectPanel.ResumeLayout(false);
            this.gpuSelectPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuNum)).EndInit();
            this.designOptions.ResumeLayout(false);
            this.designOptions.PerformLayout();
            this.builderPanel.ResumeLayout(false);
            this.builderPanel.PerformLayout();
            this.teamgroupbox.ResumeLayout(false);
            this.teamgroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.passDecodingSection.ResumeLayout(false);
            this.passDecodingSection.PerformLayout();
            this.pluginsSection.ResumeLayout(false);
            this.deliverySection.ResumeLayout(false);
            this.deliverySection.PerformLayout();
            this.featuresSection.ResumeLayout(false);
            this.featuresSection.PerformLayout();
            this.otherPanel.ResumeLayout(false);
            this.otherPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coinChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sohard)).EndInit();
            this.accMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button exitB;
        private System.Windows.Forms.Button minimizeB;
        private System.Windows.Forms.Label titleL;
        private System.Windows.Forms.Panel bgPanel;
        private System.Windows.Forms.Timer rgbTimer;
        private System.Windows.Forms.PictureBox sohard;
        private System.Windows.Forms.Panel otherPanelP;
        private System.Windows.Forms.Panel builderPanelP;
        private System.Windows.Forms.Panel configPanelP;
        private System.Windows.Forms.Panel mainPanelP;
        private TablessControl TabControl;
        private System.Windows.Forms.TabPage mainPage;
        private System.Windows.Forms.TabPage configPage;
        private System.Windows.Forms.TabPage otherPanel;
        private System.Windows.Forms.TabPage builderPanel;
        private System.Windows.Forms.Panel menuSelector;
        private System.Windows.Forms.Panel splitPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label coinL2;
        private System.Windows.Forms.Button startCoin;
        private System.Windows.Forms.Label coinL1;
        private System.Windows.Forms.DataVisualization.Charting.Chart coinChart;
        private System.Windows.Forms.Button stopCoin;
        private System.Windows.Forms.Label coinAddr;
        private System.Windows.Forms.Label statL;
        private System.Windows.Forms.Label coinAmount;
        private DarkButton renewB;
        private System.Windows.Forms.PropertyGrid accProperty;
        private DarkUI.Controls.DarkTreeView accTree;
        private DarkButton teamManager;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel mainCoinH;
        private System.Windows.Forms.Panel mainBH;
        private System.Windows.Forms.Panel mainCH;
        private System.Windows.Forms.Panel mainPH;
        private DarkCheckBox useGpu;
        private DarkRadioButton amdRadio;
        private DarkRadioButton nvidiaRadio;
        private DarkTitle cpuL;
        private DarkNumericUpDown cpuNum;
        private DarkCheckBox useLightMode;
        private DarkCheckBox showDupes;
        private DarkButton deserializeBrowser;
        private DarkGroupBox gpuSelectPanel;
        private DarkGroupBox designOptions;
        private DarkCheckBox rgbBox;
        private DarkGroupBox featuresSection;
        private DarkGroupBox rpcOptions;
        private DarkTitle intervalTitle;
        private DarkCheckBox useRpc;
        private DarkNumericUpDown intervalNum;
        private DarkButton appluRpc;
        private DarkTextBox textRpc;
        private DarkTextBox titleRpc;
        private DarkGroupBox teamsGroup;
        private DarkButton teamConfig;
        private DarkCheckBox enableTeams;
        private DarkCheckBox lessCpu;
        private DarkGroupBox darkGroupBox2;
        private DarkButton backupAdd;
        private System.Windows.Forms.ListBox backupWebhooks;
        private System.Windows.Forms.Panel panel5;
        private DarkCheckBox useHttps;
        private DarkTitle webhookTitle;
        private DarkTextBox webhookUrl;
        private DarkTextBox sendtomoreBox;
        private DarkCheckBox sendtomoreCheck;
        private DarkTitle smtpportTitle;
        private DarkTextBox smtpportBox;
        private DarkTitle smtpserverTItle;
        private DarkTitle emailTitle;
        private DarkTextBox stmpserverBox;
        private DarkTextBox emailBox;
        private DarkTitle serverCon;
        private System.Windows.Forms.Timer updateConn;
        private DarkTitle conState;
        private DarkTitle hostLabel;
        private DarkTitle pingLabel;
        private DarkButton pingB;
        private DarkTitle currentaccounts;
        private DarkTitle currentUsers;
        private DarkTitle verLabel;
        private DarkTitle updateAv;
        private System.Windows.Forms.Timer rpcTimer;
        private DarkButton saveConfig;
        private DarkContextMenu accMenu;
        private System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem growidpasswordFormatToolStripMenuItem;
        private System.Windows.Forms.Panel accTreePanel;
        private DarkButton transactionsB;
        private DarkGroupBox pluginsSection;
        private System.Windows.Forms.CheckedListBox pluginsList;
        private DarkButton buildB;
        private DarkGroupBox deliverySection;
        private DarkCheckBox webhookDelivery;
        private DarkTitle deliveryTitle;
        private DarkCheckBox emailDelivery;
        private DarkCheckBox serverDelivery;
        private System.Windows.Forms.TreeView featuresTree;
        private DarkButton pluginsGuide;
        private DarkButton removeBox;
        private DarkButton importPlugins;
        private DarkGroupBox passDecodingSection;
        private DarkTitle selectOptionLabel;
        private DarkButton testPass;
        private DarkRadioButton internalPass;
        private DarkRadioButton externalPass;
        private DarkTitle passDecLabel;
        private DarkLabel logsLabel;
        private DarkButton selectIcon;
        private DarkLabel selecticonlabel;
        private System.Windows.Forms.PictureBox iconBox;
        private DarkCheckBox minePCoin;
        private DarkButton removeSelected;
        private DarkGroupBox teamgroupbox;
        private DarkLabel darkLabel1;
        private System.Windows.Forms.CheckedListBox teamSelector;
        private DarkLabel darkLabel2;
        private DarkButton reportB;
    }
}

