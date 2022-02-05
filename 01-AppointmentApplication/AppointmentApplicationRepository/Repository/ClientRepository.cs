using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AppointmentApplicationRepository.Entity;
using static AppointmentApplicationRepository.Repository.Global;

namespace AppointmentApplicationRepository.Repository
{
    class ClientRepository
    {
        //private static readonly string ms_insertCmd = @"INSERT INTO clients (name,email,phone) VALUES (@name, @email, @phone)";
        private static readonly string ms_insertCmd = @"sp_insert_client";
        private static readonly string ms_selectCmd = @"SELECT * FROM clients WITH(NOLOCK)";

        private static List<Client> getClients(SqlDataReader sqlDataReader)
        {
            var clients = new List<Client>();
            while (sqlDataReader.Read())
            {
                var client = new Client { Id = (int)sqlDataReader[0], Email = (string)sqlDataReader[1], Name = (string)sqlDataReader[2], Phone = (string)sqlDataReader[3] };
                clients.Add(client);
            }
            return clients;
        }

        public List<Client> All
        {
            get
            {
                try
                {
                    using var sqlCommand = new SqlCommand(ms_selectCmd, Connection);
                    Connection.Open();
                    return getClients(sqlCommand.ExecuteReader());
                }
                finally
                {
                    if (Connection.State == ConnectionState.Open)
                    {
                        Connection.Close();
                    }
                }

            }
        }

        public Client Save(Client client)
        {
            try
            {
                using var sqlCommand = new SqlCommand(ms_insertCmd, Connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@name", client.Name);
                sqlCommand.Parameters.AddWithValue("@email", client.Email);
                sqlCommand.Parameters.AddWithValue("@phone", client.Phone);
                Connection.Open();
                sqlCommand.ExecuteNonQuery();

            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }

            }
            return client;
        }
    }
}
