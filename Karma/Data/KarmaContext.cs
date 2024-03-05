using Microsoft.EntityFrameworkCore;

namespace Karma.Data
{
	public class KarmaContext:DbContext
	{
        public KarmaContext(DbContextOptions options):base(options)
        {
            
        }
    }
}
