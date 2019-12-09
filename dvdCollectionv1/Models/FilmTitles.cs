using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dvdCollection.Models {

    public class FilmTitles {
         [Key]
         [Display(Name="ID")]
        public int FilmTitleID { get; set;}
        [Required]
        [StringLength(80)]
        public string FilmTitle { get; set;}
          [Required]
        [StringLength(300)]
        public string FilmStory { get; set;}
         [Required]
        public DateTime FilmRelaseDate { get; set;}
         [Required]
         [DataType(DataType.Date)]
         //[DisplayFormatString="{}"]
        public int FilmDuration { get; set;}
         [Required]
        public int FilmGenereID { get; set;}
         [Required]
        public int FilmCertificateID { get; set;}
         [Required]
        public string FilmAdditionalInfo { get; set;}

        public FilmGeneres Genere { get; set;}
        public Certificates Certificate { get; set;}

        public ICollection<FilmTitlesProducers> FilmTitlesProducers { get; set;}
        public ICollection<FilmsActorRoles> FilmActorRoles { get; set;}

         

    }
}