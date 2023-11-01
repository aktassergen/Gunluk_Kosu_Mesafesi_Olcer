namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool cıkıs = true;
            while (cıkıs)
            {
                double birAdimMetre = 0;
                int dakikaAdimSayisi = 0;
                int adimDakika = 0;
                int adimSaat = 0;
                bool count1 = true;
                bool count2 = true;
                bool count3 = true;
                bool count4 = true;

                while (count1)
                {
                    Console.WriteLine("Ortalama adım uzunluğunuzu (metre cinsinden) giriniz:");
                    bool result1 = double.TryParse(Console.ReadLine(), out birAdimMetre);
                    count1 = false;
                    if (result1 == false)
                    {
                        Console.WriteLine("double cinsinden giris yapiniz");
                        count1 = true;
                    }

                }
                while (count2)
                {
                    Console.WriteLine("Bir dakikada kaç adım attığınızı giriniz:");
                    bool result2 = int.TryParse(Console.ReadLine(), out dakikaAdimSayisi);
                    count2 = false;
                    if (result2 == false)
                    {
                        Console.WriteLine("adim sayinizi tamsayi cinsinden giris yapiniz");
                        count2 = true;
                    }

                }
                while (count3)
                {
                    Console.WriteLine("Koşu süresini  saat cinsinden giriniz:");
                    bool result3 = int.TryParse(Console.ReadLine(), out adimSaat);
                    count3 = false;
                    if (result3 == false)
                    {
                        Console.WriteLine("saat sürenizi tamsayi cinsinden giris yapiniz");
                        count3 = true;
                    }

                }
                while (count4)
                {
                    Console.WriteLine("Koşu süresini  dakika cinsinden giriniz:");
                    bool result4 = int.TryParse(Console.ReadLine(), out adimDakika);
                    count4 = false;
                    if (result4 == false)
                    {
                        Console.WriteLine("dakika sürenizi tamsayi cinsinden giris yapiniz");
                        count4 = true;
                    }

                }
                int dakikaToplamKosu = (adimSaat * 60) + adimDakika;
                double kosuMesafeMetre = dakikaToplamKosu * birAdimMetre;
                Console.WriteLine(adimSaat + "saat" + adimDakika + "dakikada toplam adiminiz: " + kosuMesafeMetre);

                Console.WriteLine("kosu hesapı yapilacaktır eger yeni hesap yapmak istemiyorsanız   (cıkıs)  yaziniz. devam etmek için (devam)  yazınız");
                Console.WriteLine("cıkıs yapilirsa 200 metrelik bir mesafeyi 5 tur atilacak ve her turda ne kadar zamanda bitirildiğine bakılacak");
                string kosul = Console.ReadLine();
                if (kosul == "devam")
                {
                    cıkıs = true;
                }
                else if (kosul == "cıkıs")
                {
                    cıkıs = false;
                }
                else
                    Console.WriteLine("yaziginiz ifade anlasilmadi  bu sebepten dolayı islemler tekrarlanacak");


            }

            Console.WriteLine("--------------------");
            Console.WriteLine("eger 5 tur atilacaksa 5 tur sonunda kaç metre koşarız");


            int birTurMesafe = 200;
            double[] Siralama=new double[6];
            
            for (int i = 0;i<5;i++)
            {
                Random rnd=new Random();
                double adimmMetre=rnd.NextDouble();
                switch (i)
                {
                    case 0:
                        double turDakikasi1= 200 / adimmMetre;
                        Siralama[i]= turDakikasi1;
                        Console.WriteLine("1.tur dakikasi "+200/adimmMetre); break;
                    case 1:
                        double turDakikasi2 = 200 / adimmMetre;
                        Siralama[i] = turDakikasi2;
                        Console.WriteLine("2.tur dakikasi "+200 / adimmMetre); break;
                    case 2:
                        double turDakikasi3 = 200 / adimmMetre;
                        Siralama[i] = turDakikasi3;
                        Console.WriteLine("3.tur dakikasi "+200 / adimmMetre); break;
                    case 3:
                        double turDakikasi4 = 200 / adimmMetre;
                        Siralama[i] = turDakikasi4;
                        Console.WriteLine("4.tur dakikasi "+200 / adimmMetre); break;
                    case 4:
                        double turDakikasi5 = 200 / adimmMetre;
                        Siralama[i] = turDakikasi5;
                        Console.WriteLine("5.tur dakikasi "+200 / adimmMetre); break;
                }


            }



            Console.WriteLine("siralama asagidaki gibidir");
              
                Array.Sort(Siralama);

                Console.WriteLine("\nDizi sıralı hali:");
                
            foreach (double i in Siralama)
            {
                Console.WriteLine(i + " ");
            }
                Console.ReadLine();
            

           


        }
       

    }
}