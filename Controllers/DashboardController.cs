using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SprintOApp.Models;
using SprintOApp.ViewModels;

namespace SprintOApp.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        //   /Dashboard/Sprints
        private ApplicationDbContext _context;

        public DashboardController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Sprints()
        {
            var sprints = _context.Sprints.ToList();
      
            return View(sprints);
        }
        public ActionResult CreateSprint()
        {
            var SprintAccesses = _context.SprintAccesses.ToList();
            var SprintTypes = _context.SprintTypes.ToList();
            var viewModel = new CreateSprintViewModel
            {
                SprintAccess = SprintAccesses,
                SprintType = SprintTypes

            };
            return View(viewModel);  
        }
        [HttpPost]
        public ActionResult Create(Sprint sprint)
        { 
            _context.Sprints.Add(sprint);
            if(sprint.SprintTypeId == 1)
            {
                Card card1 = new Card { Name = "To-do", SprintId = sprint.Id };
                Card card2 = new Card { Name = "Doing", SprintId = sprint.Id };
                Card card3 = new Card { Name = "Done", SprintId = sprint.Id };
                _context.Cards.Add(card1);
                _context.Cards.Add(card2);
                _context.Cards.Add(card3);
            }
            _context.SaveChanges();
            return RedirectToAction("Sprints","Dashboard");
        }
        
        public ActionResult SprintDetails( int id)
        {
            var sprint = _context.Sprints.SingleOrDefault(c => c.Id == id);
            var card = _context.Cards.Where(c => c.SprintId == sprint.Id).ToList();
          //  var card = _context.Cards.SingleOrDefault(c => c.SprintId == id);

            var viewModel = new DashboardSprintCardViewModel
            {
                Sprint = sprint,
                Cards = card,
            };

            if (sprint == null)
                return HttpNotFound();
            return View(viewModel);

        }

     
    }
}