using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SprintOApp.Models;

namespace SprintOApp.ViewModels
{
    public class CreateSprintViewModel
    {
        public IEnumerable<SprintAccess> SprintAccess { get; set; }
        public IEnumerable<SprintType> SprintType { get; set; }
        public Sprint Sprint { get; set; }
    }
}