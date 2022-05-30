using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using homework6.Properties;

namespace homework6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(int a)
        {

        }
        formSEPET formSEPET = new formSEPET();
        public static int sayac = 0;
        public int secim = 0;
        int fiyat = 0;
        string urunAdi;
        int a = 3;


        public void Form1_Load(object sender, EventArgs e)
        {
            formSEPET.rtbSepetFiyat1.Text = "0";
            formSEPET.rtbSepetFiyat2.Text = "0";
            formSEPET.rtbSepetFiyat3.Text = "0";
            formSEPET.rtbSepetFiyat4.Text = "0";
            formSEPET.rtbSepetFiyat5.Text = "0";
            formSEPET.rtbAdet1.Text = "1";
            formSEPET.rtbAdet2.Text = "1";
            formSEPET.rtbAdet3.Text = "1";
            formSEPET.rtbAdet4.Text = "1";
            formSEPET.rtbAdet5.Text = "1";
            formSEPET.cb5.Visible = false;
            formSEPET.cb4.Visible = false;
            formSEPET.cb3.Visible = false;
            formSEPET.cb2.Visible = false;
            formSEPET.cb1.Visible = false;
            formSEPET.lb5.Visible = false;
            formSEPET.lb4.Visible = false;
            formSEPET.lb3.Visible = false;
            formSEPET.lb2.Visible = false;
            formSEPET.lb1.Visible = false;
            formSEPET.btarti5.Visible = false;
            formSEPET.btarti4.Visible = false;
            formSEPET.btarti3.Visible = false;
            formSEPET.btarti2.Visible = false;
            formSEPET.btarti1.Visible = false;
            formSEPET.bteksi5.Visible = false;
            formSEPET.bteksi4.Visible = false;
            formSEPET.bteksi3.Visible = false;
            formSEPET.bteksi2.Visible = false;
            formSEPET.bteksi1.Visible = false;

        }

        #region Menü İçerikleri ve Menü Seçim Alanı
        private void bALIKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbMenu.Text = "";
            string[] dizi = (string[])Enum.GetNames(typeof(Balik));  //balık isimleri string diziye atanmıştır 
            foreach (var item in dizi)
            {
                rtbMenu.Text = $"{rtbMenu.Text}{item} = {(int)Enum.Parse(typeof(Balik), item)} \n";
            }      // balık seçimi yapıldıysa tüm balıkların textboxta alt alta yazılması sağlanmıştır.
             secim = 1;
        }
        public enum Balik
        {
            Tekir = 1,
            Kefal,
            Lüfer,
            Hamsi,
            Çıpura,
            Mezgit
        }
        private void tAVUKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbMenu.Text = "";
            string[] dizi = (string[])Enum.GetNames(typeof(Tavuk));
            foreach (var item in dizi)
            {
                rtbMenu.Text = $"{rtbMenu.Text}{item} = {(int)Enum.Parse(typeof(Tavuk), item)} \n";
            }
            secim = 2;
        }
        public enum Tavuk
        {
            TavukSis = 1,
            TavukTantuni,
            TavukSote,
            TavukKanat

        }
        private void eTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbMenu.Text = "";
            string[] dizi = (string[])Enum.GetNames(typeof(Et));
            foreach (var item in dizi)
            {
                rtbMenu.Text = $"{rtbMenu.Text}{item} = {(int)Enum.Parse(typeof(Et), item)} \n";
            }
            secim = 3;
        }
        public enum Et
        {
            SultanKebabi = 1,
            Güveç,
            Antrikot,
            EtSote
        }
        private void çORBAToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            rtbMenu.Text = "";
            string[] dizi = (string[])Enum.GetNames(typeof(Corba));     
            foreach (var item in dizi)
            {
                rtbMenu.Text = $"{rtbMenu.Text}{item} = {(int)Enum.Parse(typeof(Corba), item)} \n";
            }
            secim = 4;
        }

        public enum Corba
        {
            Tarhana = 1,
            Mercimek,
            KellePaça,
            Yayla
        }
        private void sALATAToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            rtbMenu.Text = "";
            string[] dizi = (string[])Enum.GetNames(typeof(Salata));
            foreach (var item in dizi)
            {
                rtbMenu.Text = $"{rtbMenu.Text}{item} = {(int)Enum.Parse(typeof(Salata), item)} \n";
            }
            secim = 5;
        }

        public enum Salata
        {
            YıldızŞehriyeSalatası = 1,
            GarnitürlüTavukSalatası,
            YoğurtluKabakSalatası,
            KözPatlıcanlıHumus
        }
        #endregion
            #region kaç numaralı ürünün seçildiğini kontrol eden ve sonuçlar döndüren kısım
        private void tbSayi_TextChanged(object sender, EventArgs e)
        {
            tbSayi.ForeColor = Color.Black;
            bool b = int.TryParse(tbSayi.Text, out int secimm); //sayısal değer dışında değer girilirse, sistemin patlamaması için yazılmıştır
            if (b == false)
            {
                return;                           //sayısal değer kontrolü
            }
            if (secim == 1 || secim == 2 || secim == 3 || secim == 4 || secim == 5)
            {
                pcbYemekFoto.Visible = true;
                rtbFiyat.Visible = true;
                rtbYemekBilgi.Visible = true;
                btEkle.Visible = true;
            }
            else
            {
                pcbYemekFoto.Visible = false;
                rtbFiyat.Visible = false;
                rtbYemekBilgi.Visible = false;
                btEkle.Visible = false;


            }
            if (secim == 1)
            {

                urunAdi = (string)Enum.GetName(typeof(Form1.Balik), int.Parse(tbSayi.Text));
                if (secimm == 1)            //tryParse sonucu true ise tbsayi.text'in int hali secim olacaktır
                {
                    fiyat = 35;
                    rtbYemekBilgi.Text = "Tekir ile ilgili bilgi";
                    rtbFiyat.Text = $"Fiyat = {fiyat}TL";
                    pcbYemekFoto.Image = Resources.Tekirr;
                }
                else if (tbSayi.Text == "2")
                {
                    fiyat = 45;
                    rtbYemekBilgi.Text = "Kefal ile ilgili bilgi";
                    rtbFiyat.Text = $"Fiyat = {fiyat}TL";
                    pcbYemekFoto.Image = Resources.Kefal;
                }
                else if (tbSayi.Text == "3")
                {
                    fiyat = 25;
                    rtbYemekBilgi.Text = "Lüfer ile ilgili bilgi";
                    rtbFiyat.Text = $"Fiyat = {fiyat}TL";
                    pcbYemekFoto.Image = Resources.Lüfer;
                }
                else if (tbSayi.Text == "4")
                {
                    fiyat = 55;
                    rtbYemekBilgi.Text = "Hamsi ile ilgili bilgi";
                    rtbFiyat.Text = $"Fiyat = {fiyat}TL";
                    pcbYemekFoto.Image = Resources.Hamsi;
                }
                else if (tbSayi.Text == "5")
                {
                    fiyat = 35;
                    rtbYemekBilgi.Text = "Çıpura ile ilgili bilgi";
                    rtbFiyat.Text = $"Fiyat = {fiyat}TL";
                    pcbYemekFoto.Image = Resources.Çıpura;
                }
                else if (tbSayi.Text == "6")
                {
                    fiyat = 35;
                    rtbYemekBilgi.Text = "Mezgit ile ilgili bilgi";
                    rtbFiyat.Text = $"Fiyat = {fiyat}TL";
                    pcbYemekFoto.Image = Resources.Mezgit;
                }
                else
                {
                    tbSayi.ForeColor = Color.Red;
                }
            }
            else if (secim == 2)
            {
                urunAdi = (string)Enum.GetName(typeof(Form1.Tavuk), int.Parse(tbSayi.Text));
                if (tbSayi.Text == "1")
                {
                    fiyat = 30;
                    rtbYemekBilgi.Text = "Tavuk Şiş ile ilgili bilgi";
                    rtbFiyat.Text = $"Fiyat = {fiyat}TL";
                    pcbYemekFoto.Image = Resources.tavuksis;
                }
                else if (tbSayi.Text == "2")
                {
                    fiyat = 20;
                    rtbYemekBilgi.Text = "Tavuk Tantuni ile ilgili bilgi";
                    rtbFiyat.Text = $"Fiyat = {fiyat}TL";
                    pcbYemekFoto.Image = Resources.tavuktantuni;
                }
                else if (tbSayi.Text == "3")
                {
                    fiyat = 45;
                    rtbYemekBilgi.Text = "Tavuk Sote ile ilgili bilgi";
                    rtbFiyat.Text = $"Fiyat = {fiyat}TL";
                    pcbYemekFoto.Image = Resources.tavuksote;
                }
                else if (tbSayi.Text == "4")
                {
                    fiyat = 35;
                    rtbYemekBilgi.Text = "Tavuk Kanat ile ilgili bilgi";
                    rtbFiyat.Text = $"Fiyat = {fiyat}TL";
                    pcbYemekFoto.Image = Resources.tavukkanat;
                }
                else
                {
                    tbSayi.ForeColor = Color.Red;
                }

            }
            else if (secim == 3)
            {
                urunAdi = (string)Enum.GetName(typeof(Form1.Et), int.Parse(tbSayi.Text));
                if (tbSayi.Text == "1")
                {
                    fiyat = 30;
                    rtbYemekBilgi.Text = "Sultan Kebabı ile ilgili bilgi";
                    rtbFiyat.Text = $"Fiyat = {fiyat}TL";
                    pcbYemekFoto.Image = Resources.SultanKebabi;
                }
                else if (tbSayi.Text == "2")
                {
                    fiyat = 20;
                    rtbYemekBilgi.Text = "Güveç ile ilgili bilgi";
                    rtbFiyat.Text = $"Fiyat = {fiyat}TL";
                    pcbYemekFoto.Image = Resources.Guvec;
                }
                else if (tbSayi.Text == "3")
                {
                    fiyat = 45;
                    rtbYemekBilgi.Text = "Antrikot ile ilgili bilgi";
                    rtbFiyat.Text = $"Fiyat = {fiyat}TL";
                    pcbYemekFoto.Image = Resources.antrikot;
                }
                else if (tbSayi.Text == "4")
                {
                    fiyat = 35;
                    rtbYemekBilgi.Text = "Et sote ile ilgili bilgi";
                    rtbFiyat.Text = $"Fiyat = {fiyat}TL";
                    pcbYemekFoto.Image = Resources.etsote;
                }
                else
                {
                    tbSayi.ForeColor = Color.Red;
                }
            }
            else if (secim == 4)
            {

                urunAdi = (string)Enum.GetName(typeof(Form1.Corba), int.Parse(tbSayi.Text));
                if (tbSayi.Text == "1")
                {
                    fiyat = 30;
                    rtbYemekBilgi.Text = "Tarhana ile ilgili bilgi";
                    rtbFiyat.Text = $"Fiyat = {fiyat}TL";
                    pcbYemekFoto.Image = Resources.tarhana;
                }
                else if (tbSayi.Text == "2")
                {
                    fiyat = 20;
                    rtbYemekBilgi.Text = "Mercimek ile ilgili bilgi";
                    rtbFiyat.Text = $"Fiyat = {fiyat}TL";
                    pcbYemekFoto.Image = Resources.mercimek;
                }
                else if (tbSayi.Text == "3")
                {
                    fiyat = 45;
                    rtbYemekBilgi.Text = "Kelle Paça ile ilgili bilgi";
                    rtbFiyat.Text = $"Fiyat = {fiyat}TL";
                    pcbYemekFoto.Image = Resources.kellepaca;
                }
                else if (tbSayi.Text == "4")
                {
                    fiyat = 35;
                    rtbYemekBilgi.Text = "Yayla ile ilgili bilgi";
                    rtbFiyat.Text = $"Fiyat = {fiyat}TL";
                    pcbYemekFoto.Image = Resources.yayla;
                }
                else
                {
                    tbSayi.ForeColor = Color.Red;
                }
            }
            else if (secim == 5)
            {

                urunAdi = (string)Enum.GetName(typeof(Form1.Salata), int.Parse(tbSayi.Text));
                if (tbSayi.Text == "1")
                {
                    fiyat = 25;
                    rtbYemekBilgi.Text = "Yıldız Şehriye Salatası ile ilgili bilgi";
                    rtbFiyat.Text = $"Fiyat = {fiyat}TL";
                    pcbYemekFoto.Image = Resources.yıldızlışehriyesalatası;
                }
                else if (tbSayi.Text == "2")
                {
                    fiyat = 40;
                    rtbYemekBilgi.Text = "Garnitürlü Tavuk Salatası ile ilgili bilgi";
                    rtbFiyat.Text = $"Fiyat = {fiyat}TL";
                    pcbYemekFoto.Image = Resources.garnitürlütavuksalatası;
                }
                else if (tbSayi.Text == "3")
                {
                    fiyat = 27;
                    rtbYemekBilgi.Text = "Yoğurtlu Kabak Salatası ile ilgili bilgi";
                    rtbFiyat.Text = $"Fiyat = {fiyat}TL";
                    pcbYemekFoto.Image = Resources.yoğurlukabaksalatası;
                }
                else if (tbSayi.Text == "4")
                {
                    fiyat = 23;
                    rtbYemekBilgi.Text = "Köz Patlıcanlı Humus ile ilgili bilgi";
                    rtbFiyat.Text = $"Fiyat = {fiyat}TL";
                    pcbYemekFoto.Image = Resources.közpatlıcanlıhumus;
                }
                else
                {
                    tbSayi.ForeColor = Color.Red;
                }
            }
        }
            #endregion

        private void btEkle_Click(object sender, EventArgs e) // sepet ile form arasında kurulan bağlantı
        {
            sayac++;

            formSEPET.BilgiSepeti = rtbYemekBilgi.Text;
            formSEPET.FiyatSepeti = fiyat.ToString();
            formSEPET.UrunAdiSepet = urunAdi;
            formSEPET.pcbSepet = pcbYemekFoto;
            formSEPET.Ekle(sayac);

        }


        private void btSepetim_Click(object sender, EventArgs e) //sepetin açılmasını sağlayan kısım
        {
            if (a == 3)
            {
                formSEPET.Show();
                a++;
            }
            if (a == 4)
            {
                formSEPET.Visible = true;
            }

        }


    }
}
