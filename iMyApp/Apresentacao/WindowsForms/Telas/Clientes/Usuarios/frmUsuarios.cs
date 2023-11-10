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

namespace WindowsForms.Telas.Clientes.Usuarios
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmEnviar_Click(object sender, EventArgs e)
        {
            var remetente = txtFrom.Text;
            var destinatario = txtTo.Text;
            var assunto = txtSubject.Text;
            var menssagem = txtMessage.Text;

            var email = new EmailService(remetente, destinatario, assunto, menssagem);
            email.EnviarEmail();
        }
    }
}
