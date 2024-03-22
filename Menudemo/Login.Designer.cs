namespace Menudemo
{
    partial class flogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.btn_login = new Guna.UI2.WinForms.Guna2Button();
            this.lbMiss = new System.Windows.Forms.Label();
            this.lb_log = new System.Windows.Forms.Label();
            this.txt_log = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_pas = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_pas = new System.Windows.Forms.Label();
            this.hidepass = new System.Windows.Forms.PictureBox();
            this.showpass = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidepass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showpass)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(61)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // btn_close
            // 
            this.btn_close.BorderColor = System.Drawing.Color.Bisque;
            this.btn_close.BorderRadius = 20;
            this.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(28)))), ((int)(((byte)(2)))));
            resources.ApplyResources(this.btn_close, "btn_close");
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Name = "btn_close";
            this.btn_close.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_login
            // 
            this.btn_login.BorderRadius = 20;
            this.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.btn_login, "btn_login");
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Name = "btn_login";
            this.btn_login.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbMiss
            // 
            resources.ApplyResources(this.lbMiss, "lbMiss");
            this.lbMiss.BackColor = System.Drawing.Color.Transparent;
            this.lbMiss.Name = "lbMiss";
            this.lbMiss.Click += new System.EventHandler(this.lbMiss_Click);
            // 
            // lb_log
            // 
            resources.ApplyResources(this.lb_log, "lb_log");
            this.lb_log.Name = "lb_log";
            // 
            // txt_log
            // 
            this.txt_log.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_log.DefaultText = "";
            this.txt_log.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_log.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_log.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_log.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_log.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.txt_log, "txt_log");
            this.txt_log.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_log.Name = "txt_log";
            this.txt_log.PasswordChar = '\0';
            this.txt_log.PlaceholderText = "";
            this.txt_log.SelectedText = "";
            // 
            // txt_pas
            // 
            this.txt_pas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pas.DefaultText = "";
            this.txt_pas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_pas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_pas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.txt_pas, "txt_pas");
            this.txt_pas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pas.Name = "txt_pas";
            this.txt_pas.PasswordChar = '*';
            this.txt_pas.PlaceholderText = "";
            this.txt_pas.SelectedText = "";
            // 
            // lb_pas
            // 
            resources.ApplyResources(this.lb_pas, "lb_pas");
            this.lb_pas.Name = "lb_pas";
            // 
            // hidepass
            // 
            this.hidepass.BackColor = System.Drawing.Color.Transparent;
            this.hidepass.BackgroundImage = global::Menudemo.Properties.Resources.icons8_hide_password_50;
            resources.ApplyResources(this.hidepass, "hidepass");
            this.hidepass.Name = "hidepass";
            this.hidepass.TabStop = false;
            this.hidepass.Click += new System.EventHandler(this.hidepass_Click);
            // 
            // showpass
            // 
            this.showpass.BackColor = System.Drawing.Color.Transparent;
            this.showpass.BackgroundImage = global::Menudemo.Properties.Resources.icons8_show_password_50;
            resources.ApplyResources(this.showpass, "showpass");
            this.showpass.Name = "showpass";
            this.showpass.TabStop = false;
            this.showpass.Click += new System.EventHandler(this.showpass_Click);
            // 
            // flogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txt_pas);
            this.Controls.Add(this.lb_pas);
            this.Controls.Add(this.txt_log);
            this.Controls.Add(this.lb_log);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.hidepass);
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.lbMiss);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "flogin";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hidepass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showpass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_close;
        private Guna.UI2.WinForms.Guna2Button btn_login;
        private System.Windows.Forms.PictureBox hidepass;
        private System.Windows.Forms.PictureBox showpass;
        private System.Windows.Forms.Label lbMiss;
        private System.Windows.Forms.Label lb_log;
        private Guna.UI2.WinForms.Guna2TextBox txt_log;
        private Guna.UI2.WinForms.Guna2TextBox txt_pas;
        private System.Windows.Forms.Label lb_pas;
    }
}