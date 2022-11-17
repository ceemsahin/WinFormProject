namespace WindowsFormsApp1
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnPSil = new System.Windows.Forms.Button();
            this.dtPers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtPers)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adı Soyadı:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(57, 46);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(57, 111);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(100, 20);
            this.txtNo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Numarası:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(57, 160);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(109, 23);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Personel Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(57, 189);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(109, 23);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Personel Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnPSil
            // 
            this.btnPSil.Location = new System.Drawing.Point(57, 218);
            this.btnPSil.Name = "btnPSil";
            this.btnPSil.Size = new System.Drawing.Size(109, 23);
            this.btnPSil.TabIndex = 6;
            this.btnPSil.Text = "Personel Sil";
            this.btnPSil.UseVisualStyleBackColor = true;
            this.btnPSil.Click += new System.EventHandler(this.btnPSil_Click);
            // 
            // dtPers
            // 
            this.dtPers.AllowUserToAddRows = false;
            this.dtPers.AllowUserToDeleteRows = false;
            this.dtPers.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dtPers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtPers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtPers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPers.GridColor = System.Drawing.SystemColors.Info;
            this.dtPers.Location = new System.Drawing.Point(172, 46);
            this.dtPers.Name = "dtPers";
            this.dtPers.ReadOnly = true;
            this.dtPers.Size = new System.Drawing.Size(415, 195);
            this.dtPers.TabIndex = 7;
            this.dtPers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPers_CellClick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1028, 494);
            this.Controls.Add(this.dtPers);
            this.Controls.Add(this.btnPSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtPers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdiSoyadi;
        private System.Windows.Forms.TextBox txtNumarasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPersonelKaydet;
        private System.Windows.Forms.DataGridView DtPersonel;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnPSil;
        private System.Windows.Forms.DataGridView dtPers;
    }
}

