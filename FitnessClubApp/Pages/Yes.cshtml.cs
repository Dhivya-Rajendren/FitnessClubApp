using FitnessClubApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FitnessClubApp.Pages
{
    public class YesModel : PageModel
    {
        DBHelper repo = new DBHelper();
        public IActionResult OnGet( int id)
        {
            repo.DeleteCoach(id);
            return Redirect("Trainer");
        }
    }
}
