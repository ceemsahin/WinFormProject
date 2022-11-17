using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Textboxtan gelecek verileri boşaltmak için bir metot yazdım işlemlerden sonra textboxların içi silinsin.

        public void Bosalt()
        {
            txtAdSoyad.Text = "";
            txtNo.Text = "";
        }


        // Veri kaydetme kısmı 
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Veri Tabanı Bağlantısı Gerçekleştirdik.


            DatabasePersonelEntities db = new DatabasePersonelEntities();


            //Veri Ekleme Yapıcağımız class çağrılıyor.

            TBLPersonel tp = new TBLPersonel();

            //Mükerrer numara olmaması için önce textboxttan gelen numara db'de varmı yok mu diye kontrol ediyorum.

           var noKontrol = db.TBLPersonel.FirstOrDefault(x => x.Numarasi == txtNo.Text);

            //Textboxt alanları boş geçilemesin diye bir if bloğu yazdım.

            if (!String.IsNullOrEmpty(txtAdSoyad.Text) && (!String.IsNullOrEmpty(txtNo.Text)))
            {
                //Eğer textboxtan gelen numara yok ise 

                if (noKontrol==null)
                {
                    // İsim alanı en fazla 50 karakter olacak 
                    if (txtAdSoyad.Text.Length<=50)
                    {
                        tp.AdiSoyadi = txtAdSoyad.Text;

                    }
                    else
                    {
                        MessageBox.Show("İsim soy isim alanı en fazla 50 karakter olabilir.");
                        return;
                    }

                    // Numara alanı en fazla 12 karakter olacak
                    if (txtNo.Text.Length<=12)
                    {
                        tp.Numarasi = txtNo.Text;
                    }
                    else
                    {
                        MessageBox.Show("Numara alanı en fazla 12 karakter olabilir.");
                        return;
                    }



                    
                    db.TBLPersonel.Add(tp); //Class'ın içerisinde ki verileri Db'ye gönderiyoruz.
                    db.SaveChanges(); // İşlemi kaydediyoruz.

                    MessageBox.Show("Kayıt Başarılı");

                    Bosalt();

                    // Veri kayıt edildikten son gridwiew içerisine listeleme yapılıyor.
                    dtPers.DataSource = db.TBLPersonel.ToList();

                }

                else
                {
                    MessageBox.Show(" Böyle bir numara mevcut. Lütfen farklı bir numara giriniz");
                }



            }
            else
            {
                MessageBox.Show("Lütfen Ad Soyad ve Numara alanlarını boş geçmeyiniz");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatabasePersonelEntities db = new DatabasePersonelEntities();
            dtPers.DataSource = db.TBLPersonel.ToList();
        }

        int veriId = 0;

        private void dtPers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView içerisinde ki satıra tıkladıgımızda satırın bigisini textbox'lara yazdıracağız.


            //Hangi satıra tıklanırsa,1. Sütunun değerini alıp kutulara yazdıracak.

            txtAdSoyad.Text = dtPers.Rows[e.RowIndex].Cells[1].Value.ToString();

            //Hangi satıra tıklanırsa,2. Sütunun değerini alıp kutulara yazdıracak.

            txtNo.Text = dtPers.Rows[e.RowIndex].Cells[2].Value.ToString();

            //Güncelleme yapabilmemiz için,tıklanan veri'nin ID bilgisini almak zorundayız.

            veriId = Convert.ToInt32(dtPers.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        //Güncelleme kısmı
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DatabasePersonelEntities db = new DatabasePersonelEntities();


            TBLPersonel tp = db.TBLPersonel.Find(veriId);
            //Kişiye tıklanmasını istiyorum.
            if (tp!=null)
            {
                //Burda gelen veriler üzerinde bir işlem yapılıp yapılmama kontrolü yapıyorum.
                if (tp.Numarasi != txtNo.Text || tp.AdiSoyadi != txtAdSoyad.Text)
                {
                    tp.AdiSoyadi = txtAdSoyad.Text;
                    tp.Numarasi = txtNo.Text;
                    db.SaveChanges();
                    dtPers.DataSource = db.TBLPersonel.ToList();

                    MessageBox.Show("Veri Güncelleme Başarılı");
                }
                else
                {
                    MessageBox.Show("Lütfen güncelleme yapılacak alanları değiştirin.");
                }

                
            }
            else
            {
                MessageBox.Show("Kişi seçiniz.");
            }
           
          

        }

        private void btnPSil_Click(object sender, EventArgs e)
        {
            //İlk olarak alınan Id aresine ait veri daha önce silinmiş mi bakalım 


            if (veriId==0)
            {
                MessageBox.Show("Veri Bulunamadı");

            }

            else
            {
                DatabasePersonelEntities db = new DatabasePersonelEntities();
                db.TBLPersonel.Remove(db.TBLPersonel.Find(veriId));
                db.SaveChanges();
                veriId = 0;
                Bosalt();
                dtPers.DataSource = db.TBLPersonel.ToList();
                MessageBox.Show("Veri silindi.");
            }
        }
    }
}
