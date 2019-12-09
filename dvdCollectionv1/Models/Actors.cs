using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dvdCollection.Models {

    public class Actors {

        [Key]
        [Display(Name="ID")]
        public int ActorID { get; set;}

        [Required]
        [StringLength(80)]
        public string ActorFullName { get; set;}
        [StringLength(300)]
        public string ActorNotes { get; set;}

        public ICollection<FilmsActorRoles> FilmActorRoles { get; set;}

    }
}