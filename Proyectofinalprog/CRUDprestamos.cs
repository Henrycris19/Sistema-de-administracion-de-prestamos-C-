using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Proyectofinalprog
{

    class CRUDprestamos : C_UD
    {
        string cedulax ,IDx;
        int id;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8MNDSMG\\SQLEXPRESS;Initial Catalog=proyectoprog;Integrated Security=True");
        SqlConnection conn2 = new SqlConnection("Data Source=DESKTOP-8MNDSMG\\SQLEXPRESS;Initial Catalog=proyectoprog;Integrated Security=True");
        SqlConnection conn3 = new SqlConnection("Data Source=DESKTOP-8MNDSMG\\SQLEXPRESS;Initial Catalog=proyectoprog;Integrated Security=True");
        SqlCommand comando;
        SqlCommand comando2;

        public string cedulaP { get; set; }
        public string fecha { get; set; }
        public string monto { get; set; }
        public string cuotas { get; set; }
        public string cedulaCl { get; set; }
        public string y { get; set; }

        public DataTable BuscarClC_P()
        {
            conn.Open();
            comando = new SqlCommand($"SELECT Nombre, Cedula FROM Clientes WHERE Cedula LIKE '{cedulaP}%' order by IdCliente ASC", conn);
            comando.ExecuteNonQuery();
            DataTable Tabla = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(Tabla);

            conn.Close();
            return Tabla;
        }

        public override void Guardar()
        {
            
            try
            {
                conn.Open();
                comando = new SqlCommand($"insert into Prestamos values('{fecha}', {monto}, '{cedulaCl}', {cuotas})", conn);
                comando.ExecuteNonQuery();
                conn.Close();
                System.Windows.Forms.MessageBox.Show("Guardado exitoso!");
                movimientos();
            }
            catch (Exception error)
            {
                System.Windows.Forms.MessageBox.Show(error.Message);

            }

        }
        public int prestamoid(int x)
        {

            conn3.Open();
            string query = "select ISNULL(MAX(IdPrestamo), 0) from Prestamos";
            SqlCommand command = new SqlCommand(query, conn3);
            int z = Convert.ToInt32(command.ExecuteScalar());
            conn3.Close();
            return z;

        }
        public void movimientos()
        {
            int x = 0;
            try
            {
                conn2.Open();
                comando2 = new SqlCommand($"insert into MovientosPrestamos values({prestamoid(x)},{monto})", conn2);
                comando2.ExecuteNonQuery();

                conn2.Close();

            }
            catch (Exception error)
            {
                System.Windows.Forms.MessageBox.Show(error.Message);

            }
        }

        

        public override void Actualizar()
        {
            try
            {
                conn.Open();
                comando2 = new SqlCommand($"SELECT IdPrestamo FROM Prestamos WHERE IdPrestamo = '{y}' ", conn);

                SqlDataReader registro = comando2.ExecuteReader();
                if (registro.Read())
                {
                    IDx = registro["IdPrestamo"].ToString();
                    
                    conn.Close();
                    if (IDx == y)
                    {
                        conn.Open();
                        comando = new SqlCommand($"UPDATE Prestamos SET MontoPrestamo = {monto}, Cuotas = {cuotas} WHERE IdPrestamo = '{IDx}' ", conn);
                        comando.ExecuteNonQuery();
                        conn.Close();
                        System.Windows.Forms.MessageBox.Show("Actualizado exitoso!");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Los datos no se encuentran registrados.");
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Los datos no se encuentran registrados.");
                }
            }
            catch (Exception error)
            {
                System.Windows.Forms.MessageBox.Show(error.Message);
            }
        }

        public override void Borrar()
        {
            conn.Open();
            comando = new SqlCommand($"DELETE FROM MovientosPrestamos WHERE IdPrestamos = '{y}'", conn);
            comando.ExecuteNonQuery();
            conn.Close();
            conn.Open();
            comando2 = new SqlCommand($"SELECT IdPrestamo FROM Prestamos WHERE IdPrestamo = '{y}'", conn);
            SqlDataReader registro = comando2.ExecuteReader();
            if (registro.Read())
            {
                IDx = registro["IdPrestamo"].ToString();
                conn.Close();
                if (IDx == y)
                {
                    conn.Open();
                    comando = new SqlCommand($"DELETE FROM Prestamos WHERE IdPrestamo = '{y}'", conn);
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

        public void comprobar()
        {

        }

        public DataTable MostrarClP()
        {

            conn2.Open();
            comando = new SqlCommand($"SELECT Nombre, Cedula FROM Clientes order by Nombre ASC", conn2);
            comando.ExecuteNonQuery();
            DataTable Tabla2 = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(Tabla2);

            conn2.Close();
            return Tabla2;

        }
        public DataTable MostrarP()
        {

            conn2.Open();
            comando = new SqlCommand($"SELECT * FROM Prestamos order by IdPrestamo ASC", conn2);
            comando.ExecuteNonQuery();
            DataTable Tabla3 = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(Tabla3);

            conn2.Close();
            return Tabla3;

        }

        public DataTable BuscarPF()
        {
            conn.Open();
            comando = new SqlCommand($"SELECT * FROM Prestamos WHERE Fecha LIKE '{y}%' order by IdPrestamo ASC", conn);
            comando.ExecuteNonQuery();
            DataTable Tabla = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(Tabla);

            conn.Close();
            return Tabla;

        }

        public DataTable BuscarPC()
        {
            conn.Open();
            comando = new SqlCommand($"SELECT * FROM Prestamos WHERE Cedula LIKE '{y}%' order by IdPrestamo ASC", conn);
            comando.ExecuteNonQuery();
            DataTable Tabla = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(Tabla);

            conn.Close();
            return Tabla;

        }
        public DataTable BuscarPID()
        {
            conn.Open();
            comando = new SqlCommand($"SELECT * FROM Prestamos WHERE IdPrestamo LIKE '{y}%' order by IdPrestamo ASC", conn);
            comando.ExecuteNonQuery();
            DataTable Tabla = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(Tabla);

            conn.Close();
            return Tabla;

        }

        public int noprestamo(int x)
        {

            conn3.Open();
            string query = "select ISNULL(MAX(IdPrestamo), 0) from Prestamos";
            SqlCommand command = new SqlCommand(query, conn3);
            int z = Convert.ToInt32(command.ExecuteScalar());
            z = z + 1;
            conn3.Close();
            return z;

        }


    }

}
