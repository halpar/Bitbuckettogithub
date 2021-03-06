using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using OnlineVindorel.Models;

namespace OnlineVindorel.Migrations
{
    [DbContext(typeof(VindorelDbContext))]
    [Migration("20151229002452_Vindorel")]
    partial class Vindorel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasAnnotation("Relational:Name", "RoleNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasAnnotation("Relational:TableName", "AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasAnnotation("Relational:TableName", "AspNetUserRoles");
                });

            modelBuilder.Entity("OnlineVindorel.Models.Account", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasAnnotation("Relational:Name", "EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .HasAnnotation("Relational:Name", "UserNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetUsers");
                });

            modelBuilder.Entity("OnlineVindorel.Models.Messages", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("From");

                    b.Property<string>("Message")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<DateTime>("SendTime");

                    b.Property<string>("To");

                    b.Property<string>("UserID");

                    b.HasKey("MessageID");
                });

            modelBuilder.Entity("OnlineVindorel.Models.Mission", b =>
                {
                    b.Property<int>("MissionID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Army_Bowman");

                    b.Property<int>("Army_Rider");

                    b.Property<int>("Army_Swordman");

                    b.Property<int>("MissionType");

                    b.Property<DateTime>("Time");

                    b.Property<int>("TownFrom");

                    b.Property<string>("TownFromGod");

                    b.Property<int>("TownId");

                    b.Property<int>("TownTo");

                    b.Property<string>("TownToGod");

                    b.HasKey("MissionID");
                });

            modelBuilder.Entity("OnlineVindorel.Models.TownArmy", b =>
                {
                    b.Property<int>("TownArmyID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Bowman");

                    b.Property<int>("Rider");

                    b.Property<int>("Swordman");

                    b.Property<int>("TownId");

                    b.HasKey("TownArmyID");
                });

            modelBuilder.Entity("OnlineVindorel.Models.TownBuildings", b =>
                {
                    b.Property<int>("BuildingsID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Barracks");

                    b.Property<int>("CityWall");

                    b.Property<int>("Farm");

                    b.Property<int>("MeatCamp");

                    b.Property<int>("Mine");

                    b.Property<int>("TaxHouse");

                    b.Property<int>("TechnologyCamp");

                    b.Property<int>("Temple");

                    b.Property<int>("TownCenter");

                    b.Property<int>("TownID");

                    b.Property<int>("TradeHouse");

                    b.Property<int>("Warehouse");

                    b.Property<int>("WoodCutterHut");

                    b.HasKey("BuildingsID");
                });

            modelBuilder.Entity("OnlineVindorel.Models.TownPopulations", b =>
                {
                    b.Property<int>("PopulationID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AggressivePop");

                    b.Property<int>("BreedRate");

                    b.Property<int>("CulturalPop");

                    b.Property<int>("TownId");

                    b.Property<int>("TraderPop");

                    b.HasKey("PopulationID");
                });

            modelBuilder.Entity("OnlineVindorel.Models.Towns", b =>
                {
                    b.Property<int>("TownId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Coordinate_X");

                    b.Property<int>("Coordinate_Y");

                    b.Property<DateTime>("LastUpdated");

                    b.Property<int>("MaxFOOD");

                    b.Property<int>("MaxIRON");

                    b.Property<int>("MaxWOOD");

                    b.Property<int>("TownGOLD");

                    b.Property<int>("TownGOLD_perHour");

                    b.Property<int>("TownIRON");

                    b.Property<int>("TownIRON_perHour");

                    b.Property<int>("TownMEAT");

                    b.Property<int>("TownMeat_perHour");

                    b.Property<string>("TownName");

                    b.Property<int>("TownWHEAT");

                    b.Property<int>("TownWHEAT_perHour");

                    b.Property<int>("TownWOOD");

                    b.Property<int>("TownWOOD_perHour");

                    b.Property<string>("UserId");

                    b.HasKey("TownId");
                });

            modelBuilder.Entity("OnlineVindorel.Models.UpgradeQueue", b =>
                {
                    b.Property<int>("UpgradeID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BuildingINDEX");

                    b.Property<DateTime>("ProductionTime");

                    b.Property<int>("TownID");

                    b.HasKey("UpgradeID");
                });

            modelBuilder.Entity("OnlineVindorel.Models.UserGameSettings", b =>
                {
                    b.Property<int>("SettingID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnarchyRate");

                    b.Property<int>("ArmySpeed");

                    b.Property<int>("BattleStat");

                    b.Property<int>("BuildSpeed");

                    b.Property<int>("CultureRate");

                    b.Property<int>("DefeatStat");

                    b.Property<string>("God");

                    b.Property<int>("NaturalAttack");

                    b.Property<int>("NaturalBreedRate");

                    b.Property<int>("NaturalDef");

                    b.Property<int>("Point_Culture");

                    b.Property<int>("Point_Economy");

                    b.Property<int>("Point_Exp");

                    b.Property<int>("Point_Karma");

                    b.Property<int>("Point_Military");

                    b.Property<int>("TraderRate");

                    b.Property<int>("TrainSpeed");

                    b.Property<string>("UserId");

                    b.Property<int>("VictoryStat");

                    b.HasKey("SettingID");
                });

            modelBuilder.Entity("OnlineVindorel.Models.UserTechnologyTree", b =>
                {
                    b.Property<int>("TechnologyID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CULTURE_BTimeReduction");

                    b.Property<int>("CULTURE_Morale");

                    b.Property<int>("ECONOMY_Obey");

                    b.Property<int>("ECONOMY_SafeRoad");

                    b.Property<int>("MILITARY_Defence");

                    b.Property<int>("MILITARY_Power");

                    b.Property<string>("UserID");

                    b.HasKey("TechnologyID");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("OnlineVindorel.Models.Account")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("OnlineVindorel.Models.Account")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("OnlineVindorel.Models.Account")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("OnlineVindorel.Models.Messages", b =>
                {
                    b.HasOne("OnlineVindorel.Models.Account")
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("OnlineVindorel.Models.Mission", b =>
                {
                    b.HasOne("OnlineVindorel.Models.Towns")
                        .WithMany()
                        .HasForeignKey("TownId");
                });

            modelBuilder.Entity("OnlineVindorel.Models.TownArmy", b =>
                {
                    b.HasOne("OnlineVindorel.Models.Towns")
                        .WithMany()
                        .HasForeignKey("TownId");
                });

            modelBuilder.Entity("OnlineVindorel.Models.TownBuildings", b =>
                {
                    b.HasOne("OnlineVindorel.Models.Towns")
                        .WithMany()
                        .HasForeignKey("TownID");
                });

            modelBuilder.Entity("OnlineVindorel.Models.TownPopulations", b =>
                {
                    b.HasOne("OnlineVindorel.Models.Towns")
                        .WithMany()
                        .HasForeignKey("TownId");
                });

            modelBuilder.Entity("OnlineVindorel.Models.Towns", b =>
                {
                    b.HasOne("OnlineVindorel.Models.Account")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("OnlineVindorel.Models.UpgradeQueue", b =>
                {
                    b.HasOne("OnlineVindorel.Models.Towns")
                        .WithMany()
                        .HasForeignKey("TownID");
                });

            modelBuilder.Entity("OnlineVindorel.Models.UserGameSettings", b =>
                {
                    b.HasOne("OnlineVindorel.Models.Account")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("OnlineVindorel.Models.UserTechnologyTree", b =>
                {
                    b.HasOne("OnlineVindorel.Models.Account")
                        .WithMany()
                        .HasForeignKey("UserID");
                });
        }
    }
}
