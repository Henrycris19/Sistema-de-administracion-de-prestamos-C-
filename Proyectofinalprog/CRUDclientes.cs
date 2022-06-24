using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Proyectofinalprog
{
    class CRUDclientes : HerenciaCLIENTES
    {
        string  cedulax;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8MNDSMG\\SQLEXPRESS;Initial Catalog=proyectoprog;Integrated Security=True");
        SqlConnection conn2 = new SqlConnection("Data Source=DESKTOP-8MNDSMG\\SQLEXPRESS;Initial Catalog=proyectoprog;Integrated Security=True");
        SqlCommand comando;
        SqlCommand comando2;

        
        public void GuardarCl()
        {
            try
            {
                conn.Open();
                comando = new SqlCommand($"insert into Clientes values('{cedula}', '{nombre}', '{correo}', '{direccion}', '{telefono}')", conn);
                comando.ExecuteNonQuery();
                conn.Close();
                System.Windows.Forms.MessageBox.Show("Guardado exitoso!");
            }
            catch (Exception error)
            {
                System.Windows.Forms.MessageBox.Show(error.Message);

            }

        }
       
        public DataTable MostrarCl()
        {

            conn2.Open();
            comando = new SqlCommand($"SELECT * FROM Clientes order by IdCliente ASC", conn2);
            comando.ExecuteNonQuery();
            DataTable Tabla = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(Tabla);

            conn2.Close();
            return Tabla;

        }

        public DataTable BuscarClN()
        {
            conn.Open();
            comando = new SqlCommand($"SELECT * FROM Clientes WHERE Nombre = '{nombre}' order by IdCliente ASC", conn);
            comando.ExecuteNonQuery();
            DataTable Tabla = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(Tabla);

            conn.Close();
            return Tabla;

        }

        public void ActualizarCl()
        {
            try
            {
                conn.Open();
                comando2 = new SqlCommand($"SELECT Cedula FROM Clientes WHERE Cedula = '{x}' ", conn);

                SqlDataReader registro = comando2.ExecuteReader();
                if (registro.Read())
                {
                    cedulax = registro["Cedula"].ToString();

                    conn.Close();
                    if (cedulax == x)
                    {
                        conn.Open();
                        comando = new SqlCommand($"UPDATE Clientes SET Cedula = '{cedula}', Nombre = '{nombre}', CorreoElectronico = '{correo}', Direccion='{direccion}', Telefono = '{telefono}' WHERE Cedula = '{cedulax}' ", conn);
                        comando.ExecuteNonQuery();
                        conn.Close();
                        System.Windows.Forms.MessageBox.Show("Actualizado exitoso!");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("No existen los datos indicados en la base de datos.");
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("No existen los datos indicados en la base de datos.");
                }

            }
            catch (Exception error)
            {
                System.Windows.Forms.MessageBox.Show(error.Message);
            }
        }


        public DataTable BuscarClC()
        {
            conn.Open();
            comando = new SqlCommand($"SELECT * FROM Clientes WHERE Cedula = '{cedula}' order by IdCliente ASC", conn);
            comando.ExecuteNonQuery();
            DataTable Tabla = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(Tabla);

            conn.Close();
            return Tabla;

        }

        public DataTable BuscarClCor()
        {
            conn.Open();
            comando = new SqlCommand($"SELECT * FROM Clientes WHERE CorreoElectronico = '{correo}'", conn);
            comando.ExecuteNonQuery();
            DataTable Tabla = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(Tabla);

            conn.Close();
            return Tabla;

        }

        public void BorrarClC()
        {

            conn.Open();
            comando2 = new SqlCommand($"SELECT Cedula FROM Clientes WHERE Cedula = '{x}'", conn);
            SqlDataReader registro = comando2.ExecuteReader();
            if (registro.Read())
            {
                cedulax = registro["Cedula"].ToString();
                conn.Close();
                if (cedulax == x)
                {
                    conn.Open();
                    comando = new SqlCommand($"DELETE FROM Clientes WHERE Cedula = '{x}'", conn);
                    comando.ExecuteNonQuery();
                    conn.Close();
                    System.Windows.Forms.MessageBox.Show("Datos eliminados correctamente.");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("El nombre indicado no existe entre los datos de Clientes almacenados.");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("El nombre indicado no existe entre los datos de Clientes almacenados.");
            }
        }

       
    }
}
