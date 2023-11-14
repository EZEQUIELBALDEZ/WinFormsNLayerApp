using Negocio.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.telas.usuarios
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            var emailService = new EmailService(txtFrom.Text, txtTo.Text, txtSubject.Text, txtMessage.Text);
            emailService.EnviarEmail();
        }
    }
}
