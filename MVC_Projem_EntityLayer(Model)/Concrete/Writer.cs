using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Projem_EntityLayer_Model_.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }

        [StringLength(50)]
        public string WriterName { get; set; }

        [StringLength(50)]
        public string WriterSurname { get; set; }

        [StringLength(100)]
        public string WriterImage { get; set; }

        [StringLength(50)]
        public string WriterMail { get; set; }

        [StringLength(20)]
        public string WriterPassword { get; set; }

        // Başlık hangi yazar tarafından oluşturuldu.. Yazar Bir Başlıklar Çok ilişkide

        public ICollection<Heading> Headings { get; set; }  //Bire- Çok ilişkide BİR tarafı burası
        // public ICollection<Content> Contents  { get; set; }
    }
}
