﻿using System;
using System.Collections.Generic;

namespace DAMP6.DAL.Entities;

public partial class Phuhuynh
{
    public int Id { get; set; }

    public string Ten { get; set; } = null!;

    public string? Nghenghiep { get; set; }

    public virtual ICollection<Sinhvien> Sinhviens { get; set; } = new List<Sinhvien>();
}
