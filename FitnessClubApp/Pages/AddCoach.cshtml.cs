using FitnessClubApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FitnessClubApp.Pages
{
    public class AddCoachModel : PageModel
    {
        DBHelper repo= new DBHelper();

        [BindProperty]
        public Coach Coach { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            repo.AddNewCoach(Coach);
        }
    }
}
