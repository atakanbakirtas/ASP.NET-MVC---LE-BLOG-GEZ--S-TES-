using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeziSitesi.Models.Classlar
{
    public class Yorumlar
    {
        [Key]
        public int id { get; set; }
        public string kadi { get; set; }
        public string mail { get; set; }
        public string yorum { get; set; }
        public int blogI_ıd { get; set; }
        public virtual Blog Blog { get; set; }
    }
}