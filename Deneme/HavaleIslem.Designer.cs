namespace Deneme
{
    partial class HavaleIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HavaleIslem));
            this.label1 = new System.Windows.Forms.Label();
            this.txtGonderen = new System.Windows.Forms.TextBox();
            this.txtAlici = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGonder = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PARA GÖNDERİCİ HESAP NO :";
            // 
            // txtGonderen
            // 
            this.txtGonderen.Location = new System.Drawing.Point(259, 48);
            this.txtGonderen.Name = "txtGonderen";
            this.txtGonderen.Size = new System.Drawing.Size(100, 22);
            this.txtGonderen.TabIndex = 1;
            // 
            // txtAlici
            // 
            this.txtAlici.Location = new System.Drawing.Point(259, 100);
            this.txtAlici.Name = "txtAlici";
            this.txtAlici.Size = new System.Drawing.Size(100, 22);
            this.txtAlici.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "PARA ALICI HESAP NO :";
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.SystemColors.Control;
            this.btnGonder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.BackgroundImage")));
            this.btnGonder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGonder.Location = new System.Drawing.Point(90, 187);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(204, 147);
            this.btnGonder.TabIndex = 4;
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(259, 150);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(100, 22);
            this.txtTutar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "GÖNDERİLECEK TUTAR :";
            // 
            // HavaleIslem
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 346);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtAlici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGonderen);
            this.Controls.Add(this.label1);
            this.Name = "HavaleIslem";
            this.Text = "HavaleIslem";
            this.Load += new System.EventHandler(this.HavaleIslem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGonderen;
        private System.Windows.Forms.TextBox txtAlici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label3;
    }
}