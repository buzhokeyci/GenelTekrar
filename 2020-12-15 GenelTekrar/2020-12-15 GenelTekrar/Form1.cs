using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_12_15_GenelTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region değişkenler
            //daha sonra tekrar kullanmak istediğimiz verileri bir isim vererek ram üzerinde tutmamızı sağlayan veri parçalarıdır.
            int sayi = 5;
            decimal ondalikliSayi = 10.5M;
            double ondalikliSayi2 = 5.3D;
            float ondalikliSayi3 = 1.1F;
            string metin = "ali ata bak";
            char karakter = 'a';
            DateTime tarih = DateTime.Now;
            bool tekMi = true;
            long buyukSayi = 12314234234;
            short kucukSayi = 123;

            //button1.ForeColor = Color.Red;

            Color benimRengim = Color.Blue;

            //MessageBox.Show(sayi.ToString());
            //sayi++;
            //MessageBox.Show(sayi.ToString());
            //sayi -= 2;
            //MessageBox.Show(sayi.ToString());
            //sayi = 5;
            #endregion

            #region tip dönüşümleri
            //içine atacağınız değer illaki kutunun(değşken tipinin) tipiyle aynı olmalı
            string mm = 5.ToString();

            //string ile herhangi bir tipde değeri toplarsanız sonul string olur ve toplamayı yan yana birleştirecek şekilde yapar.
            int sonuc = Convert.ToInt32(mm) + 3;

            TimeSpan ts = DateTime.Now - Convert.ToDateTime("1989-08-20"); //iki tarih arasındaki fark datetime tipinde olamaz. sadece x yıl, y ay, z gün gibi bir fark verebilir. bu da timeSpan tipinde tutulur.
            MessageBox.Show("toplam yaşadığınız gün sayısı : " + ts.TotalDays);
            #endregion

            #region Operatörler
            //++, --, *=, +=
            int a = 5;
            MessageBox.Show((++a).ToString());
            MessageBox.Show((a++).ToString());

            #endregion

            #region Karar Yapıları
            #region if-else
            //if(<koşul>) -> koşul - bool tipinde sonuç verecek herhangi bir işlem yapılabilir
            //else if -> o değilde buysa
            //else hiç biri değilse

            //if vb. sonrasında yaşam alanı oluşturulan kodlar için -> eğer sadece ardından tek satırlık bir kod gelecekse, yaşam alanı oluşturmanıza gerek yok (oluşturursanız da bir sorun yaratmaz). yaşam alanı olmadığında sadece bir sonraki satırı bağlar.
            if (5 == 5)
                MessageBox.Show("Test");
            else
                MessageBox.Show("Test2");
            #endregion

            #region switch-case
            int tamSayi = 5;
            switch (tamSayi) // anahtar bir değer - !!!! koşul değil değer !!! koşul yazarsam
            {
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                default:

                    break;
            }

            #endregion

            #region ternary if
            //kısa if kullanımı -> tek bir değer için karar yapısı kullanılıyorsa ternary if kullanılabilir
            int b = 5;
            if (b > 5)
                MessageBox.Show("Büyük");
            else
                MessageBox.Show("Küçük");

            string isim = "Ebru";
            MessageBox.Show(b > 5 && isim == "hakkı" || DateTime.Now > Convert.ToDateTime("2020-12-15") ? "Büyük" : "Küçük");//iki durumdada kod değil sadece değer değiştiği için burada değeri karar yapısına bağlayabiliriz
            MessageBox.Show(b > 5 ? "büyük" : b > 5 && b < 10 ? "5-10 arası" : "küçük");

            #endregion
            #endregion

            #region Döngüler
            //for (int i = 0; i < length; i++)
            //{

            //}

            //while (true)
            //{

            //}

            //do
            //{

            //} while (true);

            //foreach (var item in collection)
            //{

            //}

            #endregion

            #region Hata yönetimi
            
            
            a = 12;
            //break point ekleme kısa yolu F9 -> kod break point'te durduktan sonra örneğin bir değişkenin içindeki değeri görmek için sadece mouse ile üzerine gelmeniz yeterli.
            //1 satır çalıştırıp sonraki koda geçmek için F10 tuşu kullanılır
            //bulunduğunuz noktadan sonraki (varsa diğer break pointe kadar) tüm kodları çalıştırmak için F5

            //try
            //{
            //    int x = 0;
            //    int asdf = 1 / x;
            //}
            //catch
            //{
            //    Exception ex = new Exception("bu hata başka hata!");
            //    throw ex;
            //}
            #endregion

            #region Diziler
            //diziler aynı isimle çağırabileceğimiz içinde 1den fazla değer tutan değişkenlerdir.
            //dizilerde index numarası 0dan başlar
            int[] dizi1 = new int[5];
            string[] dizi2 = { "ankara", "izmir" };
            MessageBox.Show(dizi2[1]);

            MessageBox.Show(dizi2.Length.ToString());

            Array.Resize(ref dizi2, dizi2.Length + 1);

            dizi2[dizi2.Length - 1] = "Afyon";
            #endregion

            //int aasdf =  Int32.Parse("5");
            //decimal.Parse()


            //int.TryParse()

            decimal sss = -1;
            decimal.TryParse("ahmet", out sss);
            if (sss == -1)
            {
                MessageBox.Show("decimal bir değer girin");
            }
            else
                MessageBox.Show(sss.ToString());

            //ÖDEV: TryParse 2 - örnek
                //iç içe döngüleri tekrar edin küçük bir örnek

            #region Hazır Metotlar
            //string metotlar
            string ad = "aaaahmet";
            //ad.CompareTo()
            //ad.Replace("h", "*");
            //string[] heceler =  ad.Split('m');
            //string jyjyjy = ad.Trim('a','t');
            //ad.Contains("h");

            #endregion
        }
    }
}
