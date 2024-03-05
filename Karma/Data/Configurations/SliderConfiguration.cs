using Karma.Data.Configurations.BaseEntityConfiguration;
using Karma.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Karma.Data.Configurations
{
	public class SliderConfiguration : BaseEntityConfiguration<Slider>
	{
		public override void Configure(EntityTypeBuilder<Slider> builder)
		{
			base.Configure(builder);

			builder.Property(m => m.Title).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
			builder.Property(m => m.Description).HasColumnType("nvarchar").HasMaxLength(1000).IsRequired();
			builder.Property(m => m.ImageUrl).HasColumnType("varchar").HasMaxLength(500).IsRequired();
		}
	}
}
