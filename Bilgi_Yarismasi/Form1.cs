namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {

        int soruNo = 0, dogru, yanlis;

        //butona basilip basilmadigini tutacagimiz degisken
        int tiklanildi = 0;

        String dogruCevap = "";

        //tiklanip tiklanmadigini atayacagimiz diger degisken ve ana metodumuz olan button5_Click'te kullaniyoruz
        int girdi = 0;

        

        private void buttonA_Click(object sender, EventArgs e)
        {
            if(dogruCevap == buttonA.Text)
            {
                //dogru oldugunda green light gif yanacak
                trueBox.Visible = true;
                //dogru sayisini bir artirip label'e atiyoruz
                dogru++;
                label7.Text = Convert.ToString( dogru);
                //herhangi bir butona tiklanildigini tutan degiskenimiz
                tiklanildi++;
            }
            else
            {
                //yanlis oldugunda red light gif yanacak
                falseBox.Visible = true;
                //yanlis sayisini bir artirip label'e atiyoruz
                yanlis++;
                label6.Text = Convert.ToString( yanlis);
                //herhangi bir butona tiklanildigini tutan degiskenimiz
                tiklanildi++;
            }
            //buton'a bir daha tiklanma ozelligini kapatiyoruz
            butonFalseEnableMetodu();

            //diger butonlarda da ayni ozellikleri kullandik
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            if (dogruCevap == buttonB.Text)
            {
                trueBox.Visible = true;
                dogru++;
                label7.Text = Convert.ToString(dogru);
                tiklanildi++;
            }
            else
            {
                falseBox.Visible = true;
                yanlis++;
                label6.Text = Convert.ToString(yanlis);
                tiklanildi++;
            }
            butonFalseEnableMetodu();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (dogruCevap == buttonC.Text)
            {
                trueBox.Visible = true;

                dogru++;
                label7.Text = Convert.ToString(dogru);
                tiklanildi++;
            }
            else
            {
                falseBox.Visible = true;
                yanlis++;
                label6.Text = Convert.ToString(yanlis);
                tiklanildi++;
            }
            butonFalseEnableMetodu();
        }
        private void buttonD_Click(object sender, EventArgs e)
        {
            if (dogruCevap == buttonD.Text)
            {
                trueBox.Visible = true;

                dogru++;
                label7.Text = Convert.ToString(dogru);
                tiklanildi++;
            }
            else
            {
                falseBox.Visible = true;
                yanlis++;
                label6.Text = Convert.ToString(yanlis);
                tiklanildi++;
            }
            butonFalseEnableMetodu();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //form'umuza Restart ozelligi atadik ve text'teki yazimizi kontrol ettik
            if(button5.Text == "Yeniden Başlat")
            {
               Application.Restart();
            }
            else
            {
                //soruNo diye bir degiskenimiz var,hangi soruda oldugumuzu tutuyor,default degeri de '0' oldugundan
                //bir artirip devam ediyoruz 
                if (soruNo == 0)
                {
                    soruNo++;

                    //converter
                    label8.Text = soruNo.ToString();

                    //sorular() metodumuzda 'sorularımızı' donduruyoruz ve parametre olarak 'soruNo' degiskenimizi atiyoruz
                    sorular(soruNo);
                }
                //1.sorudan itibaren girilecek kosul sarti blogu
                else if (soruNo != 0)
                {
                    //hicbir butonun secilip secilmedigini kontrol eden metodumuzu calistiriyoruz
                    tiklanmaKontrol();
                    //eger hicbir buton tiklanmadiysa 'girdi' degerimizin default degeri '0' olur ve ileri soruya gidemeyiz
                    if (girdi != 0)
                    {
                        //ileri soruya gidemedigimizden dolayi 'soruNo' degiskenimiz artmadan kalir
                        label8.Text = soruNo.ToString();
                        //tekrar ayni soruyu dondururuz
                        sorular(soruNo);
                        //ve her defasinda girdimizi sifirlayip yeniden kontrol edilmeye hazir hale getiririz
                        girdi = 0;
                    }
                    else
                    {
                        //herhangi bir buton secildiyse girilecek sart blogu
                        //'soruNo' bir artirilip sonraki soruya gecilir
                        soruNo++;

                        label8.Text = soruNo.ToString();

                        sorular(soruNo);



                    }
                }
            }
            
            
        }
        //butonlari erisilebilir hale getiriyoruz
        public void butonTrueEnableMetodu()
        {
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
        }
        //butonlari erisilemez hale getiriyoruz
        public void butonFalseEnableMetodu()
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
        }

        //herhangi bir butonun tiklanip tiklanmadigini kontrol edecek metod
        public void tiklanmaKontrol()
        {
            //bir butona tiklanilmadiysa hata mesajini ekrana vericez
            if(tiklanildi == 0)
            {
                MessageBox.Show("\n Hiçbir Cevap Seçilmedi. \n Diğer Soruya Geçemezsiniz !!! \n Lütfen Cevap Seçiniz !!!");
                girdi++;
            }
        }
        //sorularimizi dondurecegimiz metod
        public void sorular(int soruNo)
        {
            if (soruNo == 1)
            {
                
                soruLabel.Text = "Cumhuriyet Kaç Yılında Kurulmuştur ? ";
                buttonA.Text = "1920";
                buttonB.Text = "1921";
                buttonC.Text = "1922";
                buttonD.Text = "1923";
                dogruCevap = "1923";
                //butonlari default olarak 'invisible' yapmistik
                //ilk sorudan itibaren 'visible' yaptik
                buttonA.Visible = true;buttonB.Visible = true;buttonC.Visible = true;buttonD.Visible = true;

            }
            else if (soruNo == 2)
            {
                //true-false giflerimizi her sorudan sonra tekrardan invisible yapiyoruz
                trueBox.Visible = false; falseBox.Visible = false;
                //butonlara erisim sagliyoruz
                butonTrueEnableMetodu();
                tiklanildi = 0;
                soruLabel.Text = "Yumurta ve irmikle yapılan,fırında piştikten sonra üzerine şerbet " +
                    "dökülen tatlının adı nedir ? ";
                buttonA.Text = "Lokma";
                buttonB.Text = "Revani";
                buttonC.Text = "Şekerpare";
                buttonD.Text = "Kemalpaşa";
                dogruCevap = "Revani";
            }
            else if (soruNo == 3)
            {
                trueBox.Visible = false; falseBox.Visible = false;
                butonTrueEnableMetodu();
                tiklanildi = 0;
                soruLabel.Text = "Eline geçeni zamansız ve ayırt etmeden yiyen kişiye ne denir? ";
                buttonA.Text = "Açık Ağız";
                buttonB.Text = "Pis Boğaz";
                buttonC.Text = "Tıknaz";
                buttonD.Text = "Savurgan";
                dogruCevap = "Pis Boğaz";
            }
            else if (soruNo == 4)
            {
                trueBox.Visible = false; falseBox.Visible = false;
                butonTrueEnableMetodu();
                tiklanildi = 0;
                soruLabel.Text = "Romen Rakamında Hangi Sayı Yoktur? ";
                buttonA.Text = "0";
                buttonB.Text = "50";
                buttonC.Text = "100";
                buttonD.Text = "1000";
                dogruCevap = "0";
            }
            else if (soruNo == 5)
            {
                trueBox.Visible = false; falseBox.Visible = false;
                butonTrueEnableMetodu();
                tiklanildi = 0;
                soruLabel.Text = "Magna Carta hangi ülkenin kralıyla yapılmış bir sözleşmedir? ";
                buttonA.Text = "İspanya";
                buttonB.Text = "Fransa";
                buttonC.Text = "İngiltere";
                buttonD.Text = "Almanya";
                dogruCevap = "İngiltere";
            }
            else if (soruNo == 6)
            {
                trueBox.Visible = false; falseBox.Visible = false;
                butonTrueEnableMetodu();
                tiklanildi = 0;
                soruLabel.Text = "Galatasaray hangi yıl UEFA kupasını almıştır? ";
                buttonA.Text = "2000";
                buttonB.Text = "2001";
                buttonC.Text = "2002";
                buttonD.Text = "2003";
                dogruCevap = "2000";
            }
            else if (soruNo == 7)
            {
                trueBox.Visible = false; falseBox.Visible = false;
                butonTrueEnableMetodu();
                tiklanildi = 0;
                soruLabel.Text = "Kıbrıs Barış harekatı hangi tarihte gerçekleşmiştir? ";
                buttonA.Text = "1970";
                buttonB.Text = "1972";
                buttonC.Text = "1974";
                buttonD.Text = "1976";
                dogruCevap = "1974";
            }
            else if (soruNo == 8)
            {
                trueBox.Visible = false; falseBox.Visible = false;
                butonTrueEnableMetodu();
                tiklanildi = 0;
                soruLabel.Text = "Osmanlı’da Lale devri hangi padişah döneminde yaşamıştır? ";
                buttonA.Text = "3.Ahmet";
                buttonB.Text = "4.Murat";
                buttonC.Text = "3.Selim";
                buttonD.Text = "4.Mehmet";
                dogruCevap = "3.Ahmet";
            }
            else if (soruNo == 9)
            {
                trueBox.Visible = false; falseBox.Visible = false;
                butonTrueEnableMetodu();
                tiklanildi = 0;
                soruLabel.Text = "Bir elektrik devresinde direnç hangi harfle gösterilir? ";
                buttonA.Text = "D";
                buttonB.Text = "R";
                buttonC.Text = "A";
                buttonD.Text = "G";
                dogruCevap = "R";
            }
            else if (soruNo == 10)
            {
                trueBox.Visible = false; falseBox.Visible = false;
                butonTrueEnableMetodu();
                tiklanildi = 0;
                soruLabel.Text = "İstiklal Marşı hangi yıl yazılmıştır? ";
                buttonA.Text = "1919";
                buttonB.Text = "1920";
                buttonC.Text = "1921";
                buttonD.Text = "1922";
                dogruCevap = "1921";

                button5.Text = "Bitir";
            }
            
            else
            {
                //sorularimiz bittiginde 'soruNo' degiskenimizin artmasini onlemek icin bu sarta giriyoruz
                label8.Text = "10";
                
                MessageBox.Show("\n Bütün Soruları Cevapladınız \n \n Toplam Soru Sayısı : 10 " +
                    "\n Doğru Sayınız : " + dogru + "\n Yanlış Sayınız : " + yanlis + "\n Doğru Yüzdeniz : % " + (100 * dogru)/10);
                button5.Text = "Yeniden Başlat";
                //MessageBox'tan sonra kullaniciya 'yeniden baslayabilme' sansini veriyoruz

            }

        }
    }
}