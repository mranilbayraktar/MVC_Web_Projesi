using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Projem_EntityLayer_Model_.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [StringLength(50)]
        public string CategoryName { get; set; }
        [StringLength(500)]
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; } // İlişkili tablolarda silme işlemi yapmayacağız, durumu aktif/pasif yapacağız

        public ICollection<Heading> Headings { get; set; }  // T type istiyor. Yani ilişki içine almak istediğin şeyi ver bana

    }
}
