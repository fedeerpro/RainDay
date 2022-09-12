using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Xml;
using System.IO;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace DataManager
{
    public class DBOperacion : DBConexion {
        String _server, _Port, _Database, _Uid, _Pwd;
        String current = Directory.GetCurrentDirectory();
        DataTable _DATOS = new DataTable();
        RSACryptoServiceProvider _rsa;
        readonly CspParameters _cspp = new CspParameters();
        const string KeyName = "Key01";


        private void InicializarTabla()
        {
            _DATOS.TableName = "DatosConexion";
            _DATOS.Columns.Add("Usuario");
            _DATOS.Columns.Add("Clave");
            _DATOS.Columns.Add("Puerto");
            _DATOS.Columns.Add("BaseDeDatos");
            _DATOS.Columns.Add("Servidor");

        }

        private void LeerDatos()
        {
            try
            {
                InicializarTabla();
                _DATOS.ReadXml("DatosDeConexion.xml");
                Uid = _DATOS.Rows[0]["Usuario"].ToString();
                Pwd = _DATOS.Rows[0]["Clave"].ToString();
                Port = _DATOS.Rows[0]["Puerto"].ToString();
                Database = _DATOS.Rows[0]["BaseDeDatos"].ToString();
                Server = _DATOS.Rows[0]["Servidor"].ToString();

            }
            catch (Exception)
            {

            }
        }

        public string Server
        {
            get
            {
                return _server;
            }

            set
            {
                _server = value;
            }
        }

        public string Port
        {
            get
            {
                return _Port;
            }

            set
            {
                _Port = value;
            }
        }

        public string Database
        {
            get
            {
                return _Database;
            }

            set
            {
                _Database = value;
            }
        }

        public string Uid
        {
            get
            {
                return _Uid;
            }

            set
            {
                _Uid = value;
            }
        }

        public string Pwd
        {
            get
            {
                return _Pwd;
            }

            set
            {
                _Pwd = value;
            }
        }

        private void DecryptFile(FileInfo file)
        {
            // Create instance of Aes for
            // symmetric decryption of the data.
            Aes aes = Aes.Create();

            // Create byte arrays to get the length of
            // the encrypted key and IV.
            // These values were stored as 4 bytes each
            // at the beginning of the encrypted package.
            byte[] LenK = new byte[4];
            byte[] LenIV = new byte[4];

            // Construct the file name for the decrypted file.
            string outFile =
                Path.ChangeExtension(file.FullName.Replace("Encrypt", "Decrypt"), ".xml");

            // Use FileStream objects to read the encrypted
            // file (inFs) and save the decrypted file (outFs).
            using (var inFs = new FileStream(file.FullName, FileMode.Open))
            {
                inFs.Seek(0, SeekOrigin.Begin);
                inFs.Read(LenK, 0, 3);
                inFs.Seek(4, SeekOrigin.Begin);
                inFs.Read(LenIV, 0, 3);

                // Convert the lengths to integer values.
                int lenK = BitConverter.ToInt32(LenK, 0);
                int lenIV = BitConverter.ToInt32(LenIV, 0);

                // Determine the start postition of
                // the ciphter text (startC)
                // and its length(lenC).
                int startC = lenK + lenIV + 8;
                int lenC = (int)inFs.Length - startC;

                // Create the byte arrays for
                // the encrypted Aes key,
                // the IV, and the cipher text.
                byte[] KeyEncrypted = new byte[lenK];
                byte[] IV = new byte[lenIV];

                // Extract the key and IV
                // starting from index 8
                // after the length values.
                inFs.Seek(8, SeekOrigin.Begin);
                inFs.Read(KeyEncrypted, 0, lenK);
                inFs.Seek(8 + lenK, SeekOrigin.Begin);
                inFs.Read(IV, 0, lenIV);

                Directory.CreateDirectory(current);
                // Use RSACryptoServiceProvider
                // to decrypt the AES key.
                byte[] KeyDecrypted = _rsa.Decrypt(KeyEncrypted, false);

                // Decrypt the key.
                ICryptoTransform transform = aes.CreateDecryptor(KeyDecrypted, IV);

                // Decrypt the cipher text from
                // from the FileSteam of the encrypted
                // file (inFs) into the FileStream
                // for the decrypted file (outFs).
                using (var outFs = new FileStream(outFile, FileMode.Create))
                {
                    int count = 0;
                    int offset = 0;

                    // blockSizeBytes can be any arbitrary size.
                    int blockSizeBytes = aes.BlockSize / 8;
                    byte[] data = new byte[blockSizeBytes];

                    // By decrypting a chunk a time,
                    // you can save memory and
                    // accommodate large files.

                    // Start at the beginning
                    // of the cipher text.
                    inFs.Seek(startC, SeekOrigin.Begin);
                    using (var outStreamDecrypted =
                        new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                    {
                        do
                        {
                            count = inFs.Read(data, 0, blockSizeBytes);
                            offset += count;
                            outStreamDecrypted.Write(data, 0, count);
                        } while (count > 0);

                        outStreamDecrypted.FlushFinalBlock();
                    }
                }
            }
        }

        public Int32 Insertar(String pSentencia)
        {
            return EjecutarSentencia(pSentencia);
        }

        public Int32 Actualizar(String pSentencia)
        {
            return EjecutarSentencia(pSentencia);
        }

        public Int32 Eliminar(String pSentencia)
        {
            return EjecutarSentencia(pSentencia);
        }
 
        private Int32 EjecutarSentencia(String pSentencia)
        {
            string path2 = current + "/DatosDeConexion.txt";
            _cspp.KeyContainerName = KeyName;
            _rsa = new RSACryptoServiceProvider(_cspp)
            {
                PersistKeyInCsp = true
            };
            if (_rsa == null)
            {
            }
            else
            {
                string fName = path2;
                if (fName != null)
                {
                    DecryptFile(new FileInfo(fName));
                }
            }
            String path = current + "/DatosDeConexion.xml";
            if (File.Exists(path))
            {
                LeerDatos();
                File.Delete(path);

            }

            MySqlCommand Comando = new MySqlCommand();
            Int32 FilasAfectadas = 0;
            try
            {
                if (base.Conectar(_server, _Port, _Database, _Uid, _Pwd))
                {
                    Comando.Connection = base._CONEXION;
                    Comando.CommandType = System.Data.CommandType.Text;
                    Comando.CommandText = pSentencia;
                    FilasAfectadas=Comando.ExecuteNonQuery();
                    base.Desconectar();
                }
            }
            catch (Exception)
            {
                FilasAfectadas = -1;
            }
            return FilasAfectadas;
        }

        public DataTable Consultar(String pConsulta)
        {
            string path2 = current + "/DatosDeConexion.txt";
            _cspp.KeyContainerName = KeyName;
            _rsa = new RSACryptoServiceProvider(_cspp)
            {
                PersistKeyInCsp = true
            };
            if (_rsa == null)
            {
            }
            else
            {
                string fName = path2;
                if (fName != null)
                {
                    DecryptFile(new FileInfo(fName));
                }
            }
            String path = current + "/DatosDeConexion.xml";
            if (File.Exists(path))
            {
                LeerDatos();
                File.Delete(path);

            }

            MySqlCommand Comando = new MySqlCommand();
            MySqlDataAdapter Adaptador = new MySqlDataAdapter();
            DataTable Resultado = new DataTable();
            try
            {
                if (base.Conectar(_server, _Port, _Database, _Uid, _Pwd))
                {
                    Comando.Connection = base._CONEXION;
                    Comando.CommandType = System.Data.CommandType.Text;
                    Comando.CommandText = pConsulta;
                    Adaptador.SelectCommand = Comando;
                    Adaptador.Fill(Resultado);
                    base.Desconectar();
                }
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }
    }
}
