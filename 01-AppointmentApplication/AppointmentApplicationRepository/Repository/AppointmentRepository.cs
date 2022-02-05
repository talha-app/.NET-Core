using AppointmentApplicationRepository.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using static AppointmentApplicationRepository.Repository.Global;

namespace AppointmentApplicationRepository.Repository
{
    class AppointmentRepository
    {
        private readonly static string ms_insertCmd = @"INSERT INTO appointments (client_id, date) values (@client_id, @date)";
        private readonly static string ms_getAllCmd = @"SELECT * FROM appointments WHERE client_id = @client_id";

        public Appointment Save(Appointment appointment)
        {
            try
            {
                using var command = new SqlCommand(ms_insertCmd, Connection);
                command.Parameters.AddWithValue("@client_id", appointment.ClientId);
                command.Parameters.AddWithValue("@date", appointment.Date);
                Connection.Open();
                command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State == System.Data.ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
            return appointment;
        }

        internal List<Appointment> GetAllAppointments(int clientId)
        {
            try
            {
                using var command = new SqlCommand(ms_getAllCmd, Connection);
                command.Parameters.AddWithValue("@client_id", clientId);
                Connection.Open();
                return getAppointments(command.ExecuteReader());

            }
            finally
            {
                if (Connection.State == System.Data.ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        private List<Appointment> getAppointments(SqlDataReader sqlDataReader)
        {
            var appointments = new List<Appointment>();
            while (sqlDataReader.Read())
            {
                var appointment = new Appointment { Id = (int)sqlDataReader[0], ClientId = (int)sqlDataReader[1], Date = (DateTime)sqlDataReader[2] };
                appointments.Add(appointment);

            }
            return appointments;
        }
    }
}
