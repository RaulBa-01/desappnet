using System.Collections.Generic;

namespace dvdCollection.Models{
    public class FilmGeneres
    {
            public int GenereID {get; set;} 
            public string RoleDesc {get; set;}

            public ICollection<FilmTitles> FilmTitles {get; set;}      
    }
}