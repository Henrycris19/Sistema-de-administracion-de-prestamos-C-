using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Proyectofinalprog
{
    class HerenciaCLIENTES
    {
        public string correo { get; set; }
        public string nombre { get; set; }
        public string cedula { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string x { get; set; }
    }

   public abstract class C_UD
   {
        public abstract void Guardar();
        public abstract void Actualizar();
        public abstract void Borrar();
    }

    class virtuales
    {
        public virtual void Pagar() { }
        public virtual void Actualizar() { }
        public virtual void MostrarP() { }
        public virtual void BuscarNOP_M() { }
    }
    interface Movimientos
    {
         DataTable MostrarP();
        DataTable BuscarClC();
        DataTable BuscarP_IdP();
    }
}
