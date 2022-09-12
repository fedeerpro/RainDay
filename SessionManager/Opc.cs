using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SessionManager
{
    public sealed class Opc
    {
        private static Opc instance = null;
        private static readonly object padlock = new object();

        String _Opcion;

        public string Opcion
        {
            get
            {
                return _Opcion;
            }

            set
            {
                _Opcion = value;
            }
        }

        public static Opc Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Opc();
                        }
                    }
                }
                return instance;
            }
        }

        private Opc()
        { }
    }
}
