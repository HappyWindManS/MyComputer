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

        public DbSet<ZGKdata.Data_Table.User> User { get; set; }
        public DbSet<ZKGDataAPI.TabelModels.SchoolScore> SchoolScore { get; set; }
        public DbSet<ZKGDataAPI.TabelModels.MajorSore> MajorSore { get; set; }
    }
}
