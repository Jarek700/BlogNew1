using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogNew1.Models
{
    public class Artykuly
    {
        [Key]
        public int Id { get; set; }
        public string Tytul { get; set; }
        public string Wstep { get; set; }
        public string TekstArtykulu { get; set; }
    }
}