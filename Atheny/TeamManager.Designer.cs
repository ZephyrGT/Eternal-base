namespace Atheny
{
    partial class TeamManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamManager));
            this.teamList = new System.Windows.Forms.ListBox();
            this.titleL = new System.Windows.Forms.Label();
            this.minimizeB = new System.Windows.Forms.Button();
            this.exitB = new System.Windows.Forms.Button();
            this.leaveTeam = new System.Windows.Forms.Button();
            this.joinTeam = new System.Windows.Forms.Button();
            this.teamCode = new System.Windows.Forms.TextBox();
            this.createTeam = new System.Windows.Forms.Button();
            this.teamInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // teamList
            // 
            this.teamList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.teamList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamList.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamList.ForeColor = System.Drawing.Color.White;
            this.teamList.FormattingEnabled = true;
            this.teamList.ItemHeight = 20;
            this.teamList.Location = new System.Drawing.Point(12, 50);
            this.teamList.Name = "teamList";
            this.teamList.Size = new System.Drawing.Size(440, 102);
            this.teamList.TabIndex = 0;
            // 
            // titleL
            // 
            this.titleL.AutoSize = true;
            this.titleL.BackColor = System.Drawing.Color.Transparent;
            this.titleL.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleL.ForeColor = System.Drawing.Color.White;
            this.titleL.Location = new System.Drawing.Point(12, 12);
            this.titleL.Name = "titleL";
            this.titleL.Size = new System.Drawing.Size(151, 22);
            this.titleL.TabIndex = 5;
            this.titleL.Text = "Team Manager";
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
            this.minimizeB.Location = new System.Drawing.Point(392, -1);
            this.minimizeB.Name = "minimizeB";
            this.minimizeB.Size = new System.Drawing.Size(35, 35);
            this.minimizeB.TabIndex = 9;
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
            this.exitB.Location = new System.Drawing.Point(427, -1);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(35, 35);
            this.exitB.TabIndex = 8;
            this.exitB.Text = "X";
            this.exitB.UseVisualStyleBackColor = false;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // leaveTeam
            // 
            this.leaveTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.leaveTeam.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.leaveTeam.FlatAppearance.BorderSize = 0;
            this.leaveTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leaveTeam.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveTeam.ForeColor = System.Drawing.Color.White;
            this.leaveTeam.Location = new System.Drawing.Point(12, 167);
            this.leaveTeam.Name = "leaveTeam";
            this.leaveTeam.Size = new System.Drawing.Size(80, 28);
            this.leaveTeam.TabIndex = 16;
            this.leaveTeam.Text = "Leave All";
            this.leaveTeam.UseVisualStyleBackColor = false;
            this.leaveTeam.Click += new System.EventHandler(this.leaveTeam_Click);
            // 
            // joinTeam
            // 
            this.joinTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.joinTeam.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.joinTeam.FlatAppearance.BorderSize = 0;
            this.joinTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.joinTeam.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinTeam.ForeColor = System.Drawing.Color.White;
            this.joinTeam.Location = new System.Drawing.Point(356, 168);
            this.joinTeam.Name = "joinTeam";
            this.joinTeam.Size = new System.Drawing.Size(96, 27);
            this.joinTeam.TabIndex = 15;
            this.joinTeam.Text = "Join Team";
            this.joinTeam.UseVisualStyleBackColor = false;
            this.joinTeam.Click += new System.EventHandler(this.joinTeam_Click);
            // 
            // teamCode
            // 
            this.teamCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.teamCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamCode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamCode.ForeColor = System.Drawing.Color.White;
            this.teamCode.Location = new System.Drawing.Point(98, 170);
            this.teamCode.Name = "teamCode";
            this.teamCode.Size = new System.Drawing.Size(252, 23);
            this.teamCode.TabIndex = 17;
            // 
            // createTeam
            // 
            this.createTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.createTeam.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.createTeam.FlatAppearance.BorderSize = 0;
            this.createTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeam.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeam.ForeColor = System.Drawing.Color.White;
            this.createTeam.Location = new System.Drawing.Point(356, 201);
            this.createTeam.Name = "createTeam";
            this.createTeam.Size = new System.Drawing.Size(96, 33);
            this.createTeam.TabIndex = 18;
            this.createTeam.Text = "Create Team";
            this.createTeam.UseVisualStyleBackColor = false;
            this.createTeam.Click += new System.EventHandler(this.createTeam_Click);
            // 
            // teamInfo
            // 
            this.teamInfo.AutoSize = true;
            this.teamInfo.BackColor = System.Drawing.Color.Transparent;
            this.teamInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamInfo.ForeColor = System.Drawing.Color.White;
            this.teamInfo.Location = new System.Drawing.Point(12, 200);
            this.teamInfo.Name = "teamInfo";
            this.teamInfo.Size = new System.Drawing.Size(330, 34);
            this.teamInfo.TabIndex = 19;
            this.teamInfo.Text = "Join a team by typing the name and secret code.\r\nFormat - name:code";
            // 
            // TeamManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(464, 245);
            this.Controls.Add(this.teamInfo);
            this.Controls.Add(this.createTeam);
            this.Controls.Add(this.teamCode);
            this.Controls.Add(this.leaveTeam);
            this.Controls.Add(this.joinTeam);
            this.Controls.Add(this.minimizeB);
            this.Controls.Add(this.exitB);
            this.Controls.Add(this.titleL);
            this.Controls.Add(this.teamList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeamManager";
            this.Text = "Team Manager";
            this.Load += new System.EventHandler(this.TeamManager_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox teamList;
        private System.Windows.Forms.Label titleL;
        private System.Windows.Forms.Button minimizeB;
        private System.Windows.Forms.Button exitB;
        private System.Windows.Forms.Button leaveTeam;
        private System.Windows.Forms.Button joinTeam;
        private System.Windows.Forms.TextBox teamCode;
        private System.Windows.Forms.Button createTeam;
        private System.Windows.Forms.Label teamInfo;
    }
}