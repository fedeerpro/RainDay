using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoDSII.GUI
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Tiempo.Stop();
            Close();
        }

        private void splash_Load(object sender, EventArgs e)
        {
            Tiempo.Start();
        }
    }
}
