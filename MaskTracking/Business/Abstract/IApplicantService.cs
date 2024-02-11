using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    // İş sınıflarının (BUSINESS) interface'lerini genellikle bu şekilde isimlendiririz.
    // İLK BAŞTA, PersonManager.cs'den public void ApplyForMask(Person person), public List<Person> GetList() ve
    // public bool CheckPerson(Person person) kod blokalrını alıp yapıştırdım. Buna kızar ve der ki sen Interface’in içinde
    // sadece metot imzası bulundurabilirsin der. Sonra bazı satırları ve 'public'leri sildim ve aşağıdaki kod bloğunu elde
    // ettim.  Yani sadece imzaları oluşturman gerekiyordu.
    // public interface IApplicantService
    // {
    //   void ApplyForMask(Person person);
    //
    //   List<Person> GetList();
    //
    //   bool CheckPerson(Person person);
    // }
    // Bu üstteki son haline METODUN İMZASI denir. Bu yapıyı oluşturmasaydım, PersonManager.cs'de yabancı uyruklular için bir 
    // manager yazamayacaktım. (WORD'e bak - SYNTAX için).


    public interface IApplicantService
    {

    // ÖNEMLİ: Her kim IApplicantService'i kullanırsa, 'IApplicantService' onun referansını tutabiliyor. Bizim prpjemizde, hem
    // ForeignerManager sınıfında 'public class ForeignerManager : IApplicantService' koduyla
    // hem de PersonManager'de 'public class PersonManager : IApplicantService' koduyla 'IApplicantService' kullandığımız için
    // ikisinin de [PersonManager ve ForignerManager] referansını tutabiliyor. Biz gidip PttManager sınıfında
    // ister PttManager pttManager = new PttManager (new PersonManager()); veririz [PersonManager --> TC vatandaşı]
    // ister PttManager pttManager = new PttManager (new ForeignerManager()); veririz. [ForeignerManager --> Yabancı uyruklular]
    // Hoca bu üstteki iki kodu (ikisinden  birini) PttManager class'ındaki
    // if (personManager.CheckPerson(person)) {Console.WriteLine(person.FirstName + " için maske verildi");} kodunun hemen
    // üzerine yazdı.
    // ÖNEMLİ = Interface'ler 'NEW'lenemez.
    // PttManager pttManager = new PttManager (new IApplicantService); --> YAZAMAZSIN.
    // but Interface'ler referans tutucudur. Dolayıslyla ben
    // PttManager sınıfında
    // if(_applicantService.CheckPerson(person)) {Console.WriteLine(person.FirstName + " için maske verildi"); şeklinde
    // yazabilirim.
    
        void ApplyForMask(Person person);

        List<Person> GetList();

        bool CheckPerson(Person person);
    }








 }









    

