using Microsoft.EntityFrameworkCore;

namespace HotelPortfolio.Models;

public class HotelDBContext : DbContext
{
    public HotelDBContext(DbContextOptions<HotelDBContext> options) : base(options)
    {

    }

    //Create Table here
    public DbSet<HotelModel> Hotel { get; set; }
}
