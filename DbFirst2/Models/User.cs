﻿using System;
using System.Collections.Generic;

namespace DbFirst2.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }
}
