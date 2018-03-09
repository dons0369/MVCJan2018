using System.ComponentModel.DataAnnotations;
namespace MVCJan2018.Models

{
   public class ProductVM
   {
      public int ID { get; set; }

      //[Required]
      [Required(ErrorMessage = "Enter the Product Name")]
      [MinLength(5, ErrorMessage = "Enter atleast 5 characters")]

      public string Name { get; set; }
      [Required(ErrorMessage = "Enter the Product Price")]
      public decimal Price { get; set; }
   }
}