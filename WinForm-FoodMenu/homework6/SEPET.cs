using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace homework6
{
    public partial class formSEPET : Form
    {
       
        public formSEPET()
        {
            InitializeComponent();
        }
        int SepetToplamFiyat = 0;
        public string BilgiSepeti;
        public string FiyatSepeti;
        public string UrunAdiSepet;
        public PictureBox pcbSepet;


        public void Ekle(int urunSirasi)
        {
            switch (urunSirasi)
            {
                case 1:
                    rtbUrunBilgiSepet1.Visible = true;
                    rtbSepetFiyat1.Visible = true;
                    rtbUrunAdi1.Visible = true;
                    rtbAdet1.Visible = true;
                    pcbSepet1.Visible = true;
                    cb1.Visible = true;
                    lb1.Visible = true;
                    bteksi1.Visible = true;
                    btarti1.Visible = true;
                    rtbUrunBilgiSepet1.Text = BilgiSepeti;
                    rtbSepetFiyat1.Text = FiyatSepeti;
                    rtbUrunAdi1.Text = UrunAdiSepet;
                    pcbSepet1.Image = pcbSepet.Image;

                    break;
                case 2:
                    rtbUrunBilgiSepet2.Visible = true;
                    rtbSepetFiyat2.Visible = true;
                    rtbUrunAdi2.Visible = true;
                    rtbAdet2.Visible = true;
                    pcbSepet2.Visible = true;
                    cb2.Visible = true;
                    lb2.Visible = true;
                    bteksi2.Visible = true;
                    btarti2.Visible = true;
                    rtbUrunBilgiSepet2.Text = BilgiSepeti;
                    rtbSepetFiyat2.Text = FiyatSepeti;
                    rtbUrunAdi2.Text = UrunAdiSepet;
                    pcbSepet2.Image = pcbSepet.Image;
                    break;
                case 3:
                    rtbUrunBilgiSepet3.Visible = true;
                    rtbSepetFiyat3.Visible = true;
                    rtbUrunAdi3.Visible = true;
                    rtbAdet3.Visible = true;
                    pcbSepet3.Visible = true;
                    cb3.Visible = true;
                    lb3.Visible = true;
                    bteksi3.Visible = true;
                    btarti3.Visible = true;
                    rtbUrunBilgiSepet3.Text = BilgiSepeti;
                    rtbSepetFiyat3.Text = FiyatSepeti;
                    rtbUrunAdi3.Text = UrunAdiSepet;
                    pcbSepet3.Image = pcbSepet.Image;

                    break;
                case 4:
                    rtbUrunBilgiSepet4.Visible = true;
                    rtbSepetFiyat4.Visible = true;
                    rtbUrunAdi4.Visible = true;
                    rtbAdet4.Visible = true;
                    pcbSepet4.Visible = true;
                    cb4.Visible = true;
                    lb4.Visible = true;
                    bteksi4.Visible = true;
                    btarti4.Visible = true;
                    rtbUrunBilgiSepet4.Text = BilgiSepeti;
                    rtbSepetFiyat4.Text = FiyatSepeti;
                    rtbUrunAdi4.Text = UrunAdiSepet;
                    pcbSepet4.Image = pcbSepet.Image;
                    break;
                case 5:
                    rtbUrunBilgiSepet5.Visible = true;
                    rtbSepetFiyat5.Visible = true;
                    rtbUrunAdi5.Visible = true;
                    rtbAdet5.Visible = true;
                    pcbSepet5.Visible = true;
                    cb5.Visible = true;
                    lb5.Visible = true;
                    bteksi5.Visible = true;
                    btarti5.Visible = true;
                    rtbUrunBilgiSepet5.Text = BilgiSepeti;
                    rtbSepetFiyat5.Text = FiyatSepeti;
                    rtbUrunAdi5.Text = UrunAdiSepet;
                    pcbSepet5.Image = pcbSepet.Image;
                    break;
                default:
                  
                    MessageBox.Show("Sepetiniz dolmustur");
                    Form1.sayac--;  
                    return;
            }
            SepetToplamFiyat = int.Parse(rtbSepetFiyat1.Text) + int.Parse(rtbSepetFiyat2.Text) + int.Parse(rtbSepetFiyat3.Text) + int.Parse(rtbSepetFiyat4.Text) + int.Parse(rtbSepetFiyat5.Text);
            rtbSepetToplamFiyat.Text = SepetToplamFiyat.ToString();
        } //formdan yüklenen verilerin sepette gösterildiği alan

        private void btSil_Click(object sender, EventArgs e)  //ürünlerin silindiği ve sepet içi değişikliklerin,fiyatın kontrolünün yapıldığı alan
        {
            int silinenFiyat = 0;
            int sayac = 0;
            DialogResult dialogResult = MessageBox.Show("Ürünleri silmek istediğinizden emin misiniz?", "ÜRÜN SİLME İŞLEMİ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                if (cb1.Checked == true)
                {

                    silinenFiyat += int.Parse(rtbSepetFiyat1.Text);
                    sayac++;

                }
                if (cb2.Checked == true)
                {
                    silinenFiyat += int.Parse(rtbSepetFiyat2.Text);
                    sayac++;
                }
                else
                {
                    if (sayac == 1)
                    {
                        rtbUrunBilgiSepet1.Text = rtbUrunBilgiSepet2.Text;
                        rtbUrunAdi1.Text = rtbUrunAdi2.Text;
                        rtbSepetFiyat1.Text = rtbSepetFiyat2.Text;
                        rtbAdet1.Text = rtbAdet2.Text;
                        pcbSepet1.Image = pcbSepet2.Image;
                    }
                }
                if (cb3.Checked == true)
                {
                    silinenFiyat += int.Parse(rtbSepetFiyat3.Text);
                    sayac++;
                }
                else
                {
                    switch (sayac)
                    {
                        case 1:
                            rtbUrunBilgiSepet2.Text = rtbUrunBilgiSepet3.Text;
                            rtbUrunAdi2.Text = rtbUrunAdi3.Text;
                            rtbSepetFiyat2.Text = rtbSepetFiyat3.Text;
                            rtbAdet2.Text = rtbAdet3.Text;
                            pcbSepet2.Image = pcbSepet3.Image;
                            break;
                        case 2:
                            rtbUrunBilgiSepet1.Text = rtbUrunBilgiSepet3.Text;
                            rtbUrunAdi1.Text = rtbUrunAdi3.Text;
                            rtbSepetFiyat1.Text = rtbSepetFiyat3.Text;
                            rtbAdet1.Text = rtbAdet3.Text;
                            pcbSepet1.Image = pcbSepet3.Image;
                            break;
                    }
                }
                if (cb4.Checked == true)
                {
                    silinenFiyat += int.Parse(rtbSepetFiyat4.Text);
                    sayac++;
                }
                else
                {
                    switch (sayac)
                    {
                        case 1:
                            rtbUrunBilgiSepet3.Text = rtbUrunBilgiSepet4.Text;
                            rtbUrunAdi3.Text = rtbUrunAdi4.Text;
                            rtbSepetFiyat3.Text = rtbSepetFiyat4.Text;
                            rtbAdet3.Text = rtbAdet4.Text;
                            pcbSepet3.Image = pcbSepet4.Image;
                            break;
                        case 2:
                            rtbUrunBilgiSepet2.Text = rtbUrunBilgiSepet4.Text;
                            rtbUrunAdi2.Text = rtbUrunAdi4.Text;
                            rtbSepetFiyat2.Text = rtbSepetFiyat4.Text;
                            rtbAdet2.Text = rtbAdet4.Text;
                            pcbSepet2.Image = pcbSepet4.Image;
                            break;
                        case 3:
                            rtbUrunBilgiSepet1.Text = rtbUrunBilgiSepet4.Text;
                            rtbUrunAdi1.Text = rtbUrunAdi4.Text;
                            rtbSepetFiyat1.Text = rtbSepetFiyat4.Text;
                            rtbAdet1.Text = rtbAdet4.Text;
                            pcbSepet1.Image = pcbSepet4.Image;
                            break;
                    }
                }
                if (cb5.Checked == true)
                {
                    silinenFiyat += int.Parse(rtbSepetFiyat5.Text);
                    sayac++;

                }
                else
                {
                    switch (sayac)
                    {
                        case 1:
                            rtbUrunBilgiSepet4.Text = rtbUrunBilgiSepet5.Text;
                            rtbUrunAdi4.Text = rtbUrunAdi5.Text;
                            rtbSepetFiyat4.Text = rtbSepetFiyat5.Text;
                            rtbAdet4.Text = rtbAdet5.Text;
                            pcbSepet4.Image = pcbSepet5.Image;
                            break;
                        case 2:
                            rtbUrunBilgiSepet3.Text = rtbUrunBilgiSepet5.Text;
                            rtbUrunAdi3.Text = rtbUrunAdi5.Text;
                            rtbSepetFiyat3.Text = rtbSepetFiyat5.Text;
                            rtbAdet3.Text = rtbAdet5.Text;
                            pcbSepet3.Image = pcbSepet5.Image;
                            break;
                        case 3:
                            rtbUrunBilgiSepet2.Text = rtbUrunBilgiSepet5.Text;
                            rtbUrunAdi2.Text = rtbUrunAdi5.Text;
                            rtbSepetFiyat2.Text = rtbSepetFiyat5.Text;
                            rtbAdet2.Text = rtbAdet5.Text;
                            pcbSepet2.Image = pcbSepet5.Image;
                            break;
                        case 4:
                            rtbUrunBilgiSepet1.Text = rtbUrunBilgiSepet5.Text;
                            rtbUrunAdi1.Text = rtbUrunAdi5.Text;
                            rtbSepetFiyat1.Text = rtbSepetFiyat5.Text;
                            rtbAdet1.Text = rtbAdet5.Text;
                            pcbSepet1.Image = pcbSepet5.Image;
                            break;
                    }
                }
                cb5.Checked = false;
                cb4.Checked = false;
                cb3.Checked = false;
                cb2.Checked = false;
                cb1.Checked = false;
            }
            else
            {

            }
          
            int silinecekCaseSayisi = 5 - Form1.sayac + sayac;
            switch (silinecekCaseSayisi)
            {
                case 1:
                    rtbSepetFiyat5.Text = "0";
                    rtbSepetFiyat5.Visible = false;
                    rtbAdet5.Visible = false;
                    rtbUrunAdi5.Visible = false;
                    pcbSepet5.Visible = false;
                    rtbUrunBilgiSepet5.Visible = false;
                    cb5.Visible = false;
                    lb5.Visible = false;
                    btarti5.Visible = false;
                    bteksi5.Visible = false;
                    break;

                case 2:
                    rtbSepetFiyat5.Text = "0";
                    rtbSepetFiyat5.Visible = false;
                    rtbAdet5.Visible = false;
                    rtbUrunAdi5.Visible = false;
                    pcbSepet5.Visible = false;
                    rtbUrunBilgiSepet5.Visible = false;
                    rtbSepetFiyat4.Text = "0";
                    rtbSepetFiyat4.Visible = false;
                    rtbAdet4.Visible = false;
                    rtbUrunAdi4.Visible = false;
                    pcbSepet4.Visible = false;
                    rtbUrunBilgiSepet4.Visible = false;
                    cb5.Visible = false;
                    cb4.Visible = false;
                    lb5.Visible = false;
                    lb4.Visible = false;
                    btarti5.Visible = false;
                    btarti4.Visible = false;
                    bteksi5.Visible = false;
                    bteksi4.Visible = false;

                    break;
                case 3:
                    rtbSepetFiyat5.Text = "0";
                    rtbSepetFiyat5.Visible = false;
                    rtbAdet5.Visible = false;
                    rtbUrunAdi5.Visible = false;
                    pcbSepet5.Visible = false;
                    rtbUrunBilgiSepet5.Visible = false;
                    rtbSepetFiyat4.Text = "0";
                    rtbSepetFiyat4.Visible = false;
                    rtbAdet4.Visible = false;
                    rtbUrunAdi4.Visible = false;
                    pcbSepet4.Visible = false;
                    rtbUrunBilgiSepet4.Visible = false;
                    rtbSepetFiyat3.Text = "0";
                    rtbSepetFiyat3.Visible = false;
                    rtbAdet3.Visible = false;
                    rtbUrunAdi3.Visible = false;
                    pcbSepet3.Visible = false;
                    rtbUrunBilgiSepet3.Visible = false;
                    cb5.Visible = false;
                    cb4.Visible = false;
                    cb3.Visible = false;
                    lb5.Visible = false;
                    lb4.Visible = false;
                    lb3.Visible = false;
                    btarti5.Visible = false;
                    btarti4.Visible = false;
                    btarti3.Visible = false;
                    bteksi5.Visible = false;
                    bteksi4.Visible = false;
                    bteksi3.Visible = false;
                    break;
                case 4:
                    rtbSepetFiyat5.Text = "0";
                    rtbSepetFiyat5.Visible = false;
                    rtbAdet5.Visible = false;
                    rtbUrunAdi5.Visible = false;
                    pcbSepet5.Visible = false;
                    rtbUrunBilgiSepet5.Visible = false;
                    rtbSepetFiyat4.Text = "0";
                    rtbSepetFiyat4.Visible = false;
                    rtbAdet4.Visible = false;
                    rtbUrunAdi4.Visible = false;
                    pcbSepet4.Visible = false;
                    rtbUrunBilgiSepet4.Visible = false;
                    rtbSepetFiyat3.Text = "0";
                    rtbSepetFiyat3.Visible = false;
                    rtbAdet3.Visible = false;
                    rtbUrunAdi3.Visible = false;
                    pcbSepet3.Visible = false;
                    rtbUrunBilgiSepet3.Visible = false;
                    rtbSepetFiyat2.Text = "0";
                    rtbSepetFiyat2.Visible = false;
                    rtbAdet2.Visible = false;
                    rtbUrunAdi2.Visible = false;
                    pcbSepet2.Visible = false;
                    rtbUrunBilgiSepet2.Visible = false;
                    cb5.Visible = false;
                    cb4.Visible = false;
                    cb3.Visible = false;
                    cb2.Visible = false;
                    lb5.Visible = false;
                    lb4.Visible = false;
                    lb3.Visible = false;
                    lb2.Visible = false;
                    btarti5.Visible = false;
                    btarti4.Visible = false;
                    btarti3.Visible = false;
                    btarti2.Visible = false;
                    bteksi5.Visible = false;
                    bteksi4.Visible = false;
                    bteksi3.Visible = false;
                    bteksi2.Visible = false;

                    break;
                case 5:
                    TumSepetiSil();
                    break;
            }


            for (int i = 0; i < sayac; i++)
            {
                Form1.sayac--;
            }

            rtbSepetToplamFiyat.Text = (int.Parse(rtbSepetToplamFiyat.Text) - silinenFiyat).ToString();  //fiyat kontrol


        }

        private void TumSepetiSil()
        {
            rtbSepetFiyat5.Text = "0";
            rtbSepetFiyat5.Visible = false;
            rtbAdet5.Visible = false;
            rtbUrunAdi5.Visible = false;
            pcbSepet5.Visible = false;
            rtbUrunBilgiSepet5.Visible = false;
            rtbSepetFiyat4.Text = "0";
            rtbSepetFiyat4.Visible = false;
            rtbAdet4.Visible = false;
            rtbUrunAdi4.Visible = false;
            pcbSepet4.Visible = false;
            rtbUrunBilgiSepet4.Visible = false;
            rtbSepetFiyat3.Text = "0";
            rtbSepetFiyat3.Visible = false;
            rtbAdet3.Visible = false;
            rtbUrunAdi3.Visible = false;
            pcbSepet3.Visible = false;
            rtbUrunBilgiSepet3.Visible = false;
            rtbSepetFiyat2.Text = "0";
            rtbSepetFiyat2.Visible = false;
            rtbAdet2.Visible = false;
            rtbUrunAdi2.Visible = false;
            pcbSepet2.Visible = false;
            rtbUrunBilgiSepet2.Visible = false;
            rtbSepetFiyat1.Text = "0";
            rtbSepetFiyat1.Visible = false;
            rtbAdet1.Visible = false;
            rtbUrunAdi1.Visible = false;
            pcbSepet1.Visible = false;
            rtbUrunBilgiSepet1.Visible = false;
            cb5.Visible = false;
            cb4.Visible = false;
            cb3.Visible = false;
            cb2.Visible = false;
            cb1.Visible = false;
            lb5.Visible = false;
            lb4.Visible = false;
            lb3.Visible = false;
            lb2.Visible = false;
            lb1.Visible = false;
            btarti5.Visible = false;
            btarti4.Visible = false;
            btarti3.Visible = false;
            btarti2.Visible = false;
            btarti1.Visible = false;
            bteksi5.Visible = false;
            bteksi4.Visible = false;
            bteksi3.Visible = false;
            bteksi2.Visible = false;
            bteksi1.Visible = false;
        }
        private void btSepetKapat_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        #region Adet arttırma ve azaltma işlemlerinin yapıldığı kısım
        private void btarti1_Click(object sender, EventArgs e)
        {
            rtbAdet1.Text = (int.Parse(rtbAdet1.Text) + 1).ToString();
            rtbSepetToplamFiyat.Text = ((int.Parse(rtbSepetToplamFiyat.Text)) + int.Parse(rtbSepetFiyat1.Text) / (int.Parse(rtbAdet1.Text) - 1)).ToString();
            rtbSepetFiyat1.Text = (int.Parse(rtbSepetFiyat1.Text) + int.Parse(rtbSepetFiyat1.Text) / (int.Parse(rtbAdet1.Text) - 1)).ToString();
        }

        private void btarti2_Click(object sender, EventArgs e)
        {
            rtbAdet2.Text = (int.Parse(rtbAdet2.Text) + 1).ToString();
            rtbSepetToplamFiyat.Text = ((int.Parse(rtbSepetToplamFiyat.Text)) + int.Parse(rtbSepetFiyat2.Text) / (int.Parse(rtbAdet2.Text) - 1)).ToString();
            rtbSepetFiyat2.Text = (int.Parse(rtbSepetFiyat2.Text) + int.Parse(rtbSepetFiyat2.Text) / (int.Parse(rtbAdet2.Text) - 1)).ToString();
        }

        private void btarti3_Click(object sender, EventArgs e)
        {
            rtbAdet3.Text = (int.Parse(rtbAdet3.Text) + 1).ToString();
            rtbSepetToplamFiyat.Text = ((int.Parse(rtbSepetToplamFiyat.Text)) + int.Parse(rtbSepetFiyat3.Text) / (int.Parse(rtbAdet3.Text) - 1)).ToString();
            rtbSepetFiyat3.Text = (int.Parse(rtbSepetFiyat3.Text) + int.Parse(rtbSepetFiyat3.Text) / (int.Parse(rtbAdet3.Text) - 1)).ToString();
        }

        private void btarti4_Click(object sender, EventArgs e)
        {
            rtbAdet4.Text = (int.Parse(rtbAdet4.Text) + 1).ToString();
            rtbSepetToplamFiyat.Text = ((int.Parse(rtbSepetToplamFiyat.Text)) + int.Parse(rtbSepetFiyat4.Text) / (int.Parse(rtbAdet4.Text) - 1)).ToString();
            rtbSepetFiyat4.Text = (int.Parse(rtbSepetFiyat4.Text) + int.Parse(rtbSepetFiyat4.Text) / (int.Parse(rtbAdet4.Text) - 1)).ToString();
        }

        private void btarti5_Click(object sender, EventArgs e)
        {
            rtbAdet5.Text = (int.Parse(rtbAdet5.Text) + 1).ToString();
            rtbSepetToplamFiyat.Text = ((int.Parse(rtbSepetToplamFiyat.Text)) + int.Parse(rtbSepetFiyat5.Text) / (int.Parse(rtbAdet5.Text) - 1)).ToString();
            rtbSepetFiyat5.Text = (int.Parse(rtbSepetFiyat5.Text) + int.Parse(rtbSepetFiyat5.Text) / (int.Parse(rtbAdet5.Text) - 1)).ToString();
        }

        private void btkeksi1_Click(object sender, EventArgs e)
        {
            if (int.Parse(rtbAdet1.Text) > 1)
            {
                rtbAdet1.Text = (int.Parse(rtbAdet1.Text) - 1).ToString();
                rtbSepetToplamFiyat.Text = ((int.Parse(rtbSepetToplamFiyat.Text)) - int.Parse(rtbSepetFiyat1.Text) / (int.Parse(rtbAdet1.Text) + 1)).ToString();
                rtbSepetFiyat1.Text = (int.Parse(rtbSepetFiyat1.Text) - int.Parse(rtbSepetFiyat1.Text) / (int.Parse(rtbAdet1.Text) + 1)).ToString();
            }
        }

        private void btkeksi2_Click(object sender, EventArgs e)
        {
            if (int.Parse(rtbAdet2.Text) > 1)
            {
                rtbAdet2.Text = (int.Parse(rtbAdet2.Text) - 1).ToString();
                rtbSepetToplamFiyat.Text = ((int.Parse(rtbSepetToplamFiyat.Text)) - int.Parse(rtbSepetFiyat2.Text) / (int.Parse(rtbAdet2.Text) + 1)).ToString();
                rtbSepetFiyat2.Text = (int.Parse(rtbSepetFiyat2.Text) - int.Parse(rtbSepetFiyat2.Text) / (int.Parse(rtbAdet2.Text) + 1)).ToString();
            }
        }

        private void btkeksi3_Click(object sender, EventArgs e)
        {
            if (int.Parse(rtbAdet3.Text) > 1)
            {
                rtbAdet3.Text = (int.Parse(rtbAdet3.Text) - 1).ToString();
                rtbSepetToplamFiyat.Text = ((int.Parse(rtbSepetToplamFiyat.Text)) - int.Parse(rtbSepetFiyat3.Text) / (int.Parse(rtbAdet3.Text) + 1)).ToString();
                rtbSepetFiyat3.Text = (int.Parse(rtbSepetFiyat3.Text) - int.Parse(rtbSepetFiyat3.Text) / (int.Parse(rtbAdet3.Text) + 1)).ToString();
            }

        }

        private void btkeksi4_Click(object sender, EventArgs e)
        {
            if (int.Parse(rtbAdet4.Text) > 1)
            {
                rtbAdet4.Text = (int.Parse(rtbAdet4.Text) - 1).ToString();
                rtbSepetToplamFiyat.Text = ((int.Parse(rtbSepetToplamFiyat.Text)) - int.Parse(rtbSepetFiyat4.Text) / (int.Parse(rtbAdet4.Text) + 1)).ToString();
                rtbSepetFiyat4.Text = (int.Parse(rtbSepetFiyat4.Text) - int.Parse(rtbSepetFiyat4.Text) / (int.Parse(rtbAdet4.Text) + 1)).ToString();
            }
        }

        private void btkeksi5_Click(object sender, EventArgs e)
        {
            if (int.Parse(rtbAdet5.Text) > 1)
            {
                rtbAdet5.Text = (int.Parse(rtbAdet5.Text) - 1).ToString();
                rtbSepetToplamFiyat.Text = ((int.Parse(rtbSepetToplamFiyat.Text)) - int.Parse(rtbSepetFiyat5.Text) / (int.Parse(rtbAdet5.Text) + 1)).ToString();
                rtbSepetFiyat5.Text = (int.Parse(rtbSepetFiyat5.Text) - int.Parse(rtbSepetFiyat5.Text) / (int.Parse(rtbAdet5.Text) + 1)).ToString();
            }
        }
        #endregion
        private void btSatinAl_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show($"Ürünleri toplam tutarı {rtbSepetToplamFiyat} TL'dir, satın almayı onaylıyor musunuz?", "Onay Sayfası", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                MessageBox.Show("Talabiniz başarılı bir şekilde alınmıştır.");
                TumSepetiSil();
                Form1.sayac = 0;

            }
        }
    }
}
