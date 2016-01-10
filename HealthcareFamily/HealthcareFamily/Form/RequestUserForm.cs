using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace HealthcareFamilyGUI
{
    public partial class RequestUserForm : MetroForm
    {
        public RequestUserForm()
        {
            InitializeComponent();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAcceptUser_Click(object sender, EventArgs e)
        {

        }
    }
}
