using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace session06.Model.Config;
public class UserConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("users_xyz", "auth");
        //Fluent API
        builder
            .Property(x => x.Email)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("email_xyz")
        ;
    }
}
