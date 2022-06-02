using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Abby.Models;

public class MenuItem
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public string Image { get; set; }
    
    [Range(1,100,ErrorMessage = "Price should be between $1 and $1000")]
    public double Price { get; set; }
    
    public int FoodTypeId { get; set; }
    
    [ForeignKey("FoodTypeId")]
    public FoodType FoodType { get; set; }
    
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    
}