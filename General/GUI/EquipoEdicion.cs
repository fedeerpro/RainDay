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
    public partial class EquipoEdicion : Form
    {
        String _PC;
        
        public string PC
        {
            get
            {
                return _PC;
            }

            set
            {
                _PC = value;
            }
        }
        
        public EquipoEdicion()
        {
            InitializeComponent();
        }

        String ObtenerEquipoPC(String PC)
        {
            String Temp="", NewName ="";
            Char[] Cad = PC.ToCharArray();
            int cont = Cad.Length;
            double Cod = -5;

            if (PC.Equals("VACIO"))
            {
                NewName = "PC-001";
            }
            else
            {
                for (int i = 3; i < Cad.Length; i++)
                {
                    Temp += Cad[i].ToString();
                }


                Cod = double.Parse(Temp);
                Cod++;

                if (Cod > 0 && Cod < 10)
                {
                    NewName = "PC-00" + Cod.ToString();
                }
                else if (Cod >= 10 && Cod < 100)
                {
                    NewName = "PC-0" + Cod.ToString();
                }
                else if (Cod >= 100)
                {
                    NewName = "PC-" + Cod.ToString();
                }
            }

            return NewName;

        }
        
        private bool Validar()
        {
            bool Valido = true;

            Not.Clear();
            if (txbDetalles.TextLength == 0)
            {
                Not.SetError(txbDetalles, "Escriba los detalles del equipo");
                Valido = false;
            }

            if (txbDetalles.TextLength < 100)
            {
                Not.SetError(txbDetalles,"Este campo no puede llevar menos de 100 caracteres");
                Valido = false;
            }
            return Valido;
        }

        private void Procesar()
        {

            try
            {
                CLS.Equipos Eq = new CLS.Equipos();
                Eq.Detalles = txbDetalles.Text;

                if (Validar())
                {

                    if (txbID.TextLength > 0)
                    {
                        //Edicion
                        Eq.IDEquipo = txbID.Text;

                        if (Eq.Actualizar())
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

                        Eq.Equipo = ObtenerEquipoPC(this._PC);

                        if (Eq.Agregar())
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
            catch (Exception)
            {

            }
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
