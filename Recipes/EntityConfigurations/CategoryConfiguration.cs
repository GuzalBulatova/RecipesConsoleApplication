using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipes.Models;

namespace Recipes.EntityConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .HasKey(category => category.Name);

            builder
                .Property(category => category.Name)
                .IsRequired();

            builder
                .Property(category => category.Description)
                .IsRequired(false);

            builder
                .HasMany(category => category.Recipes)
                .WithOne(recipes => recipes.Category);
        }
    }
}
