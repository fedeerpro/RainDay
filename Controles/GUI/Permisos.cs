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
    public partial class Permisos : Form
    {
        BindingSource _DATOS = new BindingSource();
        private void Cargar()
        {
            try
            {
                _DATOS.DataSource = DataSource.Consultas.PERMISOS_DE_UN_ROL(cbbRol.SelectedValue.ToString());
                dtgDatos.DataSource=_DATOS;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void LlenarRoles()
        {
            try
            {
                cbbRol.DataSource = DataSource.Consultas.TODOS_LOS_ROLES();
                cbbRol.DisplayMember = "Rol";
                cbbRol.ValueMember = "IDRol";
                Cargar();
            }
            catch (Exception)
            {

            }
        }
        public Permisos()
        {
            InitializeComponent();
            LlenarRoles();
        }

        private void cbbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cargar();
        }

        private void dtgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 3)
                {
                    String Valor;
                    CLS.Permisos oPermiso = new CLS.Permisos();
                    oPermiso.IDOpcion = dtgDatos.CurrentRow.Cells["IDOpcion"].Value.ToString();
                    oPermiso.IDRol = cbbRol.SelectedValue.ToString();
                    Valor = dtgDatos.CurrentRow.Cells["Asignado"].Value.ToString();
                    if (Valor.Equals("1"))
                    {
                        oPermiso.IDPermiso = dtgDatos.CurrentRow.Cells["IDPermiso"].Value.ToString();
                        oPermiso.Eliminar();
                    }
                    else
                    {
                        oPermiso.IDOpcion = dtgDatos.CurrentRow.Cells["IDOpcion"].Value.ToString();
                        oPermiso.IDRol = cbbRol.SelectedValue.ToString();
                        oPermiso.Agregar();
                    }
                    Cargar();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
