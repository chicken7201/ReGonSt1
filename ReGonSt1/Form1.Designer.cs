﻿namespace ReGonSt1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_Home = new System.Windows.Forms.Panel();
            this.panel_Settings = new System.Windows.Forms.Panel();
            this.panel_Help = new System.Windows.Forms.Panel();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_Menu = new System.Windows.Forms.Button();
            this.button_Help = new System.Windows.Forms.Button();
            this.button_Settings = new System.Windows.Forms.Button();
            this.button_Home = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_Home.SuspendLayout();
            this.panel_Settings.SuspendLayout();
            this.panel_Help.SuspendLayout();
            this.panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 62);
            this.panel1.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("메이플스토리", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelName.Location = new System.Drawing.Point(65, 3);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(228, 54);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "ReGonSt";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.sidebar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 613);
            this.panel2.TabIndex = 1;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Silver;
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(269, 613);
            this.sidebar.MinimumSize = new System.Drawing.Size(57, 613);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(269, 613);
            this.sidebar.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel_Menu);
            this.panel3.Controls.Add(this.panel_Help);
            this.panel3.Controls.Add(this.panel_Settings);
            this.panel3.Controls.Add(this.panel_Home);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(389, 338);
            this.panel3.TabIndex = 0;
            // 
            // panel_Home
            // 
            this.panel_Home.Controls.Add(this.button_Home);
            this.panel_Home.Location = new System.Drawing.Point(0, 93);
            this.panel_Home.Name = "panel_Home";
            this.panel_Home.Size = new System.Drawing.Size(266, 62);
            this.panel_Home.TabIndex = 1;
            // 
            // panel_Settings
            // 
            this.panel_Settings.Controls.Add(this.button_Settings);
            this.panel_Settings.Location = new System.Drawing.Point(0, 153);
            this.panel_Settings.Name = "panel_Settings";
            this.panel_Settings.Size = new System.Drawing.Size(266, 62);
            this.panel_Settings.TabIndex = 2;
            // 
            // panel_Help
            // 
            this.panel_Help.BackColor = System.Drawing.Color.Silver;
            this.panel_Help.Controls.Add(this.button_Help);
            this.panel_Help.Location = new System.Drawing.Point(0, 213);
            this.panel_Help.Name = "panel_Help";
            this.panel_Help.Size = new System.Drawing.Size(266, 62);
            this.panel_Help.TabIndex = 1;
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.Silver;
            this.panel_Menu.Controls.Add(this.button_Menu);
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(266, 90);
            this.panel_Menu.TabIndex = 1;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ReGonSt1.Properties.Resources.about1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(991, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // button_Menu
            // 
            this.button_Menu.BackColor = System.Drawing.Color.Silver;
            this.button_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Menu.Font = new System.Drawing.Font("Segoe Print", 21.75F);
            this.button_Menu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Menu.Image = global::ReGonSt1.Properties.Resources.menu_bar;
            this.button_Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Menu.Location = new System.Drawing.Point(-13, -9);
            this.button_Menu.Name = "button_Menu";
            this.button_Menu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_Menu.Size = new System.Drawing.Size(300, 108);
            this.button_Menu.TabIndex = 3;
            this.button_Menu.Text = "   Menu";
            this.button_Menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Menu.UseVisualStyleBackColor = false;
            this.button_Menu.Click += new System.EventHandler(this.button_Menu_Click);
            // 
            // button_Help
            // 
            this.button_Help.BackColor = System.Drawing.Color.Silver;
            this.button_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Help.Font = new System.Drawing.Font("Segoe Print", 21.75F);
            this.button_Help.Image = global::ReGonSt1.Properties.Resources.help;
            this.button_Help.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Help.Location = new System.Drawing.Point(-13, -7);
            this.button_Help.Name = "button_Help";
            this.button_Help.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_Help.Size = new System.Drawing.Size(289, 78);
            this.button_Help.TabIndex = 2;
            this.button_Help.Text = "   Help";
            this.button_Help.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Help.UseVisualStyleBackColor = false;
            // 
            // button_Settings
            // 
            this.button_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Settings.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Settings.Image = global::ReGonSt1.Properties.Resources.control;
            this.button_Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Settings.Location = new System.Drawing.Point(-16, -9);
            this.button_Settings.Name = "button_Settings";
            this.button_Settings.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_Settings.Size = new System.Drawing.Size(300, 78);
            this.button_Settings.TabIndex = 0;
            this.button_Settings.Text = "   Settings";
            this.button_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Settings.UseVisualStyleBackColor = true;
            // 
            // button_Home
            // 
            this.button_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Home.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Home.Image = global::ReGonSt1.Properties.Resources.home_button;
            this.button_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Home.Location = new System.Drawing.Point(-16, -9);
            this.button_Home.Name = "button_Home";
            this.button_Home.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_Home.Size = new System.Drawing.Size(300, 78);
            this.button_Home.TabIndex = 0;
            this.button_Home.Text = "   Home";
            this.button_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Home.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1038, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReGonSt 1.0.0";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel_Home.ResumeLayout(false);
            this.panel_Settings.ResumeLayout(false);
            this.panel_Help.ResumeLayout(false);
            this.panel_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel_Home;
        private System.Windows.Forms.Button button_Home;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_Settings;
        private System.Windows.Forms.Button button_Settings;
        private System.Windows.Forms.Panel panel_Help;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Button button_Menu;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

