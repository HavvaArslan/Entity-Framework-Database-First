namespace Model_First_Entity_Framework
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
            this.btn_ders_listele = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_bul = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_foto = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ogr_ad = new System.Windows.Forms.TextBox();
            this.txt_ogrenci_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ders_id = new System.Windows.Forms.TextBox();
            this.txt_ders_ad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_not_güncelle = new System.Windows.Forms.Button();
            this.btn_ort_hesapla = new System.Windows.Forms.Button();
            this.txt_durum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_ort = new System.Windows.Forms.TextBox();
            this.txt_sinav3 = new System.Windows.Forms.TextBox();
            this.txt_sinav2 = new System.Windows.Forms.TextBox();
            this.txt_sinav1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_not_listele = new System.Windows.Forms.Button();
            this.btn_ogrenci_listele = new System.Windows.Forms.Button();
            this.btn_prosedur = new System.Windows.Forms.Button();
            this.RadioBtn_LinqEntity = new System.Windows.Forms.RadioButton();
            this.BtnLinqEntity = new System.Windows.Forms.Button();
            this.RadioBtn_ZA = new System.Windows.Forms.RadioButton();
            this.RadioBtn_IlkUc = new System.Windows.Forms.RadioButton();
            this.RadioBtn_ID = new System.Windows.Forms.RadioButton();
            this.RadioBtn_Start_A = new System.Windows.Forms.RadioButton();
            this.RadioBtn_End_B = new System.Windows.Forms.RadioButton();
            this.RadioBtn_Deger_Kontrol = new System.Windows.Forms.RadioButton();
            this.RadioBtn_Kayit_Sayisi = new System.Windows.Forms.RadioButton();
            this.RadioBtn_Ort = new System.Windows.Forms.RadioButton();
            this.RadioBtn_Max = new System.Windows.Forms.RadioButton();
            this.RadioBtn_Min = new System.Windows.Forms.RadioButton();
            this.RadioBtn_Min_ogr = new System.Windows.Forms.RadioButton();
            this.RadioBtn_Ort_Yuksek = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ders_listele
            // 
            this.btn_ders_listele.Location = new System.Drawing.Point(579, 264);
            this.btn_ders_listele.Name = "btn_ders_listele";
            this.btn_ders_listele.Size = new System.Drawing.Size(122, 23);
            this.btn_ders_listele.TabIndex = 11;
            this.btn_ders_listele.Text = "Ders Listele";
            this.btn_ders_listele.UseVisualStyleBackColor = true;
            this.btn_ders_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(579, 293);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(122, 23);
            this.btn_ekle.TabIndex = 12;
            this.btn_ekle.Text = "Öğrenci Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(579, 350);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(122, 23);
            this.btn_guncelle.TabIndex = 13;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(579, 322);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(122, 23);
            this.btn_sil.TabIndex = 14;
            this.btn_sil.Text = "Öğrenci Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(530, 206);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_bul
            // 
            this.btn_bul.Location = new System.Drawing.Point(579, 379);
            this.btn_bul.Name = "btn_bul";
            this.btn_bul.Size = new System.Drawing.Size(122, 23);
            this.btn_bul.TabIndex = 16;
            this.btn_bul.Text = "Bul";
            this.btn_bul.UseVisualStyleBackColor = true;
            this.btn_bul.Click += new System.EventHandler(this.btn_bul_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_foto);
            this.groupBox1.Controls.Add(this.txt_soyad);
            this.groupBox1.Controls.Add(this.txt_ogr_ad);
            this.groupBox1.Controls.Add(this.txt_ogrenci_id);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(52, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 162);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci";
            // 
            // txt_foto
            // 
            this.txt_foto.Location = new System.Drawing.Point(119, 118);
            this.txt_foto.Name = "txt_foto";
            this.txt_foto.Size = new System.Drawing.Size(100, 20);
            this.txt_foto.TabIndex = 17;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(119, 86);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(100, 20);
            this.txt_soyad.TabIndex = 16;
            // 
            // txt_ogr_ad
            // 
            this.txt_ogr_ad.Location = new System.Drawing.Point(119, 60);
            this.txt_ogr_ad.Name = "txt_ogr_ad";
            this.txt_ogr_ad.Size = new System.Drawing.Size(100, 20);
            this.txt_ogr_ad.TabIndex = 15;
            this.txt_ogr_ad.TextChanged += new System.EventHandler(this.txt_ogr_ad_TextChanged);
            // 
            // txt_ogrenci_id
            // 
            this.txt_ogrenci_id.Location = new System.Drawing.Point(119, 28);
            this.txt_ogrenci_id.Name = "txt_ogrenci_id";
            this.txt_ogrenci_id.Size = new System.Drawing.Size(100, 20);
            this.txt_ogrenci_id.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(29, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fotoğraf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(46, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(49, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(49, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(46, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ad";
            // 
            // txt_ders_id
            // 
            this.txt_ders_id.Location = new System.Drawing.Point(119, 28);
            this.txt_ders_id.Name = "txt_ders_id";
            this.txt_ders_id.Size = new System.Drawing.Size(100, 20);
            this.txt_ders_id.TabIndex = 14;
            // 
            // txt_ders_ad
            // 
            this.txt_ders_ad.Location = new System.Drawing.Point(119, 60);
            this.txt_ders_ad.Name = "txt_ders_ad";
            this.txt_ders_ad.Size = new System.Drawing.Size(100, 20);
            this.txt_ders_ad.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_ders_ad);
            this.groupBox2.Controls.Add(this.txt_ders_id);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(320, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 94);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dersler";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_not_güncelle);
            this.groupBox3.Controls.Add(this.btn_ort_hesapla);
            this.groupBox3.Controls.Add(this.txt_durum);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_ort);
            this.groupBox3.Controls.Add(this.txt_sinav3);
            this.groupBox3.Controls.Add(this.txt_sinav2);
            this.groupBox3.Controls.Add(this.txt_sinav1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(594, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 235);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notlar";
            // 
            // btn_not_güncelle
            // 
            this.btn_not_güncelle.Location = new System.Drawing.Point(119, 199);
            this.btn_not_güncelle.Name = "btn_not_güncelle";
            this.btn_not_güncelle.Size = new System.Drawing.Size(100, 23);
            this.btn_not_güncelle.TabIndex = 21;
            this.btn_not_güncelle.Text = "Not Güncelle";
            this.btn_not_güncelle.UseVisualStyleBackColor = true;
            // 
            // btn_ort_hesapla
            // 
            this.btn_ort_hesapla.Location = new System.Drawing.Point(128, 170);
            this.btn_ort_hesapla.Name = "btn_ort_hesapla";
            this.btn_ort_hesapla.Size = new System.Drawing.Size(75, 23);
            this.btn_ort_hesapla.TabIndex = 20;
            this.btn_ort_hesapla.Text = "Hesapla";
            this.btn_ort_hesapla.UseVisualStyleBackColor = true;
            // 
            // txt_durum
            // 
            this.txt_durum.Location = new System.Drawing.Point(119, 144);
            this.txt_durum.Name = "txt_durum";
            this.txt_durum.Size = new System.Drawing.Size(100, 20);
            this.txt_durum.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(46, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Durum";
            // 
            // txt_ort
            // 
            this.txt_ort.Location = new System.Drawing.Point(119, 118);
            this.txt_ort.Name = "txt_ort";
            this.txt_ort.Size = new System.Drawing.Size(100, 20);
            this.txt_ort.TabIndex = 17;
            // 
            // txt_sinav3
            // 
            this.txt_sinav3.Location = new System.Drawing.Point(119, 86);
            this.txt_sinav3.Name = "txt_sinav3";
            this.txt_sinav3.Size = new System.Drawing.Size(100, 20);
            this.txt_sinav3.TabIndex = 16;
            // 
            // txt_sinav2
            // 
            this.txt_sinav2.Location = new System.Drawing.Point(119, 60);
            this.txt_sinav2.Name = "txt_sinav2";
            this.txt_sinav2.Size = new System.Drawing.Size(100, 20);
            this.txt_sinav2.TabIndex = 15;
            // 
            // txt_sinav1
            // 
            this.txt_sinav1.Location = new System.Drawing.Point(119, 28);
            this.txt_sinav1.Name = "txt_sinav1";
            this.txt_sinav1.Size = new System.Drawing.Size(100, 20);
            this.txt_sinav1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(29, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ortalama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(46, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sınav 3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(46, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Sınav 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(49, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Sınav 1 ";
            // 
            // btn_not_listele
            // 
            this.btn_not_listele.Location = new System.Drawing.Point(579, 408);
            this.btn_not_listele.Name = "btn_not_listele";
            this.btn_not_listele.Size = new System.Drawing.Size(122, 23);
            this.btn_not_listele.TabIndex = 19;
            this.btn_not_listele.Text = "Not Listele";
            this.btn_not_listele.UseVisualStyleBackColor = true;
            this.btn_not_listele.Click += new System.EventHandler(this.btn_not_listele_Click);
            // 
            // btn_ogrenci_listele
            // 
            this.btn_ogrenci_listele.Location = new System.Drawing.Point(579, 437);
            this.btn_ogrenci_listele.Name = "btn_ogrenci_listele";
            this.btn_ogrenci_listele.Size = new System.Drawing.Size(122, 23);
            this.btn_ogrenci_listele.TabIndex = 20;
            this.btn_ogrenci_listele.Text = "Öğrenci Listele";
            this.btn_ogrenci_listele.UseVisualStyleBackColor = true;
            this.btn_ogrenci_listele.Click += new System.EventHandler(this.btn_ogrenci_listele_Click);
            // 
            // btn_prosedur
            // 
            this.btn_prosedur.Location = new System.Drawing.Point(713, 264);
            this.btn_prosedur.Name = "btn_prosedur";
            this.btn_prosedur.Size = new System.Drawing.Size(122, 23);
            this.btn_prosedur.TabIndex = 21;
            this.btn_prosedur.Text = "Prosedür";
            this.btn_prosedur.UseVisualStyleBackColor = true;
            this.btn_prosedur.Click += new System.EventHandler(this.btn_prosedur_Click);
            // 
            // RadioBtn_LinqEntity
            // 
            this.RadioBtn_LinqEntity.AutoSize = true;
            this.RadioBtn_LinqEntity.Location = new System.Drawing.Point(869, 48);
            this.RadioBtn_LinqEntity.Name = "RadioBtn_LinqEntity";
            this.RadioBtn_LinqEntity.Size = new System.Drawing.Size(131, 17);
            this.RadioBtn_LinqEntity.TabIndex = 22;
            this.RadioBtn_LinqEntity.TabStop = true;
            this.RadioBtn_LinqEntity.Text = "Ada Göre Sırala(A-->Z)";
            this.RadioBtn_LinqEntity.UseVisualStyleBackColor = true;
            // 
            // BtnLinqEntity
            // 
            this.BtnLinqEntity.Location = new System.Drawing.Point(869, 485);
            this.BtnLinqEntity.Name = "BtnLinqEntity";
            this.BtnLinqEntity.Size = new System.Drawing.Size(117, 23);
            this.BtnLinqEntity.TabIndex = 23;
            this.BtnLinqEntity.Text = "Linq Listele";
            this.BtnLinqEntity.UseVisualStyleBackColor = true;
            this.BtnLinqEntity.Click += new System.EventHandler(this.BtnLinqEntity_Click);
            // 
            // RadioBtn_ZA
            // 
            this.RadioBtn_ZA.AutoSize = true;
            this.RadioBtn_ZA.Location = new System.Drawing.Point(869, 81);
            this.RadioBtn_ZA.Name = "RadioBtn_ZA";
            this.RadioBtn_ZA.Size = new System.Drawing.Size(131, 17);
            this.RadioBtn_ZA.TabIndex = 24;
            this.RadioBtn_ZA.TabStop = true;
            this.RadioBtn_ZA.Text = "Ada Göre Sırala(Z-->A)";
            this.RadioBtn_ZA.UseVisualStyleBackColor = true;
            // 
            // RadioBtn_IlkUc
            // 
            this.RadioBtn_IlkUc.AutoSize = true;
            this.RadioBtn_IlkUc.Location = new System.Drawing.Point(869, 113);
            this.RadioBtn_IlkUc.Name = "RadioBtn_IlkUc";
            this.RadioBtn_IlkUc.Size = new System.Drawing.Size(71, 17);
            this.RadioBtn_IlkUc.TabIndex = 25;
            this.RadioBtn_IlkUc.TabStop = true;
            this.RadioBtn_IlkUc.Text = "İlk 3 Kayıt";
            this.RadioBtn_IlkUc.UseVisualStyleBackColor = true;
            // 
            // RadioBtn_ID
            // 
            this.RadioBtn_ID.AutoSize = true;
            this.RadioBtn_ID.Location = new System.Drawing.Point(869, 144);
            this.RadioBtn_ID.Name = "RadioBtn_ID";
            this.RadioBtn_ID.Size = new System.Drawing.Size(126, 17);
            this.RadioBtn_ID.TabIndex = 26;
            this.RadioBtn_ID.TabStop = true;
            this.RadioBtn_ID.Text = "ID\'ye Göre Kayıt Getir";
            this.RadioBtn_ID.UseVisualStyleBackColor = true;
            // 
            // RadioBtn_Start_A
            // 
            this.RadioBtn_Start_A.AutoSize = true;
            this.RadioBtn_Start_A.Location = new System.Drawing.Point(869, 170);
            this.RadioBtn_Start_A.Name = "RadioBtn_Start_A";
            this.RadioBtn_Start_A.Size = new System.Drawing.Size(146, 17);
            this.RadioBtn_Start_A.TabIndex = 27;
            this.RadioBtn_Start_A.TabStop = true;
            this.RadioBtn_Start_A.Text = "Adı A ile Başlayan Kayıtlar";
            this.RadioBtn_Start_A.UseVisualStyleBackColor = true;
            // 
            // RadioBtn_End_B
            // 
            this.RadioBtn_End_B.AutoSize = true;
            this.RadioBtn_End_B.Location = new System.Drawing.Point(869, 199);
            this.RadioBtn_End_B.Name = "RadioBtn_End_B";
            this.RadioBtn_End_B.Size = new System.Drawing.Size(127, 17);
            this.RadioBtn_End_B.TabIndex = 28;
            this.RadioBtn_End_B.TabStop = true;
            this.RadioBtn_End_B.Text = "Adı A ile Biten Kayıtlar";
            this.RadioBtn_End_B.UseVisualStyleBackColor = true;
            // 
            // RadioBtn_Deger_Kontrol
            // 
            this.RadioBtn_Deger_Kontrol.AutoSize = true;
            this.RadioBtn_Deger_Kontrol.Location = new System.Drawing.Point(869, 228);
            this.RadioBtn_Deger_Kontrol.Name = "RadioBtn_Deger_Kontrol";
            this.RadioBtn_Deger_Kontrol.Size = new System.Drawing.Size(87, 17);
            this.RadioBtn_Deger_Kontrol.TabIndex = 29;
            this.RadioBtn_Deger_Kontrol.TabStop = true;
            this.RadioBtn_Deger_Kontrol.Text = "Değer Var Mı";
            this.RadioBtn_Deger_Kontrol.UseVisualStyleBackColor = true;
            // 
            // RadioBtn_Kayit_Sayisi
            // 
            this.RadioBtn_Kayit_Sayisi.AutoSize = true;
            this.RadioBtn_Kayit_Sayisi.Location = new System.Drawing.Point(869, 251);
            this.RadioBtn_Kayit_Sayisi.Name = "RadioBtn_Kayit_Sayisi";
            this.RadioBtn_Kayit_Sayisi.Size = new System.Drawing.Size(116, 17);
            this.RadioBtn_Kayit_Sayisi.TabIndex = 30;
            this.RadioBtn_Kayit_Sayisi.TabStop = true;
            this.RadioBtn_Kayit_Sayisi.Text = "Toplam Kayıt Sayısı";
            this.RadioBtn_Kayit_Sayisi.UseVisualStyleBackColor = true;
            this.RadioBtn_Kayit_Sayisi.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RadioBtn_Ort
            // 
            this.RadioBtn_Ort.AutoSize = true;
            this.RadioBtn_Ort.Location = new System.Drawing.Point(869, 274);
            this.RadioBtn_Ort.Name = "RadioBtn_Ort";
            this.RadioBtn_Ort.Size = new System.Drawing.Size(131, 17);
            this.RadioBtn_Ort.TabIndex = 31;
            this.RadioBtn_Ort.TabStop = true;
            this.RadioBtn_Ort.Text = "Sınav1 Ortalama Puan";
            this.RadioBtn_Ort.UseVisualStyleBackColor = true;
            // 
            // RadioBtn_Max
            // 
            this.RadioBtn_Max.AutoSize = true;
            this.RadioBtn_Max.Location = new System.Drawing.Point(869, 299);
            this.RadioBtn_Max.Name = "RadioBtn_Max";
            this.RadioBtn_Max.Size = new System.Drawing.Size(139, 17);
            this.RadioBtn_Max.TabIndex = 32;
            this.RadioBtn_Max.TabStop = true;
            this.RadioBtn_Max.Text = "En Yüksek Sınav1 Notu";
            this.RadioBtn_Max.UseVisualStyleBackColor = true;
            // 
            // RadioBtn_Min
            // 
            this.RadioBtn_Min.AutoSize = true;
            this.RadioBtn_Min.Location = new System.Drawing.Point(869, 328);
            this.RadioBtn_Min.Name = "RadioBtn_Min";
            this.RadioBtn_Min.Size = new System.Drawing.Size(134, 17);
            this.RadioBtn_Min.TabIndex = 33;
            this.RadioBtn_Min.TabStop = true;
            this.RadioBtn_Min.Text = "En Düşük Sınav1 Notu";
            this.RadioBtn_Min.UseVisualStyleBackColor = true;
            // 
            // RadioBtn_Min_ogr
            // 
            this.RadioBtn_Min_ogr.AutoSize = true;
            this.RadioBtn_Min_ogr.Location = new System.Drawing.Point(869, 356);
            this.RadioBtn_Min_ogr.Name = "RadioBtn_Min_ogr";
            this.RadioBtn_Min_ogr.Size = new System.Drawing.Size(138, 17);
            this.RadioBtn_Min_ogr.TabIndex = 34;
            this.RadioBtn_Min_ogr.TabStop = true;
            this.RadioBtn_Min_ogr.Text = "Notu En Düşük Öğrenci";
            this.RadioBtn_Min_ogr.UseVisualStyleBackColor = true;
            // 
            // RadioBtn_Ort_Yuksek
            // 
            this.RadioBtn_Ort_Yuksek.AutoSize = true;
            this.RadioBtn_Ort_Yuksek.Location = new System.Drawing.Point(869, 382);
            this.RadioBtn_Ort_Yuksek.Name = "RadioBtn_Ort_Yuksek";
            this.RadioBtn_Ort_Yuksek.Size = new System.Drawing.Size(175, 17);
            this.RadioBtn_Ort_Yuksek.TabIndex = 35;
            this.RadioBtn_Ort_Yuksek.TabStop = true;
            this.RadioBtn_Ort_Yuksek.Text = "Ortalamadan Yüksek Öğrenciler";
            this.RadioBtn_Ort_Yuksek.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 520);
            this.Controls.Add(this.RadioBtn_Ort_Yuksek);
            this.Controls.Add(this.RadioBtn_Min_ogr);
            this.Controls.Add(this.RadioBtn_Min);
            this.Controls.Add(this.RadioBtn_Max);
            this.Controls.Add(this.RadioBtn_Ort);
            this.Controls.Add(this.RadioBtn_Kayit_Sayisi);
            this.Controls.Add(this.RadioBtn_Deger_Kontrol);
            this.Controls.Add(this.RadioBtn_End_B);
            this.Controls.Add(this.RadioBtn_Start_A);
            this.Controls.Add(this.RadioBtn_ID);
            this.Controls.Add(this.RadioBtn_IlkUc);
            this.Controls.Add(this.RadioBtn_ZA);
            this.Controls.Add(this.BtnLinqEntity);
            this.Controls.Add(this.RadioBtn_LinqEntity);
            this.Controls.Add(this.btn_prosedur);
            this.Controls.Add(this.btn_ogrenci_listele);
            this.Controls.Add(this.btn_not_listele);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_bul);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_ders_listele);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ders_listele;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_bul;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_foto;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ogr_ad;
        private System.Windows.Forms.TextBox txt_ogrenci_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ders_id;
        private System.Windows.Forms.TextBox txt_ders_ad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_durum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_ort;
        private System.Windows.Forms.TextBox txt_sinav3;
        private System.Windows.Forms.TextBox txt_sinav2;
        private System.Windows.Forms.TextBox txt_sinav1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_not_listele;
        private System.Windows.Forms.Button btn_ogrenci_listele;
        private System.Windows.Forms.Button btn_not_güncelle;
        private System.Windows.Forms.Button btn_ort_hesapla;
        private System.Windows.Forms.Button btn_prosedur;
        private System.Windows.Forms.RadioButton RadioBtn_LinqEntity;
        private System.Windows.Forms.Button BtnLinqEntity;
        private System.Windows.Forms.RadioButton RadioBtn_ZA;
        private System.Windows.Forms.RadioButton RadioBtn_IlkUc;
        private System.Windows.Forms.RadioButton RadioBtn_ID;
        private System.Windows.Forms.RadioButton RadioBtn_Start_A;
        private System.Windows.Forms.RadioButton RadioBtn_End_B;
        private System.Windows.Forms.RadioButton RadioBtn_Deger_Kontrol;
        private System.Windows.Forms.RadioButton RadioBtn_Kayit_Sayisi;
        private System.Windows.Forms.RadioButton RadioBtn_Ort;
        private System.Windows.Forms.RadioButton RadioBtn_Max;
        private System.Windows.Forms.RadioButton RadioBtn_Min;
        private System.Windows.Forms.RadioButton RadioBtn_Min_ogr;
        private System.Windows.Forms.RadioButton RadioBtn_Ort_Yuksek;
    }
}

