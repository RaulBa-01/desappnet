using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dvdCollection.Models {

    public class Producers {
         [Key]
         [Display(Name="ID")]
        public int ProducerID {get; set;}
        public string ProducerName {get; set;}
        [DataType(DataType.EmailAddrees)]
        public string ContactEmailAddress {get; set;}
        public string WebSite {get; set;}

        public ICollection<FilmTitlesProducers> FilmTitlesProducers {get; set;}
    }
}