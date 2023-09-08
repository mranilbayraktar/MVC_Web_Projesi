using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Projem_EntityLayer_Model_.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        [StringLength(1000)]
        public string AboutDetails1 { get; set; }
        [StringLength(1000)]

        public string AboutDetails2 { get; set; }
        [StringLength(100)]

        public string AboutImage { get; set; }  //Resimleri dosya yolu olarak tutacağım. Sunucuya yüklemek tercih edilmez. Dosya yolları veritabanına çekilir
        [StringLength(100)]

        public string AboutImage2 { get; set; }
    }
}
