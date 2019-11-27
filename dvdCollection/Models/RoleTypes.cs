using System.Collections.Generic;

namespace dvdCollection.Models{
    public class RoleTypes
    {
            public int RolesTypeID {get; set;} 
            public string ActorFullName {get; set;} 
            public string RoleDesc {get; set;}

            public ICollection<FilmActorRoles> FilmActorRoles {get; set;}      
    }
}