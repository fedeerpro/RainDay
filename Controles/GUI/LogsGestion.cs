using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles.GUI
{
    public partial class LogsGestion : Form
    {
        BindingSource _DATOS = new BindingSource();
        private void Cargar()
        {
            try
            {
                _DATOS.DataSource = DataSource.Consultas.Logs1();
                dtgDatos.AutoGenerateColumns = false;
                dtgDatos.DataSource=_DATOS;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public LogsGestion()
        {
            InitializeComponent();
        }

        private void dtgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LogsGestion_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
