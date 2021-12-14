using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_Asunto
{
    public partial class BaseForm : Form
    {
        NataMusicEntities1 db = new NataMusicEntities1();
        
        public BaseForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoLogin();

        }

        private void DoLogin()
        {
            var hotmail = txtUsuario.Text;
            var contra = txtContra.Text;
            var usuario = db.Usuario.FirstOrDefault(x => x.hotmail == hotmail && x.Contra == contra);
            if(usuario == null)
            {
                MessageBox.Show("No Esta Registrado En Nuestro Sistema");
                return;
            }
            var form = new MainForm();
            form.Show();
            this.Hide();
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
