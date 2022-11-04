using Microsoft.EntityFrameworkCore;
using coldplayz.TodoAppNTier.Entities.Domains;

namespace coldplayz.TodoAppNTier.DataAccess.Configurations{

    public class WorkConfiguration : IEntityTypeConfiguration<Work>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Work> builder){
            builder.HasKey(x=>x.Id);
            
            builder.Property(x=>x.Definition).HasMaxLength(300);
            builder.Property(x=>x.Definition).IsRequired(true);

            builder.Property(x=>x.IsCompleted).IsRequired(true);
        }
    }
}