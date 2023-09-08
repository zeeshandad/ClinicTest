using System;
using System.Collections.Generic;

namespace Clinic.DAL.Entities;

public partial class Patient
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
}
