using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace GeziSitesi.Models.Classlar
{
    public class Hakkımzda
    {
        [Key]
        public int id { get; set; }
        public string fotoUrl { get; set; }
        public string aciklama { get; set; }
    }
}