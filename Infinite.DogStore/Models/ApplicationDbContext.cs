using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Infinite.DogStore.Models
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext() : base("PetDog")
        {

        }   
        public DbSet<Dogs> Dogs { get; set; }
        public DbSet<DogBreed> DogBreeds { get; set; }

        //for authentication and authorization
      
    } 
}
