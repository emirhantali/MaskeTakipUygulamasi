
//string mesaj = "Selam";

//Console.WriteLine(mesaj);

//double tutar = 100000.5;

//int sayi = 100000;

//bool girisYapmisMi = false;


//string ad = "Emirhan";

//string soyad = "Tali";

//int dogumYili = 1985;

//long tcNo = 11111111111;


//Vatandas vatandas  = new Vatandas();


//SelamVer("emirhan");
//SelamVer();
//Console.WriteLine(Topla(2,3));




//string[] ogranciler = new string[3] {"engin","emirhan","ayşe"};


//for (int i = 0; i < ogranciler.Length; i++)
//{
//    Console.WriteLine(ogranciler[i]);


//}


//foreach (string ogrenci in ogranciler)
//{
//    Console.WriteLine(ogrenci);
//}


using Business.Concrete;
using Entities.Concrete;

List<string> yeniSehirler1 = new List<string>() {"Ankara","İstanbul","İzmir" };

yeniSehirler1.Add("edirne");

foreach (var yeniSehir in yeniSehirler1)
{
    Console.WriteLine(yeniSehir);
}


Person person = new Person();
person.FirstName = "Emirhan";

PttManager pttManager = new PttManager(new PersonManager());

pttManager.GiveMask(person);











static void SelamVer(string isim = "KULLANİCİ")
{

    Console.WriteLine("merhaba " + isim);

}



static int Topla(int sayi1, int sayi2)
{





    return sayi1+ sayi2;

}







public class Vatandas
{

    public string Ad { get; set; }

    public string Soyad { get; set; }

    public int DogumYili { get; set; }

    public long TcNo { get; set; }


}