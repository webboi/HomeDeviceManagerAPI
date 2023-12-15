using Microsoft.EntityFrameworkCore;

namespace HomeDeviceManagerApi.Models
{
    public class DeviceDetailContext : DbContext
    {
        public DeviceDetailContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Device> DeviceDetails { get; set;  }
    }
}
