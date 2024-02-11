using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    // Başlangıçta ,class person, olarak geliyor. Biz başına internal ekliyoruz. internal'a bir sınıfın default erişim
    // bildirgeci deniyor. Bu şekilde yani ,internal class Person, olursa program.cs'ye gidip person yazarsam gelmez
    // BUT ,public class Person, olursa program.cs'ye gidip Person person = new Person () desem yani "new"lesem gelir.
    // Geldiği zaman da en üstte yani 1. satırda using Entities.Concrete; 2. satırda using System; yazıyor. Burada 
    // using Entities.Concrete demek Entities.Concrete adı altındaki sınıfları kullanabilmek istiyorum demektir. Bunu
    // Java'da, Python'da ve Dart'ta ,import, olarak görebilirsiniz.
    // class'ın başına public yazmazsan sınıfa (Person) erişmekte zorluk çekersin. UNUTMA!!!
    public class Person
    {
        public string FirstName { get; set; }
        public string Lastname{ get; set; }
        public long NationalIdentitiy { get; set; }
        public int DateOfBirthYear{ get; set; }








    }
}
