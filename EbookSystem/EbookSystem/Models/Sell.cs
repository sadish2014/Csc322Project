using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace EbookSystem.Models
{
    public class Sell
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public string Comment { get; set; }
        public string Rating { get; set; }

    }
    public class SellDBContext : DbContext
    {
        public DbSet<Sell> Sell { get; set; }
    }
}