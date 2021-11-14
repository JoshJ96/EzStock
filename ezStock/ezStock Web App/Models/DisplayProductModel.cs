using System.ComponentModel.DataAnnotations;

namespace ezStock_Web_App.Models;
public class DisplayProductModel
{
    [Required]
    [StringLength(6, ErrorMessage = "Product ID can't exceed 6 integers")]
    public int Id { get; set; }
    [Required]
    [StringLength(20, ErrorMessage = "Product name can't exceed 20 characters")]
    public string? Name { get; set; }
    [Required]
    [DataType(DataType.Currency)]
    public double Price { get; set; }
}