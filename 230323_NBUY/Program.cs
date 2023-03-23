using System;
using System.Collections.Generic;

namespace _230323_NBUY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kimlik Sorgusu sınıflar metod  ile sorgulatma
            /*  gel:
             *  // interface ile kullanılacaksa sınıflarda void metod ve get set içeren değişkenler kullanılacak.
                  kisi kisi = new kisi();
                  Console.Write("ad gir: ");
                  kisi.ad = Console.ReadLine();
                  Console.Write("soyad gir: ");
                  kisi.soyad = Console.ReadLine();

                  Console.Write("kimlik numarası gir (ehliyet veya tc): ");
                  string kimliknumarası = Console.ReadLine();

                  Ikimlik kimlik = null;
                  if (kimliknumarası.Length == 6)
                  {
                      ehliyet et = new ehliyet();
                      et.kimlikno = kimliknumarası;
                      kimlik = et;
                  }
                  else if (kimliknumarası.Length == 16)
                  {
                      tc tc1 = new tc();
                      tc1.kimlikno = kimliknumarası;
                      kimlik = tc1;
                  }

                  if (kimlik != null)
                  {
                      kimlik.kimliksorgu();
                  }
                  else
                  {
                      Console.WriteLine("Kimlik Numarasını Eksik Girdiniz.");
                  }


                  Console.WriteLine("Yeni Sorgu İçin Enter Tuşana Basınız.");
                  Console.ReadLine();
                  goto gel;

              }
          }
          class kisi
          {
              public string ad;
              public string soyad;
          }

          interface Ikimlik
          {
              /*  string kimlikno;
                public void kimliksorgu()
                {
                    Console.WriteLine("Kimlik Sorgusu Yapılmıştır");
                }*/
            /*  string kimlikno { get; set; }
              public void kimliksorgu()
              {
                  Console.WriteLine("Kimlik Sorgusu Yapılmıştır");
              }*/



            /*   class ehliyet : Ikimlik
               {
                   /*  public string ehliyetno;
                     public override void kimliksorgu()
                     {
                         Console.Clear();
                         Console.WriteLine("Kimlik Sorgusu Ehliyetten Yapılmıştır.");
                     }*/
            /*   public string kimlikno { get; set; }
               public void kimliksorgu()
               {
                   Console.Clear();
                   Console.WriteLine("Kimlik Sorgusu Ehliyetten Yapılmıştır.");
               }
           }*/

            /* class tc : Ikimlik
             {
                    public string tcno;
                    public override void kimliksorgu()
                    {
                        Console.Clear();
                        Console.WriteLine("Kimlik Sorgusu Nüfus Cüzdanından Yapılmıştır.");
                    }
                 public string kimlikno { get; set; }
                 public void kimliksorgu()
                 {
                     Console.Clear();
                     Console.WriteLine("Kimlik Sorgusu Ehliyetten Yapılmıştır.");
                 }
             } */
            #endregion

            #region Kimlik Sorgu Uğur Hoca çözümü
            /*   DateTime dt = new DateTime(1995, 1, 25);

               nufuscuzdani nfs = new nufuscuzdani();
               nfs.ad = "ibrahim";
               nfs.soyad = "inan";
               nfs.dogumtarihi = dt;
               nfs.dogumyeri = "Londra";
               nfs.kullanim();

               ehliyet ehl = new ehliyet();
               ehl.ad = nfs.ad;
               ehl.sinif = "b2";
               ehl.kullanim();

               // kimlik kml = new kimlik();
               kontrol knt = new kontrol();
               knt.kontrolet(ehl);
               knt.kontrolet(nfs);


               Console.ReadLine();
           }
           interface Ikimlik
           {
               public string ad { get; set; }
               public string soyad { get; set; }
               public int tcno { get; set; }
               public void kullanim();


           }
           class nufuscuzdani : Ikimlik
           {
               public string dogumyeri { get; set; }
               public DateTime dogumtarihi { get; set; }
               public string ad { get; set; }
               public string soyad { get; set; }
               public int tcno { get; set; }

               public void kullanim()
               {
                   Console.WriteLine("nüfus cüzdanı kullanıldı.");
               }

           }
           class ehliyet : Ikimlik
           {
               public string sinif { get; set; }
               public string ad { get; set; }
               public string soyad { get; set; }
               public int tcno { get; set; }

               public void kullanim()
               {
                   Console.WriteLine("ehliyet kartı kullanıldı.");
               }

           }
           class okul : Ikimlik
           {
               public string okulu { get; set; }
               public string bolumu { get; set; }
               public string ad { get; set; }
               public string soyad { get; set; }
               public int tcno { get; set; }

               public void kullanim()
               {
                   Console.WriteLine("ogrenci kartı kullanıldı.");
               }

           }
           class kontrol
           {
               public void kontrolet(Ikimlik kml)
               {
                   kml.kullanim();
               }
           } */
            #endregion

            #region Tapu interfacesi ile ev ve arsa tapusu olusturup kontrol sınıfındaki metod ile ekrana yazdırma
            /*  ev ev1 = new ev()
              {
                  ad = "Hakkı",
                  soyad = "Bulut",
                  il = "Edirne",
                  ilce = "Merkez",
                  mahalle = "Bosnaköy",
                  hisse = "Tam",
                  nitelik = "Arsa",
                  yuzOlcumu = 5000,
                  tarih = "23.03.2023"
              };
              // ev1.olustur();

              kontrol k1 = new kontrol();
              k1.kontrolet(ev1);


          }
      }
      interface ITapu
      {
          string ad { get; set; }
          string soyad { get; set; }
          string tarih { get; set; }
          string nitelik { get; set; }
          string hisse { get; set; }
          int yuzOlcumu { get; set; }
          string il { get; set; }
          string ilce { get; set; }
          string mahalle { get; set; }
          public void olustur();
      }
      class ev : ITapu
      {
          public string ad { get; set; }
          public string soyad { get; set; }
          public string tarih { get; set; }
          public string nitelik { get; set; }
          public string hisse { get; set; }
          public int yuzOlcumu { get; set; }
          public string il { get; set; }
          public string ilce { get; set; }
          public string mahalle { get; set; }

          public void olustur()
          {
              Console.WriteLine("Ev Tapusu Oluşturuldu.");
              Console.WriteLine("Adı: " + ad + "\n" + "Soyadı: " + soyad + "\n" + "İl: " + il + "\n" + "İlce:" + ilce + "\n" + "Mahalle: " + mahalle + "\n" + "Hissesi: " + hisse + "\n" + "Yüzölçümü: " + yuzOlcumu + "m2" + "\n" + "Tarih: " + tarih);
          }
      }

      class arsa : ITapu
      {
          public string ad { get; set; }
          public string soyad { get; set; }
          public string tarih { get; set; }
          public string nitelik { get; set; }
          public string hisse { get; set; }
          public int yuzOlcumu { get; set; }
          public string il { get; set; }
          public string ilce { get; set; }
          public string mahalle { get; set; }

          public void olustur()
          {
              Console.WriteLine("Arsa Tapusu Oluşturuldu.");
          }
      }
      class kontrol
      {
          public void kontrolet(ITapu tapu)
          {
              tapu.olustur();
          }
      }
  } */
            #endregion

            #region generic içerisine nesne ekleme ve foreach / for ile nesneleri ekrana yazdırma 
            /*     kisiler k1 = new kisiler() { ad = "Vinicius", soyad = "Junior", cinsiyet = 'E', yas = 21 };
                 kisiler k2 = new kisiler() { ad = "Federico", soyad = "Valverde", cinsiyet = 'E', yas = 21 };
                 List<kisiler> list = new List<kisiler>();
                 list.Add(k1);
                 list.Add(k2);

                  foreach (kisiler kisi in list)
                   {
                       Console.WriteLine("Adı: " + kisi.ad);
                       Console.WriteLine("Soyadı: " + kisi.soyad);
                       Console.WriteLine("Cinsiyeti: " + kisi.cinsiyet);
                       Console.WriteLine("Yaşı: " + kisi.yas);
                       Console.WriteLine();
                   }
                 for (int i = 0; i < list.Count; i++)
                 {
                     Console.WriteLine(list[i].ad + " " + list[i].soyad + " " + list[i].cinsiyet + " " + list[i].yas);
                 }
             }
         }
         class kisiler
         {
             public string ad { get; set; }
             public string soyad { get; set; }
             public char cinsiyet { get; set; }
             public int yas { get; set; }
         } */
            #endregion

            #region Generic Sınıflar Giriş
            /*    //Ogrenci<int> ogr = new Ogrenci<int>();

                  //ogr.Temsilitip = 0;

                  Ogrenci<string, int, char> ogrenci = new Ogrenci<string, int, char>();
                  ogrenci.Temsilitip = "aa";
                  ogrenci.Sinif = 'L';
                  ogrenci.OkulNo = 1;

                  Ogrenci<Ders<string>, int, decimal> ogr2 = new Ogrenci<Ders<string>, int, decimal>();

                  // Ogrenci<int, string, double> ogr3 = new Ogrenci<int, string, double>();
                  List<int> list = new List<int>();
                  list.Add(1);
                  MetotGeneric mtr = new MetotGeneric();
                  mtr.Ekle<string>("Badem");
              }
          }
          class Ogrenci<T, H, Y> where T : class where Y : struct where H : struct
          {
              //Generic : Dışarıdan bir tip alarak çalışmayı sağlayan yapı 
              public string Ad { get; set; }
              public string Soyad { get; set; }
              public Y Sinif { get; set; }
              public H OkulNo { get; set; }
              public T Temsilitip { get; set; }
          }
          class Ders<T>
          {
              public int DersId { get; set; }
              public string DersAdi { get; set; }
              public T Kitabi { get; set; }
          }
          class MetotGeneric
          {
              public void Ekle<T>(T prm)
              {

              }
          } */
            #endregion
        }
    }
}