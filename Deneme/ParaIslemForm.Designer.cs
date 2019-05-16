namespace Deneme
{
    partial class ParaIslemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParaIslemForm));
            this.btnİslemYap = new System.Windows.Forms.Button();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbParaYatırma = new System.Windows.Forms.RadioButton();
            this.rbParaCekme = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnİslemYap
            // 
            this.btnİslemYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnİslemYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİslemYap.Image = ((System.Drawing.Image)(resources.GetObject("btnİslemYap.Image")));
            this.btnİslemYap.Location = new System.Drawing.Point(151, 237);
            this.btnİslemYap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnİslemYap.Name = "btnİslemYap";
            this.btnİslemYap.Size = new System.Drawing.Size(210, 121);
            this.btnİslemYap.TabIndex = 15;
            this.btnİslemYap.UseVisualStyleBackColor = true;
            this.btnİslemYap.Click += new System.EventHandler(this.btnİslemYap_Click);
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(220, 88);
            this.dtTarih.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(200, 22);
            this.dtTarih.TabIndex = 13;
            this.dtTarih.ValueChanged += new System.EventHandler(this.dtTarih_ValueChanged);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(220, 139);
            this.txtTutar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(200, 22);
            this.txtTutar.TabIndex = 10;
            this.txtTutar.TextChanged += new System.EventHandler(this.txtTutar_TextChanged);
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(220, 29);
            this.txtHesapNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(200, 22);
            this.txtHesapNo.TabIndex = 11;
            this.txtHesapNo.TextChanged += new System.EventHandler(this.txtHesapNo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(29, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "İşlem Türü :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(29, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tutar :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "İşlem Tarihi :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hesap No :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rbParaYatırma
            // 
            this.rbParaYatırma.AutoSize = true;
            this.rbParaYatırma.Location = new System.Drawing.Point(225, 201);
            this.rbParaYatırma.Margin = new System.Windows.Forms.Padding(4);
            this.rbParaYatırma.Name = "rbParaYatırma";
            this.rbParaYatırma.Size = new System.Drawing.Size(111, 21);
            this.rbParaYatırma.TabIndex = 16;
            this.rbParaYatırma.TabStop = true;
            this.rbParaYatırma.Text = "Para Yatırma";
            this.rbParaYatırma.UseVisualStyleBackColor = true;
            this.rbParaYatırma.CheckedChanged += new System.EventHandler(this.rbParaYatırma_CheckedChanged);
            // 
            // rbParaCekme
            // 
            this.rbParaCekme.AutoSize = true;
            this.rbParaCekme.Location = new System.Drawing.Point(359, 201);
            this.rbParaCekme.Margin = new System.Windows.Forms.Padding(4);
            this.rbParaCekme.Name = "rbParaCekme";
            this.rbParaCekme.Size = new System.Drawing.Size(106, 21);
            this.rbParaCekme.TabIndex = 17;
            this.rbParaCekme.TabStop = true;
            this.rbParaCekme.Text = "Para Çekme";
            this.rbParaCekme.UseVisualStyleBackColor = true;
            this.rbParaCekme.CheckedChanged += new System.EventHandler(this.rbParaCekme_CheckedChanged);
            // 
            // ParaIslemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 368);
            this.Controls.Add(this.rbParaCekme);
            this.Controls.Add(this.rbParaYatırma);
            this.Controls.Add(this.btnİslemYap);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtHesapNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ParaIslemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParaIslemForm";
            this.Load += new System.EventHandler(this.ParaIslemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnİslemYap;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbParaYatırma;
        private System.Windows.Forms.RadioButton rbParaCekme;
    }
}