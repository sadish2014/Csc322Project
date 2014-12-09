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