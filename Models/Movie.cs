using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homework6_Solution.Models
{
    public class Movie
    {
        public int MovieID {get; set;}

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title {get; set;}

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate {get; set;}

        [StringLength(30)]
        [Required]
        public string Genre {get; set;}

        [Range(1,100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price {get; set;}

        [StringLength(5)]
        [Required]
        public string Rating {get; set;}
        
    }
}