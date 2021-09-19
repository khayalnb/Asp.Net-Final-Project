using EduHome.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.DataAccessLayer
{
    public class AppEduHomeDbContext:DbContext
    {
        public AppEduHomeDbContext(DbContextOptions<AppEduHomeDbContext> options) : base(options)
        {
        }
        public DbSet<Slide> Slides{ get; set; }
    }
}
