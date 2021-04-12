namespace Atheny
{
    partial class PluginsGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginsGuide));
            this.darkTitle1 = new DarkUI.Controls.DarkTitle();
            this.howToPlugins = new DarkUI.Controls.DarkSectionPanel();
            this.usePluginsL = new DarkUI.Controls.DarkLabel();
            this.howToCreatePlugins = new DarkUI.Controls.DarkSectionPanel();
            this.createPluginsL = new DarkUI.Controls.DarkLabel();
            this.codeBox = new Zeroit.Framework.CodeTextBox.ZeroitCodeTextBox();
            this.savePlugin = new DarkUI.Controls.DarkButton();
            this.clearB = new DarkUI.Controls.DarkButton();
            this.redoB = new DarkUI.Controls.DarkButton();
            this.undoB = new DarkUI.Controls.DarkButton();
            this.minimizeB = new System.Windows.Forms.Button();
            this.exitB = new System.Windows.Forms.Button();
            this.howToPlugins.SuspendLayout();
            this.howToCreatePlugins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // darkTitle1
            // 
            this.darkTitle1.AutoSize = true;
            this.darkTitle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkTitle1.Location = new System.Drawing.Point(15, 15);
            this.darkTitle1.Name = "darkTitle1";
            this.darkTitle1.Size = new System.Drawing.Size(175, 22);
            this.darkTitle1.TabIndex = 0;
            this.darkTitle1.Text = "A guide to plugins";
            this.darkTitle1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            // 
            // howToPlugins
            // 
            this.howToPlugins.Controls.Add(this.usePluginsL);
            this.howToPlugins.Location = new System.Drawing.Point(12, 52);
            this.howToPlugins.Name = "howToPlugins";
            this.howToPlugins.SectionHeader = "How do I use plugins?";
            this.howToPlugins.Size = new System.Drawing.Size(241, 87);
            this.howToPlugins.TabIndex = 2;
            // 
            // usePluginsL
            // 
            this.usePluginsL.AutoSize = true;
            this.usePluginsL.BackColor = System.Drawing.Color.Transparent;
            this.usePluginsL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.usePluginsL.Location = new System.Drawing.Point(14, 37);
            this.usePluginsL.Name = "usePluginsL";
            this.usePluginsL.Size = new System.Drawing.Size(212, 32);
            this.usePluginsL.TabIndex = 0;
            this.usePluginsL.Text = "Simply, import or drag the plugin file to\r\nthe Plugins viewer and enable it.";
            // 
            // howToCreatePlugins
            // 
            this.howToCreatePlugins.Controls.Add(this.createPluginsL);
            this.howToCreatePlugins.Location = new System.Drawing.Point(259, 52);
            this.howToCreatePlugins.Name = "howToCreatePlugins";
            this.howToCreatePlugins.SectionHeader = "How do I create plugins?";
            this.howToCreatePlugins.Size = new System.Drawing.Size(387, 87);
            this.howToCreatePlugins.TabIndex = 3;
            // 
            // createPluginsL
            // 
            this.createPluginsL.AutoSize = true;
            this.createPluginsL.BackColor = System.Drawing.Color.Transparent;
            this.createPluginsL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.createPluginsL.Location = new System.Drawing.Point(8, 31);
            this.createPluginsL.Name = "createPluginsL";
            this.createPluginsL.Size = new System.Drawing.Size(366, 48);
            this.createPluginsL.TabIndex = 0;
            this.createPluginsL.Text = "This process is a little harder and you must have basic\r\nc# knowledge. Write the " +
    "plugin code in the box below or some IDE\r\nand click the \"Save\" button.\r\n";
            // 
            // codeBox
            // 
            this.codeBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.codeBox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.codeBox.AutoScrollMinSize = new System.Drawing.Size(0, 56);
            this.codeBox.BackBrush = null;
            this.codeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.codeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeBox.BracketsHighlightStrategy = Zeroit.Framework.CodeTextBox.BracketsHighlightStrategy.Strategy2;
            this.codeBox.CharHeight = 14;
            this.codeBox.CharWidth = 8;
            this.codeBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.codeBox.FoldingIndicatorColor = System.Drawing.Color.PaleGreen;
            this.codeBox.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.codeBox.ForeColor = System.Drawing.Color.White;
            this.codeBox.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.codeBox.IsReplaceMode = false;
            this.codeBox.Language = Zeroit.Framework.CodeTextBox.Language.CSharp;
            this.codeBox.LeftBracket = '(';
            this.codeBox.LeftBracket2 = '{';
            this.codeBox.LineNumberColor = System.Drawing.Color.White;
            this.codeBox.Location = new System.Drawing.Point(12, 145);
            this.codeBox.Name = "codeBox";
            this.codeBox.Paddings = new System.Windows.Forms.Padding(0);
            this.codeBox.RightBracket = ')';
            this.codeBox.RightBracket2 = '}';
            this.codeBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.codeBox.ServiceColors = ((Zeroit.Framework.CodeTextBox.ServiceColors)(resources.GetObject("codeBox.ServiceColors")));
            this.codeBox.ServiceLinesColor = System.Drawing.Color.White;
            this.codeBox.Size = new System.Drawing.Size(557, 224);
            this.codeBox.TabIndex = 5;
            this.codeBox.Text = "//Note: Do not use classes!\r\nstring message = \"Hello World!\";\r\nConsole.WriteLine(" +
    "message);\r\n";
            this.codeBox.WordWrap = true;
            this.codeBox.Zoom = 100;
            // 
            // savePlugin
            // 
            this.savePlugin.Location = new System.Drawing.Point(575, 346);
            this.savePlugin.Name = "savePlugin";
            this.savePlugin.Padding = new System.Windows.Forms.Padding(5);
            this.savePlugin.Size = new System.Drawing.Size(75, 23);
            this.savePlugin.TabIndex = 1;
            this.savePlugin.Text = "Save";
            this.savePlugin.Click += new System.EventHandler(this.savePlugin_Click);
            // 
            // clearB
            // 
            this.clearB.Location = new System.Drawing.Point(575, 317);
            this.clearB.Name = "clearB";
            this.clearB.Padding = new System.Windows.Forms.Padding(5);
            this.clearB.Size = new System.Drawing.Size(75, 23);
            this.clearB.TabIndex = 6;
            this.clearB.Text = "Clear";
            this.clearB.Click += new System.EventHandler(this.clearB_Click);
            // 
            // redoB
            // 
            this.redoB.Location = new System.Drawing.Point(575, 288);
            this.redoB.Name = "redoB";
            this.redoB.Padding = new System.Windows.Forms.Padding(5);
            this.redoB.Size = new System.Drawing.Size(75, 23);
            this.redoB.TabIndex = 7;
            this.redoB.Text = "Redo";
            this.redoB.Click += new System.EventHandler(this.redoB_Click);
            // 
            // undoB
            // 
            this.undoB.Location = new System.Drawing.Point(575, 259);
            this.undoB.Name = "undoB";
            this.undoB.Padding = new System.Windows.Forms.Padding(5);
            this.undoB.Size = new System.Drawing.Size(75, 23);
            this.undoB.TabIndex = 8;
            this.undoB.Text = "Undo";
            this.undoB.Click += new System.EventHandler(this.undoB_Click);
            // 
            // minimizeB
            // 
            this.minimizeB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.minimizeB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeB.FlatAppearance.BorderSize = 0;
            this.minimizeB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.minimizeB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.minimizeB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeB.ForeColor = System.Drawing.Color.White;
            this.minimizeB.Location = new System.Drawing.Point(588, -1);
            this.minimizeB.Name = "minimizeB";
            this.minimizeB.Size = new System.Drawing.Size(35, 35);
            this.minimizeB.TabIndex = 3;
            this.minimizeB.Text = "_";
            this.minimizeB.UseVisualStyleBackColor = false;
            this.minimizeB.Click += new System.EventHandler(this.minimizeB_Click);
            // 
            // exitB
            // 
            this.exitB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.exitB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitB.FlatAppearance.BorderSize = 0;
            this.exitB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.exitB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.exitB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitB.ForeColor = System.Drawing.Color.White;
            this.exitB.Location = new System.Drawing.Point(623, -1);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(35, 35);
            this.exitB.TabIndex = 2;
            this.exitB.Text = "X";
            this.exitB.UseVisualStyleBackColor = false;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // PluginsGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(658, 381);
            this.Controls.Add(this.minimizeB);
            this.Controls.Add(this.undoB);
            this.Controls.Add(this.exitB);
            this.Controls.Add(this.redoB);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.savePlugin);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.howToCreatePlugins);
            this.Controls.Add(this.howToPlugins);
            this.Controls.Add(this.darkTitle1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PluginsGuide";
            this.Text = "PluginsGuide";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            this.howToPlugins.ResumeLayout(false);
            this.howToPlugins.PerformLayout();
            this.howToCreatePlugins.ResumeLayout(false);
            this.howToCreatePlugins.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkTitle darkTitle1;
        private DarkUI.Controls.DarkSectionPanel howToPlugins;
        private DarkUI.Controls.DarkLabel usePluginsL;
        private DarkUI.Controls.DarkSectionPanel howToCreatePlugins;
        private DarkUI.Controls.DarkLabel createPluginsL;
        private Zeroit.Framework.CodeTextBox.ZeroitCodeTextBox codeBox;
        private DarkUI.Controls.DarkButton savePlugin;
        private DarkUI.Controls.DarkButton clearB;
        private DarkUI.Controls.DarkButton redoB;
        private DarkUI.Controls.DarkButton undoB;
        private System.Windows.Forms.Button minimizeB;
        private System.Windows.Forms.Button exitB;
    }
}