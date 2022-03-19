using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        UsuarioDA usuarioDA = new UsuarioDA();
        string operacion = string.Empty;
        Usuario user = new Usuario();


        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }

        private void ListarUsuarios()
        {
            UsuariosdataGridView1.DataSource = usuarioDA.ListarUsuarios();
        }

        private void Aceptarbutton1_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }

        private void HabilitarControles()
        {
            CodigoTextBox1.Enabled = true;
            NombreTextBox2.Enabled = true;
            ClaveTextBox4.Enabled = true;
            RolcomboBox1.Enabled = true;

            Nuevobutton1.Enabled = false;
            Guardarbutton3.Enabled = true;
            Cancelarbutton5.Enabled = true;
        }

        private void DesabilitarControles()
        {
            CodigoTextBox1.Enabled = false;
            NombreTextBox2.Enabled = false;
            ClaveTextBox4.Enabled = false;
            RolcomboBox1.Enabled = false;

            Nuevobutton1.Enabled = true;
            Guardarbutton3.Enabled = false;
            Cancelarbutton5.Enabled = false;
        }

        private void LimpiarControles()
        {
            CodigoTextBox1.Clear();
            NombreTextBox2.Clear();
            ClaveTextBox4.Clear();
            RolcomboBox1.Text = string.Empty;
        }

        private void Guardarbutton3_Click(object sender, EventArgs e)
        {
            user.Codigo = CodigoTextBox1.Text;
            user.Nombre = NombreTextBox2.Text;
            user.Rol = RolcomboBox1.Text;
            user.Clave = ClaveTextBox4.Text;

            if (operacion == "Nuevo")
            {
                bool inserto = usuarioDA.InsertarUsuario(user);

                if (inserto)
                {
                    MessageBox.Show("Usuario Creado");
                    ListarUsuarios();
                    LimpiarControles();
                    DesabilitarControles();
                }
                else
                {
                    MessageBox.Show("Usuario no se puede crear");
                }
            }
            else if (operacion == "Modificar")
            {
                bool modifico = usuarioDA.ModificarUsuario(user);
                if (modifico)
                {
                    MessageBox.Show("Usuario Modificado");
                    ListarUsuarios();
                    LimpiarControles();
                    DesabilitarControles();
                }
                else
                {
                    MessageBox.Show("Usuario no se puede modificar");
                }
            }

            
        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            operacion = "Modificar";

            if (UsuariosdataGridView1.SelectedRows.Count > 0)
            {
                CodigoTextBox1.Text = UsuariosdataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
                NombreTextBox2.Text = UsuariosdataGridView1.CurrentRow.Cells["Nombre"].Value.ToString(); ;
                RolcomboBox1.Text = UsuariosdataGridView1.CurrentRow.Cells["Rol"].Value.ToString(); ;
                ClaveTextBox4.Text = UsuariosdataGridView1.CurrentRow.Cells["Clave"].Value.ToString();
                HabilitarControles();
            }
        }

        private void Eliminarbutton4_Click(object sender, EventArgs e)
        {
            if (UsuariosdataGridView1.SelectedRows.Count > 0)
            {
                bool elimino = usuarioDA.EliminarUsuario(UsuariosdataGridView1.CurrentRow.Cells["Codigo"].Value.ToString());
                if (elimino)
                {
                    MessageBox.Show("Usuario Eliminado");
                    ListarUsuarios();
                   
                }
                else
                {
                    MessageBox.Show("Usuario no se puede eliminar");
                }
            }
        }

        private void Cancelarbutton5_Click(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
        }
    }

}
