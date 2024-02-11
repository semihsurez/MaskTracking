using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace WorkAround
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables();

            Citizen citizen1 = new Citizen(); // 1 tane citizen oluşturdum. Citizen citizen = new ();
                                              // Buna INSTANCE deniyor.

            SayHello(name: "Engin");
            SayHello(name: "Ahmet");
            SayHello(name: "Veli");
            SayHello();            

            int result = Sum(6, 68);

            // Arrays (Diziler)
            // Sen bir öğretmensin ve 10 tane öğrencin var.

            string student1 = "Emre";
            string student2 = "Aysun";
            string student3 = "Aylin";
            string student4 = "Hatice";

            //Console.WriteLine("student1");
            //Console.WriteLine("student2");
            //Console.WriteLine("student3");
            //Console.WriteLine("student4");
            // BÖYLE YAZMAK YERİNE aşağıdaki gibi ARRAY ile yazmamız lazım.

            string[] students = new string[3];  // Bu bir ARRAY, which tanımladığımız tipte veri tutan yapılardır. 
                                                // 3 elemanlı diziyi (array)i tanımlamış oluyoruz. Dördüncü bir öğrenci
                                                // eklersen 3 öğrencilik (3 elemanlı) bir array olduğu için hata alırsın.
                                                // string[] students = new string[3]; sadece string[] students yazıp
                                                // alta geçip students[0] = "Emre"; çalılşırsan NULL REFERENCE EXCEPTION 
                                                // hatası alırsın. Bu şu demek, sen onu NEW'lemedin demek. REFERAN TİPLERİ
                                                // kullanabilmen için bellekte (HEAP'te) yer açman gerekiyor.
                                                // REFERANS TİP açıklamaları DEFTERDE.

            students[0] = "Emre";
            students[1] = "Aysun";
            students[2] = "Hasan";     //3 öğrencilik listeyi bu şekilde yönetebiliyoruz. Bu listedeki eleman sayısı daha da
                                       // artabilir.
            students = new string[4];  // öğrenicilerin eleman sayısını 4'e çektim.
            students[3] = "Veli";


            // LOOPS - Döngüler, birbirlerine benzaeyen işleri tekrar tekrar yazmak yerine bir kere de yapma sürecidir.
            // i, index'den gelir, sayaçtan gelir. i değil de başka bir harf ya da kelime (sayaç vb.) de using.
            // i < students.Length; --> Bu kısım ŞART kısmı. Length, eleman sayısı, yani 3'den küçük olduüu sürece
            // i++, 1'er 1'er attır demek.

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            // Bu, REFERANS TİP ÖRNEĞİ. [AÇIKLAMALAR DEFTERDE]
            string[] cities1 = new[] { "Ankara", "İstanbul", "İzmir"};  
            string[] cities2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            cities2 = cities1;
            cities1[0] = "Zonguldak";
            Console.WriteLine(cities2[0]);

            // Bu, DEĞER TİP ÖRNEĞİ. [AÇIKLAMALAR DEFTERDE]
            //int number1 = 10;    
            //int number2 = 20;
            //number2 = number1;
            //number1 = 30;
            //number2 

            // STRING = Referans tiptir. Değer tip gibi çalışır ama referans tiptir.
            // STRING dediğimiz şey de bir CHAR ARRAY'idir.

            Person person1 = new Person();
            person1.FirstName = "ENGİN";
            person1.Lastname = "DEMİROĞ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentitiy = 987;


            Person person2 = new Person();
            person2.FirstName = "Murat";

            foreach (string city in cities1)  // foreach döngüsüyle dizi formatındaki yapıları dönüyoruz.
                                              // in cities1'den okumaya başla, bu cities1'deki "Ankara", "İstanbul",
                                              // "İzmir"i sırasıyla dolaşıyor. Her dolaştığıan takma bir isim (alias) veriyor. 
                                              // takma ismin adı da "city". Biz buna elma, armut vb. birşey de diyebiliriz.
                                              // Genelde çoğulun tekil halini yazarız (city/cities gibi). Çünkü dizi demek
                                              // çoğul demek.
            {
                Console.WriteLine(city);
            }

            // C#, 2005 versiyomnuyla beraber Generic Collection dediğimiz yapıyı getirdiler. 
            // string[] cities1 = new[] { "Ankara", "İstanbul", "İzmir" };
            // string[] cities2 = new[] { "Bursa", "Antalya", "Diyarbakır" };
            // Biz bu üst satırdaki arrayleri çok az kullanıyoruz artık. Onun yerine şöyle bir yapı kullanıyoruz;

            List<string> newcities1 = new List<string>{"Bolu","Edirne", "Aydın"};
            // Bu 3 elemanlı bir liste, bu bir dizi aslında. List bir sınıftır so referans tiptir.
            newcities1.Add("Van"); // ADD şunu yapıyor. Siz new'lediğiniz zaman önce gidip eski verileri cebe atıyor.
                                   // new'lediğiniz zaman yeniliyor, cebe attıklarını yerine koyuyor. Yeni elemanı da sona 
                                   // ekliyor.
            // List<string> newcities1 = new List<string>{"Bolu","Edirne", "Aydın"}; --> Bu bir string koleksiyon, yani string 
            // tipinde çalışacak type safe diyoruz. Tip güvenli yapı diyoruz. 

            foreach (var city in newcities1)  
            {
                Console.WriteLine(city);
            
            }

          
            // Başka bir sayfada PttManager pttManager = new PttManager(new PersonManager()); da kullanabilirdim.

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1); // yukarıdaki Engin için dolduracağız burayı.
            // NE OLDU ŞİMDİ? PTT'deyken sistem ECZANEYE döndü şimdi. Yazılım böyle birşey. Değişiklikler geliyor, müşterinin
            // istekleri gibi düşün bunları. Sen PttManager'ı (PttManager class'ını) bu kuralı çiğneyerek yaptın.

            // Console.ReadLine();
        }

        // --> Bu " static void SayHello() {}" benim için bir Metot or Fonksiyon
        // --> void, herhangi birşey döndürmeyecek demek, sadece iş yapar ve herhangi bir bilgi vermez. Git bunu kaydet, git
        // bunu güncelle gibi. Emir kipiyle çalışır.
        // fonksiyonun isminden sonra SayHello()'dan sonra () içinde yazılan değerlere PARAMETRE denir.
        // static void SayHello(string name)  --> parametre verirsem, o parametreye göre çalışsın.
        // static void SayHello(string name="noname") --> parametre vermezsem, Hello, noname yasın. Buna da default parametre
        // deniyor.

        static void SayHello(string name="noname")
        {
            Console.WriteLine("Hello" + " " + name);
        }


        // 5 değeri return edecektir. int var çünkü void yok.
        // Bunun gibi metotları kredi tutarını hesaplarken ya da aylık ödemme miktarını hesaplarken vb.kullanıyoruz.
        // Bana değer ver, ben onu kullanacam diyorsan return ifadesinde n yararlanıyorsun.
        // static int Sum(int num1, int num2) halindeyken fonsksiyon static void Main(string[] args) bloğunun içine
        // int result = Sum(3, 5) yazdığımızda sonuç 8 çıkıyordu. Sonra aşağıdaki gibi değiştirdin. O zmn sonuç : 15
        // static void Main(string[] args)  bloğunun içine
        // int result = Sum(500) deyip static int Sum(int num1, int num2=10) yazabilirsin BUT
        // static int Sum(int num1=10, int num2) YAZAMAZSIN. DEFAULT veriler SONDA OLMALIDIR. DEFAULT PARAMETRELER,
        // en sona yazılır. static int Sum(int num1, int num2=10) gibi int num2=10 DEFAULT bir veridir.

        static int Sum(int num1, int num2=10)   
        {
            int result = num1 + num2;
            Console.WriteLine(" Toplam: " + result); 
            // Console.Writeline (int + str) kendisi otomatik olarak bize dönüştürüp veriyor. Normalde toplayamazsın.
            // BREAKPOINT: int result = num1 + num2; olduğu satıra breakpont koyuyorum. Buraya gelince DUR diyorum
            // Sonra Continue or F5 ile devam ettirebilirsin.

            return result; 
        }



        private static void Variables()
        {
            string message = "Hello";
            double amount = 100000;
            int number = 200;
            bool logInOrNot = false;                 // uygulamayı dallandırmak için kullanırız.

            string name = "Ali";
            string surname = "Gecegider";
            int birthDate = 1989;
            long tcNo = 12345678910;      // long'da int gibi bir değişken, int'den daha fazla veri tutabiliyor.
                                          // TC'yi string olarakta tutabilirsin, because işlem yapmıyorsun TC ile.

            Console.WriteLine(message);

            Console.WriteLine(amount * 2.50);
        }
    }
    public class Citizen 
    {
        // prop yazıyoruz ve TAB'a basıyoruz. property - Citizen özelliği (name, surname, birth date or TC)
        // Burada kelimelerin ilk harfi büyük oluyor. Buna Pascal Casing deniyor.

        public string Name{ get; set; }
        public string Surnama{ get; set; }
        public int BirtDate { get; set; }
        public long TcNo { get; set; }

        // Burdaki Name, Surname de okuma ile ilgili değişiklik yapmak istersen get ve set e {} blok oluşturup get ve 
        // set özeliklerini değiştirebiliyorsun. Günümüzde çok fazla kullanılmıyor.

        // DİPNOT - Java'da properties yok buradaki gibi, onun yerine get ve set blokları kullanmanız gerekiyor ayrı ayrı
        // Dart dilinde de öyle ayrı ayrı get ve set bloklarını yazmanız gerekiyor.

        // public string Name = "Ali";
        // public string Surname = "Gecegider";
        // public int birthDate = 1989;
        // public long tcNo = 12345678910;      // long'da int gibi bir değişken, int'den daha fazla veri tutabiliyor
        // TC'yi string olarakta tutabilirsin, because işlem yapmıyorsun TC ile

        // Bir Class'ın içinde değişkenleri tanımlarsan, o değişkenleri sadece o Class'ın içinde kullanabilirsin.
        // Aşağıdaki gibi olursa başka bir yer kullnamazsın. Bu yüzden başına public yazdım. public yazınca değişken
        // adlarının ilk harfini Büyük yazıyoruz. Buna Pascal Casing deniyor.
        // Public yazınca başka yerden de erişilebilir demek.

        // string name = "Ali";
        // string surname = "Gecegider";
        // int birthDate = 1989;
        // long tcNo = 12345678910;
    }
}
