using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Materia : BusinessEntity
    {
        public Materia(string des, int hss, int hst, int idp)
        {
            Descripcion = des;
            HSSemanales = hss;
            HSTotales = hst;
            IDPlan = idp;
        }

        private string _Descripcion;
        private int _HSSemanales;
        private int _HSTotales;
        private int _IDPlan;

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public int IDPlan
        {
            get { return _IDPlan; }
            set { _IDPlan = value; }
        }

        public int HSSemanales
        {
            get { return _HSSemanales; }
            set { _HSSemanales = value; }
        }

        public int HSTotales
        {
            get { return _HSTotales; }
            set { _HSTotales = value; }
        }

        public bool Equals(Materia o)
        {
            if (this.Descripcion == o.Descripcion 
                //&&
                //this.HSSemanales == o.HSSemanales &&
                //this.HSTotales == o.HSTotales &&
                //this.IDPlan == o.IDPlan
                )
            { return true; }
            else {
                return false;
            };
        }
    }
}
