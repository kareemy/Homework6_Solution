using System.ComponentModel.DataAnnotations;

namespace Homework6.Models;

public class Review
{
    public int ReviewID {get; set;}

    [Range(1,5)]
    public int Score {get; set;}

    [Display(Name = "Review")]
    public string ReviewText {get; set;} = string.Empty;

    [Display(Name = "Product")]
    public int ProductID {get; set;} // Foreign Key
    public Product? Product {get; set;} = default!; // Navigation Property back to Product
}