using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class PlanDesktop : ApplicationForm
    {
        public PlanDesktop()
        {
            InitializeComponent();
        }

        private void UsuarioDesktop_Load(object sender, EventArgs e)
        {

        }

        Plan _PlanActual;

        public Plan PlanActual
        {
            get { return _PlanActual; }
            set { _PlanActual = value; }
        }

        public PlanDesktop(ModoForm modo) : this()    
        {
            this._Modo = modo;
        }

        public PlanDesktop(int ID, ModoForm modo) : this()
        {
            this._Modo = modo;
            PlanLogic PlanNegocio = new PlanLogic();
            PlanActual = PlanNegocio.GetOne(ID);
            this.MapearDeDatos();
        }
    }
}
