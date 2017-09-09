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
using System.Collections;


namespace UI.Desktop
{
    public partial class ABMPersonas : Form
    {
        Usuarios ctrPersona = new Usuarios();
        public ABMPersonas()
        {
            InitializeComponent();
            this.oUsuarios = new Negocio.Usuarios();
            ArrayList usuarios = new ArrayList();
            usuarios = ctrPersona.GetAll();
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

        private void button2_Click(object sender, EventArgs e)
        {
            //comentario de git 2
        }
    }
}
