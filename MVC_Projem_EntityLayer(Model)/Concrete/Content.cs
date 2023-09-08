using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Projem_EntityLayer_Model_.Concrete
{
    public class Content
    {
        [Key]
        public int ContentID { get; set; }

        [StringLength(1000)]
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }

        // ContentYazar  - Bu yazıyı kim yazdı
        // ContentBaşlık  - Bu yazı hangi başlığa yazıldı

        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }

        // public int WriterID { get; set; }
        // public virtual Writer Writer { get; set; }
    }
}
