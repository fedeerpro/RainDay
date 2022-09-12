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
    public partial class GestionDeIncidencias : Form
    {

        BindingSource _DATOS = new BindingSource();
        DateTimePicker HoraAp = new DateTimePicker();
        DateTimePicker HoraCierre = new DateTimePicker();
        CLS.Incidencia icd = new CLS.Incidencia();
        DataTable _Nombres = new DataTable();
        String _OpcEmp;
        String _ID;
        String _Rol;

        public string OpcEmp
        {
            get
            {
                return _OpcEmp;
            }

            set
            {
                _OpcEmp = value;
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

        private void EditarParaEmp()
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro de EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    GUI.IncidenciasEdicion v = new IncidenciasEdicion();
                    v.txbID.Text = dtgDatos.CurrentRow.Cells["IdIncidencia"].Value.ToString();
                    v.txbDescripcion.Text = dtgDatos.CurrentRow.Cells["Descripcion"].Value.ToString();
                    v.dtpF_Aper.Text = dtgDatos.CurrentRow.Cells["Fecha_Apertura"].Value.ToString();
                    v.txbDiagnostico.Text = dtgDatos.CurrentRow.Cells["Diagnostico"].Value.ToString();
                    v.cbbTipo.Text = dtgDatos.CurrentRow.Cells["Tipo"].Value.ToString();
                    v.cbbEstado.Text = dtgDatos.CurrentRow.Cells["Estado"].Value.ToString();
                    v.cbbCriticidad.Text = dtgDatos.CurrentRow.Cells["Criticidad"].Value.ToString();
                    v.txbIDEmpleado.Text = dtgDatos.CurrentRow.Cells["IdEmpleado"].Value.ToString();
                    v.txbEmpleado.Text = dtgDatos.CurrentRow.Cells["Empleados"].Value.ToString();
                    //v.txbEmpleado.Text = dtgDatos.CurrentRow.Cells["Empleado"].Value.ToString();
                    v.txbIdTecnico.Text = dtgDatos.CurrentRow.Cells["IdTecnico"].Value.ToString();
                    v.txbTecnico.Text = dtgDatos.CurrentRow.Cells["Tecnicos"].Value.ToString();
                    //v.txbTecnico.Text = dtgDatos.CurrentRow.Cells["Tecnico"].Value.ToString();
                    v.txbIDCliente.Text = dtgDatos.CurrentRow.Cells["IdCliente"].Value.ToString();
                    v.txbCliente.Text = dtgDatos.CurrentRow.Cells["Clientes"].Value.ToString();
                    //v.txbCliente.Text = dtgDatos.CurrentRow.Cells["Cliente"].Value.ToString();
                    v.txbIDEquipo.Text = dtgDatos.CurrentRow.Cells["IdEquipo"].Value.ToString();
                    v.txbEquipo.Text = dtgDatos.CurrentRow.Cells["Equipos"].Value.ToString();
                    //v.txbEquipo.Text = dtgDatos.CurrentRow.Cells["Equipo"].Value.ToString();
                    string a = dtgDatos.CurrentRow.Cells["Fecha_Cierre"].Value.ToString();

                    if (a.Length != 0)
                    {
                        v.dtpF_Cierre.Text = dtgDatos.CurrentRow.Cells["Fecha_Cierre"].Value.ToString();
                        HoraCierre.Value = Convert.ToDateTime(dtgDatos.CurrentRow.Cells["Fecha_Cierre"].Value.ToString());
                        v.dtpHoraCierre.Text = HoraCierre.Value.ToString("HH:mm");
                    }


                    v.txbSolucion.Text = dtgDatos.CurrentRow.Cells["Solucion"].Value.ToString();
                    HoraAp.Value = Convert.ToDateTime(dtgDatos.CurrentRow.Cells["Fecha_Apertura"].Value.ToString());

                    v.dtpHoraAp.Text = HoraAp.Value.ToString("HH:mm");
                    v.OpcEmpleado = this._OpcEmp;
                    v.Rol = this._Rol;
                    v.ID = this._ID;

                    if (this._Rol != "Administrador")
                    {
                        v.btnEliminarEmpleado.Visible = false;
                        v.btnEliminarCliente.Visible = false;
                    }

                    v.ShowDialog();

                    CargarDatos();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una fila válida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void EditarParaTec()
        {
            try
            {
                    GUI.IncidenciasEdicion v = new IncidenciasEdicion();
                    v.txbID.Text = dtgDatos.CurrentRow.Cells["IdIncidencia"].Value.ToString();
                    v.txbID.Width = 70;

                    v.btnCancelar.Location = new Point(v.lblDiagnostico.Location.X + 20,v.lblDiagnostico.Location.Y);
                    v.btnGuardar.Location = new Point(v.lblDiagnostico.Location.X + 120, v.lblDiagnostico.Location.Y);

                    v.txbDescripcion.Text = dtgDatos.CurrentRow.Cells["Descripcion"].Value.ToString();
                    v.lblDesc.Visible = false;
                    v.txbDescripcion.Visible = false;
                
                    v.dtpF_Aper.Text = dtgDatos.CurrentRow.Cells["Fecha_Apertura"].Value.ToString();
                    v.lblF_AP.Visible = false;
                    v.dtpF_Aper.Visible = false;
                    v.lblHoraAp.Visible = false;
                    v.dtpHoraAp.Visible = false;
                    v.dtpF_Cierre.Visible = false;
                    v.dtpHoraCierre.Visible = false;
                    v.lblF_Cierre.Visible = false;
                    v.lblF_CierreAMPM.Visible = false;
                    v.chbF_Cierre.Visible = false;
                    v.lblHoraCierre.Visible = false;
                    v.lblF_ApAMPM.Visible = false;

                    v.txbDiagnostico.Text = dtgDatos.CurrentRow.Cells["Diagnostico"].Value.ToString();
                    v.lblDiagnostico.Location = new Point(v.lblDesc.Location.X, v.lblDesc.Location.Y);
                    v.txbDiagnostico.Location = new Point(v.txbDescripcion.Location.X, v.txbDescripcion.Location.Y);

                    v.cbbTipo.Text = dtgDatos.CurrentRow.Cells["Tipo"].Value.ToString();
                    v.lblTipo.Location = new Point(v.lblHoraAp.Location.X + 135, v.lblHoraAp.Location.Y);
                    v.cbbTipo.Location = new Point(v.dtpHoraAp.Location.X +130, v.dtpHoraAp.Location.Y);

                    v.cbbEstado.Text = dtgDatos.CurrentRow.Cells["Estado"].Value.ToString();
                    v.lblEstado.Location = new Point(v.lblHoraAp.Location.X, v.lblHoraAp.Location.Y);
                    v.cbbEstado.Location = new Point(v.dtpHoraAp.Location.X-10, v.dtpHoraAp.Location.Y);
                 
                    v.cbbCriticidad.Text = dtgDatos.CurrentRow.Cells["Criticidad"].Value.ToString();
                    v.lblCriticidad.Visible = false;
                    v.cbbCriticidad.Visible = false;

                    v.txbIDEmpleado.Text = dtgDatos.CurrentRow.Cells["IdEmpleado"].Value.ToString();
                    v.txbIDEmpleado.Visible = false;
                    v.lblEmpleado.Location = new Point(v.txbIDEmpleado.Location.X, v.txbIDEmpleado.Location.Y);
                    v.txbEmpleado.Text = dtgDatos.CurrentRow.Cells["Empleados"].Value.ToString();
                    v.btnBuscarEmpleado.Visible = false;
                    v.btnEliminarEmpleado.Visible = false;
                    v.lblEmpleado.Visible = false;
                    v.txbIDEmpleado.Visible = false;
                    v.txbEmpleado.Visible = false;

                    v.txbIdTecnico.Text = dtgDatos.CurrentRow.Cells["IdTecnico"].Value.ToString();
                    v.txbIdTecnico.Visible = false;
                    v.lblTecnico.Location = new Point(v.txbIdTecnico.Location.X, v.txbIdTecnico.Location.Y);
                    v.txbTecnico.Text = dtgDatos.CurrentRow.Cells["Tecnicos"].Value.ToString();
                    v.btnBuscarTecnico.Visible = false;
                    v.lblTecnico.Visible = false;
                    v.txbIdTecnico.Visible = false;
                    v.txbTecnico.Visible = false;

                    v.txbIDCliente.Text = dtgDatos.CurrentRow.Cells["IdCliente"].Value.ToString();
                    v.txbIDCliente.Visible = false;
                    v.lblCliente.Location = new Point(v.txbIDCliente.Location.X, v.txbIDCliente.Location.Y);
                    v.txbCliente.Text = dtgDatos.CurrentRow.Cells["Clientes"].Value.ToString();
                    v.btnBuscarCliente.Visible = false;
                    v.btnEliminarCliente.Visible = false;
                    v.lblCliente.Visible = false;
                    v.txbIDCliente.Visible = false;
                    v.txbCliente.Visible = false;
                
                    v.txbIDEquipo.Text = dtgDatos.CurrentRow.Cells["IdEquipo"].Value.ToString();
                    v.txbIDEquipo.Visible = false;
                    v.lblEquipo.Location = new Point(v.txbIDEquipo.Location.X, v.txbIDEquipo.Location.Y);
                    v.txbEquipo.Text = dtgDatos.CurrentRow.Cells["Equipos"].Value.ToString();
                    v.btnEquipo.Visible = false;
                    v.lblEquipo.Location = new Point(v.lblID.Location.X+110, v.lblID.Location.Y);
                    v.txbIDEquipo.Visible = false;
                    v.txbEquipo.Location = new Point(v.txbID.Location.X+110, v.txbID.Location.Y);
                    v.txbEquipo.Width = 100;
                

                string a = dtgDatos.CurrentRow.Cells["Fecha_Cierre"].Value.ToString();
                    
                    if (a.Length != 0)
                    {
                        v.dtpF_Cierre.Text = dtgDatos.CurrentRow.Cells["Fecha_Cierre"].Value.ToString();
                        HoraCierre.Value = Convert.ToDateTime(dtgDatos.CurrentRow.Cells["Fecha_Cierre"].Value.ToString());
                        v.dtpHoraCierre.Text = HoraCierre.Value.ToString("HH:mm");
                    }

                    if (v.cbbEstado.Text == "Solucionado")
                    {
                        v.cbbEstado.Enabled = false;
                        v.btnGuardar.Enabled = false;
                    }
                    v.chbF_Cierre.Checked = true;
                    
                    v.txbSolucion.Text = dtgDatos.CurrentRow.Cells["Solucion"].Value.ToString();
                    v.lblSolucion.Location = new Point(v.lblDesc.Location.X + 270, v.lblDesc.Location.Y);
                    v.txbSolucion.Location = new Point(v.txbDescripcion.Location.X + 270, v.txbDescripcion.Location.Y);

                    HoraAp.Value = Convert.ToDateTime(dtgDatos.CurrentRow.Cells["Fecha_Apertura"].Value.ToString());

                    v.dtpHoraAp.Text = HoraAp.Value.ToString("HH:mm");
                    v.OpcEmpleado = this._OpcEmp;
                    v.Rol = this._Rol;
                    
                    v.Width = 550;
                    v.Height = 362;

                    v.ShowDialog();
                    CargarDatos();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una fila válida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        void VerDetalles()
        {
            IncidenciasEdicion v = new IncidenciasEdicion();

            int x = v.btnGuardar.Location.X, xC = v.btnCancelar.Location.X;
            int y = v.btnGuardar.Location.Y, yC = v.btnCancelar.Location.Y;

            v.btnGuardar.Visible = false;
            v.btnCancelar.Location = new Point(x, y);
            v.btnBuscarCliente.Enabled = false;
            v.btnBuscarEmpleado.Enabled = false;
            v.btnBuscarTecnico.Enabled = false;
            v.btnEquipo.Enabled = false;
            v.cbbTipo.Enabled = false;
            v.cbbCriticidad.Enabled = false;
            v.cbbEstado.Enabled = false;
            v.txbDiagnostico.ReadOnly = true;
            v.txbSolucion.ReadOnly = true;
            v.dtpF_Aper.Enabled = false;
            v.dtpF_Cierre.Enabled = false;
            v.dtpHoraAp.Enabled = false;
            v.dtpHoraCierre.Enabled = false;
            v.chbF_Cierre.Checked = true;
            v.chbF_Cierre.Enabled = false;
            v.txbDescripcion.ReadOnly = true;
            v.btnEliminarCliente.Enabled = false;
            v.btnEliminarEmpleado.Enabled = false;

            v.VerDetalles = true;
            v.txbID.Text = dtgDatos.CurrentRow.Cells["IdIncidencia"].Value.ToString();
            v.txbDescripcion.Text = dtgDatos.CurrentRow.Cells["Descripcion"].Value.ToString();
            v.dtpF_Aper.Text = dtgDatos.CurrentRow.Cells["Fecha_Apertura"].Value.ToString();
            v.txbDiagnostico.Text = dtgDatos.CurrentRow.Cells["Diagnostico"].Value.ToString();
            v.txbIDEmpleado.Text = dtgDatos.CurrentRow.Cells["IdEmpleado"].Value.ToString();
            v.txbEmpleado.Text = dtgDatos.CurrentRow.Cells["Empleados"].Value.ToString();
            v.txbIdTecnico.Text = dtgDatos.CurrentRow.Cells["IdTecnico"].Value.ToString();
            v.txbTecnico.Text = dtgDatos.CurrentRow.Cells["Tecnicos"].Value.ToString();
            v.txbIDCliente.Text = dtgDatos.CurrentRow.Cells["IdCliente"].Value.ToString();
            v.txbCliente.Text = dtgDatos.CurrentRow.Cells["Clientes"].Value.ToString();
            v.txbIDEquipo.Text = dtgDatos.CurrentRow.Cells["IdEquipo"].Value.ToString();
            v.txbEquipo.Text = dtgDatos.CurrentRow.Cells["Equipos"].Value.ToString();
            string a = dtgDatos.CurrentRow.Cells["Fecha_Cierre"].Value.ToString();
            v.ID = this._ID;
            v.Rol = this._Rol;
            v.OpcEmpleado = this._OpcEmp;

            if (a.Length != 0)
            {
                v.dtpF_Cierre.Text = dtgDatos.CurrentRow.Cells["Fecha_Cierre"].Value.ToString();
                HoraCierre.Value = Convert.ToDateTime(dtgDatos.CurrentRow.Cells["Fecha_Cierre"].Value.ToString());
                v.dtpHoraCierre.Text = HoraCierre.Value.ToString("HH:mm");
            }


            v.txbSolucion.Text = dtgDatos.CurrentRow.Cells["Solucion"].Value.ToString();
            HoraAp.Value = Convert.ToDateTime(dtgDatos.CurrentRow.Cells["Fecha_Apertura"].Value.ToString());
            v.Text = "Detalles de incidencia";
            v.dtpHoraAp.Text = HoraAp.Value.ToString("HH:mm");

            if (this._OpcEmp.Equals("Cliente") || this._OpcEmp.Equals("Tecnico"))
            {

                v.lblTipo.Text = dtgDatos.CurrentRow.Cells["Tipo"].Value.ToString();
                v.lblEstado.Text = dtgDatos.CurrentRow.Cells["Estado"].Value.ToString();
                v.lblCriticidad.Text = dtgDatos.CurrentRow.Cells["Criticidad"].Value.ToString();
                v.txbDescripcion.ReadOnly = true;
                v.chbF_Cierre.Visible = false;
                v.btnEquipo.Visible = false;
                v.txbIDEquipo.Visible = false;
                v.lblEquipo.Location = new Point(313, 115);

                v.btnBuscarCliente.Visible = false;
                v.btnEliminarCliente.Visible = false;
                v.txbIDCliente.Visible = false;
                v.lblCliente.Location = new Point(315, 201);

                v.btnBuscarTecnico.Visible = false;
                v.txbIdTecnico.Visible = false;
                v.lblTecnico.Location = new Point(17, 298);

                v.btnBuscarEmpleado.Visible = false;
                v.btnEliminarEmpleado.Visible = false;
                v.txbIDEmpleado.Visible = false;
                v.lblEmpleado.Location = new Point(17, 384);

                v.lblEstado.Text = "Estado: " + dtgDatos.CurrentRow.Cells["Estado"].Value.ToString();
                v.cbbEstado.Visible = false;
                v.lblEstado.Location = new Point(560, 143);

                v.lblCriticidad.Text = "Criticidad: " + dtgDatos.CurrentRow.Cells["Criticidad"].Value.ToString();
                v.cbbCriticidad.Visible = false;
                v.lblCriticidad.Location = new Point(560, 187);

                v.lblTipo.Text = "Tipo: " + dtgDatos.CurrentRow.Cells["Tipo"].Value.ToString();
                v.cbbTipo.Visible = false;
                v.lblTipo.Location = new Point(560, 229);

                if (this._OpcEmp.Equals("Cliente"))
                {
                    v.btnCancelar.Location = new Point(xC, yC);
                    v.btnGuardar.Visible = true;
                    v.txbDescripcion.ReadOnly = false;
                }

                if (this._OpcEmp.Equals("Cliente") && dtgDatos.CurrentRow.Cells["Estado"].Value.ToString().Equals("Solucionado"))
                {
                    v.btnGuardar.Visible = false;
                    v.btnCancelar.Location = new Point(x, y);
                    v.txbDescripcion.ReadOnly = true;
                }
            }
            else
            {
                v.cbbTipo.Text = dtgDatos.CurrentRow.Cells["Tipo"].Value.ToString();
                v.cbbEstado.Text = dtgDatos.CurrentRow.Cells["Estado"].Value.ToString();
                v.cbbCriticidad.Text = dtgDatos.CurrentRow.Cells["Criticidad"].Value.ToString();
            }

            if (dtgDatos.CurrentRow.Cells["Estado"].Value.ToString() != "Solucionado")
            {
                v.dtpF_Cierre.Visible = false;
                v.lblF_CierreAMPM.Visible = false;
                v.lblHoraCierre.Visible = false;
                v.dtpHoraCierre.Visible = false;
                v.lblF_Cierre.Location = new Point(v.dtpF_Cierre.Location.X, v.dtpF_Cierre.Location.Y);
                v.lblF_Cierre.Text = "Fecha de cierre aun no establecida";
            }

            v.ShowDialog();
        }
        
        public GestionDeIncidencias()
        {
            InitializeComponent();
        }

        private void AgregarParaCliente()
        {
            IncidenciasEdicion v = new IncidenciasEdicion();

            v.lblDiagnostico.Visible = false;
            v.txbDiagnostico.Visible = false;
            v.lblSolucion.Visible = false;
            v.txbSolucion.Visible = false;
            v.lblEstado.Visible = false;
            v.cbbEstado.Visible = false;
            v.lblCriticidad.Visible = false;
            v.cbbCriticidad.Visible = false;
            v.lblTipo.Visible = false;
            v.cbbTipo.Visible = false;
            v.lblTecnico.Visible = false;
            v.txbIdTecnico.Visible = false;
            v.txbTecnico.Visible = false;
            v.btnBuscarTecnico.Visible = false;
            v.lblCliente.Visible = false;
            v.txbIDCliente.Visible = false;
            v.txbCliente.Visible = false;
            v.btnBuscarCliente.Visible = false;
            v.btnEliminarCliente.Visible = false;
            v.lblEmpleado.Visible = false;
            v.txbIDEmpleado.Visible = false;
            v.txbEmpleado.Visible = false;
            v.btnBuscarEmpleado.Visible = false;
            v.btnEliminarEmpleado.Visible = false;
            v.lblF_Cierre.Visible = false;
            v.lblHoraCierre.Visible = false;
            v.dtpF_Cierre.Visible = false;
            v.dtpHoraCierre.Visible = false;
            v.lblF_CierreAMPM.Visible = false;
            v.chbF_Cierre.Checked = true;
            v.chbF_Cierre.Visible = false;
            v.Width = 566;
            v.Height = 376;
            v.btnCancelar.Location = new Point(447, 290);
            v.btnGuardar.Location = new Point(345, 290);
            v.OpcEmpleado = this._OpcEmp;
            v.ID = this._ID;
            v.Rol = this._Rol;
            v.ShowDialog();

        }

        private void Agregar()
        {
            IncidenciasEdicion v = new IncidenciasEdicion();
            v.OpcEmpleado = this._OpcEmp;
            v.Rol = this._Rol;
            v.ID = this._ID;

            if (this._Rol != "Administrador")
            {
                v.lblEmpleado.Visible = false;
                v.btnBuscarEmpleado.Visible = false;
                v.btnEliminarEmpleado.Visible = false;
                v.txbIDEmpleado.Visible = false;
                v.txbEmpleado.Visible = false;
                
            }

            v.ShowDialog();
        }

        private void DeshabilitarControles()
        {
            switch (this.OpcEmp)
            {
                case "Cliente":
                    {
                        btnEditar.Visible = false;
                        toolStripSeparator3.Visible = false;
                        btnEliminar.Visible = false;
                        toolStripSeparator4.Visible = false;
                    }
                    break;

                case "Tecnico":
                    {
                        btnAgregar.Visible = false;
                        toolStripSeparator1.Visible = false;
                        btnEliminar.Visible = false;
                        toolStripSeparator4.Visible = false;
                    }
                    break;
            }
        }

        private void OcultarColumnas()
        {
            switch (this.OpcEmp)
            {
                case "Cliente":
                    {
                        dtgDatos.Columns["Diagnostico"].Visible = false;
                        dtgDatos.Columns["Tipo"].Visible = false;
                        dtgDatos.Columns["Criticidad"].Visible = false;
                        dtgDatos.Columns["Fecha_Cierre"].Visible = false;
                        dtgDatos.Columns["Solucion"].Visible = false;
                        dtgDatos.Columns["Empleados"].Visible = false;
                        dtgDatos.Columns["Tecnicos"].Visible = false;
                        
                    }
                    break;

                case "Tecnico":
                    {
                        dtgDatos.Columns["Diagnostico"].Visible = false;
                        dtgDatos.Columns["Tipo"].Visible = false;
                        dtgDatos.Columns["Fecha_Cierre"].Visible = false;
                        dtgDatos.Columns["Solucion"].Visible = false;
                        dtgDatos.Columns["Empleados"].Visible = false;
                        dtgDatos.Columns["Clientes"].Visible = false;

                    }
                    break;
            }
        }

        private void CargarDatos()
        {
            try
            {
                switch (this._OpcEmp)
                {
                    case "Empleado":
                        {
                                _DATOS.DataSource = DataSource.Consultas.TODAS_LAS_INCIDENCIAS();
                        }
                        break;

                    case "Cliente":
                        {
                            _DATOS.DataSource = DataSource.Consultas.TODAS_LAS_INCIDENCIAS_POR_CLIENTE(this.ID);
                        }
                        break;

                    case "Tecnico":
                        {
                            _DATOS.DataSource = DataSource.Consultas.TODAS_LAS_INCIDENCIAS_POR_TECNICO(this.ID);
                        }
                        break;
                }

                if (cbbFiltroEstado.Text != "Todos")
                {
                    FiltrarEstado();
                }
                else
                {
                    Filtrar();
                }
                
            }
            catch (Exception)
            {

            }
        }
        

        private void Filtrar()
        {
            try
            {
                switch (this._OpcEmp)
                {
                    case "Empleado":
                        {
                            if (txbFiltro.TextLength > 0)
                            {
                                _DATOS.Filter = "Criticidad LIKE '%" + txbFiltro.Text + "%' OR Estado LIKE '%" + txbFiltro.Text + @"%' 
                                                 OR Tipo LIKE '%" + txbFiltro.Text + "%' OR Empleados LIKE '%" + txbFiltro.Text + @"%' 
                                                 OR Tecnicos LIKE '%" + txbFiltro.Text + "%' OR Clientes LIKE '%" + txbFiltro.Text + @"%' 
                                                 OR Equipos LIKE '%" + txbFiltro.Text + "%'";
                            }
                            else
                            {
                                _DATOS.RemoveFilter();
                            }

                            dtgDatos.AutoGenerateColumns = false;
                            dtgDatos.DataSource = _DATOS;

                        }
                        break;

                    case "Cliente":
                        {
                            if (txbFiltro.TextLength > 0)
                            {
                                _DATOS.Filter = "Descripcion LIKE '%" + txbFiltro.Text + "%' OR Estado LIKE '%" + txbFiltro.Text + "%'";
                            }
                            else
                            {
                                _DATOS.RemoveFilter();
                            }

                            dtgDatos.AutoGenerateColumns = false;
                            dtgDatos.DataSource = _DATOS;
                        }
                        break;

                    case "Tecnico":
                        {
                            if (txbFiltro.TextLength > 0)
                            {
                                _DATOS.Filter = "Descripcion LIKE '%" + txbFiltro.Text + "%' OR Estado LIKE '%" + txbFiltro.Text + "%'";
                            }
                            else
                            {
                                _DATOS.RemoveFilter();
                            }

                            dtgDatos.AutoGenerateColumns = false;
                            dtgDatos.DataSource = _DATOS;
                        }
                        break;
                }

                lblRegistros.Text = dtgDatos.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }
        
        private void FiltrarEstado()
        {
            try
            {
                if (cbbFiltroEstado.Text.Length > 0)
                {
                    _DATOS.Filter = "Estado LIKE '%" + cbbFiltroEstado.Text + "%'";
                }
                else
                {
                    _DATOS.RemoveFilter();
                }

                dtgDatos.AutoGenerateColumns = false;
                dtgDatos.DataSource = _DATOS;

                lblRegistros.Text = dtgDatos.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            

            switch (this.OpcEmp)
            {
                case "Empleado":
                    {
                        Agregar();
                    }
                    break;

                case "Cliente":
                    {
                        AgregarParaCliente();                        
                    }
                    break;

                case "Tecnico":
                    {
                    }
                    break;
            }

            CargarDatos();

        }

        private void GestionDeIncidencias_Load(object sender, EventArgs e)
        {
            cbbFiltroEstado.SelectedItem = "Pendiente";
            CargarDatos();
            DeshabilitarControles();
            OcultarColumnas();

        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            cbbFiltroEstado.Text = "Todos";
            Filtrar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro de ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLS.Incidencia idc = new CLS.Incidencia();
                    idc.IDIncidencia = dtgDatos.CurrentRow.Cells["IdIncidencia"].Value.ToString();

                    if (idc.Eliminar())
                    {
                        MessageBox.Show("Registro eliminado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("El registro no fue eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception)
            {
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            switch (this._OpcEmp)
            {
                case "Empleado":
                    { 
                        EditarParaEmp();
                        
                    }
                    break;

                case "Tecnico":
                    {
                        EditarParaTec();
                    }
                    break;
            }
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            VerDetalles();
        }

        private void cbbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbFiltroEstado.Text != "Todos")
            {
                FiltrarEstado();
            }
            else
            {
                Filtrar();
            }
        }


        
    }
}
