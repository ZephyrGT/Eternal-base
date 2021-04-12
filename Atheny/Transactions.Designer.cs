namespace Atheny
{
    partial class Transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transactions));
            this.titleL = new System.Windows.Forms.Label();
            this.minimizeB = new System.Windows.Forms.Button();
            this.exitB = new System.Windows.Forms.Button();
            this.sendPCoin = new DarkUI.Controls.DarkButton();
            this.addressNum = new DarkUI.Controls.DarkTextBox();
            this.sendtoTitle = new DarkUI.Controls.DarkTitle();
            this.amountTitle = new DarkUI.Controls.DarkTitle();
            this.amountNum = new DarkUI.Controls.DarkNumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.amountNum)).BeginInit();
            this.SuspendLayout();
            // 
            // titleL
            // 
            this.titleL.AutoSize = true;
            this.titleL.BackColor = System.Drawing.Color.Transparent;
            this.titleL.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleL.ForeColor = System.Drawing.Color.White;
            this.titleL.Location = new System.Drawing.Point(13, 10);
            this.titleL.Name = "titleL";
            this.titleL.Size = new System.Drawing.Size(122, 22);
            this.titleL.TabIndex = 6;
            this.titleL.Text = "Transactions";
            this.titleL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
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
            this.minimizeB.Location = new System.Drawing.Point(420, 0);
            this.minimizeB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.minimizeB.Name = "minimizeB";
            this.minimizeB.Size = new System.Drawing.Size(41, 43);
            this.minimizeB.TabIndex = 11;
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
            this.exitB.Location = new System.Drawing.Point(461, 0);
            this.exitB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(41, 43);
            this.exitB.TabIndex = 10;
            this.exitB.Text = "X";
            this.exitB.UseVisualStyleBackColor = false;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // sendPCoin
            // 
            this.sendPCoin.Location = new System.Drawing.Point(388, 108);
            this.sendPCoin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendPCoin.Name = "sendPCoin";
            this.sendPCoin.Padding = new System.Windows.Forms.Padding(6);
            this.sendPCoin.Size = new System.Drawing.Size(87, 34);
            this.sendPCoin.TabIndex = 12;
            this.sendPCoin.Text = "Send";
            this.sendPCoin.Click += new System.EventHandler(this.sendPCoin_Click);
            // 
            // addressNum
            // 
            this.addressNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.addressNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.addressNum.Location = new System.Drawing.Point(29, 74);
            this.addressNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addressNum.Name = "addressNum";
            this.addressNum.Size = new System.Drawing.Size(446, 21);
            this.addressNum.TabIndex = 13;
            this.addressNum.TextChanged += new System.EventHandler(this.addressNum_TextChanged);
            // 
            // sendtoTitle
            // 
            this.sendtoTitle.AutoSize = true;
            this.sendtoTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendtoTitle.Location = new System.Drawing.Point(28, 53);
            this.sendtoTitle.Name = "sendtoTitle";
            this.sendtoTitle.Size = new System.Drawing.Size(61, 17);
            this.sendtoTitle.TabIndex = 14;
            this.sendtoTitle.Text = "Send to:";
            // 
            // amountTitle
            // 
            this.amountTitle.AutoSize = true;
            this.amountTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTitle.Location = new System.Drawing.Point(28, 99);
            this.amountTitle.Name = "amountTitle";
            this.amountTitle.Size = new System.Drawing.Size(64, 17);
            this.amountTitle.TabIndex = 16;
            this.amountTitle.Text = "Amount:";
            // 
            // amountNum
            // 
            this.amountNum.Location = new System.Drawing.Point(29, 121);
            this.amountNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.amountNum.Name = "amountNum";
            this.amountNum.Size = new System.Drawing.Size(89, 21);
            this.amountNum.TabIndex = 17;
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(504, 165);
            this.Controls.Add(this.amountNum);
            this.Controls.Add(this.amountTitle);
            this.Controls.Add(this.sendtoTitle);
            this.Controls.Add(this.addressNum);
            this.Controls.Add(this.sendPCoin);
            this.Controls.Add(this.minimizeB);
            this.Controls.Add(this.exitB);
            this.Controls.Add(this.titleL);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Transactions";
            this.Text = "Transactions Menu";
            this.Load += new System.EventHandler(this.Transactions_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            ((System.ComponentModel.ISupportInitialize)(this.amountNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleL;
        private System.Windows.Forms.Button minimizeB;
        private System.Windows.Forms.Button exitB;
        private DarkUI.Controls.DarkButton sendPCoin;
        private DarkUI.Controls.DarkTextBox addressNum;
        private DarkUI.Controls.DarkTitle sendtoTitle;
        private DarkUI.Controls.DarkTitle amountTitle;
        private DarkUI.Controls.DarkNumericUpDown amountNum;
    }
}