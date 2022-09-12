using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoDSII.CLS
{
    class AppManager:ApplicationContext
    {
        public Boolean Splash()
        {
            Boolean _Resultado = true;
            GUI.splash f = new GUI.splash();
            f.ShowDialog();
            return _Resultado;
        }
        public Boolean Login()
        {
            Boolean _Resultado = false;
            GUI.login f = new GUI.login();
            f.ShowDialog();
            _Resultado = f.Autorizado;
            return _Resultado;
        }
        public AppManager()
        {
            if (Splash())
            {
                if (Login())
                {
                    GUI.Principal f = new GUI.Principal();
                    f.ShowDialog();
                    Environment.Exit(0);

                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }

    }
}
