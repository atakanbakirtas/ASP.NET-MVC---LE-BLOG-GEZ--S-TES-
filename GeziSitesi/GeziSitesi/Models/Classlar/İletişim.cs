﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeziSitesi.Models.Classlar
{
    public class İletişim
    {
        [Key]
        public int id { get; set; }
        public string adsoyad { get; set; }
        public string mail { get; set; }
        public string konu { get; set; }
        public string icerik { get; set; }
    }
}