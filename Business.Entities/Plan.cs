using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Plan: BusinessEntity
    {
        private string _Descripcion;
        private int _IDEspecialidad;
        private int _IDPlan;

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

        public int IDPlan
        {
            get { return _IDPlan; }
            set { _IDPlan = value; }
        }
    }
}
