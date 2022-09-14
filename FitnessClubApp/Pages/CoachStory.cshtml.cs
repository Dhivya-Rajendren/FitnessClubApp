using FitnessClubApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FitnessClubApp.Pages
{
    public class CoachStoryModel : PageModel
    {


        DBHelper repo = new DBHelper();
        public Coach CoachPro { get; set; }
        public void OnGet(int id)
        {

          

       CoachPro=  repo.GetCoach(id);



        }
    }
}
