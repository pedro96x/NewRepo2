using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Collections;


namespace Negocio
{
    public class Usuarios 
    {   
        public ArrayList usuariosMemoria = new ArrayList();
        public Usuario u1 = new Usuario("Rossotto96", "12345", "Marcos", "Rossotto", "Rossotto@gmail.com", true);
        public Usuario u2 = new Usuario("Pedro96", "12345", "Pedro", "Routaboul", "Routaboul@gmail.com", true);

        public Usuarios()
        {
            usuariosMemoria.Add(u1);
            usuariosMemoria.Add(u2);
        }
        
        public void AgregarUser(Usuario u)

        {
            usuariosMemoria.Add(u);
        }

        protected ArrayList _daUsuarios;

        public ArrayList daUsuarios
        {
            get { return _daUsuarios; }
            set { _daUsuarios = value; }
        }

        protected SqlConnection _conn;

        
        public SqlConnection Conn
        {
            get { return _conn; }
            set { _conn = value; }
        }

        public ArrayList GetAll()
        {
            return usuariosMemoria;
        }

         
        public Usuario GetOne(string nom)
        {
            return buscaUsuario(nom);
        }

        public Usuario buscaUsuario(string nombre)
        {
            foreach (Usuario ua in usuariosMemoria)
            {
                if (Equals(ua.Nombre,nombre))
                {
                    return ua;
                } 
            }
            return new Usuario("Nuevo", "", "", "", "", true);
        }

        public void GuardarCambios(ArrayList dtUsuarios)
        {
            foreach (Usuario ua in daUsuarios)
            {
                if (daUsuarios.Contains(ua))
                {

                }
                else
                {
                    dtUsuarios.Add(ua);
                }
            }
            
        }

 }

}
