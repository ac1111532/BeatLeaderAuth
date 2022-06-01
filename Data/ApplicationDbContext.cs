using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeatLeaderAuth.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BeatLeaderAuth.Models.Beatmap> Beatmap { get; set; }

        public DbSet<BeatLeaderAuth.Models.Song> Song { get; set; }

        public DbSet<BeatLeaderAuth.Models.Score> Score { get; set; }

        public DbSet<BeatLeaderAuth.Models.Player> Player { get; set; }
    }
}
