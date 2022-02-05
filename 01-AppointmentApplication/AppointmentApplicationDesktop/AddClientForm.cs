using AppointmentApplicationRepository.DAL;
using AppointmentApplicationRepository.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace AppointmentApplicationDesktop
{
    public partial class AddClientForm : Form
    {
        private readonly AppointmentApplicationHelper appointmentApplicationHelper = new AppointmentApplicationHelper();
        public AddClientForm()
        {
            InitializeComponent();
        }

        private void mButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var name = mtextBoxName.Text;
                var email = mtextBoxEmail.Text;
                var phone = mtextBoxPhone.Text;
                var client = new Client { Name = name, Email = email, Phone = phone };
                appointmentApplicationHelper.SaveClient(client);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Unexpected exception", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mButtonClear_Click(object sender, EventArgs e)
        {
            foreach (var control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }

        private void mButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
