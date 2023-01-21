using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Infinite.DogStore.Models
{
    public class Dogs
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Dog Name Cannot be Blank")]
        [Display(Name = "Dog Name")]
        [StringLength(50)]
        public string DogName { get; set; }

        [Required(ErrorMessage = "Description can't  be Blank")]
        [Display(Name = "Dog Description")]
        public string Description { get; set; }


        [Required(ErrorMessage = "Height can't be Blank")]
        [Display(Name = "Dog Height")]
        public int Height { get; set; }

        [Required(ErrorMessage = "Weight can't be Blank")]
        [Display(Name = "Dog Weight")]
        public int Weight { get; set; }
        [Required(ErrorMessage = "Age can't be Blank")]
        [Display(Name = "Dog Age")]
        public int Age { get; set; }

        public DogBreed DogBreed { get; set; }


        public int DogBreedId { get; set; }



    }
}