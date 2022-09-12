using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informes.GUI
{
    public partial class VisorIncidenciasPorCliente : Form
    {
        String f1 = "", f2 = "";

        private void Cargar()
        {
            f1 = dtpFechaInicio.Value.ToString("yy-MM-dd");
            f2 = dtpFechaFinal.Value.ToString("yy-MM-dd");
            try
            {
                REP.IncidenciasPorCliente oReporte = new REP.IncidenciasPorCliente();
                if (chbAnularFechas.Checked)
                {
                    oReporte.SetDataSource(DataSource.Consultas.REPORTE_GENERAL_INCIDENCIAS2());
                }
                else
                {
                    oReporte.SetDataSource(DataSource.Consultas.REPORTE_GENERAL_INCIDENCIAS_POR_FECHA_Y_ESTADO(f1, f2, cbbEstado.Text));
                }
                crvVisor.ReportSource = oReporte;

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }


        private void chbAnularFechas_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAnularFechas.Checked)
            {
                dtpFechaInicio.Enabled = false;
                dtpFechaFinal.Enabled = false;
                cbbEstado.Enabled = false;
                btnVerRegis.Enabled = false;
                Cargar();
            }
            else
            {
                dtpFechaInicio.Enabled = true;
                dtpFechaFinal.Enabled = true;
                cbbEstado.Enabled = true;
                btnVerRegis.Enabled = true;

            }
        }

        private void btnVerRegis_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        public VisorIncidenciasPorCliente()
        {
            InitializeComponent();
            cbbEstado.SelectedItem = "Todos";
        }
    }
}
