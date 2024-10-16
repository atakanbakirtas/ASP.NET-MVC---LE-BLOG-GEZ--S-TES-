using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeziSitesi.Models.Classlar
{
    public class Blog
    {
        [Key]
        public int id { get; set; }
        public string baslik { get; set; }
        public DateTime tarih { get; set; }
        public string aciklama { get; set; }
        public string blogImg { get; set; }
        public ICollection<Yorumlar>Yorumlars { get; set; } 

    }
}