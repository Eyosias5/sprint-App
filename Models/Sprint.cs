using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SprintOApp.Models
{
    public class Sprint
    {
      public int Id { get; set; }
      public string Name { get; set; }

      public SprintAccess SprintAccess { get; set; }
      [Display(Name = "Access")]
      public byte SprintAccessId { get; set; }

      public SprintType SprintType { get; set; }
      [Display(Name = "Sprint Type")]
      public byte SprintTypeId { get; set; }
     
      
    }  
}