// See https://aka.ms/new-console-template for more information
using OOP;
using OOP.Constructors;
using OOP.Override;
using OOP.SOLID.Odeme_Yontemi_Kotu;
using OOP.SOLID.Open_Closed_Kotu;
using System.Collections;

Console.WriteLine("Hello, World!");

//Insan class'ından nesne oluştur

//ClassIsni nesneAdı = new ClassIsmi();

Insan i = new Insan();
i.ad = "Can";
i.soyad = "Gozcu";
i.yas = 40;
i.maas = 100;
i.cinsiyet = false;       // Erkek
i.Uyu(i.ad, i.soyad);
Insan.boy = 180;

Araba r = new Araba();

r.renk = "Kırmızı";
r.model = "Golf";
r.kapiSayisi = 4;
r.yakitTuketimi = 5.1;
r.Git("VW", r.model);

Matematik m = new Matematik();
int gelenDeger= m.Topla(5 , 5);
Console.WriteLine("Toplam = " + gelenDeger);


Console.WriteLine("Toplam 2 = " + m.Topla(5, 5));


Console.WriteLine("yaşınız :" + i.yashesap(1982));

Anne a = new Anne();
a.ad = "Fahriye";
a.soyad = "Gokyar";

Baba b = new Baba();
b.ad = "Kasım";
b.soyad = "Gokyar";
b.dinle(b.ad);

Cocuk c = new Cocuk();
c.ad = "İbrahim";
c.soyad = "Gokyar";


a.yazdir(a.ad, a.soyad);
b.yazdir(b.ad, b.soyad);
c.yazdir(c.ad, c.soyad);

Akillicocuk d = new Akillicocuk();
d.ad = "Hakan";
d.soyad = "Yılmaz";
d.sifat = "akillir";
d.Sifatyaz(d.ad, d.soyad, d.sifat);
d.Asker(d.ad);
d.Ehliyet(d.ad);
d.Kulüp(d.ad);

UsluCocuk e = new UsluCocuk();
e.ad = "Mehmet";
e.soyad = "Yılmaz";
e.sifat = "usludur";
e.Sifatyaz(e.ad, e.soyad, e.sifat);
e.Asker(e.ad);
e.Ehliyet(e.ad);

HiperaktifCocuk h = new HiperaktifCocuk();
h.ad = "Ali";
h.soyad = "Veli";
h.Asker(h.ad);

GenelMudur gm = new GenelMudur();
Mudur mudur = new Mudur();
Programci p = new Programci();
Stajyer s = new Stajyer();
int toplam = gm.MaasinizNedir() + mudur.MaasinizNedir() + p.MaasinizNedir() + s.MaasinizNedir();
Console.WriteLine("Maaşlar toplamı : " + toplam);


Child child = new Child();
child.Yaz();


Goz goz = new Goz("Mavi");
Kulak kulak = new Kulak("Kepçe");
Burun burun = new Burun("Kemer");

Kafa kafa = new Kafa(goz, kulak, burun);


YeniInsan yeni = new YeniInsan("ibrahim", "gökyar", kafa);
yeni.EkranaYazdir();

string[] gunler = new string[7];
gunler[0] = "Pazartesi";
gunler[1] = "Salı";
gunler[2] = "Çarşamba";
gunler[3] = "Perşembe";
gunler[4] = "Cuma";
gunler[5] = "Cumartesi";
gunler[6] = "Pazar";


for (int x = 0; x<gunler.Length; x++)
{
    Console.WriteLine(gunler[x]);
}

Employee[] emp = { gm, mudur, p, s };


int MaasToplam = 0;
for(int z=0;z<emp.Length;z++)
{
    MaasToplam += emp[z].MaasinizNedir();

}
Console.WriteLine("Maas Toplamı =" + MaasToplam);


List<Insan> liste = new List<Insan>();
//liste.Add("İBRAHİM");
//liste.Add(33);
//liste.Add(true);
//liste.Add(3.14);


//if(liste.Contains("İbrahim"))
//{
//    Console.WriteLine("ilgili kişi listede var");
//}
//else
//{
//    Console.WriteLine("İlgili kişi listede yok");
//}


//liste.Insert(0, "abc");
//foreach (object o in liste)
//{
//    Console.WriteLine(o);
//}

//içine personel tipinden veri alan bir liste olsun
//3 kayıt ekle
//3 personelin adı soyadı maaşlarını yazdır

List<Personel> personelListe = new List<Personel>();

Personel p1 = new Personel("Ali", "Veli",1000);
Personel p2 = new Personel("Ahmet", "Mehmet", 2000);
Personel p3 = new Personel("Ferhat", "Veli", 3000);



personelListe.Add(p1);
personelListe.Add(p2);
personelListe.Add(p3);
int toplamMaas = 0;
foreach (Personel element in personelListe)
{
    Console.WriteLine(element.adi + " " + element.soyadi + " "+ element.maas);
    toplamMaas += element.maas;
}
Console.WriteLine("Toplam Maaş:" + toplamMaas);


//10.08.2022 



XMLLog xmllog = new XMLLog();
DbLog dblog = new DbLog();
JsonLog jsonlog = new JsonLog();

Logger logger = new Logger(xmllog);       //Constructor Injection
logger.Log(" 404 bulunamadı...");


//Constructor Injection do it yourself 
KrediKarti kredikarti = new KrediKarti();
MailOrder mailoerder = new MailOrder();
OdemeIslemi ode = new OdemeIslemi(kredikarti);
ode.OdemeYap(400);

OdemeIslemi mail = new OdemeIslemi(mailoerder);
//mailoerder.Od

