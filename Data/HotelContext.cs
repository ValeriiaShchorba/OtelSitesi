using Microsoft.EntityFrameworkCore;
using OtelSitesi.Models;

namespace OtelSitesi.Data
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options) : base(options) { }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Mesajlar> Mesajlar { get; set; }
        public DbSet<Rezervasyonlar> Rezervasyonlar { get; set; }
    }
}
