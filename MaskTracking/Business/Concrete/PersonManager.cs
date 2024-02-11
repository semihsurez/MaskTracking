using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    // PersonManager sınfını Service olarak da görebilirsiniz başka projelerde/yerlerde. Benzer işler yapıyorlar.
    // class'ın başına public yazmazsan sınıfa (PersonManager) erişmekte zorluk çekersin. UNUTMA!!!
    // PersonManager benim için, bir BUSINESS classıdır (sınıfıdır).
    // Biz class'ları sadece property (özellik) tutmak için değil, yani person.cs'deki public class person'daki gibi değil, 
    // aşağıdaki gibi operasyonları/fonksiyonları/metotları tutmak için de using.
    // PersonManager --> bizim için bu vatandaşa / kullanıcıcıya maske verdiğimiz bir ortam sunacak

    // ÇIPLAK CLASS KALMASIN

    // Normalde bir class'ı yazmaya başladığınızda [iş sınıfları (BUSINESS) için söylüyor] ALIŞKANLIK HALİNE GETİRİN.
    // Bir class'ı oluşturduğunuz zaman onun interface'ini oluşturmuş olduğunuzdan emin olun. Yani, önce INTERFACE ile başlanır
    // olaya. Interface = Arayüz - [IApplicantService.cs] interface'i oluşturduk.

    // Bu kısmı (ÇIPLAK KRAL KALMASIN)'dan sonraki kısmı PttManager.cs'deki WHY DO WE CREATE INTERFACE? başlığı ile birlikte
    // değerlendir. Aşağıdaki kod bloğu gibi oluşturmamamalıydık burayı.
    // public class PersonManager 
    // {
    //   public void ApplyForMask (Person person) {}
    //   public List<Person> GetList() { return null;}
    //   public bool CheckPerson (Person person) {return = true}
    // }
    // Doğru yazım için Business sınıfının Concrete klasörünün içine ForeignManager adlı bir class oluşturduk.

    public class PersonManager : IApplicantService
    {
        //   ENCAPSULATION
        // public void ApplyForMask (string firstName, string lastName, int yil)
        // {
        //     ApplyForMask ("Engin" , "Demiroğ", 1985)
        //     ApplyForMask ("Engin" , "Demiroğ", 1985)
        //     ApplyForMask ("Engin" , "Demiroğ", 1985)
        // }
        // yazdınız ki bu kötü bir kod yazımı, sonra bir de tcNo ekleyin dediler
        // (string firstName, string lastName, int yil, long tcNo) { } haline geldi. Bİr sürü yerde kullanmıştınız.
        // ApplyForMask ("Engin" , "Demiroğ", 1985) buna bir de tek tek tcNo eklemek zorundasınız.
        // Bunun doğru şekilde, aşağıda yaptuğımız gibi, (string firstName, string lastName, int yil) içindeki özellikleri alıp
        // bir class'ın içine koymaya ENCAPSULATION denir.

        // FONKSİYON: Diyelim ki bizim maske başvurusunda bulun (ApplyForMask) diye bir operasyonumuz var, Biz bunu
        // projenin bir çok yerinde kullanabiliriz. Biz sıklıkla kullanacağımız operasyonları böyle fonksiyonların,
        // metotların içerisine yerleştiriyoruz ki daha sonra onu kullanabilelim.

        // Bu projede ben, maskeye başvurmak, başvuran kişiyi kaydetmek, sistemde şu ana kada kaç kişi maske aldı, maske
        // almayan kaç kişi kaldı, bunları görmek istiyorum. Daha önce bir maske almış mı diye bir kontrol etmem lazım
        // bunları yazmak istiyorum. Bu tarz kod bloklarını, iş bloklarını yazdığımız operasyonlara metot deniyor.
        // Buradaki person, maskeye başvuru yapan vatandaşlardır.

        // public --> erişim bildirgeci, başka yerlere ulaşabilelim diye
        // void --> şimdilik birşey döndürmüyor.
        // ApplyForMask --> Metotun ismi
        // Person --> Class --
        // person --> parameter

        public void ApplyForMask (Person person)  // --> Fonksiyon = metot = prosedür diyoruz programlama dillerinde
                                                  // C# tarafında yoğun olarak metoot ifadesini kullanıyoruz. 
        {
            
            
            
        }

        // Kimler maske başvurusunda bulunmuş, bununla ilgili bir fonksiyon yazalım. Bir operasyon daha yaptım.
        // List dediğimiz yapı verdiğimiz tipte bir listedir. Alışveriş sitelerinde ana sayfadan laptop dediğimiz zaman bize
        // laptopları listeliyor.
        // list yazdığınızda gelmiyorsa en üstteki "using System.Collections.Generic;" kontrol et. Ampulden ekleyebilirsin. Daha
        // fazla açıklama için DEFTERE bak.

        public List<Person> GetList() // public List<Person> GetList --> Maske alan kişilerin listesini dökseydim diyorum
                                      // bunun için de bana list<Person>, yani list of person ver diyorum.
        {
            return null;   // --> null = tanımlanmamış demektir. Bütün referans tipleri böyle verebilirsiniz.  
        }


        // CheckPerson şu işe yarayacak, bu adam doğru bir adam mı? Adı, soyadı, doğum yılı doğru mu, kısacaso bir vatandaş mı?
        // ona bakacak. CheckPerson MERNIS'e bağlanacak ve bu adam doğru bir adam mı diye kontrol edecek. Parametrem de person.
        // (Person person) ifadesi, bir metodun parametre listesini belirtir. Bu durumda, CheckPerson adlı bir metodun
        // parametre olarak Person tipinde bir nesne alacağını ifade eder. Diğer bir deyişle, metodun çağrılması sırasında bu
        // parametre listesine Person tipinde bir nesne sağlanmalıdır.
        // Person: Bu, parametrenin türünü(type) belirtir.Yani, bu metodun alacağı parametrenin bir Person tipinde nesne
        // olacağını gösterir. Person, SINIFIN (person.cs) adıdır. Bu sınıfın içinde kişinin özellikleri ve davranışları
        // tanımlanmıştır.
        // person: Bu, parametrenin adıdır. Metot içinde bu isimle, metoda geçilen Person tipinde nesneye erişebilirsiniz.
        // Yani, metodu çağırırken CheckPerson metoduna bir Person nesnesi verirseniz, bu nesneye metodun içinde person adıyla
        // erişebilirsiniz.

        public bool CheckPerson (Person person)  // CheckPerson direkt yabancı uyruklu olup olmadığına bakacak.
                                                 // spagetti kod yapısı kurmaya kurmya başlayacak.
                                                 // DİPNOT: If, suitimali en yüksek olan yapıdır. If, birbirinin alternatifi 
                                                 // olan iş kuralları (TC vatandaşının iş kuralı ile yabancı uyruklu olanın 
                                                 // iş kuralı birbirinin alternatifi) için using.
                                                 // Bir projede ne kadar if varsa, o proje o kadar yazılım geliştirme prensip
                                                 //lerinden uzaktır deriz.

        {
            // 'MernisServiceReference. ' yazdıktan sonra pencere çıkıyor oradan bakabilirsin "KPSPublicSoapClient" mesela.
            // Endpoint, uç demektir. (SONRA BAK bu alttaki satıra, hoca yazdı bunu). 

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(person.NationalIdentitiy, person.FirstName, person.Lastname, person.DateOfBirthYear)))
                .Result.Body.TCKimlikNoDogrulaResult;

            // Üstteki kodu (KPSPublicSoapClient client ile başlayıp .... .Result.Body.TCKimlikNoDogrulaResult;) buraya yazıp
            // başka bir yerde de kullanmak istersem sadece bu kısmı
            // (KPSPublicSoapClient client ile başlayıp .... .Result.Body.TCKimlikNoDogrulaResult;) oraya da yazmam gerekir.
            // Therefore AdaptorDesignPattern diye bir tasarım deseni denen birşey var. (WORD'e bak.)
        }
    }
}
