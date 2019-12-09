using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dvdCollection.Models {

    public class FilmGeneres {
        [Key]
        [Display(Name="ID")]
        public int GenereID { get; set;}
        [Required]
        [StringLength(300)]
        public string GenreDesc { get; set;}

        public ICollection<FilmTitles> FilmTitles { get; set;}

    }
}