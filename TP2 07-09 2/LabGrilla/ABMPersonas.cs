using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;


namespace LabGrilla
{
    public partial class formListaUsuarios : Form
    {

        public formListaUsuarios()
        {
            InitializeComponent();
            this.oUsuarios = new Negocio.Usuarios();
            Usuario[] usuarios = new Usuario[2];
            Usuario nuevoUsuario = new Entidades.Usuario("Rossotto96", "12345", "Marcos", "Rossotto", "Rossotto@gmail.com", true);
            Usuario nuevoUsuario2 = new Entidades.Usuario("Pedro96", "12345", "Pedro", "Routaboul", "Routaboul@gmail.com", true);
            usuarios[0] = nuevoUsuario;
            usuarios[1] = nuevoUsuario2;
            this.dgvUsuarios.DataSource = usuarios;
        }


        private Usuarios _usuarios;
      
        public Negocio.Usuarios oUsuarios
        {
            get { return _usuarios; }
            set { _usuarios = value; }
        }

        private void RecargarGrilla()
        {
            this.dgvUsuarios.DataSource = this.oUsuarios.GetAll();
        }

        private void GuardarCambios()
        {
           // this.oUsuarios.GuardarCambios((DataTable)this.dgvUsuarios.DataSource);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
            this.RecargarGrilla();

        }

    }
}
