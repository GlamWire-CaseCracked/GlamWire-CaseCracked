using GlamWire_Case_Cracked.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlamWire_Case_Cracked
{
    public class GlamwireDbContext : DbContext
    {
        public DbSet<Case> Case { get; set; }
        public DbSet<NPC> NPC { get; set; }
        public DbSet<CaseNPC> CaseNPCs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GlamWireDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

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
