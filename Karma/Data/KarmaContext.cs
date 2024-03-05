using Karma.Models;
using Microsoft.EntityFrameworkCore;

namespace Karma.Data
{
	public class KarmaContext : DbContext
	{
		public KarmaContext(DbContextOptions<KarmaContext> options) : base(options)
		{

		}

		public DbSet<Slider> Sliders { get; set; }
	}
}
