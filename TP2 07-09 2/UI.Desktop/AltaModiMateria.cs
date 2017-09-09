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
using UI.Desktop;

namespace UI.Desktop
{
    public partial class AltaModiMateria : Form
    {
        public ArrayList descPlanes;
        public Negocio.Planes ctrPlan = new Negocio.Planes();
        public ArrayList planes;

        public AltaModiMateria()
        {
            InitializeComponent();
        }

        public AltaModiMateria(Materia mat)
        {
            InitializeComponent();
            txtDescripcion.Text = mat.Descripcion;
            txtHSS.Text = mat.HSSemanales.ToString();
            txtHST.Text = mat.HSTotales.ToString();
            planes = ctrPlan.GetAll();
            int indice = 0;
            foreach (Plan p in planes)
            {
                if(Equals(p.IDEspecialidad = mat.IDPlan))
                {
                    indice = cmbPlan.Items.IndexOf(p);
                }
            }
            cmbPlan.SelectedItem = cmbPlan.Items.IndexOf(indice);
        }

        private void AltaModiMateria_Load(object sender, EventArgs e)
        {
            planes = ctrPlan.GetAll();
            descPlanes = new ArrayList();
            foreach (Plan plan in planes)
            {
                this.cmbPlan.Items.Add(plan.Descripcion);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string desc = txtDescripcion.Text;
            int hss = Int32.Parse(txtHSS.Text);
            int hst = Int32.Parse(txtHST.Text);
            int idp = 0; 
            string abuscar = cmbPlan.SelectedText;
            foreach (Plan plan in planes)
            {
                if (plan.Descripcion.Equals(abuscar))
                {
                    idp = plan.IDEspecialidad;
                }
            }
            Materia mat = new Materia(desc, hss, hst, idp);
            label5.Text = "  " + desc + "  " + hss + "  " + hst + "  " + idp + "  ";
            Materias ctrMaterias = ABMmaterias.obtenerControlador();
            ctrMaterias.agregarMaterias(mat);
            //Probando el git 1
        }
    }
}
