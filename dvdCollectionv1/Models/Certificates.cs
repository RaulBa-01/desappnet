using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dvdCollection.Models {

    public class Certificates {

        [Key]
        [Display(Name="ID")]
        public int CertificateID { get; set;}
        [Required]
        [StringLength(10)]
        public string Certificate { get; set;}

        public ICollection<FilmTitles> FilmTitles { get; set;}

    }
}