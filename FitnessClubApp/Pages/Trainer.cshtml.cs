using FitnessClubApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.Collections.Generic;

namespace FitnessClubApp.Pages
{
    public class TrainerModel : PageModel
    {
        DBHelper repo = new DBHelper();

        public List<Coach> Coaches { get; set; }


        public void OnGet()
        {

           

            Coaches = repo.GetCoaches();
               }
    }
}
