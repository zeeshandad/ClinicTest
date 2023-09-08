using System.Collections;
using System.ComponentModel.DataAnnotations;


namespace Clinic.Models.Appointments
{
    public class AppointmentDTO
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public DateOnly Date { get; set; }

        public Boolean CancelStatus { get; set; }

        public string? CancelReason { get; set; }
    }
}
