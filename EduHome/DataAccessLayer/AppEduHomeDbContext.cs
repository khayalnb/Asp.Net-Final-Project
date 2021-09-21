using EduHome.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.DataAccessLayer
{
    public class AppEduHomeDbContext: IdentityDbContext<AppUser>
    {
        public AppEduHomeDbContext(DbContextOptions<AppEduHomeDbContext> options) : base(options)
        {
        }
        public DbSet<Slide> Slides{ get; set; }

        public DbSet<BioInformation> bioInformation { get; set; }
    }
}
