using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class IncidenciasEdicion : Form
    {
        bool _VerDetalles = false;
        
        Int32 w = 613, h = 412;

        DateTime fechaCierre = new DateTime();

        String _OpcEmpleado;
        String _ID;
        String _Rol;


        public bool VerDetalles
        {
            get
            {
                return _VerDetalles;
            }

            set
            {
                _VerDetalles = value;
            }
        }

        public string OpcEmpleado
        {
            get
            {
                return _OpcEmpleado;
            }

            set
            {
                _OpcEmpleado = value;
            }
        }

        public string ID
        {
            get
            {
                return _ID;
            }

            set
            {
                _ID = value;
            }
        }

        public string Rol
        {
            get
            {
                return _Rol;
            }

            set
            {
                _Rol = value;
            }
        }

        private bool ValidarParaCliente()
        {
            bool Valido = true;

            DescNot.Clear();
            EquipoNot.Clear();

            if (txbDescripcion.TextLength == 0)
            {
                DescNot.SetError(txbDescripcion, "Escriba una descripcion");
                Valido = false;
            }

            if (txbIDEquipo.TextLength == 0)
            {
                EquipoNot.SetError(txbEquipo, "Seleccione un equipo");
                Valido = false;
            }


            return Valido;
        }

        private bool ValidarParaTecnico()
        {
            bool Valido = true;

            DiagnosticoNot.Clear();
            SolucionNot.Clear();
            DescNot.Clear();

            if (cbbEstado.Text.Equals("Solucionado"))
            {
                if (txbDiagnostico.TextLength == 0)
                {
                    DiagnosticoNot.SetError(txbDiagnostico,"Escriba el diagnostico");
                    Valido = false;
                }

                if (txbSolucion.TextLength == 0)
                {
                    SolucionNot.SetError(txbSolucion,"Escriba una solucion");
                    Valido = false;
                }

            }

            if (cbbTipo.Text.Length == 0)
            {
                DescNot.SetError(cbbTipo,"Seleccione el tipo(Software o Hardware)");
                Valido = false;
            }
            
            return Valido;
        }

        public IncidenciasEdicion()
        {
            InitializeComponent();
        }

        private String Convertir_A_FormatoAMPM(DateTimePicker HORA)
        {
            String hora = "", min = "", HoraReal = "00000";
            hora = HORA.Value.ToString("HH");
            min = HORA.Value.ToString("mm");

            int Hora = Convert.ToInt32(hora);
            int HoraAMPM = 0;

            if (Hora > 12)
            {
                HoraAMPM = Hora - 12;
                HoraReal = HoraAMPM.ToString() + ":" + min + " PM";
            }
            else if (Hora == 0)
            {
                HoraAMPM = Hora + 12;
                HoraReal = HoraAMPM.ToString() + ":" + min + " AM";
            }
            else if (Hora == 12)
            {
                HoraReal = hora + ":" + min + " PM";
            }
            else
            {

                HoraReal = hora + ":" + min + " AM";

            }

            return HoraReal;
        }

        private void ConvertirFechaCompleta(bool Validar)
        {
            if (Validar)
            {

                string fecchaAP = dtpF_Aper.Value.ToString("dd-MM-yy");
                string horaAp = dtpHoraAp.Value.ToString("HH:mm");
                string fechaApCompleta = fecchaAP + " " + horaAp;

                string fechaC = dtpF_Cierre.Value.ToString("dd-MM-yy");
                string horaC = dtpHoraCierre.Value.ToString("HH:mm");
                string fechaCCompleta = fechaC + " " + horaC;

                dtpF_Aper.Value = Convert.ToDateTime(fechaApCompleta);
                dtpF_Cierre.Value = Convert.ToDateTime(fechaCCompleta);
            }
            else
            {
                string fecchaAP = dtpF_Aper.Value.ToString("dd-MM-yy");
                string horaAp = dtpHoraAp.Value.ToString("HH:mm");
                string fechaApCompleta = fecchaAP + " " + horaAp;

                string fechaC = dtpF_Cierre.Value.ToString("dd-MM-yy");
                string horaC = dtpHoraCierre.Value.ToString("HH:mm");
                string fechaCCompleta = fechaC + " " + horaC;

                dtpF_Aper.Value = Convert.ToDateTime(fechaApCompleta);
                dtpF_Cierre.Value = Convert.ToDateTime(fechaCCompleta);

                if (dtpF_Aper.Value > dtpF_Cierre.Value)
                {
                    FechaApNot.SetError(dtpF_Aper, "La fecha de apertura no puede ser mayor a la de cierre");
                }
                else if (dtpF_Aper.Value == dtpF_Cierre.Value)
                {
                    FechaApNot.SetError(dtpF_Aper, "La fecha de apertura no puede ser igual que la de cierre");
                    FechaCierreNot.SetError(dtpF_Cierre, "La fecha de cierre no puede ser igual que la de apertura");
                }
            }

        }
        
        private bool Validar()
        {
            bool Valido = true;

            DescNot.Clear();
            FechaApNot.Clear();
            FechaCierreNot.Clear();
            OpcEmpNot.Clear();
            TecnicoNot.Clear();
            CriticidadNot.Clear();
            EstadoNot.Clear();
            EquipoNot.Clear();

            if (txbDescripcion.TextLength == 0)
            {
                DescNot.SetError(txbDescripcion, "Escriba una descripcion");
                Valido = false;
            }
            
            if (!chbF_Cierre.Checked)
            {
                ConvertirFechaCompleta(true);
                if (dtpF_Aper.Value > dtpF_Cierre.Value)
                {
                    FechaApNot.SetError(dtpF_Aper, "La fecha de apertura no puede ser mayor a la de cierre");
                    Valido = false;
                }
                else if (dtpF_Aper.Value == dtpF_Cierre.Value)
                {
                    FechaApNot.SetError(dtpF_Aper,"La fecha de apertura no puede ser igual que la de cierre");
                    FechaCierreNot.SetError(dtpF_Cierre, "La fecha de cierre no puede ser igual que la de apertura");
                    Valido = false;
                }
            }

            if (txbIDCliente.TextLength == 0)
            {
                if (txbIDEmpleado.TextLength == 0)
                {
                    OpcEmpNot.SetError(txbEmpleado, "Seleccione un empleado o cliente");
                    OpcEmpNot.SetError(txbCliente, "Seleccione un empleado o cliente");
                    Valido = false;
                }
            }

            if (txbIdTecnico.TextLength == 0)
            {
                TecnicoNot.SetError(txbTecnico, "Seleccione un tecnico");
                Valido = false;
            }

            if (cbbCriticidad.Text.Length == 0)
            {
                CriticidadNot.SetError(cbbCriticidad, "Este campo no puede quedar vacio");
                Valido = false;
            }

            if (cbbEstado.Text.Length == 0)
            {
                EstadoNot.SetError(cbbEstado, "Seleccione un estado valido");
                Valido = false;
            }

            if (txbIDEquipo.TextLength == 0)
            {
                EquipoNot.SetError(txbEquipo, "Seleccione un equipo");
                Valido = false;
            }
            

            return Valido;
        }
        
        private void Procesar()
        {

            try
            {
                CLS.Incidencia icd = new CLS.Incidencia();
                icd.IDIncidencia = txbID.Text;
                icd.Descripcion = txbDescripcion.Text;
                ConvertirFechaCompleta(true);
                icd.Fecha_Apertura = dtpF_Aper.Value.ToString("yy-MM-dd HH:mm");
                icd.Diagnostico = txbDiagnostico.Text;
                icd.Tipo = cbbTipo.Text;
                icd.Estado = cbbEstado.Text;
                icd.Criticidad = cbbCriticidad.Text;
                icd.IDEmpleado = txbIDEmpleado.Text;
                icd.IDTecnico = txbIdTecnico.Text;
                icd.IDCliente = txbIDCliente.Text;
                
                icd.IDEquipo = txbIDEquipo.Text;
                if (!chbF_Cierre.Checked)
                {
                    icd.Fecha_Cierre = "'" + dtpF_Cierre.Value.ToString("yy-MM-dd HH:mm") + "'";
                }
                else
                {
                    icd.Fecha_Cierre = "null";
                }

                icd.Solucion = txbSolucion.Text;

                switch (this.OpcEmpleado)
                {
                    case "Empleado":
                        {
                                if (Validar())
                                {
                                    if (txbIDEmpleado.TextLength == 0)
                                    {
                                        icd.IDEmpleado = "null";
                                    }
                                    else if (txbIDCliente.TextLength == 0)
                                    {
                                        icd.IDCliente = "null";
                                    }
                                    
                                if (txbID.TextLength > 0)
                                    {
                                    //Edicion
                                    if (icd.Actualizar())
                                        {
                                            MessageBox.Show("El registro fue actualizado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("El registro no fue actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else
                                    {
                                    //Agregar

                                        if (this._Rol != "Administrador")
                                        {
                                            icd.IDEmpleado = this.ID;
                                        }

                                        if (icd.Agregar())
                                            {
                                                MessageBox.Show("El registro fue agregado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                Close();
                                            }
                                            else
                                            {
                                                MessageBox.Show("El registro no fue agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            }

                                    }
                                }
                            
                        }
                        break;

                    case "Cliente":
                        {
                            if (ValidarParaCliente())
                            {
                                icd.IDEmpleado = "null";
                                icd.IDTecnico = "null";
                                icd.IDCliente = this._ID;
                                icd.Estado = "Pendiente";
                                if (txbID.TextLength > 0)
                                { //Edicion

                                    if (icd.Actualizar())
                                    {
                                        MessageBox.Show("El registro fue actualizado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("El registro no fue actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {//Agregar

                                    //Agregar
                                    if (icd.Agregar())
                                    {
                                        MessageBox.Show("El registro fue agregado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("El registro no fue agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }

                                }


                            }

                        }
                        break;

                    case "Tecnico":
                        {
                            if (cbbEstado.Text.Equals("Solucionado"))
                            {
                                fechaCierre = DateTime.Now;


                                icd.Fecha_Cierre = "'" + fechaCierre.ToString("yy-MM-dd HH:mm") + "'";

                                if (MessageBox.Show("¿Esta seguro dar como 'Solucionado' esta incidencia?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    if (ValidarParaTecnico())
                                    {
                                        if (txbIDCliente.TextLength == 0)
                                        {
                                            icd.IDCliente = "null";
                                        }

                                        if (icd.Actualizar())
                                        {
                                            MessageBox.Show("El registro fue actualizado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("El registro no fue actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }

                                    }
                                }
                            }
                            else
                            {
                                if (ValidarParaTecnico())
                                {
                                    if (txbIDCliente.TextLength == 0)
                                    {
                                        icd.IDCliente = "null";
                                    }
                                    if (icd.Actualizar())
                                    {
                                        MessageBox.Show("El registro fue actualizado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("El registro no fue actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }

                                }
                            }
                        }
                        break;
                }


            }
            catch (Exception)
            {

            }
        }
        
        private void IncidenciasEdicion_Load(object sender, EventArgs e)
        {
            lblF_ApAMPM.Text = Convertir_A_FormatoAMPM(dtpHoraAp);
            lblF_CierreAMPM.Text =  Convertir_A_FormatoAMPM(dtpHoraCierre);
        }
        
        private void btnBuscarTecnico_Click(object sender, EventArgs e)
        {
            try
            {

                GUI.TecnicosGestion NV = new TecnicosGestion();
                NV.SELECCION = true;
                NV.FormBorderStyle = FormBorderStyle.FixedSingle;
                NV.Width = w;
                NV.Height = h;
                NV.ShowDialog();
                if (NV.Seleccionado)
                {
                    txbIdTecnico.Text = NV.IDTecnicoSeleccionado;
                    txbTecnico.Text = NV.TecnicoSeleccionado;
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            GUI.EmpleadosGestion f = new EmpleadosGestion();
            f.SELECCION = true;
            f.FormBorderStyle = FormBorderStyle.FixedSingle;
            f.Width = w;
            f.Height = h;
            f.ShowDialog();
            if (f.Seleccionado)
            {
                txbIDEmpleado.Text = f.IDEmpleadoSeleccionado;
                txbEmpleado.Text = f.EmpleadoSeleccionado;
            }
        }

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            GUI.EquiposGestion f = new EquiposGestion();
            f.SELECCION = true;
            f.FormBorderStyle = FormBorderStyle.FixedSingle;
            f.Width = w;
            f.Height = h;
            f.ShowDialog();
            if (f.Seleccionado)
            {
                txbIDEquipo.Text = f.IDEquipoSeleccionado;
                txbEquipo.Text = f.EquipoSeleccionado;
            }
        }

        private void txbIDEmpleado_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.ClientesGestion V = new ClientesGestion();
                V.SELECCION = true;
                V.FormBorderStyle = FormBorderStyle.FixedSingle;
                V.Width = w;
                V.Height = h;
                V.ShowDialog();
                if (V.Seleccionado)
                {
                    txbIDCliente.Text = V.IDClienteSeleccionado;
                    txbCliente.Text = V.ClienteSeleccionado;
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void dtpF_Aper_ValueChanged(object sender, EventArgs e)
        {
            if (!this._VerDetalles)
            {
                FechaApNot.Clear();
                FechaCierreNot.Clear();

                if (!chbF_Cierre.Checked)
                {
                    ConvertirFechaCompleta(false);
                }
            }
        }
        
        private void dtpF_Cierre_ValueChanged(object sender, EventArgs e)
        {
            if (!this._VerDetalles)
            {
                FechaApNot.Clear();
                FechaCierreNot.Clear();
                ConvertirFechaCompleta(false);
            }
        }

        private void dtpHoraAp_ValueChanged(object sender, EventArgs e)
        {
            if (!this._VerDetalles)
            {
                FechaApNot.Clear();
                FechaCierreNot.Clear();

                if (!chbF_Cierre.Checked)
                {
                    ConvertirFechaCompleta(false);
                }
            }

            lblF_ApAMPM.Text = Convertir_A_FormatoAMPM(dtpHoraAp);
        }

        private void dtpHoraCierre_ValueChanged(object sender, EventArgs e)
        {
            if (!this._VerDetalles)
            {
                FechaApNot.Clear();
                FechaCierreNot.Clear();
                ConvertirFechaCompleta(false);
            }

            lblF_CierreAMPM.Text = Convertir_A_FormatoAMPM(dtpHoraCierre);
        }

        private void chbF_Cierre_CheckedChanged(object sender, EventArgs e)
        {
            if (chbF_Cierre.Checked)
            {
                dtpF_Cierre.Enabled = false;
                dtpHoraCierre.Enabled = false;
                FechaApNot.Clear();
                FechaCierreNot.Clear();
            }
            else
            {
                dtpF_Cierre.Enabled = true;
                dtpHoraCierre.Enabled = true;
                ConvertirFechaCompleta(false);
            }
        }























































        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (txbIDCliente.TextLength > 0)
            {
                if (MessageBox.Show("¿Esta seguro de ELIMINAR al Cliente: " + txbCliente.Text + "?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txbIDCliente.Clear();
                    txbCliente.Clear();
                }
            }
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            if (txbIDEmpleado.TextLength > 0)
            {
                if (MessageBox.Show("¿Esta seguro de ELIMINAR al Empleado: " + txbEmpleado.Text + "?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txbIDEmpleado.Clear();
                    txbEmpleado.Clear();
                }
            }
        }

        private void cbbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
