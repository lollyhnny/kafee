namespace CafeOtomasyonu
{
    partial class frmOdeme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOdenecek = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblKdv = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblIndirim = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbKupon = new System.Windows.Forms.RadioButton();
            this.rbKrediKarti = new System.Windows.Forms.RadioButton();
            this.rbNakit = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkIndirim = new System.Windows.Forms.CheckBox();
            this.gbIndirim = new System.Windows.Forms.GroupBox();
            this.txtIndirimTutar = new System.Windows.Forms.TextBox();
            this.lblIndirimTutar = new System.Windows.Forms.Label();
            this.lvUrunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.bnGeriDon = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblAdısyonId = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnHesapozeti = new System.Windows.Forms.Button();
            this.btnHesapKapat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbIndirim.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOdenecek);
            this.groupBox1.Controls.Add(this.lblToplamTutar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblKdv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblIndirim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(20, 529);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme Bilgileri";
            // 
            // lblOdenecek
            // 
            this.lblOdenecek.AutoSize = true;
            this.lblOdenecek.Location = new System.Drawing.Point(155, 175);
            this.lblOdenecek.Name = "lblOdenecek";
            this.lblOdenecek.Size = new System.Drawing.Size(27, 31);
            this.lblOdenecek.TabIndex = 0;
            this.lblOdenecek.Text = "0";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(155, 135);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(27, 31);
            this.lblToplamTutar.TabIndex = 0;
            this.lblToplamTutar.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(221, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "₺ ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "₺ ";
            // 
            // lblKdv
            // 
            this.lblKdv.AutoSize = true;
            this.lblKdv.Location = new System.Drawing.Point(155, 92);
            this.lblKdv.Name = "lblKdv";
            this.lblKdv.Size = new System.Drawing.Size(27, 31);
            this.lblKdv.TabIndex = 0;
            this.lblKdv.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ara Toplam";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "₺ ";
            // 
            // lblIndirim
            // 
            this.lblIndirim.AutoSize = true;
            this.lblIndirim.Location = new System.Drawing.Point(155, 45);
            this.lblIndirim.Name = "lblIndirim";
            this.lblIndirim.Size = new System.Drawing.Size(27, 31);
            this.lblIndirim.TabIndex = 0;
            this.lblIndirim.Text = "0";
            this.lblIndirim.TextChanged += new System.EventHandler(this.lblIndirim_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "₺ ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "KDV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "İndirim";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbKupon);
            this.groupBox2.Controls.Add(this.rbKrediKarti);
            this.groupBox2.Controls.Add(this.rbNakit);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(378, 529);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 228);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ödeme Türü";
            // 
            // rbKupon
            // 
            this.rbKupon.AutoSize = true;
            this.rbKupon.Location = new System.Drawing.Point(38, 162);
            this.rbKupon.Name = "rbKupon";
            this.rbKupon.Size = new System.Drawing.Size(106, 35);
            this.rbKupon.TabIndex = 0;
            this.rbKupon.TabStop = true;
            this.rbKupon.Text = "Kupon";
            this.rbKupon.UseVisualStyleBackColor = true;
            // 
            // rbKrediKarti
            // 
            this.rbKrediKarti.AutoSize = true;
            this.rbKrediKarti.Location = new System.Drawing.Point(38, 107);
            this.rbKrediKarti.Name = "rbKrediKarti";
            this.rbKrediKarti.Size = new System.Drawing.Size(298, 35);
            this.rbKrediKarti.TabIndex = 0;
            this.rbKrediKarti.TabStop = true;
            this.rbKrediKarti.Text = "Kredi Kartı / Banka Kartı";
            this.rbKrediKarti.UseVisualStyleBackColor = true;
            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.Location = new System.Drawing.Point(38, 53);
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Size = new System.Drawing.Size(94, 35);
            this.rbNakit.TabIndex = 0;
            this.rbNakit.TabStop = true;
            this.rbNakit.Text = "Nakit";
            this.rbNakit.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkIndirim);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(923, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 228);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Özel indirim";
            // 
            // chkIndirim
            // 
            this.chkIndirim.AutoSize = true;
            this.chkIndirim.Location = new System.Drawing.Point(30, 78);
            this.chkIndirim.Name = "chkIndirim";
            this.chkIndirim.Size = new System.Drawing.Size(197, 35);
            this.chkIndirim.TabIndex = 0;
            this.chkIndirim.Text = "İndirim Uygula";
            this.chkIndirim.UseVisualStyleBackColor = true;
            this.chkIndirim.CheckedChanged += new System.EventHandler(this.chkIndirim_CheckedChanged);
            // 
            // gbIndirim
            // 
            this.gbIndirim.Controls.Add(this.txtIndirimTutar);
            this.gbIndirim.Controls.Add(this.lblIndirimTutar);
            this.gbIndirim.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbIndirim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbIndirim.Location = new System.Drawing.Point(923, 322);
            this.gbIndirim.Name = "gbIndirim";
            this.gbIndirim.Size = new System.Drawing.Size(327, 228);
            this.gbIndirim.TabIndex = 0;
            this.gbIndirim.TabStop = false;
            this.gbIndirim.Text = "İndirim Tutarı";
            this.gbIndirim.Visible = false;
            // 
            // txtIndirimTutar
            // 
            this.txtIndirimTutar.Location = new System.Drawing.Point(30, 117);
            this.txtIndirimTutar.Name = "txtIndirimTutar";
            this.txtIndirimTutar.Size = new System.Drawing.Size(253, 38);
            this.txtIndirimTutar.TabIndex = 1;
            this.txtIndirimTutar.TextChanged += new System.EventHandler(this.txtIndirimTutar_TextChanged);
            // 
            // lblIndirimTutar
            // 
            this.lblIndirimTutar.AutoSize = true;
            this.lblIndirimTutar.Location = new System.Drawing.Point(17, 59);
            this.lblIndirimTutar.Name = "lblIndirimTutar";
            this.lblIndirimTutar.Size = new System.Drawing.Size(265, 31);
            this.lblIndirimTutar.TabIndex = 0;
            this.lblIndirimTutar.Text = "İndirim Tutarını Giriniz:";
            // 
            // lvUrunler
            // 
            this.lvUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvUrunler.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lvUrunler.FullRowSelect = true;
            this.lvUrunler.GridLines = true;
            this.lvUrunler.Location = new System.Drawing.Point(20, 77);
            this.lvUrunler.Name = "lvUrunler";
            this.lvUrunler.Size = new System.Drawing.Size(770, 446);
            this.lvUrunler.TabIndex = 1;
            this.lvUrunler.UseCompatibleStateImageBehavior = false;
            this.lvUrunler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adet";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün ID";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyat";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Satış ID";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // bnGeriDon
            // 
            this.bnGeriDon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bnGeriDon.Location = new System.Drawing.Point(1100, 726);
            this.bnGeriDon.Name = "bnGeriDon";
            this.bnGeriDon.Size = new System.Drawing.Size(94, 54);
            this.bnGeriDon.TabIndex = 2;
            this.bnGeriDon.Text = "geri dön";
            this.bnGeriDon.UseVisualStyleBackColor = true;
            this.bnGeriDon.Click += new System.EventHandler(this.bnGeriDon_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCikis.Location = new System.Drawing.Point(1200, 726);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(94, 54);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // lblAdısyonId
            // 
            this.lblAdısyonId.AutoSize = true;
            this.lblAdısyonId.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdısyonId.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblAdısyonId.Location = new System.Drawing.Point(160, 31);
            this.lblAdısyonId.Name = "lblAdısyonId";
            this.lblAdısyonId.Size = new System.Drawing.Size(27, 23);
            this.lblAdısyonId.TabIndex = 3;
            this.lblAdısyonId.Text = "Id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "label10";
            // 
            // btnHesapozeti
            // 
            this.btnHesapozeti.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnHesapozeti.Location = new System.Drawing.Point(978, 577);
            this.btnHesapozeti.Name = "btnHesapozeti";
            this.btnHesapozeti.Size = new System.Drawing.Size(94, 94);
            this.btnHesapozeti.TabIndex = 5;
            this.btnHesapozeti.Text = "Hesap Özeti";
            this.btnHesapozeti.UseVisualStyleBackColor = true;
            // 
            // btnHesapKapat
            // 
            this.btnHesapKapat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHesapKapat.Location = new System.Drawing.Point(1111, 577);
            this.btnHesapKapat.Name = "btnHesapKapat";
            this.btnHesapKapat.Size = new System.Drawing.Size(94, 94);
            this.btnHesapKapat.TabIndex = 5;
            this.btnHesapKapat.Text = "Hesabı Kapat";
            this.btnHesapKapat.UseVisualStyleBackColor = true;
            this.btnHesapKapat.Click += new System.EventHandler(this.btnHesapKapat_Click);
            // 
            // frmOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1315, 792);
            this.Controls.Add(this.btnHesapKapat);
            this.Controls.Add(this.btnHesapozeti);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblAdısyonId);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.bnGeriDon);
            this.Controls.Add(this.lvUrunler);
            this.Controls.Add(this.gbIndirim);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Name = "frmOdeme";
            this.Text = "frmOdeme";
            this.Load += new System.EventHandler(this.frmOdeme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbIndirim.ResumeLayout(false);
            this.gbIndirim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label lblOdenecek;
        private Label lblToplamTutar;
        private Label label8;
        private Label label7;
        private Label lblKdv;
        private Label label3;
        private Label label6;
        private Label lblIndirim;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton rbKupon;
        private RadioButton rbKrediKarti;
        private RadioButton rbNakit;
        private GroupBox groupBox3;
        private CheckBox chkIndirim;
        private GroupBox gbIndirim;
        private ListView lvUrunler;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button bnGeriDon;
        private Button btnCikis;
        private TextBox txtIndirimTutar;
        private Label lblIndirimTutar;
        private Label lblAdısyonId;
        private Label label10;
        private Button btnHesapozeti;
        private Button btnHesapKapat;
    }
}