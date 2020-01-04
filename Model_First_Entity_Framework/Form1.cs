using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Model_First_Entity_Framework.DataConnection;

namespace Model_First_Entity_Framework
{
    public partial class Form1 : Form
    {
        DB_SinavOgrenciEntities db = new DB_SinavOgrenciEntities();
        public Form1()
        {
            InitializeComponent();

        }

        int id;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=HP;Initial Catalog=DB_SinavOgrenci;Integrated Security=True");
            SqlCommand komut = new SqlCommand("Select * From tbl_dersler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_not_listele_Click(object sender, EventArgs e)
        {
            var query = from item in db.tbl_notlar
                        select new
                        {
                            item.NotId,
                            item.Ogr,
                            item.Ders,
                            item.Sinav1,
                            item.Sinav2,
                            item.Sinav3,
                            item.Durum,
                            item.Ortalama
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void btn_bul_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.tbl_ogrenci.Where(x => x.Ad == txt_ogr_ad.Text | x.Soyad == txt_soyad.Text).ToList();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txt_ogrenci_id.Text)))
            {
                int id = Convert.ToInt16(txt_ogrenci_id.Text);
                var x = db.tbl_ogrenci.Find(id);
                x.Ad = txt_ogr_ad.Text;
                x.Soyad = txt_soyad.Text;
                x.Fotograf = txt_foto.Text;
                db.SaveChanges();
                MessageBox.Show("Güncelleme Başarılı");
                Ogrenci_Listele();

            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txt_ogrenci_id.Text)))
            {
                int id = Convert.ToInt16(txt_ogrenci_id.Text);
                var x = db.tbl_ogrenci.Find(id);
                db.tbl_ogrenci.Remove(x);
                db.SaveChanges();
                MessageBox.Show("Öğrenci Silindi");
                Ogrenci_Listele();
            }
            else
            {
                MessageBox.Show("ID Bilgisini Boş Geçmeyin!");
            }


        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            tbl_ogrenci t = new tbl_ogrenci();
            if ((!string.IsNullOrWhiteSpace(txt_ogr_ad.Text)) && (!string.IsNullOrWhiteSpace(txt_soyad.Text)))
            {
                t.Ad = txt_ogr_ad.Text;
                t.Soyad = txt_soyad.Text;
                db.tbl_ogrenci.Add(t);
                db.SaveChanges();
                MessageBox.Show("Öğrenci Listeye Eklenmiştir!");
                Ogrenci_Listele();
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız!!");
            }


        }

        private void Ogrenci_Listele()
        {
            dataGridView1.DataSource = db.tbl_ogrenci.ToList();
        }

        private void btn_ogrenci_listele_Click(object sender, EventArgs e)
        {
            Ogrenci_Listele();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Id"].Value);
            var x = db.tbl_ogrenci.Find(id);
            txt_ogr_ad.Text = x.Ad;
            txt_ogrenci_id.Text = Convert.ToString(x.Id);
            txt_soyad.Text = x.Soyad;
        }

        private void btn_prosedur_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.NOTLISTESI();
        }

        private void txt_ogr_ad_TextChanged(object sender, EventArgs e)
        {
            string aranan = txt_ogr_ad.Text;
            var sorgu = from item in db.tbl_ogrenci
                        where item.Ad.Contains(aranan)
                        select item;
            dataGridView1.DataSource = sorgu.ToList();
        }

        private void BtnLinqEntity_Click(object sender, EventArgs e)
        {
            if (RadioBtn_LinqEntity.Checked == true)
            {
                //Asc
                List<tbl_ogrenci> liste1 = db.tbl_ogrenci.OrderBy(p => p.Ad).ToList();
                dataGridView1.DataSource = liste1;
            }
            if (RadioBtn_ZA.Checked == true)
            {
                //Desc
                List<tbl_ogrenci> liste2 = db.tbl_ogrenci.OrderByDescending(p => p.Ad).ToList();
                dataGridView1.DataSource = liste2;
            }
            if (RadioBtn_IlkUc.Checked == true)
            {
                List<tbl_ogrenci> liste3 = db.tbl_ogrenci.OrderBy(p => p.Ad).Take(3).ToList();
                dataGridView1.DataSource = liste3;
            }
            if (RadioBtn_ID.Checked == true)
            {
                int ID = Convert.ToInt16(txt_ogrenci_id.Text);
                List<tbl_ogrenci> liste4 = db.tbl_ogrenci.Where(p => p.Id == ID).ToList();
                dataGridView1.DataSource = liste4;
            }
            if (RadioBtn_Start_A.Checked == true)
            {
                List<tbl_ogrenci> liste5 = db.tbl_ogrenci.Where(p => p.Ad.StartsWith("a")).ToList();
                dataGridView1.DataSource = liste5;
            }
            if (RadioBtn_End_B.Checked == true)
            {
                List<tbl_ogrenci> liste6 = db.tbl_ogrenci.Where(p => p.Ad.EndsWith("a")).ToList();
                dataGridView1.DataSource = liste6;
            }
            if (RadioBtn_Deger_Kontrol.Checked == true)
            {
                bool kontrol = db.tbl_kulupler.Any();
                MessageBox.Show(kontrol.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (RadioBtn_Kayit_Sayisi.Checked == true)
            {
                int toplam = db.tbl_ogrenci.Count();
                MessageBox.Show(toplam.ToString(), "Toplam Öğrenci Sayısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (RadioBtn_Ort.Checked == true)
            {
                var toplam = db.tbl_notlar.Average(p => p.Sinav1);
                MessageBox.Show(toplam.ToString(), "1. Sınavın Ortalaması", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (RadioBtn_Max.Checked == true)
            {
                var max = db.tbl_notlar.Max(p => p.Sinav1);
                MessageBox.Show(max.ToString(), "1. Sınavın En Yüksek Notu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (RadioBtn_Min.Checked == true)
            {
                var min = db.tbl_notlar.Min(p => p.Sinav1);
                MessageBox.Show(min.ToString(), "1. Sınavın En Düşük Notu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (RadioBtn_Min_ogr.Checked == true)
            {
                var min = db.tbl_notlar.Min(p => p.Sinav1);
                var result = from p in db.tbl_notlar
                             join c in db.tbl_ogrenci on p.Ogr equals c.Id
                             where p.Sinav1 == min
                             select new
                             {
                                 Name = c.Ad
                             };
                dataGridView1.DataSource = result.ToList();

            }
            if (RadioBtn_Ort_Yuksek.Checked == true)
            {
                var ort = db.tbl_notlar.Average(p => p.Sinav1);
                var result = from p in db.tbl_notlar
                             join c in db.tbl_ogrenci on p.Ogr equals c.Id
                             where p.Sinav1 > ort
                             select new
                             {
                                 Isim = c.Ad,
                                 Not = p.Sinav1
                             };
                dataGridView1.DataSource = result.ToList();

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
