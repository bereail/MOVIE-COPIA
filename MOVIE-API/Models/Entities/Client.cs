﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MOVIE_API.Models;

public partial class Client
{
    public int Id { get; set; }

    public int? IdUser { get; set; }

    public virtual User IdUserNavigation { get; set; }
}