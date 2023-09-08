using MVC_Projem_EntityLayer_Model_.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Projem_DataAccessLayer_DAL_.Concrete
{
    public class Context: DbContext
    {
        // Context sınıfı buraya yazılmış olan DbSet türündeki propertyleri sqle tablo olarak yansıtacak

        public DbSet<About> Abouts { get; set; } //About sınıfını burada kullanmak için model katmanını bu katmana referans ekledik
                                                 // About projemin içinde yer alan sınıfın ismi // Abouts sqlde veritabanına yansayacak tablomuzun ismi

        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
