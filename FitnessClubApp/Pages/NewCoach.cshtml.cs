using FitnessClubApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FitnessClubApp.Pages
{
    public class NewCoachModel : PageModel
    {
        CoachRepository repo = new CoachRepository();
        [BindProperty]
        public Coach CoachPro { get; set; }
       
        public void OnGet()
        {

        }


       

        public void OnPost()
        {

       
            CoachPro.CoachId = repo.GetCoaches().Count+1;
               repo.AddNewCoach(CoachPro);
            
        }
    }
}
