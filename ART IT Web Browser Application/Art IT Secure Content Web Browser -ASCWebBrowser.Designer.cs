namespace ART_IT_Web_Browser_Application
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutASCWebBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_app = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.container = new System.Windows.Forms.Panel();
            this.btn_code = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 6;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutASCWebBrowserToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutASCWebBrowserToolStripMenuItem
            // 
            this.aboutASCWebBrowserToolStripMenuItem.Name = "aboutASCWebBrowserToolStripMenuItem";
            this.aboutASCWebBrowserToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.aboutASCWebBrowserToolStripMenuItem.Text = "About AscWebBrowser...";
            this.aboutASCWebBrowserToolStripMenuItem.Click += new System.EventHandler(this.aboutASCWebBrowserToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.Controls.Add(this.btn_code);
            this.panel2.Controls.Add(this.btn_home);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.btn_app);
            this.panel2.Controls.Add(this.btn_refresh);
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Controls.Add(this.btn_stop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 46);
            this.panel2.TabIndex = 7;
            // 
            // btn_home
            // 
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Arial", 9F);
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_home.Location = new System.Drawing.Point(298, 3);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(53, 42);
            this.btn_home.TabIndex = 11;
            this.btn_home.Text = "Home";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 9F);
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(107, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 42);
            this.button5.TabIndex = 8;
            this.button5.Text = "Forward";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_app
            // 
            this.btn_app.FlatAppearance.BorderSize = 0;
            this.btn_app.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_app.Font = new System.Drawing.Font("Arial", 9F);
            this.btn_app.Image = ((System.Drawing.Image)(resources.GetObject("btn_app.Image")));
            this.btn_app.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_app.Location = new System.Drawing.Point(3, 3);
            this.btn_app.Name = "btn_app";
            this.btn_app.Size = new System.Drawing.Size(46, 42);
            this.btn_app.TabIndex = 6;
            this.btn_app.Text = "App";
            this.btn_app.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_app.UseVisualStyleBackColor = true;
            this.btn_app.Click += new System.EventHandler(this.btn_app_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Arial", 9F);
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_refresh.Location = new System.Drawing.Point(226, 3);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(66, 42);
            this.btn_refresh.TabIndex = 10;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_back
            // 
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Arial", 9F);
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_back.Location = new System.Drawing.Point(55, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(46, 42);
            this.btn_back.TabIndex = 7;
            this.btn_back.Text = "Back";
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.FlatAppearance.BorderSize = 0;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.Font = new System.Drawing.Font("Arial", 9F);
            this.btn_stop.Image = ((System.Drawing.Image)(resources.GetObject("btn_stop.Image")));
            this.btn_stop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_stop.Location = new System.Drawing.Point(174, 3);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(46, 42);
            this.btn_stop.TabIndex = 9;
            this.btn_stop.Text = "Stop";
            this.btn_stop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.White;
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 70);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(800, 416);
            this.container.TabIndex = 8;
            // 
            // btn_code
            // 
            this.btn_code.FlatAppearance.BorderSize = 0;
            this.btn_code.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_code.Font = new System.Drawing.Font("Arial", 9F);
            this.btn_code.Image = ((System.Drawing.Image)(resources.GetObject("btn_code.Image")));
            this.btn_code.Location = new System.Drawing.Point(357, 3);
            this.btn_code.Name = "btn_code";
            this.btn_code.Size = new System.Drawing.Size(86, 42);
            this.btn_code.TabIndex = 11;
            this.btn_code.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_code.UseVisualStyleBackColor = true;
            this.btn_code.Click += new System.EventHandler(this.btn_code_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.container);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Art IT Secure Content Web Browser -ASCWebBrowser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_app;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.ToolStripMenuItem aboutASCWebBrowserToolStripMenuItem;
        private System.Windows.Forms.Button btn_code;
    }
}

