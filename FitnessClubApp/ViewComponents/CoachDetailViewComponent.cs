using FitnessClubApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FitnessClubApp.ViewComponents
{
    public class CoachDetailViewComponent:ViewComponent
    {
        DBHelper repo = new DBHelper();

        public IViewComponentResult Invoke(int id)
        {
            var coach = repo.GetCoach(id);
            return View(coach);
        }
    }
}
