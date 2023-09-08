using Clinic.DAL.Entities;
using Clinic.Helper;
using Clinic.Models.Appointments;

namespace Clinic.Services
{
    public interface IClinicService
    {
        //IEnumerable<Appointment> GetAll();
        //Appointment GetById(int id);
        void Create(AppointmentDTO model);
        void Update(AppointmentDTO model);
        //void Delete(int id);
    }

    public class ClinicService : IClinicService
    {
        private ClinicContext _context;
        //private readonly IMapper _mapper;

        public ClinicService(ClinicContext context)//, IMapper mapper)
        {
            _context = context;
            //_mapper = mapper;
        }

        //public IEnumerable<Clinic> GetAll()
        //{
        //    return _context.Clinics;
        //}

        //public Clinic GetById(int id)
        //{
        //    return getClinic(id);
        //}

        public void Create(AppointmentDTO model)
        {
            long patientId = 0;
            var patient = _context.Patients.FirstOrDefault(x => x.Name == model.Name);

            if (patient == null)
            {
                var newPatient = _context.Patients.Add(new Patient() { Name = model.Name });
                patientId = newPatient.Entity.Id;
            }
            else
            {
                patientId = patient.Id;
            }

            //Due to shortage of time not using AutoMapper here
            var appointment = new Appointment() { PatientId = patientId, Date = model.Date };

            _context.Appointments.Add(appointment);
            _context.SaveChanges();
        }

        public void Update(AppointmentDTO model)
        {
            //var Clinic = getClinic(id);

            //// validate
            //if (model.Email != Clinic.Email && _context.Clinics.Any(x => x.Email == model.Email))
            //    throw new AppException("Clinic with the email '" + model.Email + "' already exists");

            //// hash password if it was entered
            //if (!string.IsNullOrEmpty(model.Password))
            //    Clinic.PasswordHash = BCrypt.HashPassword(model.Password);

            //// copy model to Clinic and save
            //_mapper.Map(model, Clinic);
            //_context.Clinics.Update(Clinic);
            //_context.SaveChanges();

            var appointment = new Appointment() { Id = model.Id, CancelStatus = true, CancelReason = model.CancelReason };

            _context.Appointments.Update(appointment);
            _context.SaveChanges();
        }

        //public void Delete(int id)
        //{
        //    var Clinic = getClinic(id);
        //    _context.Clinics.Remove(Clinic);
        //    _context.SaveChanges();
        //}

        // helper methods

        //private Clinic getClinic(int id)
        //{
        //    var Clinic = _context.Clinics.Find(id);
        //    if (Clinic == null) throw new KeyNotFoundException("Clinic not found");
        //    return Clinic;
        //}
    }
}
