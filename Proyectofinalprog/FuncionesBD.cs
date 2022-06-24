using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Proyectofinalprog
{
    class FuncionesBD : virtuales
    {
        string nombrex,  correox;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8MNDSMG\\SQLEXPRESS;Initial Catalog=proyectoprog;Integrated Security=True");
        SqlConnection conn2 = new SqlConnection("Data Source=DESKTOP-8MNDSMG\\SQLEXPRESS;Initial Catalog=proyectoprog;Integrated Security=True");
        SqlCommand comando;
        SqlCommand comando2;

        
        public string nopres { get; set; }
        public string nombre { get; set; }
        public string fecha { get; set; }
        public string fecha1 { get; set; }
        public string fecha2 { get; set; }
        public string prestamo { get; set; }
        public string montopagado { get; set; }
        public int cuotasrestantes { get; set; }
        public double montorestante { get; set; }



        new public DataTable BuscarNOP_M()
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
        new public  DataTable MostrarP()
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
        public override void Pagar()
        {

            try
            {
                conn.Open();
                comando = new SqlCommand($"insert into Pagos values('{fecha}', {prestamo}, '{nopres}', {montopagado})", conn);
                comando.ExecuteNonQuery();
                conn.Close();
                System.Windows.Forms.MessageBox.Show("Guardado exitoso!");
                movimientos();
                Actualizar();
            }
            catch (Exception error)
            {
                System.Windows.Forms.MessageBox.Show(error.Message);

            }

        }
        public void movimientos()
        {
            try
            {
                conn2.Open();
                comando2 = new SqlCommand($"insert into MovientosPrestamos values({nopres},{montopagado})", conn2);
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
                comando = new SqlCommand($"UPDATE Prestamos SET MontoPrestamo = {montorestante}, Cuotas = {cuotasrestantes} WHERE IdPrestamo = '{nopres}' ", conn);
                comando.ExecuteNonQuery();
                conn.Close();
                    
            }
            catch (Exception error)
            {
                System.Windows.Forms.MessageBox.Show(error.Message);
            }
        }
        public DataTable BuscarP_F()
        {

            conn2.Open();
            comando = new SqlCommand($"SELECT IdPagos, Fecha, Prestamo, IdPrestamo as No_prestamo, MontoPagado, Prestamo - MontoPagado as Deuda_Restante FROM Pagos where Fecha between '{fecha1}' and '{fecha2}' order by Fecha ASC", conn2);
            comando.ExecuteNonQuery();
            DataTable Tabla3 = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(Tabla3);

            conn2.Close();
            return Tabla3;
        }
        public DataTable MostrarP_F()
        {

            conn2.Open();
            comando = new SqlCommand($"SELECT IdPagos, Fecha, Prestamo, IdPrestamo as No_prestamo, MontoPagado, Prestamo - MontoPagado as Deuda_Restante FROM Pagos", conn2);
            comando.ExecuteNonQuery();
            DataTable Tabla3 = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(Tabla3);

            conn2.Close();
            return Tabla3;
        }
       
      
    }
}
