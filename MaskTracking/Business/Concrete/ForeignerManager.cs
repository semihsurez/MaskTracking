using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    // Yabancı uyruklunun kuralını buraya yazacağız.
    // Bu dosyayı oluşturunca ilk olarak 'public' ekledik. Sonra ':IApplicantService' ekledik. Sonra sağ tıklayıp "Implement"ledik
    // INTERFACE'ler belli metot imzalarını barındırırlar. Birbirini alternatifi olan sistemlerin farklı implementasyon yapmalarını
    // sağlarlar.

    public class ForeignerManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
