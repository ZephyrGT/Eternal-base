namespace Atheny
{
    partial class LoginPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPanel));
            this.titleL = new System.Windows.Forms.Label();
            this.sohard = new System.Windows.Forms.PictureBox();
            this.minimizeB = new System.Windows.Forms.Button();
            this.exitB = new System.Windows.Forms.Button();
            this.userBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.userL = new System.Windows.Forms.Label();
            this.passL = new System.Windows.Forms.Label();
            this.loginB = new System.Windows.Forms.Button();
            this.upperRgb = new System.Windows.Forms.Panel();
            this.rgb = new System.Windows.Forms.Timer(this.components);
            this.regB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.sohard)).BeginInit();
            this.SuspendLayout();
            // 
            // titleL
            // 
            this.titleL.AutoSize = true;
            this.titleL.BackColor = System.Drawing.Color.Transparent;
            this.titleL.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleL.ForeColor = System.Drawing.Color.White;
            this.titleL.Location = new System.Drawing.Point(40, 28);
            this.titleL.Name = "titleL";
            this.titleL.Size = new System.Drawing.Size(57, 22);
            this.titleL.TabIndex = 4;
            this.titleL.Text = "ollery";
            // 
            // sohard
            // 
            this.sohard.Image = global::Atheny.Properties.Resources.pog;
            this.sohard.Location = new System.Drawing.Point(8, 13);
            this.sohard.Name = "sohard";
            this.sohard.Size = new System.Drawing.Size(40, 35);
            this.sohard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sohard.TabIndex = 5;
            this.sohard.TabStop = false;
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
            this.minimizeB.Location = new System.Drawing.Point(322, 7);
            this.minimizeB.Name = "minimizeB";
            this.minimizeB.Size = new System.Drawing.Size(35, 35);
            this.minimizeB.TabIndex = 7;
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
            this.exitB.Location = new System.Drawing.Point(357, 7);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(35, 35);
            this.exitB.TabIndex = 6;
            this.exitB.Text = "X";
            this.exitB.UseVisualStyleBackColor = false;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // userBox
            // 
            this.userBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.userBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBox.ForeColor = System.Drawing.Color.White;
            this.userBox.Location = new System.Drawing.Point(12, 83);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(370, 23);
            this.userBox.TabIndex = 8;
            // 
            // passBox
            // 
            this.passBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox.ForeColor = System.Drawing.Color.White;
            this.passBox.Location = new System.Drawing.Point(13, 138);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(282, 23);
            this.passBox.TabIndex = 9;
            // 
            // userL
            // 
            this.userL.AutoSize = true;
            this.userL.BackColor = System.Drawing.Color.Transparent;
            this.userL.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userL.ForeColor = System.Drawing.Color.White;
            this.userL.Location = new System.Drawing.Point(12, 64);
            this.userL.Name = "userL";
            this.userL.Size = new System.Drawing.Size(66, 17);
            this.userL.TabIndex = 10;
            this.userL.Text = "username";
            // 
            // passL
            // 
            this.passL.AutoSize = true;
            this.passL.BackColor = System.Drawing.Color.Transparent;
            this.passL.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passL.ForeColor = System.Drawing.Color.White;
            this.passL.Location = new System.Drawing.Point(12, 117);
            this.passL.Name = "passL";
            this.passL.Size = new System.Drawing.Size(64, 17);
            this.passL.TabIndex = 11;
            this.passL.Text = "password";
            // 
            // loginB
            // 
            this.loginB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.loginB.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loginB.FlatAppearance.BorderSize = 0;
            this.loginB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginB.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginB.ForeColor = System.Drawing.Color.White;
            this.loginB.Location = new System.Drawing.Point(301, 113);
            this.loginB.Name = "loginB";
            this.loginB.Size = new System.Drawing.Size(80, 27);
            this.loginB.TabIndex = 12;
            this.loginB.Text = "Login";
            this.loginB.UseVisualStyleBackColor = false;
            this.loginB.Click += new System.EventHandler(this.loginB_Click);
            // 
            // upperRgb
            // 
            this.upperRgb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.upperRgb.Location = new System.Drawing.Point(0, 0);
            this.upperRgb.Name = "upperRgb";
            this.upperRgb.Size = new System.Drawing.Size(394, 5);
            this.upperRgb.TabIndex = 13;
            this.upperRgb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            // 
            // rgb
            // 
            this.rgb.Enabled = true;
            this.rgb.Interval = 3;
            this.rgb.Tick += new System.EventHandler(this.rgb_Tick);
            // 
            // regB
            // 
            this.regB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.regB.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.regB.FlatAppearance.BorderSize = 0;
            this.regB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regB.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regB.ForeColor = System.Drawing.Color.White;
            this.regB.Location = new System.Drawing.Point(302, 145);
            this.regB.Name = "regB";
            this.regB.Size = new System.Drawing.Size(80, 28);
            this.regB.TabIndex = 14;
            this.regB.Text = "Register";
            this.regB.UseVisualStyleBackColor = false;
            this.regB.Click += new System.EventHandler(this.regB_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 180);
            this.panel1.TabIndex = 15;
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(394, 185);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.regB);
            this.Controls.Add(this.upperRgb);
            this.Controls.Add(this.loginB);
            this.Controls.Add(this.passL);
            this.Controls.Add(this.userL);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.minimizeB);
            this.Controls.Add(this.exitB);
            this.Controls.Add(this.titleL);
            this.Controls.Add(this.sohard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginPanel";
            this.Text = "LoginPanel";
            this.Load += new System.EventHandler(this.LoginPanel_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            ((System.ComponentModel.ISupportInitialize)(this.sohard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleL;
        private System.Windows.Forms.PictureBox sohard;
        private System.Windows.Forms.Button minimizeB;
        private System.Windows.Forms.Button exitB;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label userL;
        private System.Windows.Forms.Label passL;
        private System.Windows.Forms.Button loginB;
        private System.Windows.Forms.Panel upperRgb;
        private System.Windows.Forms.Timer rgb;
        private System.Windows.Forms.Button regB;
        private System.Windows.Forms.Panel panel1;
    }
}