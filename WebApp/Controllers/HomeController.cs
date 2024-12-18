using Core.Entities;
using Core.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork<Owner> _ownerService;
        private readonly IUnitOfWork<Project> _projectService;
        private readonly IUnitOfWork<Plog> _plogService;
        private readonly IUnitOfWork<Timeline> _timelineService;
        private readonly IUnitOfWork<Social> _socialService;
        private readonly IUnitOfWork<Skill> _skillService;

        public HomeController(IUnitOfWork<Owner> ownerService, IUnitOfWork<Project> projectService, IUnitOfWork<Plog> plogService, IUnitOfWork<Timeline> timelineService, IUnitOfWork<Social> socialService, IUnitOfWork<Skill> skillService)
        {
            _ownerService = ownerService;
            _projectService = projectService;
            _plogService = plogService;
            _timelineService = timelineService;
            _socialService = socialService;
            _skillService = skillService;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel()
            {
                Owner = _ownerService.Entity.GetAll().First(),
                Projects = _projectService.Entity.GetAll().ToList(),
                Plogs = _plogService.Entity.GetAll().ToList(),
                Socials = _socialService.Entity.GetAll().ToList(),
                Skills = _skillService.Entity.GetAll().ToList(),
                Timelines = _timelineService.Entity.GetAll().ToList()
            };

            return View(homeViewModel);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
