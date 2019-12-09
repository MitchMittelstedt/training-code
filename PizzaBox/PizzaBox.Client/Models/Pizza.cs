using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaBox.Client.Validations;

namespace PizzaBox.Client.Models
{
  public class Pizza
  {

    [Required]
    public string Crust { get; set; }
    [Required]
    public int Size { get; set; }
    [Range(1,10)]
    public int Quantity { get; set; }
    public List<string> Crusts { get; set; }
    public List<int> Sizes { get; set; }
    
    [NameAttribute(ErrorMessage = "the name must be letters only")]
    [StringLength(50)]
    public string Name { get; set; }

    public Pizza()
    {
      Crusts = new List<string> { "thin crust", "deep dish" };
      Sizes = new List<int> {10, 12, 14, 16};
    }
  }
}