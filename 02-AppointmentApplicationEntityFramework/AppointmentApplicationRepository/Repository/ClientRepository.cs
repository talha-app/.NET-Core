using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AppointmentApplicationRepository.Entity;
using static AppointmentApplicationRepository.Repository.Global;
using AppointmentApplicationRepository.Data;
using System.Linq;

namespace AppointmentApplicationRepository.Repository
{
    class ClientRepository
    {
        private static readonly AppointmentDbContext appointmentDbContext = new AppointmentDbContext();

        public List<Client> All => appointmentDbContext.Clients.ToList();


        public Client Save(Client client)
        {
            appointmentDbContext.Clients.Add(client);
            appointmentDbContext.SaveChanges();
            return client;
        }
    }
}
