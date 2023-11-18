﻿using Microsoft.AspNetCore.Mvc;
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
        }


        //Adds new note to the database:
        public static void AddNote(string title, string noteTxt, string date)
        {
            //Checks the date is not in the past:
            var parsedDate = DateTime.Parse(date);
            if(parsedDate > DateTime.Now)
            {
                Console.WriteLine("Date must not be in the past.");
            }
            else
            {
                //If date not in the past, add new to do note to database:
                try
                {
                    Note note = new Note()
                    {
                        Title = title,
                        Note1 = noteTxt,
                        Date = date
                    };

                    using (var db = new TodoContext())
                    {
                        db.Notes.Add(note);
                        db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    //Write any errors to the console:
                    Console.WriteLine(ex.Message);
                }
            }

            
        }
    }
}