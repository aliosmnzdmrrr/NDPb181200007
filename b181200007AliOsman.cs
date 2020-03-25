using System;

namespace CoronaTeshisProgrami
{




    class Program
{
    static void Main(string[] args)
    {
        /****************************************************************************
        ** SAKARYA ÜNİVERSİTESİ
        ** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
        ** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
        ** NESNEYE DAYALI PROGRAMLAMA DERSİ
        ** 2019-2020 BAHAR DÖNEMİ
        **
        ** ÖDEV NUMARASI..........: 1
        ** ÖĞRENCİ ADI............: Ali Osman Özdemir 
        ** ÖĞRENCİ NUMARASI.......: b181200007


        /*Şu an en büyük problemimiz insanlık için covid-19 adlı virüs.Bu yüzden bu zor zamanda teshis programı yazmak istedim.Umarım begenirsiniz.*/

        Console.Title = ("Covid-19 Tanı ");
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Teste Hosgeldiniz");

        string ad, soyad;
        int yas;
        Console.WriteLine("Adınız");
        ad = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Soyadınız");
        soyad = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Yaşınız");
        yas = Convert.ToInt32(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("Teste Hosgeldiniz");
        Console.WriteLine("Adınız   : " + ad);
        Console.WriteLine("Soyadınız: " + soyad);
        Console.WriteLine("Yasınız  : " + yas);
        Console.WriteLine("Sorulara gore puan kazanıp veya kaybedeceksiniz");
        Console.WriteLine("Lütfen Cevaplarınızı Verirken Caps Lock Tuşunu Açmayı Unutmayınız");
        Console.WriteLine("Başlamak için her hangi bir tuşa basınız");

        Console.ReadKey();

        int dogru, yanlis, puan;
        dogru = 0;
        yanlis = 0;
        puan = 0;

        string soru1;
        Console.WriteLine("Soru 1 - Ellerinizi sık sık yıkar mısınız?");
        soru1 = Convert.ToString(Console.ReadLine());

        Console.WriteLine("A) Evet B) Hayır ");
        string cevap1;
        cevap1 = Console.ReadLine();

        if (cevap1 == "B")
        {
            Console.WriteLine("Tamamdır sıradaki soruya gecelim :) ");
            Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
            Console.Read();
            dogru++;
            puan = puan + 10;
        }
        else
        {
            Console.WriteLine("Sıradaki soruya gecelim :) ");
            Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
            Console.ReadLine();
            yanlis++;
            puan = puan - 5;
        }

        Console.WriteLine("Doğru Sayınız {0} Yanlış Sayınız {1} Puanınız {2}", dogru, yanlis, puan);
        Console.ReadLine();

        string soru2;
        Console.WriteLine("Soru 2 -Herhangi bir kronik rahatsızlıgınız var mı ?");
        soru1 = Convert.ToString(Console.ReadLine());

        Console.WriteLine("A) Evet B) Hayır");
        string cevap2;
        cevap1 = Console.ReadLine();

        if (cevap1 == "A")
        {
            Console.WriteLine("Hmm... Devam edelim ");
            Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
            Console.Read();
            dogru++;
            puan = puan + 10;

        }
        else
        {
            Console.WriteLine("Cok guzel boyle Devam ");
            Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
            Console.ReadLine();
            yanlis++;
            puan = puan - 5;
        }

        Console.WriteLine("Doğru Sayınız {0} Yanlış Sayınız {1} Puanınız {2}", dogru, yanlis, puan);
        Console.ReadLine();

        string soru3;
        Console.WriteLine("Soru 3 -Yuksek Ates belirtileriniz var mı? ");
        soru1 = Convert.ToString(Console.ReadLine());

        Console.WriteLine("A) Evet B) Hayır ");
        string cevap3;
        cevap3 = Console.ReadLine();

        if (cevap3 == "A")
        {
            Console.WriteLine("Dikkatli olmalısın");
            Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
            Console.Read();
            dogru++;
            puan = puan + 10;

        }
        else
        {
            Console.WriteLine("Sukurler olsun devam edelim");
            Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
            Console.ReadLine();
            yanlis++;
            puan = puan - 5;
        }

        Console.WriteLine("Doğru Sayınız {0} Yanlış Sayınız {1} Puanınız {2}", dogru, yanlis, puan);
        Console.ReadLine();

        string soru4;
        Console.WriteLine("Soru 4 -Nefes darlıgı cekiyor musunuz ?");
        soru1 = Convert.ToString(Console.ReadLine());

        Console.WriteLine("A) Hayır B) Evet");
        string cevap4;
        cevap4 = Console.ReadLine();

        if (cevap4 == "B")
        {
            Console.WriteLine("Iyi gorunmuyor ama devam edelim ");
            Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
            Console.Read();
            dogru++;
            puan = puan + 10;

        }
        else
        {
            Console.WriteLine("Guzel ama dikkatli olmakta fayda var");
            Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
            Console.ReadLine();
            yanlis++;
            puan = puan - 5;
        }

        Console.WriteLine("Doğru Sayınız {0} Yanlış Sayınız {1} Puanınız {2}", dogru, yanlis, puan);
        Console.ReadLine();

        string soru5;
        Console.WriteLine("Soru 5 - Peki sigara kullanıyor musunuz?");
        soru1 = Convert.ToString(Console.ReadLine());

        Console.WriteLine("A) Hayır B) Evet");
        string cevap5;
        cevap5 = Console.ReadLine();

        if (cevap5 == "B")
        {
            Console.WriteLine("Zararlı bir alıskanlık acilen bırakmalısın sigara coronavirus riskini 14 kat arttırıyor");
            Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
            Console.Read();
            dogru++;
            puan = puan + 10;

        }
        else
        {
            Console.WriteLine("Beyaz Beyaz Cigerler");
            Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
            Console.ReadLine();
            yanlis++;
            puan = puan - 5;
        }

        Console.WriteLine("Doğru Sayınız {0} Yanlış Sayınız {1} Puanınız {2}", dogru, yanlis, puan);
        Console.ReadLine();

        string soru6;
        Console.WriteLine("Soru 6 - Yakın zamanda yurt dısına cıktın mı ?");
        soru6 = Convert.ToString(Console.ReadLine());

        Console.WriteLine("A) Param yok nasıl cıkayım B) Evet C) Yakın zamanda evdeydim ");
        string cevap6;
        cevap6 = Console.ReadLine();

        if (cevap6 == "B")
        {
            Console.WriteLine(" Hay aksi");
            Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
            Console.Read();
            dogru++;
            puan = puan + 10;

        }
        else
        {
            Console.WriteLine("Iyi gidiyoruz sanki ");
            Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
            Console.ReadLine();
            yanlis++;
            puan = puan - 5;
        }

        Console.WriteLine("Doğru Sayınız {0} Yanlış Sayınız {1} Puanınız {2}", dogru, yanlis, puan);
        Console.ReadLine();

        string soru7;
        Console.WriteLine("Soru 7 - Yakın zamanda yurt dısı seyahatinden bulunan biriyle gorustun mu ?");
        soru7 = Convert.ToString(Console.ReadLine());

        Console.WriteLine("A) Evet B) Hayır");
        string cevap7;
        cevap7 = Console.ReadLine();

        if (cevap7 == "A")
        {
            Console.WriteLine("Devam edelim bakalım");
            Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
            Console.Read();
            dogru++;
            puan = puan + 10;

        }
        else
        {
            Console.WriteLine(" Boyle devaam");
            Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
            Console.ReadLine();
            yanlis++;
            puan = puan - 5;
        }

        Console.WriteLine("Doğru Sayınız {0} Yanlış Sayınız {1} Puanınız {2}", dogru, yanlis, puan);
        Console.ReadLine();

        string soru8;
        Console.WriteLine("Soru 8 - Maske eldiven kurallarına dikkat ediyor musun ?");
        soru1 = Convert.ToString(Console.ReadLine());

        Console.WriteLine("A) Hayır B) Evet ");
        string cevap8;
        cevap8 = Console.ReadLine();

        if (cevap8 == "A")
        {
            Console.WriteLine("Dikkatli olsan biraz :( ");
            Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
            Console.Read();
            dogru++;
            puan = puan + 10;

        }
        else
        {
            Console.WriteLine("Temizlik saglık demektir");
            Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
            Console.ReadLine();
            yanlis++;
            puan = puan - 5;
        }

        Console.WriteLine("Doğru Sayınız {0} Yanlış Sayınız {1} Puanınız {2}", dogru, yanlis, puan);
        Console.ReadLine();

        string soru9;
        Console.WriteLine("Soru 9 - Sık sık toplu tasıma aracı ile seyahat eder misiniz?");
        soru9 = Convert.ToString(Console.ReadLine());

        Console.WriteLine("A) Hayır B) Evet ");
        string cevap9;
        cevap9 = Console.ReadLine();

        if (cevap9 == "B")
        {
            Console.WriteLine("Maske kullanmalısın");
            Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
            Console.Read();
            dogru++;
            puan = puan + 10;

        }
        else
        {
            Console.WriteLine("Devam edelimmmm");
            Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
            Console.ReadLine();
            yanlis++;
            puan = puan - 5;
        }

        Console.WriteLine("Doğru Sayınız {0} Yanlış Sayınız {1} Puanınız {2}", dogru, yanlis, puan);
        Console.ReadLine();

        string soru10;
        Console.WriteLine("Soru 10 - Evden dısarı cıkmamaya ozen gosteriyor musun ?");
        soru10 = Convert.ToString(Console.ReadLine());

        Console.WriteLine("A) Geziyorum B) Evet Evdeyim");
        string cevap10;
        cevap10 = Console.ReadLine();

        if (cevap10 == "A")
        {
            Console.WriteLine("Kendini ve cevrendekileri korumak icin evde kal");
            Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
            Console.Read();
            dogru++;
            puan = puan + 10;

        }
        else
        {
            Console.WriteLine("Kurallar bosuna degildir");
            Console.WriteLine("Sıradaki Soruya Geçmek İçin Herhangi Bir Tuşa Basınız");
            Console.ReadLine();
            yanlis++;
            puan = puan - 5;
        }


        Console.WriteLine("Doğru Sayınız {0} Yanlış Sayınız {1} Puanınız {2}", dogru, yanlis, puan);
        Console.ReadLine();
        Console.WriteLine("Doğru Sayınız {0} Yanlış Sayınız {1} Puanınız {2}", dogru, yanlis, puan);
        Console.ReadLine();

        if (puan >= 70)
        {
           
            Console.WriteLine("Acilll  " + ad + " Hemen bir hastaneye gitmeli ve kurallara uymalısınız");
        }
        else
        {
            Console.WriteLine("Su anlık iyi " + ad + " Kendinizi ve sevdiklerinizi korumak icin devam edin ");
        }

    }

}
}