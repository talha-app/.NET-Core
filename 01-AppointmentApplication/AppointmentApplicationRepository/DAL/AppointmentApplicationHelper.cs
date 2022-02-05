using AppointmentApplicationRepository.Entity;
using AppointmentApplicationRepository.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppointmentApplicationRepository.DAL
{
    public class AppointmentApplicationHelper
    {
        private ClientRepository m_clientRepository = new ClientRepository();
        private AppointmentRepository m_appointmentRepository = new AppointmentRepository();

        public Client SaveClient(Client client)
        {
            try
            {
                return m_clientRepository.Save(client);
            }
            catch (Exception ex)
            {
                throw new AggregateException("SaveClient", ex);
            }
        }

        public List<Client> GetAllClients()
        {
            try
            {
                return m_clientRepository.All;
            }
            catch (Exception ex)
            {
                throw new AggregateException("GetAllClients", ex);
            }
        }

        public Appointment SaveAppointment(Appointment appointment)
        {
            try
            {
                return m_appointmentRepository.Save(appointment);
            }
            catch (Exception ex)
            {
                throw new AggregateException("SaveAppointment", ex);
            }
        }

        public List<Appointment> getAllAppointments(int clientId)
        {
            try
            {
                return m_appointmentRepository.GetAllAppointments(clientId);
            }
            catch (Exception ex)
            {
                throw new AggregateException("getAllAppointments", ex);
            }
        }
    }
}
