using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesScripture.Data;
using System;
using System.Linq;


namespace RazorPagesScripture.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesScriptureContext(
                serviceProvider.GetRequiredService<DbContextOptions<RazorPagesScriptureContext>>()))
            {
                // Look for any movies.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Collection = "New Testament",
                        Book = "James",
                        Chapter = "2",
                        Verse = "3",
                        Text = "Something",
                        Notes = "This something is my favorite.",
                        DateAdded = DateTime.Parse("2021-12-01")
                    },

                    new Scripture
                    {
                        Collection = "New Testament",
                        Book = "James",
                        Chapter = "2",
                        Verse = "3",
                        Text = "Something",
                        Notes = "This something is my favorite.",
                        DateAdded = DateTime.Parse("2021-12-01")
                    },

                    new Scripture
                    {
                        Collection = "New Testament",
                        Book = "James",
                        Chapter = "2",
                        Verse = "3",
                        Text = "Something",
                        Notes = "This something is my favorite.",
                        DateAdded = DateTime.Parse("2021-12-01")
                    },

                    new Scripture
                    {
                        Collection = "New Testament",
                        Book = "James",
                        Chapter = "2",
                        Verse = "3",
                        Text = "Something",
                        Notes = "This something is my favorite.",
                        DateAdded = DateTime.Parse("2021-12-01")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
