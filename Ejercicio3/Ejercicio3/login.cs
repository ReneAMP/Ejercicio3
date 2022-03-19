using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Accesos;
using Datos.Entidades;

namespace Ejercicio3
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            UsuarioDA usuarioDA = new UsuarioDA();
            Usuario usuario = new Usuario();

            usuario = usuarioDA.Login(UsuariotextBox.Text, ClavetextBox.Text);

            if (usuario == null)
            {
                MessageBox.Show("Usuario o Contraseña incorrecta");
                return;
            } 

            FrmUsuarios frmusuarios = new FrmUsuarios();
            frmusuarios.Show();
            

        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
