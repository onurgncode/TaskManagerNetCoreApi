using System;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace StaticKimlikKarti.Models
{
    public class AppContextDb:DbContext
    {
        public AppContextDb(DbContextOptions<AppContextDb> options) : base(options) { }
        public DbSet<Gorev> gorev {  get; set; }
        public DbSet<User> user { get; set; }
        public DbSet<LoginModel> login { get; set; }
        
    }
}
