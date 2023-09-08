using Clinic.Models.Appointments;
using Clinic.Services;
using Microsoft.AspNetCore.Mvc;

namespace Clinic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppointmentController : ControllerBase
    {
        private IClinicService _clinicService;
        //private IMapper _mapper;

        public AppointmentController(IClinicService clinicService)//, IMapper mapper)
        {
            _clinicService = clinicService;
            //_mapper = mapper;
        }

        [HttpPost]
        public IActionResult Create(AppointmentDTO model)
        {
            _clinicService.Create(model);
            return Ok(new { message = "Appointment created." });
        }

        [HttpPut("Cancel")]
        public IActionResult Cancel(AppointmentDTO model)
        {
            _clinicService.Update(model);
            return Ok(new { message = "Appointment cancelled." });
        }
    }
}
