using Microsoft.EntityFrameworkCore;
using WebFrontToBack.Models;

namespace WebFrontToBack.DAL;

public class AppDbcontext : DbContext
{
	public AppDbcontext(DbContextOptions<AppDbcontext>options):base(options)
	{

	}
	public DbSet<Slider> sliders { get; set; }
	public DbSet<Category> categories { get; set; }
	public DbSet<Service> services { get; set; }
	public DbSet<ServiceImage> ServiceImages { get; set; }

}
