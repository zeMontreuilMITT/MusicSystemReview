using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicSystemReview.Models;

namespace HotelSystemReview.Data
{
    public class HotelSystemReviewContext : DbContext
    {
        public HotelSystemReviewContext (DbContextOptions<HotelSystemReviewContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Client { get; set; } = default!;
        public DbSet<Room> Room { get; set; } = default!;
    }
}
