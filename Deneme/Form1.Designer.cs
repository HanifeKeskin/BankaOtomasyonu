namespace Deneme
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.musteri_islemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesaplarıGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.banka_islemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.havaleİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musteri_islemToolStripMenuItem,
            this.banka_islemToolStripMenuItem});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(10, 10, 0, 2);
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip2.Size = new System.Drawing.Size(447, 269);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // musteri_islemToolStripMenuItem
            // 
            this.musteri_islemToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.musteri_islemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapAçToolStripMenuItem,
            this.hesapSilToolStripMenuItem,
            this.hesaplarıGörüntüleToolStripMenuItem,
            this.paraİşlemleriToolStripMenuItem,
            this.havaleİşlemleriToolStripMenuItem});
            this.musteri_islemToolStripMenuItem.Name = "musteri_islemToolStripMenuItem";
            this.musteri_islemToolStripMenuItem.Size = new System.Drawing.Size(167, 257);
            this.musteri_islemToolStripMenuItem.Text = "Müşteri İşlemleri";
            this.musteri_islemToolStripMenuItem.Click += new System.EventHandler(this.musteri_islemToolStripMenuItem_Click);
            // 
            // hesapAçToolStripMenuItem
            // 
            this.hesapAçToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.hesapAçToolStripMenuItem.Name = "hesapAçToolStripMenuItem";
            this.hesapAçToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
            this.hesapAçToolStripMenuItem.Text = "Hesap Aç";
            this.hesapAçToolStripMenuItem.Click += new System.EventHandler(this.hesapAçToolStripMenuItem_Click_1);
            // 
            // hesapSilToolStripMenuItem
            // 
            this.hesapSilToolStripMenuItem.Name = "hesapSilToolStripMenuItem";
            this.hesapSilToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
            this.hesapSilToolStripMenuItem.Text = "Hesap Silme";
            this.hesapSilToolStripMenuItem.Click += new System.EventHandler(this.hesapSilToolStripMenuItem_Click);
            // 
            // hesaplarıGörüntüleToolStripMenuItem
            // 
            this.hesaplarıGörüntüleToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.hesaplarıGörüntüleToolStripMenuItem.Name = "hesaplarıGörüntüleToolStripMenuItem";
            this.hesaplarıGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
            this.hesaplarıGörüntüleToolStripMenuItem.Text = "Hesapları Görüntüle";
            this.hesaplarıGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.hesaplarıGörüntüleToolStripMenuItem_Click_1);
            // 
            // paraİşlemleriToolStripMenuItem
            // 
            this.paraİşlemleriToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.paraİşlemleriToolStripMenuItem.Name = "paraİşlemleriToolStripMenuItem";
            this.paraİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
            this.paraİşlemleriToolStripMenuItem.Text = "Para İşlemleri";
            this.paraİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.paraİşlemleriToolStripMenuItem_Click_1);
            // 
            // banka_islemToolStripMenuItem
            // 
            this.banka_islemToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.banka_islemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriEkleToolStripMenuItem,
            this.müşteriListeleToolStripMenuItem});
            this.banka_islemToolStripMenuItem.Name = "banka_islemToolStripMenuItem";
            this.banka_islemToolStripMenuItem.Size = new System.Drawing.Size(153, 257);
            this.banka_islemToolStripMenuItem.Text = "Banka İşlemleri";
            this.banka_islemToolStripMenuItem.Click += new System.EventHandler(this.banka_islemToolStripMenuItem_Click);
            // 
            // müşteriEkleToolStripMenuItem
            // 
            this.müşteriEkleToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.müşteriEkleToolStripMenuItem.Name = "müşteriEkleToolStripMenuItem";
            this.müşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(215, 32);
            this.müşteriEkleToolStripMenuItem.Text = "Müşteri Ekle";
            this.müşteriEkleToolStripMenuItem.Click += new System.EventHandler(this.müşteriEkleToolStripMenuItem_Click_1);
            // 
            // müşteriListeleToolStripMenuItem
            // 
            this.müşteriListeleToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.müşteriListeleToolStripMenuItem.Name = "müşteriListeleToolStripMenuItem";
            this.müşteriListeleToolStripMenuItem.Size = new System.Drawing.Size(215, 32);
            this.müşteriListeleToolStripMenuItem.Text = "Müşteri Listele";
            this.müşteriListeleToolStripMenuItem.Click += new System.EventHandler(this.müşteriListeleToolStripMenuItem_Click_1);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStripContainer1.ContentPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripContainer1.ContentPanel.BackgroundImage")));
            this.toolStripContainer1.ContentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(208, 269);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.menuStrip2);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(655, 294);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // havaleİşlemleriToolStripMenuItem
            // 
            this.havaleİşlemleriToolStripMenuItem.Name = "havaleİşlemleriToolStripMenuItem";
            this.havaleİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
            this.havaleİşlemleriToolStripMenuItem.Text = "Havale işlemleri";
            this.havaleİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.havaleİşlemleriToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(655, 294);
            this.Controls.Add(this.toolStripContainer1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem musteri_islemToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripMenuItem hesapAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesaplarıGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem banka_islemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem havaleİşlemleriToolStripMenuItem;
    }
}

