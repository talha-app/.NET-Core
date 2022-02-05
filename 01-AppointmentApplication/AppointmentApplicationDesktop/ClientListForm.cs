using AppointmentApplicationRepository.DAL;
using AppointmentApplicationRepository.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppointmentApplicationDesktop
{
    public partial class ClientListForm : Form
    {
        private readonly AppointmentApplicationHelper appointmentApplicationHelper = new AppointmentApplicationHelper();

        public ClientListForm()
        {
            InitializeComponent();
            mlistBoxClients.DisplayMember = "Name";
            mlistBoxClientAppointments.DisplayMember = "Date";
        }

        private void LoadAppointments(int clientId)
        {
            if (mlistBoxClients.SelectedIndex == -1)
            {
                return;
            }
            mlistBoxClientAppointments.Items.Clear();
            List<Appointment> appointments = appointmentApplicationHelper.getAllAppointments(clientId);
            appointments.ForEach(a => mlistBoxClientAppointments.Items.Add(a));
        }

        private void ClientListForm_Load(object sender, EventArgs e)
        {
            try
            {
                appointmentApplicationHelper.GetAllClients().ForEach(c => mlistBoxClients.Items.Add(c));
            }
            catch
            {
                MessageBox.Show("Unexpected exception", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mlistBoxClients_DoubleClick(object sender, EventArgs e)
        {

        }

        private void mlistBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mlistBoxClients.SelectedIndex == -1)
            {
                mGroupBoxDate.Enabled = false;
                return;
            }
            var client = mlistBoxClients.SelectedItem as Client;
            this.LoadAppointments(client.Id);
            mGroupBoxDate.Enabled = true;
        }

        private void mbuttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (mlistBoxClients.SelectedIndex == -1)
                {
                    return;
                }
                var client = mlistBoxClients.SelectedItem as Client;
                int clientId = client.Id;
                DateTime date = mdateTimePickerDate.Value;
                var appointment = new Appointment { ClientId = clientId, Date = date };
                appointmentApplicationHelper.SaveAppointment(appointment);
                this.LoadAppointments(clientId);
            }
            catch
            {
                MessageBox.Show("Unexpected exception", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
