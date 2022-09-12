using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoDSII.GUI
{
    public partial class DatosConexion : Form
    {
        String current = Directory.GetCurrentDirectory();
        DataTable _DATOS = new DataTable();
        RSACryptoServiceProvider _rsa;
        readonly CspParameters _cspp = new CspParameters();
        const string KeyName = "Key01";
        string path1 = Directory.GetCurrentDirectory() + "/DatosDeConexion.xml";

        private void InicializarTabla()
        {
            _DATOS.TableName = "DatosConexion";
            _DATOS.Columns.Add("Usuario");
            _DATOS.Columns.Add("Clave");
            _DATOS.Columns.Add("Puerto");
            _DATOS.Columns.Add("BaseDeDatos");
            _DATOS.Columns.Add("Servidor");

        }

        private void CargarDatos()
        {
            try
            {
                _DATOS.ReadXml("DatosDeConexion.xml");
            }
            catch (Exception)
            {

            }
        }
        private void EncryptFile(FileInfo file)
        {
            // Create instance of Aes for
            // symmetric encryption of the data.
            Aes aes = Aes.Create();
            ICryptoTransform transform = aes.CreateEncryptor();

            // Use RSACryptoServiceProvider to
            // encrypt the AES key.
            // rsa is previously instantiated:
            //    rsa = new RSACryptoServiceProvider(cspp);
            byte[] keyEncrypted = _rsa.Encrypt(aes.Key, false);

            // Create byte arrays to contain
            // the length values of the key and IV.
            int lKey = keyEncrypted.Length;
            byte[] LenK = BitConverter.GetBytes(lKey);
            int lIV = aes.IV.Length;
            byte[] LenIV = BitConverter.GetBytes(lIV);

            // Write the following to the FileStream
            // for the encrypted file (outFs):
            // - length of the key
            // - length of the IV
            // - ecrypted key
            // - the IV
            // - the encrypted cipher content

            // Se cambia la extension del archivo a ".txt" para no confundir a la hora de descifrar
            string outFile =
                Path.Combine(Directory.GetCurrentDirectory(), Path.ChangeExtension(file.Name, ".txt"));

            using (var outFs = new FileStream(outFile, FileMode.Create))
            {
                outFs.Write(LenK, 0, 4);
                outFs.Write(LenIV, 0, 4);
                outFs.Write(keyEncrypted, 0, lKey);
                outFs.Write(aes.IV, 0, lIV);

                // Now write the cipher text using
                // a CryptoStream for encrypting.
                using (var outStreamEncrypted =
                    new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                {
                    // By encrypting a chunk at
                    // a time, you can save memory
                    // and accommodate large files.
                    int count = 0;
                    int offset = 0;

                    // blockSizeBytes can be any arbitrary size.
                    int blockSizeBytes = aes.BlockSize / 8;
                    byte[] data = new byte[blockSizeBytes];
                    int bytesRead = 0;

                    using (var inFs = new FileStream(file.FullName, FileMode.Open))
                    {
                        do
                        {
                            count = inFs.Read(data, 0, blockSizeBytes);
                            offset += count;
                            outStreamEncrypted.Write(data, 0, count);
                            bytesRead += blockSizeBytes;
                        } while (count > 0);
                    }
                    outStreamEncrypted.FlushFinalBlock();
                }
            }
        }

        private bool Guardar()
        {
            bool Res = false;

            try
            {
                _DATOS.WriteXml("DatosDeConexion.xml");
                Res = true;
            }
            catch (Exception)
            {
                Res = false;
            }

            return Res;
        }

        public DatosConexion()
        {
            InitializeComponent();
            InicializarTabla();
        }

        private void chbMostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            String pass = txbClave.Text;
            txbClave.UseSystemPasswordChar = chbMostrarPass.Checked;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DatosConexion_Load(object sender, EventArgs e)
        {
            string path2 = current + "/DatosDeConexion.txt";
            
            CargarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            CargarDatos();
            if (File.Exists(Directory.GetCurrentDirectory()+"DatosDeConexion.txt"))
            {
                DataRow NuevaFila = _DATOS.NewRow();
                NuevaFila["Usuario"] = txbUsuario.Text;
                NuevaFila["Clave"] = txbClave.Text;
                NuevaFila["Puerto"] = txbPuerto.Text;
                NuevaFila["BaseDeDatos"] = txbBD.Text;
                NuevaFila["Servidor"] = txbServer.Text;
                _DATOS.Rows.Add(NuevaFila);


                if (Guardar())
                {
                    MessageBox.Show("¡Guardado con exito! ✔", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbUsuario.Clear();
                    txbClave.Clear();
                    txbPuerto.Clear();
                    txbBD.Clear();
                    txbServer.Clear();
                    _cspp.KeyContainerName = KeyName;
                    _rsa = new RSACryptoServiceProvider(_cspp)
                    {
                        PersistKeyInCsp = true
                    };

                    if (_rsa == null)
                    {
                        MessageBox.Show("Key not set.");
                    }
                    else
                    {
                        string fName = path1;
                        if (fName != null)
                        {
                            // Pasar el nombre del archivo con la ruta
                            EncryptFile(new FileInfo(fName));
                            File.Delete(path1);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (MessageBox.Show("Existen datos de conexion actualmente, ¿Está seguro de REEMPLAZARLOS?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _DATOS.Clear();
                    DataRow NuevaFila = _DATOS.NewRow();
                    NuevaFila["Usuario"] = txbUsuario.Text;
                    NuevaFila["Clave"] = txbClave.Text;
                    NuevaFila["Puerto"] = txbPuerto.Text;
                    NuevaFila["BaseDeDatos"] = txbBD.Text;
                    NuevaFila["Servidor"] = txbServer.Text;
                    _DATOS.Rows.Add(NuevaFila);
                    _DATOS.Rows[0]["Usuario"] = txbUsuario.Text;
                    _DATOS.Rows[0]["Clave"] = txbClave.Text;
                    _DATOS.Rows[0]["Puerto"] = txbPuerto.Text;
                    _DATOS.Rows[0]["BaseDeDatos"] = txbBD.Text;
                    _DATOS.Rows[0]["Servidor"] = txbServer.Text;


                    if (Guardar())
                    {
                        MessageBox.Show("¡Guardado con exito! ✔", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txbUsuario.Clear();
                        txbClave.Clear();
                        txbPuerto.Clear();
                        txbBD.Clear();
                        txbServer.Clear();
                        _cspp.KeyContainerName = KeyName;
                        _rsa = new RSACryptoServiceProvider(_cspp)
                        {
                            PersistKeyInCsp = true
                        };

                        if (_rsa == null)
                        {
                            MessageBox.Show("Key not set.");
                        }
                        else
                        {
                            string fName = path1;
                            if (fName != null)
                            {
                                // Pasar el nombre del archivo con la ruta
                                EncryptFile(new FileInfo(fName));
                                File.Delete(path1);

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
            Close();
        }

    }
}
