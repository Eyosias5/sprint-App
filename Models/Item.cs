using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SprintOApp.Models
{
    public class Item
    {
        public int Id {get; set;}
        public string Name { get; set; }
        public DateTime createdAt { get; set; }
    }
}