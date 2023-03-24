using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Pierre.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    [Required(ErrorMessage = "The textbox can't be empty!")]
    public string FlavorName { get; set; }

    public List<TreatFlavor> JoinEntities { get; }
  }
}