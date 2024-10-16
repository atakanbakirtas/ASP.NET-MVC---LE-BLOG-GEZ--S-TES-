using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeziSitesi.Models.Classlar
{
    public class AdresBlog
    {
        [Key]
        public int id { get; set; }
        public string baslik { get; set; }  
        public string aciklama { get; set; }
        public string adresacik { get; set; }
        public string mail { get; set; }
        public string telefon { get; set; }
        public string konum { get; set; }
    }
}