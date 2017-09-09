using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Entidades;
using Negocio;


namespace UI.Desktop
{
    public partial class ABMmaterias : Form
    {
        static Materias ctrMaterias = new Materias();
        public ArrayList materias = new ArrayList();

        static public Materias obtenerControlador()
        {
            return ctrMaterias;
        }

        public ABMmaterias()
        {
            InitializeComponent();
            
        }

        private void ABMmaterias_Load(object sender, EventArgs e)
        {
            materias = ctrMaterias.GetAll();
            this.dgvMaterias.DataSource = materias;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaModiMateria abMat = new AltaModiMateria();
            abMat.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            materias = ctrMaterias.GetAll();
            ArrayList lista = new ArrayList();
            this.dgvMaterias.DataSource = lista;
            this.dgvMaterias.DataSource = materias;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        { 
            Materia matModi = new Materia(dgvMaterias.CurrentRow.Cells[0].Value.ToString()
                                           , Convert.ToInt32(dgvMaterias.CurrentRow.Cells[2].Value)
                                           , Convert.ToInt32(dgvMaterias.CurrentRow.Cells[3].Value)
                                           , Convert.ToInt32(dgvMaterias.CurrentRow.Cells[1].Value));
        AltaModiMateria abMat = new AltaModiMateria(matModi);
        abMat.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Materia matDelete = new Materia(dgvMaterias.CurrentRow.Cells[0].Value.ToString()
                                           , Convert.ToInt32(dgvMaterias.CurrentRow.Cells[2].Value)
                                           , Convert.ToInt32(dgvMaterias.CurrentRow.Cells[3].Value)
                                           , Convert.ToInt32(dgvMaterias.CurrentRow.Cells[1].Value));
            ctrMaterias.eliminarMateria(matDelete);
            label2.Text = "La materia " + matDelete.Descripcion + "ha sido eliminada";

            //this.ABMmaterias_Load(sender, e);
            ArrayList lista = new ArrayList();
            this.dgvMaterias.DataSource = lista;
            this.dgvMaterias.DataSource = materias;
        }
    }
}
