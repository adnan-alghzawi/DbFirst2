using System;
using System.Collections.Generic;

namespace DbFirst2.Models;

public partial class Department
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Location { get; set; }

    public int? ManagerId { get; set; }

    public string? DepartmentCode { get; set; }
}
