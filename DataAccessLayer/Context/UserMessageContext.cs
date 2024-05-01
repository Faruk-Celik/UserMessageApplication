using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class UserMessageContext : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring ( DbContextOptionsBuilder optionsBuilder )
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-6VB768D\\SQLEXPRESS02; initial catalog=DbMessageApp; integrated Security=true;");

        }
        public DbSet<UserMessage> UserMessages { get; set; }
        public DbSet<Draft> Drafts { get; set; }
    }
}
