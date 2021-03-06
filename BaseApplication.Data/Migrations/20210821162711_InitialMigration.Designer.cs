// <auto-generated />
using System;
using BaseApplication.Data.Concrete.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BaseApplication.Data.Migrations
{
    [DbContext(typeof(BaseApplicationContext))]
    [Migration("20210821162711_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BaseApplication.Entities.Concrete.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Content = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
                            CreatedDate = new DateTime(2021, 8, 21, 19, 27, 10, 847, DateTimeKind.Local).AddTicks(749),
                            Date = new DateTime(2021, 8, 21, 19, 27, 10, 847, DateTimeKind.Local).AddTicks(490),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2021, 8, 21, 19, 27, 10, 847, DateTimeKind.Local).AddTicks(756),
                            Thumbnail = "default.jpg",
                            Title = "C# 9.0 makalesi"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Content = "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir.",
                            CreatedDate = new DateTime(2021, 8, 21, 19, 27, 10, 847, DateTimeKind.Local).AddTicks(765),
                            Date = new DateTime(2021, 8, 21, 19, 27, 10, 847, DateTimeKind.Local).AddTicks(764),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2021, 8, 21, 19, 27, 10, 847, DateTimeKind.Local).AddTicks(766),
                            Thumbnail = "default.jpg",
                            Title = "C++ 11 ve 19 Yenilikleri"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Content = "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir.",
                            CreatedDate = new DateTime(2021, 8, 21, 19, 27, 10, 847, DateTimeKind.Local).AddTicks(771),
                            Date = new DateTime(2021, 8, 21, 19, 27, 10, 847, DateTimeKind.Local).AddTicks(769),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2021, 8, 21, 19, 27, 10, 847, DateTimeKind.Local).AddTicks(771),
                            Thumbnail = "default.jpg",
                            Title = "JavaScript Makalesi"
                        });
                });

            modelBuilder.Entity("BaseApplication.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2021, 8, 21, 19, 27, 10, 840, DateTimeKind.Local).AddTicks(6999),
                            Description = "C# ile ilgili güncel bilgiler",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2021, 8, 21, 19, 27, 10, 840, DateTimeKind.Local).AddTicks(7254),
                            Name = "C#"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2021, 8, 21, 19, 27, 10, 840, DateTimeKind.Local).AddTicks(7492),
                            Description = "C++ ile ilgili güncel bilgiler",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2021, 8, 21, 19, 27, 10, 840, DateTimeKind.Local).AddTicks(7493),
                            Name = "C++"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2021, 8, 21, 19, 27, 10, 840, DateTimeKind.Local).AddTicks(7496),
                            Description = "JavaScript ile ilgili güncel bilgiler",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2021, 8, 21, 19, 27, 10, 840, DateTimeKind.Local).AddTicks(7497),
                            Name = "JavaScript"
                        });
                });

            modelBuilder.Entity("BaseApplication.Entities.Concrete.Article", b =>
                {
                    b.HasOne("BaseApplication.Entities.Concrete.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BaseApplication.Entities.Concrete.Category", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
