using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace registro.Modelo
{
    class DBConnect
    {
        private MySqlConnection connection;
        private String server;
        private String database;
        private String uid;
        private String pass;

        public DBConnect()
        {
            Initialize();
        }

        #region Inicia parametros para conexión
        private void Initialize()
        {
            server = "localhost";
            database = "infolab";
            uid = "root";
            pass = "root";

            String conect = "SERVER=" + server + ";" + "DATABASE=" + database +
                ";" + "UID=" + uid + ";" + "PASSWORD=" + pass + ";";
            connection = new MySqlConnection(conect);
        }
        #endregion

        #region Abrir conexión
        private bool openConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException er)
            {
                switch (er.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server ... ");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again!!!");
                        break;
                }
                return false;
            }
        }
        #endregion

        #region Cerrar la conexión
        private bool closeConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion

        public bool insertEstudiante(LinkedList<Modelo.Estudiante> listae)
        {
            bool insert = false;
            String sql;
            if (this.openConnection())
            {
                foreach (var value in listae)
                {
                    sql = "INSERT INTO estudiante (idestudiante, nombre1Estudiante, nombre2Estudiante, apellido1Estudiante, apellido2Estudiante, codigoEstudiante, carreraEstudiante)" +
                        " VALUES ('" + value.getIdestudiante() + "', '" + value.getNombre1Estudiante() + "', '" +
                        value.getNombre2Estudiante() + "', '" + value.getApellido1Estudiante() + "', '" + value.getApellido2Estudiante() + "', '" +
                        value.getCodigoEstudiante() + "', '" + value.getCarreraEstudiante() + "')";

                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.ExecuteNonQuery();


                    insert = true;

                }
            }
            this.closeConnection();

            return insert;
        }

        public bool insertCategoria(Modelo.Categoria c)
        {
            bool insert = false;
            if (this.openConnection())
            {
                string sql = "INSERT INTO categorias (nombreCategoria) value('" + c.getCategoria() + "')";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                this.closeConnection();
                insert = true;
            }
            return insert;
        }
    }
}