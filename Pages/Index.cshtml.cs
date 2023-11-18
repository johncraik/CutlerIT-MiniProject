using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CutlerIT_MiniProject.Models;

namespace CutlerIT_MiniProject.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            //Code runs when page is opened:
            try
            {
                Note note = new Note()
                {
                    Title = "Test Insert",
                    Note1 = "Test insert into the database.",
                    Date = "20/11/2023"
                };

                AddNote(note);
            }
            catch (Exception ex)
            {

            }
        }

        private void AddNote(Note note)
        {
            using(var db = new TodoContext())
            {
                db.Notes.Add(note);
                db.SaveChanges();
            }
        }
    }
}