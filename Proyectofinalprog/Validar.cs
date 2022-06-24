using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyectofinalprog
{
    class Validar
    {
        public static void Sololetras(KeyPressEventArgs i)
        {
            if (!(char.IsLetter(i.KeyChar)) && (i.KeyChar != (char)Keys.Space) && (i.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo letras permitidas en este campo.");
                i.Handled = true;
                return;
            }
        }
        public static void Solonumeros(KeyPressEventArgs i)
        {
            if (!(char.IsDigit(i.KeyChar)) && (i.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Sólo números permitidos en este campo. ");
                i.Handled = true;
                return;
            }

        }
        public static void Solonumerosyguion(KeyPressEventArgs i)
        {
            if (!(char.IsDigit(i.KeyChar)) && (i.KeyChar != (char)Keys.Back) && i.KeyChar != '-')
            {
                MessageBox.Show("Sólo números y el simbolo guion permitidos en este campo. ");
                i.Handled = true;
                return;
            }
        }
        public static void Solonumerosypunto(KeyPressEventArgs i)
        {
            if (!(char.IsDigit(i.KeyChar)) && (i.KeyChar != (char)Keys.Back) && i.KeyChar != '.')
            {
                MessageBox.Show("Sólo números y elpunto (.) permitidos en este campo. ");
                i.Handled = true;
                return;
            }
        }
    }
}
