﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Open.Infra;

namespace Open.Infra.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181211112916_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Open.Data.Bank.AccountData", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AspNetUserId");

                    b.Property<decimal?>("Balance");

                    b.Property<string>("Status");

                    b.Property<string>("Type");

                    b.Property<DateTime>("ValidFrom");

                    b.Property<DateTime>("ValidTo");

                    b.HasKey("ID");

                    b.HasIndex("AspNetUserId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("Open.Data.Bank.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("AddressID");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("AddressID");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUser");
                });

            modelBuilder.Entity("Open.Data.Bank.InsuranceData", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountId");

                    b.Property<decimal?>("Payment");

                    b.Property<string>("Status");

                    b.Property<string>("Type");

                    b.Property<DateTime>("ValidFrom");

                    b.Property<DateTime>("ValidTo");

                    b.HasKey("ID");

                    b.HasIndex("AccountId");

                    b.ToTable("Insurance");
                });

            modelBuilder.Entity("Open.Data.Bank.RequestTransactionData", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal?>("Amount");

                    b.Property<string>("Explanation");

                    b.Property<string>("ReceiverAccountId");

                    b.Property<string>("SenderAccountId");

                    b.Property<int>("Status");

                    b.Property<DateTime>("ValidFrom");

                    b.Property<DateTime>("ValidTo");

                    b.HasKey("ID");

                    b.HasIndex("ReceiverAccountId");

                    b.HasIndex("SenderAccountId");

                    b.ToTable("RequestTransaction");
                });

            modelBuilder.Entity("Open.Data.Bank.TransactionData", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal?>("Amount");

                    b.Property<string>("Explanation");

                    b.Property<string>("ReceiverAccountId");

                    b.Property<string>("SenderAccountId");

                    b.Property<DateTime>("ValidFrom");

                    b.Property<DateTime>("ValidTo");

                    b.HasKey("ID");

                    b.HasIndex("ReceiverAccountId");

                    b.HasIndex("SenderAccountId");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("Open.Data.Notification.NotificationData", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<bool?>("IsSeen");

                    b.Property<string>("Message");

                    b.Property<string>("ReceiverId");

                    b.Property<string>("SenderId");

                    b.Property<DateTime>("ValidFrom");

                    b.Property<DateTime>("ValidTo");

                    b.HasKey("ID");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Notification");

                    b.HasDiscriminator<string>("Discriminator").HasValue("NotificationData");
                });

            modelBuilder.Entity("Open.Data.Party.AddressData", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("CityOrAreaCode");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("RegionOrStateOrCountryCode");

                    b.Property<DateTime>("ValidFrom");

                    b.Property<DateTime>("ValidTo");

                    b.Property<string>("ZipOrPostCodeOrExtension");

                    b.HasKey("ID");

                    b.ToTable("Address");

                    b.HasDiscriminator<string>("Discriminator").HasValue("AddressData");
                });

            modelBuilder.Entity("Open.Data.Party.CountryData", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.Property<DateTime>("ValidFrom");

                    b.Property<DateTime>("ValidTo");

                    b.HasKey("ID");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("Open.Data.Party.TelecomDeviceRegistrationData", b =>
                {
                    b.Property<string>("AddressID");

                    b.Property<string>("DeviceID");

                    b.Property<DateTime>("ValidFrom");

                    b.Property<DateTime>("ValidTo");

                    b.HasKey("AddressID", "DeviceID");

                    b.HasIndex("DeviceID");

                    b.ToTable("TelecomDeviceRegistration");
                });

            modelBuilder.Entity("Open.Data.Quantity.CurrencyData", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Definition");

                    b.Property<string>("Name");

                    b.Property<DateTime>("ValidFrom");

                    b.Property<DateTime>("ValidTo");

                    b.HasKey("ID");

                    b.ToTable("Currency");
                });

            modelBuilder.Entity("Open.Data.Quantity.NationalCurrencyData", b =>
                {
                    b.Property<string>("CountryID");

                    b.Property<string>("CurrencyID");

                    b.Property<DateTime>("ValidFrom");

                    b.Property<DateTime>("ValidTo");

                    b.HasKey("CountryID", "CurrencyID");

                    b.HasIndex("CurrencyID");

                    b.ToTable("NationalCurrency");
                });

            modelBuilder.Entity("Open.Data.Notification.NewInsuranceNotificationData", b =>
                {
                    b.HasBaseType("Open.Data.Notification.NotificationData");

                    b.Property<string>("InsuranceType");

                    b.ToTable("Notification");

                    b.HasDiscriminator().HasValue("NewInsuranceNotificationData");
                });

            modelBuilder.Entity("Open.Data.Notification.NewTransactionNotificationData", b =>
                {
                    b.HasBaseType("Open.Data.Notification.NotificationData");

                    b.Property<decimal?>("Amount");

                    b.ToTable("Notification");

                    b.HasDiscriminator().HasValue("NewTransactionNotificationData");
                });

            modelBuilder.Entity("Open.Data.Notification.WelcomeNotificationData", b =>
                {
                    b.HasBaseType("Open.Data.Notification.NotificationData");


                    b.ToTable("Notification");

                    b.HasDiscriminator().HasValue("WelcomeNotificationData");
                });

            modelBuilder.Entity("Open.Data.Party.EmailAddressData", b =>
                {
                    b.HasBaseType("Open.Data.Party.AddressData");


                    b.ToTable("Address");

                    b.HasDiscriminator().HasValue("EmailAddressData");
                });

            modelBuilder.Entity("Open.Data.Party.GeographicAddressData", b =>
                {
                    b.HasBaseType("Open.Data.Party.AddressData");

                    b.Property<string>("CountryID");

                    b.HasIndex("CountryID");

                    b.ToTable("Address");

                    b.HasDiscriminator().HasValue("GeographicAddressData");
                });

            modelBuilder.Entity("Open.Data.Party.TelecomAddressData", b =>
                {
                    b.HasBaseType("Open.Data.Party.AddressData");

                    b.Property<int>("Device");

                    b.Property<string>("NationalDirectDialingPrefix");

                    b.ToTable("Address");

                    b.HasDiscriminator().HasValue("TelecomAddressData");
                });

            modelBuilder.Entity("Open.Data.Party.WebPageAddressData", b =>
                {
                    b.HasBaseType("Open.Data.Party.AddressData");


                    b.ToTable("Address");

                    b.HasDiscriminator().HasValue("WebPageAddressData");
                });

            modelBuilder.Entity("Open.Data.Notification.NewRequestTransactionNotificationData", b =>
                {
                    b.HasBaseType("Open.Data.Notification.NewTransactionNotificationData");


                    b.ToTable("Notification");

                    b.HasDiscriminator().HasValue("NewRequestTransactionNotificationData");
                });

            modelBuilder.Entity("Open.Data.Notification.RequestStatusNotificationData", b =>
                {
                    b.HasBaseType("Open.Data.Notification.NewRequestTransactionNotificationData");

                    b.Property<int>("Status");

                    b.ToTable("Notification");

                    b.HasDiscriminator().HasValue("RequestStatusNotificationData");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Open.Data.Bank.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Open.Data.Bank.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Open.Data.Bank.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Open.Data.Bank.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Open.Data.Bank.AccountData", b =>
                {
                    b.HasOne("Open.Data.Bank.ApplicationUser", "AspNetUser")
                        .WithMany()
                        .HasForeignKey("AspNetUserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Open.Data.Bank.ApplicationUser", b =>
                {
                    b.HasOne("Open.Data.Party.GeographicAddressData", "Address")
                        .WithMany()
                        .HasForeignKey("AddressID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Open.Data.Bank.InsuranceData", b =>
                {
                    b.HasOne("Open.Data.Bank.AccountData", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Open.Data.Bank.RequestTransactionData", b =>
                {
                    b.HasOne("Open.Data.Bank.AccountData", "ReceiverAccount")
                        .WithMany()
                        .HasForeignKey("ReceiverAccountId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Open.Data.Bank.AccountData", "SenderAccount")
                        .WithMany()
                        .HasForeignKey("SenderAccountId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Open.Data.Bank.TransactionData", b =>
                {
                    b.HasOne("Open.Data.Bank.AccountData", "ReceiverAccount")
                        .WithMany()
                        .HasForeignKey("ReceiverAccountId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Open.Data.Bank.AccountData", "SenderAccount")
                        .WithMany()
                        .HasForeignKey("SenderAccountId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Open.Data.Notification.NotificationData", b =>
                {
                    b.HasOne("Open.Data.Bank.AccountData", "Receiver")
                        .WithMany()
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Open.Data.Bank.AccountData", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Open.Data.Party.TelecomDeviceRegistrationData", b =>
                {
                    b.HasOne("Open.Data.Party.GeographicAddressData", "Address")
                        .WithMany()
                        .HasForeignKey("AddressID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Open.Data.Party.TelecomAddressData", "Device")
                        .WithMany()
                        .HasForeignKey("DeviceID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Open.Data.Quantity.NationalCurrencyData", b =>
                {
                    b.HasOne("Open.Data.Party.CountryData", "Country")
                        .WithMany()
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Open.Data.Quantity.CurrencyData", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Open.Data.Party.GeographicAddressData", b =>
                {
                    b.HasOne("Open.Data.Party.CountryData", "Country")
                        .WithMany()
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
