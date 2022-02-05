using AppointmentApplicationRepository.Data;
using AppointmentApplicationRepository.Entity;
using System.Collections.Generic;
using System.Linq;

namespace AppointmentApplicationRepository.Repository
{
    class AppointmentRepository
    {
        private static readonly AppointmentDbContext appointmentDbContext = new AppointmentDbContext();

        public Appointment Save(Appointment appointment)
        {
            appointmentDbContext.Appointments.Add(appointment);
            appointmentDbContext.SaveChanges();
            return appointment;
        }

        public List<Appointment> GetAllAppointments(int clientId)
        {
            return appointmentDbContext.Appointments.Where(s => s.ClientId == clientId).ToList();
        }

    }
}
