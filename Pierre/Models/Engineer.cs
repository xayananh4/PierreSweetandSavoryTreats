using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Pierre.Models
{
  public class Treat
  {
    public int TreatId { get; set; }

    [Required(ErrorMessage = "The textbox can't be empty!")]
    public string TreatName { get; set; }

    public List<TreatFlavor> JoinEntities { get; }

  }
}