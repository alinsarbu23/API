using DataBase.Context;
using DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DataBase.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    partial class ProjectDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity<Animal>(b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("integer");

                NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                b.Property<DateTime?>("DataCreated")
                    .HasColumnType("timestamp with time zone");

                b.Property<DateTime?>("DateDeleted")
                    .HasColumnType("timestamp with time zone");

                b.Property<DateTime?>("DateUpdated")
                    .HasColumnType("timestamp with time zone");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("text");

                b.Property<string>("Species")
                    .IsRequired()
                    .HasColumnType("text");

                b.HasKey("Id");

                b.ToTable("Animals");
            });

            modelBuilder.Entity<Owner>(b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("integer");

                NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                b.Property<DateTime?>("DataCreated")
                    .HasColumnType("timestamp with time zone");

                b.Property<DateTime?>("DateDeleted")
                    .HasColumnType("timestamp with time zone");

                b.Property<DateTime?>("DateUpdated")
                    .HasColumnType("timestamp with time zone");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("text");

                b.Property<string>("Address")
                    .IsRequired()
                    .HasColumnType("text");

                b.HasKey("Id");

                b.ToTable("Owners");
            });

            modelBuilder.Entity<UserRole>(b =>
            {
                b.Property<int>("UserId")
                    .HasColumnType("integer");

                b.Property<int>("RoleId")
                    .HasColumnType("integer");

                b.HasKey("UserId", "RoleId");

                b.HasIndex("RoleId");

                b.ToTable("UserRoles");
            });

            modelBuilder.Entity<Animal>()
                .HasOne(a => a.Owner)
                .WithMany(o => o.Animals)
                .HasForeignKey(a => a.OwnerId);

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId);
#pragma warning restore 612, 618
        }
    }
}
