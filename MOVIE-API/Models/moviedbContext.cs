﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MOVIE_API.Models;

public partial class moviedbContext : DbContext
{
    public moviedbContext(DbContextOptions<moviedbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<BookingDetail> BookingDetails { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AI");

        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Admin__3213E83F48C9CFA0");

            entity.ToTable("Admin");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EmployeeNum)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("employee_num");
            entity.Property(e => e.IdUser).HasColumnName("id_user");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Admins)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK__Admin__id_user__4E88ABD4");
        });

        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Booking__3213E83F62941D74");

            entity.ToTable("Booking");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.IdUser).HasColumnName("id_user");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK__Booking__id_user__6A30C649");
        });

        modelBuilder.Entity<BookingDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Booking___3213E83F45BA9CFE");

            entity.ToTable("Booking_Detail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BookingDate)
                .HasColumnType("date")
                .HasColumnName("booking_date");
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("comment");
            entity.Property(e => e.IdBooking).HasColumnName("id_booking");
            entity.Property(e => e.IdMovie).HasColumnName("id_movie");
            entity.Property(e => e.ReturnDate)
                .HasColumnType("date")
                .HasColumnName("return_date");
            entity.Property(e => e.State).HasColumnName("state");

            entity.HasOne(d => d.IdBookingNavigation).WithMany(p => p.BookingDetails)
                .HasForeignKey(d => d.IdBooking)
                .HasConstraintName("FK_BookingDetail_Booking");

            entity.HasOne(d => d.IdMovieNavigation).WithMany(p => p.BookingDetails)
                .HasForeignKey(d => d.IdMovie)
                .HasConstraintName("FK__Booking_D__id_mo__6754599E");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Client__3213E83F42838497");

            entity.ToTable("Client");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdUser).HasColumnName("id_user");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Clients)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK__Client__id_user__4BAC3F29");
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Movie__3213E83FF30C901A");

            entity.ToTable("Movie");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.Director)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("director");
            entity.Property(e => e.IdAdmin).HasColumnName("id_admin");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");

            entity.HasOne(d => d.IdAdminNavigation).WithMany(p => p.Movies)
                .HasForeignKey(d => d.IdAdmin)
                .HasConstraintName("FK__Movie__id_admin__5BE2A6F2");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3213E83F5F124717");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Lastname)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("lastname");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Pass)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pass");
            entity.Property(e => e.Rol)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("rol");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}