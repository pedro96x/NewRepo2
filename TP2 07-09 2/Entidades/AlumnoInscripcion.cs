﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AlumnoInscripcion : BusinessEntity
    {
        private string _Condicion;
        private int _IDAlumno;
        private int _IDCurso;
        private int _Nota;

        public int IDAlumno 
        {
            get {return _IDAlumno ;}
            set { _IDAlumno = value; }
        }
        public int IDCurso
        {
            get { return _IDCurso; }
            set { _IDCurso = value; }
        }
        public int Nota
        {
            get { return _Nota; }
            set { _Nota = value; }
        }
        public string Condicion
        {
            get { return _Condicion; }
            set { _Condicion = value; }
        }
    }
}
