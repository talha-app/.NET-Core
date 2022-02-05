using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentApplicationDesktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void m_buttonNewClient_Click(object sender, EventArgs e)
        {
            new AddClientForm().ShowDialog();
        }

        private void mButtonList_Click(object sender, EventArgs e)
        {
            new ClientListForm().ShowDialog();
        }
    }
}
