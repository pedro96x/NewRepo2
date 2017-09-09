using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Plan : BusinessEntity 
    {
        private string _Descripcion;
        private int _IDEspecialidad;

        public Plan(string desc, int id)
        {
            Descripcion = desc;
            IDEspecialidad = id;
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public int IDEspecialidad
        {
            get { return _IDEspecialidad; }
            set { _IDEspecialidad = value; }
        }

    }
}
