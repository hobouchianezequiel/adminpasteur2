using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using delSur_Solutions.Models.admin_pasteur;
using delSur_Solutions.Models;

namespace AdminPasteur.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<delSur_Solutions.Models.admin_pasteur.Affiliate> Affiliate { get; set; }
        public DbSet<delSur_Solutions.Models.admin_pasteur.Doctor> Doctor { get; set; }
        public DbSet<delSur_Solutions.Models.PayRoll> PayRoll { get; set; }
    }
}
