using BISoft.MiPrimeraApp.Aplicacion.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPrimeraApp
{
    public partial class frmMaestros : Form
    {
        private MaestroService _service;
        public frmMaestros(MaestroService service)
        {
            InitializeComponent();
           

            _service = service;
        }

        private void frmMaestros_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var maestro = _service.CrearMaestro(txtNombre.Text, txtApellido.Text, txtEmail.Text, txtDirecion.Text, txtTelefono.Text);

                MessageBox.Show("El nombre es: " + maestro.Nombre + " " + maestro.Apellido
                    + " \nEdad:" + maestro.Email, "Mensaje Maestros");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }


        }
    }
}
