using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EbookSystem.Models
{
    public class BookInitializer : DropCreateDatabaseIfModelChanges<SellDBContext>
    {
        protected override void Seed(SellDBContext context)
        {
            var sell = new List<Sell> {  
  
                new Sell { Title = "The Hunger Games",
                            Author="Suzanne Collins",
                             ReleaseDate=DateTime.Parse("2008-09-14"),   
                             Genre="Fiction",  
                             Rating="*****",
                             Comment="Best story ever!!",
                             Price= 49},  

 new Sell { Title = "Harry Potter and the Order of the Phoenix",
                            Author="J.K. Rowling",
                             ReleaseDate=DateTime.Parse("2004-07-10"),   
                             Genre="Fiction",  
                             Rating="**",
                             Comment="Disappointing!!",
                             Price= 24},  
 new Sell { Title = "Twilight",
                            Author="Stephenie Meyer",
                             ReleaseDate=DateTime.Parse("2006-09-06"),   
                             Genre="Romantic",  
                             Rating="*",
                             Comment="Boring Vampire Story!!",
                             Price= 19},  
new Sell { Title = "To Kill a Mockingbird",
                            Author="Harper Lee",
                             ReleaseDate=DateTime.Parse("2002-02-02"),   
                             Genre="Fiction",  
                             Rating="****",
                             Comment="Good read!!",
                             Price= 29}, 
new Sell { Title = "The Girl with the Dragon Tattoo",
                            Author="Stieg Larsson",
                             ReleaseDate=DateTime.Parse("2001-05-06"),   
                             Genre="Thriller",  
                             Rating="****",
                             Comment="Good story!!",
                             Price= 22}, 
new Sell { Title = "The Girl Who Played with Fire",
                            Author="Reg Keeland",
                             ReleaseDate=DateTime.Parse("2009-07-21"),   
                             Genre="Thriller",  
                             Rating="****",
                             Comment="Very good book!!",
                             Price= 34},  

new Sell { Title = "The Girl Who Kicked the Hornet's Nest",
                            Author="Stieg Larsson",
                             ReleaseDate=DateTime.Parse("2010-05-25"),   
                             Genre="Thriller",  
                             Rating="*",
                             Comment="Dull!",
                             Price= 16},  
new Sell { Title = "The Da Vinci Code",
                            Author="Dan Brown",
                             ReleaseDate=DateTime.Parse("2006-05-22"),   
                             Genre="Thriller",  
                             Rating="*****",
                             Comment="Best thriller ever!",
                             Price= 44}, 

                 new Sell { Title = "The Diary of a Young Girl",
                            Author="Anne Frank",
                             ReleaseDate=DateTime.Parse("1989-1-11"),   
                             Genre="Romantic",  
                             Rating="***",
                             Comment="Very interesting!!",
                             Price= 29},  

                     new Sell { Title = "The Glass Castle", 
                            Author ="Jeannette Walls",
                             ReleaseDate=DateTime.Parse("1984-3-13"),   
                             Genre="Comedy",  
                              Rating="**",  
                              Comment="Boring read!!!",
                             Price=19},   
   
             };

            sell.ForEach(d => context.Sell.Add(d));
        }
    }
}