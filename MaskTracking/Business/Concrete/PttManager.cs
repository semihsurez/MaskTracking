using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    // Benim bu maskeyi verebilmem için öncelikle başvurucuyu kontrol etmem lazım. Yani, PttManager'in PersonManager'e ihtiyacı
    // var.

    // [program.cs'deki NE OLDU ŞİMDİ? ile beraber incele] 'public class PttManager', bunu böyle yazarsan, yeni talebe entegre
    // etmek konusunda senin sistemin direnç gösterecek. !public class PttManager', bırayı böyle çıplak bırakmak doğru değil.
    // çıplak bırakmak means INHERITANCE or IMPLEMENTASYON ZAAFİYETİ demektir.

    // Sistem Ptt'ye göre bile yazılsa public class 'PttManager : ISupplierService' olarak yazmam gerekiyordu. Böyle yazarsam, 
    // yarın öbür gün eczaneye dönüş yapabilirim. Yeni bir özellik gelidğinde mevcut hiçbir koda dokunmaman lazım. SOLID'in O
    // harfi bu yaptığımız şey. 
    // Ben bambaşka bir mikro servisi sistemime dahil etmek istiyorum. 
    public class PttManager: ISupplierService 
    {
        // PersonManager personManager = new PersonManager();  Bu ifade, PersonManager adlı bir sınıftan bir ÖRNEK (instance)
        // oluşturur.
        // personManager, bu örneğe erişim sağlayan bir referanstır. Bu örneği kullanarak PersonManager sınıfının içindeki
        // metodlara ve özelliklere erişebilirsiniz.
        // Sonra bu ÖRNEK üzerinde CheckPerson metodunu çağırıyor. Ardından, CheckPerson metodunun döndürdüğü değeri kontrol
        // ederek bir şart bloğu içine giriyor.

        // WHY DO WE CREATE INTERFACE?
        // Burada olan ne; bir sınıf (PttManager) başka bir sınıfa (PersonManager) ihtiyaç duydu.
        // Eğer bir sınıf başka bir sınıfı kullanırken NEW'liyorsa ileriye dönük bu yazılımda değişiklik talebi geldiğinde bu 
        // uygulama direnç gisterir. [Bu CÜMLE, iş sınıfı (business), veri erişim sınıfı dediğimiz sınıflar için GEÇERLİ,
        // entities için geçerli değil]
        // PersonManager personManager = new PersonManager(); şeklinde NEW'lediğimiz için PersonManager'e bağımlısınız demektir.
        // [Burada person dediğimiz şey citizen aslında]. Şöyle bir şey oldu ve devlet yarın bir gün ben kendi vatandaşım
        // olmayanlara (yabancı uyruklulara da maske vereceğim dedi. Bu noktada SIKINTI çıkacak. Çünkü aşağıdaki 
        // PersonManager personManager = new PersonManager();
        // if (personManager.CheckPerson(person)) {Console.WriteLine(person.FirstName + " için maske verildi");}  bloğu 
        // citizen'a (person) bağlı. 
        // HOW DO WE FIX THIS?
        // PersonManager personManager = new PersonManager();
        // if (personManager.CheckPerson(person)) {Console.WriteLine(person.FirstName + " için maske verildi");} bloğuna bir
        // bağımlılığımızın olmaması lazım. Bağımlılığı kaldırmak için Business sınıfının altındaki Abstract klasörünün içine
        // IApplicantService diye bir interface oluşturuyoruz.


        // DİPNOT 1: Field'lar class'ın  içinde _ (alttan çizgi) ile yazılır.
        // DİPNOT 2: C# da kalıtımda, implementasyonda (interface'de) : (iki nokta) ile yapılıyor. JAVA'da extents ve
        // implements using (mantık tamamen aynı, only syntax farklı).
        // PersonManager personManager = new PersonManager(); daki bağımlılığı kaldırmak için bir TASARIM DESENİ kullanırsın.
        // DEPENDENCY INJECTION denir buna. PttManager'ın bağımlı olduğu sınıflar yerine o sınıfların INTERFACE'ini yazıyorum.

        private IApplicantService _applicantService; // bunlar field (string name gibi) ama class'ın içinde _ (alltan çizgi) 
                                                     // yazılır.

        // private IApplicantService _applicantService; GLOBAL alana bir değişknen tanıyorum. Bir de 
        // public PttManager(IApplicantService applicantService) { _applicantService = applicantService; } bloğunda da 
        // applicantService'i _applicantService'a atıyorum. Yerelden globale ulaşabiliyorum.


        // Burada bir TASARIM DESENİ var. Tasarım deseni, ben PttManager olarak başka bir sınıfa ihtiyaç duyuyorum. O ihtiyaç
        // duyduğum sınıfı NEW'lemek yerine onun INTERFACE'ini yazıyorum.


        // Bana ne zmn lazım? Bu class başladığında (PttManager) lazım.
        // public PttManager() { } -->Bu yapıya CONSTRUCTOR diyoruz. Constructor, new yapıldığında çalışır. Bu ne demek ben 
        // PttManager'i NEW'lediğim zaman public PttManager() { } bloğu önce çalışır. 

        public PttManager(IApplicantService applicantService) // PttManager oluşturduğu zaman bana bir tane parametre olarak
                                                              // ApplicantService (IApplicantService applicantService) ver
                                                              // diyorum.

        // TEKRAR (SON ARADAN ÖNCEKİ AÇIKLAMALAR)
        // Ben PttManager'i NEW'lediğimde bir servise ihtiyaç duyuyorum. Yani (IApplicantService applicantService) buna ihtiyaç
        // duyuyorum. Bu mikroservis mimarisinin alt yapısıdır. Mikroservis means küçük küçük servisler. Ybancı uyruklu servisi,
        // TC vatandaşı servisi gibi. Bu sistemde BAĞIMLILIĞI / MİKROSERVİS İMPLEMENTASYONUNU INTERFACE'ler üzerinden yaparız.
        

        {
            _applicantService = applicantService;   // class'larda field'lerin _ ile başlamasının sebebi budur. Constructor'dan
                                                    // onu set ederiz.
        }


        public void GiveMask(Person person) 
        {
            // PersonManager personManager = new PersonManager(); // --> burdaki gibi biır sınıfı başka bir yerde kullanıyorsan 
                                                                  // bağımlısın. SIKINTI DA BURDA.

            // If bloğu ŞART bloğudur. ŞART doğruysa o bloğa girer. Bunun asıl yazılışı şudur:
            // if (personManager.CheckPerson(person)==true) {} aama DEFAULT olarak aşağıdaki gibidir.
            // Burada şunu dedik: Eğer bu vatandaş/başvuran doğru bir kullanıcıysa/vatandaşsa o zmn bu kişiye bir maske veriyor
            // olacağız.

            // Aşağıdaki if bloğunu IApplicantService.cs'deki açıklamalarla birlikte değerlendir.

            if (_applicantService.CheckPerson(person)) 
            {
                Console.WriteLine(person.FirstName + " " + person.Lastname + " için maske verildi");
            }
            else 
            {
                Console.WriteLine(person.FirstName + " " + person.Lastname + " için maske VERİLEMEDİ");

            }
        }
    }
}
