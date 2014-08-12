using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Entities;

namespace Data.Database
{
    class EspecialidadAdapter : Adapter
    {
          #region DatosEnMemoria
        // Esta región solo se usa en esta etapa donde los datos se mantienen en memoria.
        // Al modificar este proyecto para que acceda a la base de datos esta será eliminada
        private static List<Especialidad> _Especialidades;

        private static List<Especialidad> Especialidades
        {
            get
            {
                if (_Especialidades == null)
                {
                    _Especialidades = new List<Especialidad>();
                    Especialidad esp = new Especialidad();;
                    esp.Descripcion = "Matematicas";
                    _Especialidades.Add(esp);

                    esp = new Especialidad();;
                    esp.Descripcion = "Historia";
                    _Especialidades.Add(esp);

                    esp = new Especialidad();;
                    esp.Descripcion = "Geografia";
                    _Especialidades.Add(esp);

                    esp = new Especialidad();;
                    esp.Descripcion = "Biologia";
                     _Especialidades.Add(esp);

                }
                return _Especialidades;   
            }
        }
        #endregion

        public List<Especialidad> GetAll()
        {
            return new List<Especialidad>(Especialidades);
        }

        public Especialidad GetOne(string desc)
        {
            return Especialidades.Find(delegate(Especialidad e) { return e.Descripcion == desc; });
        }

        public void Delete(string desc)
        {
            Especialidades.Remove(this.GetOne(desc));
        }

        public void Save(Especialidad esp)
        {
            if (esp.State== BusinessEntity.States.New)
            {
                Especialidades.Add(esp);
            }
            else if (esp.State == BusinessEntity.States.Deleted)
            {
                this.Delete(esp.Descripcion);
            }
            else if (esp.State == BusinessEntity.States.Modified)
            {
                Especialidades[Especialidades.FindIndex(delegate(Especialidad e) { return e.Descripcion == esp.Descripcion; })] = esp;
            }
        }
    }
}
