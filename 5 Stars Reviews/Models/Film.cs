using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _5_Stars_Reviews.Models
{
    public class Film
    {
        //This is the Film class that will be used to create the Film table

        //creates a variable for the film id
        //this is the Primary Key
        public virtual int FilmId { get; set; }
        //creates a variable for the film name
        public virtual string FilmName { get; set; }
        //creates a variable for the film description
        public virtual string Description { get; set; }
        //creates a variable for the films release date
        public virtual DateTime ReleaseDate { get; set; }
        //creates a variable for the genre
        public virtual string Genre { get; set; }
        //creates a variable for the DirectorId
        public virtual int DirectorId { get; set; }
        //creates a variable for the Director
        //this will let this class see the director class as a foreign Key
        public virtual Director Director { get; set; }
        //creates a variable for the actorId
        public virtual int ActorId { get; set; }
        //creates an Icollection for the actor table
        //this will let us collect all the actors onto one film
        public virtual ICollection<Actor> Actors { get; set; }
    }
}