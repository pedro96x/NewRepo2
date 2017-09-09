using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            label5.Text = "Dale click a ingresar, desactive el login temporalmente";
        }
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //label3.Text = "";
            //label4.Text = "";
            //label5.Text = "";

            //string User;
            //string Pass;
            //User = txtUser.Text;
            //Pass = txtPass.Text;
            //if (User.Length == 0)
            //{
            //    label4.Text = "Ingrese un Usuario valido";
            //}
            //if (Pass.Length == 0)
            //{
            //    label3.Text = "Ingrese una Contrasena valida";
            //}
            //if ((User.Equals("admin")) && (Pass.Equals("admin")))
            //{
            Menu menu = new Menu();
            menu.Show();
            //}
            //else { label5.Text = "Usuario y/o Password no Existentes"; }
        }

    }
}
