using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SprintOApp.Models
{
    public class Card
    {   //For id 
        public int Id { get; set; }
        public string Name { get; set; }

        public Sprint sprint { get; set; }
        public int SprintId { get; set; }
    }
}