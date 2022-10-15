
namespace FixMyPing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_ping_toggle_1 = new System.Windows.Forms.Button();
            this.btn_refreshdns = new System.Windows.Forms.Button();
            this.btn_switch_google = new System.Windows.Forms.Button();
            this.btn_switch_cloudflare = new System.Windows.Forms.Button();
            this.lbl_ping_1 = new System.Windows.Forms.Label();
            this.time_ping = new System.Windows.Forms.Timer(this.components);
            this.timer_blink = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_ping_2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbl_ping_3 = new System.Windows.Forms.Label();
            this.lbl_currentDns = new System.Windows.Forms.Label();
            this.S_lbl_prefDns = new System.Windows.Forms.Label();
            this.S_lbl_altDns = new System.Windows.Forms.Label();
            this.lbl_altDns = new System.Windows.Forms.Label();
            this.btn_switch_OpenDns = new System.Windows.Forms.Button();
            this.btn_switch_ControlD = new System.Windows.Forms.Button();
            this.s_lbl_dnsnam = new System.Windows.Forms.Label();
            this.lbl_dnsName = new System.Windows.Forms.Label();
            this.lbl_flush = new System.Windows.Forms.Label();
            this.lbl_release = new System.Windows.Forms.Label();
            this.lbl_renew = new System.Windows.Forms.Label();
            this.othertimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_ping_toggle_1
            // 
            this.btn_ping_toggle_1.BackColor = System.Drawing.Color.Red;
            this.btn_ping_toggle_1.Location = new System.Drawing.Point(208, 45);
            this.btn_ping_toggle_1.Name = "btn_ping_toggle_1";
            this.btn_ping_toggle_1.Size = new System.Drawing.Size(53, 25);
            this.btn_ping_toggle_1.TabIndex = 0;
            this.btn_ping_toggle_1.Text = ">";
            this.btn_ping_toggle_1.UseVisualStyleBackColor = false;
            this.btn_ping_toggle_1.Click += new System.EventHandler(this.btn_ping_toggle_Click);
            // 
            // btn_refreshdns
            // 
            this.btn_refreshdns.Location = new System.Drawing.Point(162, 123);
            this.btn_refreshdns.Name = "btn_refreshdns";
            this.btn_refreshdns.Size = new System.Drawing.Size(99, 25);
            this.btn_refreshdns.TabIndex = 1;
            this.btn_refreshdns.Text = "REFRESH DNS";
            this.btn_refreshdns.UseVisualStyleBackColor = true;
            this.btn_refreshdns.Click += new System.EventHandler(this.btn_refreshdns_Click);
            // 
            // btn_switch_google
            // 
            this.btn_switch_google.Location = new System.Drawing.Point(6, 172);
            this.btn_switch_google.Name = "btn_switch_google";
            this.btn_switch_google.Size = new System.Drawing.Size(129, 25);
            this.btn_switch_google.TabIndex = 2;
            this.btn_switch_google.Text = "Set Google Dns";
            this.btn_switch_google.UseVisualStyleBackColor = true;
            this.btn_switch_google.Click += new System.EventHandler(this.btn_switch_google_Click);
            // 
            // btn_switch_cloudflare
            // 
            this.btn_switch_cloudflare.Location = new System.Drawing.Point(141, 172);
            this.btn_switch_cloudflare.Name = "btn_switch_cloudflare";
            this.btn_switch_cloudflare.Size = new System.Drawing.Size(129, 25);
            this.btn_switch_cloudflare.TabIndex = 3;
            this.btn_switch_cloudflare.Text = "Set CloudFlare Dns";
            this.btn_switch_cloudflare.UseVisualStyleBackColor = true;
            this.btn_switch_cloudflare.Click += new System.EventHandler(this.btn_switch_cloudflare_Click);
            // 
            // lbl_ping_1
            // 
            this.lbl_ping_1.AutoSize = true;
            this.lbl_ping_1.BackColor = System.Drawing.Color.Blue;
            this.lbl_ping_1.Font = new System.Drawing.Font("NSimSun", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ping_1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_ping_1.Location = new System.Drawing.Point(126, 18);
            this.lbl_ping_1.Name = "lbl_ping_1";
            this.lbl_ping_1.Size = new System.Drawing.Size(55, 13);
            this.lbl_ping_1.TabIndex = 4;
            this.lbl_ping_1.Text = "label1";
            // 
            // time_ping
            // 
            this.time_ping.Enabled = true;
            this.time_ping.Interval = 1000;
            this.time_ping.Tick += new System.EventHandler(this.time_ping_Tick);
            // 
            // timer_blink
            // 
            this.timer_blink.Enabled = true;
            this.timer_blink.Interval = 1000;
            this.timer_blink.Tick += new System.EventHandler(this.timer_blink_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 25);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "www.google.com";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 25);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "lol.garena.com";
            // 
            // lbl_ping_2
            // 
            this.lbl_ping_2.AutoSize = true;
            this.lbl_ping_2.BackColor = System.Drawing.Color.Blue;
            this.lbl_ping_2.Font = new System.Drawing.Font("NSimSun", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ping_2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_ping_2.Location = new System.Drawing.Point(126, 51);
            this.lbl_ping_2.Name = "lbl_ping_2";
            this.lbl_ping_2.Size = new System.Drawing.Size(55, 13);
            this.lbl_ping_2.TabIndex = 7;
            this.lbl_ping_2.Text = "label1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(10, 79);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(110, 25);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "www.bbts.net";
            // 
            // lbl_ping_3
            // 
            this.lbl_ping_3.AutoSize = true;
            this.lbl_ping_3.BackColor = System.Drawing.Color.Blue;
            this.lbl_ping_3.Font = new System.Drawing.Font("NSimSun", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ping_3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_ping_3.Location = new System.Drawing.Point(126, 85);
            this.lbl_ping_3.Name = "lbl_ping_3";
            this.lbl_ping_3.Size = new System.Drawing.Size(55, 13);
            this.lbl_ping_3.TabIndex = 10;
            this.lbl_ping_3.Text = "label2";
            // 
            // lbl_currentDns
            // 
            this.lbl_currentDns.AutoSize = true;
            this.lbl_currentDns.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_currentDns.Location = new System.Drawing.Point(66, 114);
            this.lbl_currentDns.Name = "lbl_currentDns";
            this.lbl_currentDns.Size = new System.Drawing.Size(74, 17);
            this.lbl_currentDns.TabIndex = 12;
            this.lbl_currentDns.Text = "current dns";
            // 
            // S_lbl_prefDns
            // 
            this.S_lbl_prefDns.AutoSize = true;
            this.S_lbl_prefDns.Location = new System.Drawing.Point(7, 114);
            this.S_lbl_prefDns.Name = "S_lbl_prefDns";
            this.S_lbl_prefDns.Size = new System.Drawing.Size(58, 17);
            this.S_lbl_prefDns.TabIndex = 13;
            this.S_lbl_prefDns.Text = "pref Dns";
            // 
            // S_lbl_altDns
            // 
            this.S_lbl_altDns.AutoSize = true;
            this.S_lbl_altDns.Location = new System.Drawing.Point(7, 131);
            this.S_lbl_altDns.Name = "S_lbl_altDns";
            this.S_lbl_altDns.Size = new System.Drawing.Size(48, 17);
            this.S_lbl_altDns.TabIndex = 15;
            this.S_lbl_altDns.Text = "alt Dns";
            // 
            // lbl_altDns
            // 
            this.lbl_altDns.AutoSize = true;
            this.lbl_altDns.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_altDns.Location = new System.Drawing.Point(66, 131);
            this.lbl_altDns.Name = "lbl_altDns";
            this.lbl_altDns.Size = new System.Drawing.Size(84, 17);
            this.lbl_altDns.TabIndex = 14;
            this.lbl_altDns.Text = "alternate dns";
            // 
            // btn_switch_OpenDns
            // 
            this.btn_switch_OpenDns.Location = new System.Drawing.Point(6, 203);
            this.btn_switch_OpenDns.Name = "btn_switch_OpenDns";
            this.btn_switch_OpenDns.Size = new System.Drawing.Size(129, 25);
            this.btn_switch_OpenDns.TabIndex = 16;
            this.btn_switch_OpenDns.Text = "Set Open Dns";
            this.btn_switch_OpenDns.UseVisualStyleBackColor = true;
            this.btn_switch_OpenDns.Click += new System.EventHandler(this.btn_switch_OpenDns_Click);
            // 
            // btn_switch_ControlD
            // 
            this.btn_switch_ControlD.Location = new System.Drawing.Point(141, 203);
            this.btn_switch_ControlD.Name = "btn_switch_ControlD";
            this.btn_switch_ControlD.Size = new System.Drawing.Size(129, 25);
            this.btn_switch_ControlD.TabIndex = 17;
            this.btn_switch_ControlD.Text = "Set ControlD Dns";
            this.btn_switch_ControlD.UseVisualStyleBackColor = true;
            this.btn_switch_ControlD.Click += new System.EventHandler(this.btn_switch_ControlD_Click);
            // 
            // s_lbl_dnsnam
            // 
            this.s_lbl_dnsnam.AutoSize = true;
            this.s_lbl_dnsnam.Location = new System.Drawing.Point(7, 148);
            this.s_lbl_dnsnam.Name = "s_lbl_dnsnam";
            this.s_lbl_dnsnam.Size = new System.Drawing.Size(40, 17);
            this.s_lbl_dnsnam.TabIndex = 19;
            this.s_lbl_dnsnam.Text = "name";
            this.s_lbl_dnsnam.Click += new System.EventHandler(this.s_lbl_dnsnam_Click);
            // 
            // lbl_dnsName
            // 
            this.lbl_dnsName.AutoSize = true;
            this.lbl_dnsName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_dnsName.Location = new System.Drawing.Point(66, 148);
            this.lbl_dnsName.Name = "lbl_dnsName";
            this.lbl_dnsName.Size = new System.Drawing.Size(65, 17);
            this.lbl_dnsName.TabIndex = 18;
            this.lbl_dnsName.Text = "dns name";
            this.lbl_dnsName.Click += new System.EventHandler(this.lbl_dnsName_Click);
            // 
            // lbl_flush
            // 
            this.lbl_flush.AutoSize = true;
            this.lbl_flush.Location = new System.Drawing.Point(156, 103);
            this.lbl_flush.Name = "lbl_flush";
            this.lbl_flush.Size = new System.Drawing.Size(35, 17);
            this.lbl_flush.TabIndex = 20;
            this.lbl_flush.Text = "flush";
            this.lbl_flush.Click += new System.EventHandler(this.lbl_flush_Click);
            // 
            // lbl_release
            // 
            this.lbl_release.AutoSize = true;
            this.lbl_release.Location = new System.Drawing.Point(197, 103);
            this.lbl_release.Name = "lbl_release";
            this.lbl_release.Size = new System.Drawing.Size(23, 17);
            this.lbl_release.TabIndex = 21;
            this.lbl_release.Text = "rel";
            // 
            // lbl_renew
            // 
            this.lbl_renew.AutoSize = true;
            this.lbl_renew.Location = new System.Drawing.Point(227, 103);
            this.lbl_renew.Name = "lbl_renew";
            this.lbl_renew.Size = new System.Drawing.Size(43, 17);
            this.lbl_renew.TabIndex = 22;
            this.lbl_renew.Text = "renew";
            // 
            // othertimer
            // 
            this.othertimer.Enabled = true;
            this.othertimer.Interval = 2000;
            this.othertimer.Tick += new System.EventHandler(this.other_blink_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(275, 236);
            this.Controls.Add(this.lbl_renew);
            this.Controls.Add(this.lbl_release);
            this.Controls.Add(this.lbl_flush);
            this.Controls.Add(this.s_lbl_dnsnam);
            this.Controls.Add(this.lbl_dnsName);
            this.Controls.Add(this.btn_switch_ControlD);
            this.Controls.Add(this.btn_switch_OpenDns);
            this.Controls.Add(this.S_lbl_altDns);
            this.Controls.Add(this.lbl_altDns);
            this.Controls.Add(this.S_lbl_prefDns);
            this.Controls.Add(this.lbl_currentDns);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lbl_ping_3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_ping_2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_ping_1);
            this.Controls.Add(this.btn_switch_cloudflare);
            this.Controls.Add(this.btn_switch_google);
            this.Controls.Add(this.btn_refreshdns);
            this.Controls.Add(this.btn_ping_toggle_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Fix My Ping";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ping_toggle_1;
        private System.Windows.Forms.Button btn_refreshdns;
        private System.Windows.Forms.Button btn_switch_google;
        private System.Windows.Forms.Button btn_switch_cloudflare;
        private System.Windows.Forms.Label lbl_ping_1;
        private System.Windows.Forms.Timer time_ping;
        private System.Windows.Forms.Timer timer_blink;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_ping_2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbl_ping_3;
        private System.Windows.Forms.Label lbl_currentDns;
        private System.Windows.Forms.Label S_lbl_prefDns;
        private System.Windows.Forms.Label S_lbl_altDns;
        private System.Windows.Forms.Label lbl_altDns;
        private System.Windows.Forms.Button btn_switch_OpenDns;
        private System.Windows.Forms.Button btn_switch_ControlD;
        private System.Windows.Forms.Label s_lbl_dnsnam;
        private System.Windows.Forms.Label lbl_dnsName;
        private System.Windows.Forms.Label lbl_flush;
        private System.Windows.Forms.Label lbl_release;
        private System.Windows.Forms.Label lbl_renew;
        private System.Windows.Forms.Timer othertimer;
    }
}

