using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SprintOApp.Models;

namespace SprintOApp.ViewModels
{
    public class DashboardSprintCardViewModel
    {
        public Sprint Sprint { get; set; }
        public List<Card> Cards { get; set; }
    }
}