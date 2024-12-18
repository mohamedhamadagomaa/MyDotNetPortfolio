using Core.Entities;

namespace WebApp.Models
{
    public class HomeViewModel
    {
        public Owner Owner { get; set; }
        public List<Project> Projects { get; set; }
        public List<Timeline> Timelines { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Social> Socials { get; set; }
        public List<Plog> Plogs { get; set; }
    }
}
