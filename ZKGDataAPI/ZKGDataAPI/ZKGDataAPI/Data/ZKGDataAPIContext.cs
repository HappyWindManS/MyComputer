using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZGKdata.Data_Table;
using ZKGDataAPI.TabelModels;

namespace ZKGDataAPI.Models
{
    public class ZKGDataAPIContext : DbContext
    {
        public ZKGDataAPIContext (DbContextOptions<ZKGDataAPIContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<SchoolScore> SchoolScore { get; set; }
        public DbSet<MajorClassScore> MajorClassSore { get; set; }
        public DbSet<MajorScore> majorScores { get; set; }
        public DbSet<Region> regions { get; set; }
    }
}
