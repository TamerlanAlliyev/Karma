using Karma.Models.BaseEntitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Karma.Data.Configurations.BaseEntityConfiguration
{
	public class BaseEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseAuditable
	{
		public virtual void Configure(EntityTypeBuilder<TEntity> builder)
		{
			builder.Property(m=>m.Id).HasColumnType("int").UseIdentityColumn(1,1);
			builder.Property(m => m.CreateBy).HasColumnType("int").IsRequired();
			builder.Property(m => m.Created).HasColumnType("datetime").IsRequired();
			builder.Property(m => m.ModifiedBy).HasColumnType("int");
			builder.Property(m => m.Modified).HasColumnType("datetime");
			builder.Property(m => m.IsDeleted).HasColumnType("bit").IsRequired();
			builder.Property(m => m.IPAddress).HasColumnType("varchar").IsRequired();
		}
	}
}
