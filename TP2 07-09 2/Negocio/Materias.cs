using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Collections;

namespace Negocio
{
   public class Materias
        {
        protected ArrayList _damaterias = new ArrayList();

        public ArrayList damaterias
        {
            get { return _damaterias; }
            set { _damaterias = value; }
        }

        public Materias() {
            Materia mat = new Materia("Fisica", 2, 40, 123);
            _damaterias.Add(mat);
            Materia mat2 = new Materia("Matematica", 3, 60, 124);
            _damaterias.Add(mat2); }

        public void agregarMaterias(Materia mat)
        {
            damaterias.Add(mat);
        }

        public void eliminarMateria(Materia matEnv)
        {
            {
                foreach (Materia mat in damaterias)
                {
                    if (mat.Equals(mat))
                    {
                        int indice = damaterias.IndexOf(mat);
                        damaterias.RemoveAt(indice);
                    }
                }
            }
        }



        
     


        //protected SqlConnection _conn;


        //public SqlConnection Conn
        //{
        //    get { return _conn; }
        //    set { _conn = value; }
        //}

        //public Materia GetOne(string nom)
        //{
        //    return buscaMateria(nom);
        //}

        public ArrayList GetAll()
        {
            return damaterias;
        }

        public Materia buscaMateria(string desc)
            {
                foreach (Materia mat in damaterias)
                {
                    if (Equals(mat.Descripcion, desc))
                    {
                        return mat;
                    }
                }
                return null;
            }

            //public void GuardarCambios(List<Usuario> dtUsuarios)
            //{
            //    foreach (Usuario ua in daUsuarios)
            //    {
            //        if (daUsuarios.Contains(ua))
            //        {
            //        }
            //        else
            //        {
            //            dtUsuarios.Add(ua);
            //        }
            //    }
            //}

        }

    }


