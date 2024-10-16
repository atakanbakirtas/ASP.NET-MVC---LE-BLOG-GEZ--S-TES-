using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeziSitesi.Models.Classlar
{
    public class Anasayfa
    {

        [Key]
        public int id { get; set; }
        public string baslik { get; set; }
        public string aciklama { get; set; }



    }
}