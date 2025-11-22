using GlamWire_Case_Cracked.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlamWire_Case_Cracked
{
    /// <summary>
    /// GlamwireDbContext uses EF to map out database content. 
    /// <see cref="GlamwireDb"/> this gives us the information we need to map everything 
    /// out.
    /// </summary>
    public class GlamwireDbContext : DbContext
    {
        public DbSet<Case> Case { get; set; }
        public DbSet<NPC> NPC { get; set; }
        public DbSet<CaseNPC> CaseNPCs { get; set; }

        /// <summary>
        /// OnConfiguring method allows us to config. the connection string and 
        /// distribute it throughout the project, with the help of the app.config. 
        /// <see cref=">"/> insert file/page name 
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // update the connectionstring by adding app.config
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GlamWireDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }


        /// <summary>
        ///  Model Creation -- OnModelCreating passes a parameter of model builder
        ///  that allows us to insert relationships, and seed data (if needed)
        ///  for this database(structure), most of the data is premade and ready to go. 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Composite key for join table
            modelBuilder.Entity<CaseNPC>()
                .HasKey(cn => new { cn.CaseId, cn.NPCId });

            modelBuilder.Entity<CaseNPC>()
                .HasOne(cn => cn.Case)
                .WithMany(c => c.CaseNPCs)
                .HasForeignKey(cn => cn.CaseId);

            modelBuilder.Entity<CaseNPC>()
                .HasOne(cn => cn.NPC)
                .WithMany(n => n.CaseNPCs)
                .HasForeignKey(cn => cn.NPCId);
        }
    }
}
