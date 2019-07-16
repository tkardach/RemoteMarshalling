using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marshalling.RemoteClient
{
    public partial class ContactView : UserControl
    {
        public ContactView()
        {
            InitializeComponent();
        }

        public ContactView(string fullName, string number, string email) : this()
        {
            lblLastFirstName.Text = fullName;
            lblEmail.Text = email;
            lblNumber.Text = number;
        }
    }
}
