using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Proyectofinalprog
{
    class MovimientosR : Movimientos
    {

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8MNDSMG\\SQLEXPRESS;Initial Catalog=proyectoprog;Integrated Security=True");
        SqlConnection conn2 = new SqlConnection("Data Source=DESKTOP-8MNDSMG\\SQLEXPRESS;Initial Catalog=proyectoprog;Integrated Security=True");
        SqlCommand comando;

        public string nopres { get; set; }
        public string cedula { get; set; }
        public DataTable BuscarNOP_M()
        {
            conn.Open();
            comando = new SqlCommand($"SELECT Cedula, IdPrestamo, Cuotas, MontoPrestamo FROM Prestamos WHERE IdPrestamo = '{nopres}'", conn);
            comando.ExecuteNonQuery();
            DataTable Tabla = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(Tabla);

            conn.Close();
            return Tabla;
  
        }
        public DataTable MostrarP()
        {

            conn2.Open();
            comando = new SqlCommand($"SELECT Cedula, IdPrestamo, Cuotas, MontoPrestamo FROM Prestamos order by IdPrestamo ASC", conn2);
            comando.ExecuteNonQuery();
            DataTable Tabla3 = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(Tabla3);

            conn2.Close();
            return Tabla3;
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
        public DataTable BuscarP_IdP()
        {

            conn2.Open();
            comando = new SqlCommand($"SELECT IdPagos, Fecha, Prestamo, IdPrestamo as No_prestamo, MontoPagado, Prestamo - MontoPagado as Deuda_Restante FROM Pagos WHERE IdPrestamo = {nopres}", conn2);
            comando.ExecuteNonQuery();
            DataTable Tabla3 = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(Tabla3);

            conn2.Close();
            return Tabla3;
        }
        public DataTable BuscarMov_IdP()
        {
            conn2.Open();
            comando = new SqlCommand($"SELECT * FROM MovientosPrestamos where IdPrestamos = {nopres}", conn2);
            comando.ExecuteNonQuery();
            DataTable Tabla3 = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(Tabla3);

            conn2.Close();
            return Tabla3;
        }

    }
}
