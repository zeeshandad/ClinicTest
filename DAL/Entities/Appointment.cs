using System;
using System.Collections.Generic;

namespace Clinic.DAL.Entities;

public partial class Appointment
{
    public int Id { get; set; }

    public long PatientId { get; set; }

    public DateOnly Date { get; set; }

    public string? CancelReason { get; set; }

    public bool? CancelStatus { get; set; }
}
