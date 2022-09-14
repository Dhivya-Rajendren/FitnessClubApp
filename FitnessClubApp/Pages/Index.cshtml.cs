using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FitnessClubApp.Pages
{
    public class IndexModel : PageModel
    {
        private string pageTitle;

        public string PageTitle
        {
            get { return pageTitle; }
            set { pageTitle = value; }
        }

        public string SubTitle { get; set; }

        public void OnGet()
        {
            PageTitle = "Fitness Club -CK";
            SubTitle = "Home Page";

            ViewData["Message"] = "Hello Welcome to Fitness";//Key-value 
        }
    }
}
