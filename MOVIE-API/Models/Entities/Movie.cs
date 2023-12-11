﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using MOVIE_API.Models.Enum;
using System;
using System.Collections.Generic;

namespace MOVIE_API.Models;

public partial class Movie
{
    public int Id { get; set; }

    public int? IdAdmin { get; set; }

    public string Title { get; set; }

    public string Director { get; set; }

    public DateTime? Date { get; set; }

    public MovieState State { get; set; }

    public virtual ICollection<BookingDetail> BookingDetails { get; set; } = new List<BookingDetail>();

    public virtual Admin IdAdminNavigation { get; set; }
}