using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ArticleMap : EntityTypeConfiguration<Article>
    {
        public ArticleMap()
        {
            // Primary Key
            this.HasKey(t => t.ArticleID);

            // Properties
            this.Property(t => t.ArticleTitle)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Article", "Help");
            this.Property(t => t.ArticleID).HasColumnName("ArticleID");
            this.Property(t => t.ArticleText).HasColumnName("ArticleText");
            this.Property(t => t.ArticleTitle).HasColumnName("ArticleTitle");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.IsPublished).HasColumnName("IsPublished");
            this.Property(t => t.DatePublished).HasColumnName("DatePublished");
        }
    }
}
