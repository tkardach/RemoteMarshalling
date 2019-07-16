using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marshalling.RemoteClient
{
    public partial class CreateContact : Form, ICreateContactView
    {
        private IContactController _controller;
        public CreateContact(IContactController controller)
        {
            _controller = controller;
            _controller.ConnectView(this);
            InitializeComponent();
        }

        private void btnClearInfo_Click(object sender, EventArgs e)
        {
            _controller.ClearCreateContact();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            _controller.CreateContact(txtFirstName.Text, txtLastName.Text, txtNumber.Text, txtEmail.Text);
        }

        public void ClearView()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtNumber.Clear();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
            return;
        }

        private void CreateContact_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
    }
}
