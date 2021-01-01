using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VideoGameManager.DataAccess
{
        public class VideoGameDataContext : DbContext
        {
            public VideoGameDataContext(DbContextOptions<VideoGameDataContext> options)
                : base(options)
            { }

            public DbSet<Game> Games { get; set; }
            public DbSet<GameGenre> Genras { get; set; }
        }
    }
