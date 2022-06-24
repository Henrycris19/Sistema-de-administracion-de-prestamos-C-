using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectofinalprog
{
    public partial class Form1 : Form
    {
        double monto, montopagar, montores, monto2;
        int cuotas, cuotasres;
        int index = 0, index2 = 0;
        int I = 1;
        int NO;
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8MNDSMG\\SQLEXPRESS;Initial Catalog=proyectoprog;Integrated Security=True");
        SqlCommand comando;

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void añadirClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            label48.Visible = false;
            this.BackColor = Color.DodgerBlue;
            radioButton3.Checked = true;
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel1.Size = new Size(422, 272);
            this.Size = new Size(465, 365);
            button1.Visible = true;
            button4.Visible = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            limpiar();
            this.Text = "Gestión de clientes";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void verActualizarYBorrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                try //uso de try y catch por si se introduce una letra en el campo de edad
                {

                CRUDclientes Bd = new CRUDclientes();
                    Bd.nombre = textBox2.Text;
                    Bd.cedula = textBox1.Text;
                    Bd.correo = textBox3.Text;
                    Bd.direccion = textBox4.Text;
                    Bd.telefono = textBox5.Text;

                    Bd.GuardarCl();
                    //Bd.Limpiar();
                   limpiar();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

            
        }
        private void limpiar()
        {
            textBox1.Clear();//limpia el textbox
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox6.Clear();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CRUDclientes Bd = new CRUDclientes();
            dataGridView1.DataSource = Bd.MostrarCl();
            linkLabel3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CRUDclientes Bd = new CRUDclientes();
            if (index == 0)
            {
                
                try
                {

                    Bd.nombre = textBox6.Text;
                    dataGridView1.DataSource = Bd.BuscarClN();
                    
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            if (index == 1)
            {

                try
                {
                    Bd.cedula = textBox6.Text;
                    dataGridView1.DataSource = Bd.BuscarClC();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            if (index == 2)
            {

                try
                {
                    Bd.correo = textBox6.Text;
                    dataGridView1.DataSource = Bd.BuscarClCor();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

            linkLabel3.Visible = true;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = comboBox1.SelectedIndex;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            CRUDclientes Bd = new CRUDclientes();

      
                try
                {
                    Bd.x = textBox6.Text;
                    Bd.BorrarClC();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
        
            dataGridView1.DataSource = Bd.MostrarCl();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;

           
            if (index == 0)
            {

                try
                {
                    textBox1.Text = row.Cells[1].Value.ToString();
                    textBox2.Text = row.Cells[2].Value.ToString();
                    textBox3.Text = row.Cells[3].Value.ToString();
                    textBox4.Text = row.Cells[4].Value.ToString();
                    textBox5.Text = row.Cells[5].Value.ToString();
                    textBox6.Text = row.Cells[2].Value.ToString();
                }
                catch (Exception error)
                {

                    MessageBox.Show(error.Message);
                }

            }
            if (index == 1)
            {

                try
                {
                    textBox1.Text = row.Cells[1].Value.ToString();
                    textBox2.Text = row.Cells[2].Value.ToString();
                    textBox3.Text = row.Cells[3].Value.ToString();
                    textBox4.Text = row.Cells[4].Value.ToString();
                    textBox5.Text = row.Cells[5].Value.ToString();
                    textBox6.Text = row.Cells[1].Value.ToString();
                }
                catch (Exception error)
                {

                    MessageBox.Show(error.Message);
                }

            }
            if (index == 2)
            {
                try
                {
                    textBox1.Text = row.Cells[1].Value.ToString();
                    textBox2.Text = row.Cells[2].Value.ToString();
                    textBox3.Text = row.Cells[3].Value.ToString();
                    textBox4.Text = row.Cells[4].Value.ToString();
                    textBox5.Text = row.Cells[5].Value.ToString();
                    textBox6.Text = row.Cells[3].Value.ToString();
                }
                catch (Exception error)
                {

                    MessageBox.Show(error.Message);
                }

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                CRUDclientes Bd = new CRUDclientes();
                Bd.nombre = textBox2.Text;
                Bd.cedula = textBox1.Text;
                Bd.correo = textBox3.Text;
                Bd.direccion = textBox4.Text;
                Bd.telefono = textBox5.Text;
                Bd.x = textBox6.Text;
                Bd.ActualizarCl();
                dataGridView1.DataSource = Bd.MostrarCl();
                limpiar();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Size = new Size(422, 272);
            this.Size = new Size(465, 365);
            button1.Visible = true;
            button4.Visible = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            limpiar();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Size = new Size(1085, 272);
            this.Size = new Size(1127, 365);
            button1.Visible = false;
            button3.Visible = true;
            button4.Visible = false;
            comboBox1.SelectedIndex = 0;
            comboBox1.Enabled = true;
            button5.Visible = false;
            CRUDclientes Bd = new CRUDclientes();
            dataGridView1.DataSource = Bd.MostrarCl();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Size = new Size(1085, 272);
            this.Size = new Size(1127, 365);
            button1.Visible = false;
            button4.Visible = true;
            button5.Visible = true;
            comboBox1.SelectedIndex = 1;
            comboBox1.Enabled = false;
            CRUDclientes Bd = new CRUDclientes();
            dataGridView1.DataSource = Bd.MostrarCl();
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Sololetras(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumerosyguion(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumerosyguion(e);
        }

        //-------------------------------------------------------------------------------------------------------------------------------

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            label8.Text = fecha.ToString();
            label21.Text = fecha.ToString();

        }

        private void añadirPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            label48.Visible = false;
            this.BackColor = Color.DodgerBlue;
            radioButton6.Checked = true;
            CRUDprestamos Bd = new CRUDprestamos();
            panel2.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            dataGridView2.DataSource = Bd.MostrarClP();
            panel2.Size = new Size(520, 272);
            this.Size = new Size(562, 375);
            button10.Visible = true;
            button6.Visible = false;
            button7.Visible = false;
            textBox12.Enabled = true;
            textBox10.Enabled = true;
            textBox9.Visible = true;
            dataGridView2.Visible = true;
            timer1.Enabled = true;
            label13.Text = "Cedula Cliente";
            label14.Visible = false;
            comboBox2.Enabled = true;
            int x = 2;
            Bd.noprestamo(x);
            this.Text = "Gestión de prestamos";
            label16.Text = (Convert.ToString(Bd.noprestamo(x)));
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                CRUDprestamos Bd = new CRUDprestamos();
                Bd.cedulaP = textBox9.Text;
                dataGridView2.DataSource = Bd.BuscarClC_P();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            var row2 = (sender as DataGridView).CurrentRow;
            try
            {
                label13.Text = row2.Cells[1].Value.ToString();
     
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            CRUDprestamos Bd = new CRUDprestamos();
            dataGridView3.DataSource = Bd.MostrarP();
            panel2.Size = new Size(1067, 272);
            this.Size = new Size(1106, 375);
            button10.Visible = false;
            button6.Visible = false;
            button7.Visible = false;     
            textBox12.Enabled = false;
            textBox10.Enabled = false;
            textBox9.Visible = false;
            dataGridView2.Visible = false;
            timer1.Enabled = false;
            label14.Visible = false;
            comboBox2.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            limpiarP();
        }
        private void limpiarP()
        {
            textBox12.Clear();//limpia el textbox
            textBox10.Clear();
            textBox9.Clear();
            label13.Text = "Cedula Cliente";
            textBox11.Clear();
            FuncionesBD Bd = new FuncionesBD();
            dataGridView5.DataSource = Bd.MostrarP();

        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumerosypunto(e);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int x = 0;
            try //uso de try y catch por si se introduce una letra en el campo de edad
            {

                CRUDprestamos Bd = new CRUDprestamos();
                Bd.fecha = label8.Text;
                Bd.monto = textBox12.Text;
                Bd.cuotas = textBox10.Text;
                Bd.cedulaCl = label13.Text;
                Bd.Guardar();
                Bd.noprestamo(x);
                label16.Text = (Convert.ToString(Bd.noprestamo(x)));
                limpiarP();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            index2 = comboBox2.SelectedIndex;
            if (index2== 2)
            {
                button14.Visible = true;
            }
            else
            {
                button14.Visible = false;
            }
  
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            CRUDprestamos Bd = new CRUDprestamos();
            if (index2 == 0)
            {

                try
                {

                    Bd.y = textBox7.Text;
                    dataGridView3.DataSource = Bd.BuscarPF();

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            if (index2 == 1)
            {

                try
                {
                    Bd.y = textBox7.Text;
                    dataGridView3.DataSource = Bd.BuscarPC();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            if (index2 == 2)
            {
                
            }
            linkLabel4.Visible = true;
        }


        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;

                try
                {
                    label16.Text = row.Cells[0].Value.ToString();
                    label8.Text = row.Cells[1].Value.ToString();
                    textBox12.Text = row.Cells[2].Value.ToString();
                    label13.Text = row.Cells[3].Value.ToString();
                    textBox10.Text = row.Cells[4].Value.ToString();
                    label14.Text = row.Cells[3].Value.ToString();
                }
                catch (Exception error)
                {

                    MessageBox.Show(error.Message);
                }


            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            CRUDprestamos Bd = new CRUDprestamos();
            dataGridView3.DataSource = Bd.MostrarP();
            panel2.Size = new Size(1067, 272);
            this.Size = new Size(1106, 375);
            button10.Visible = false;
            button6.Visible = true;
            button7.Visible = true;
            textBox12.Enabled = true;
            textBox10.Enabled = true;
            textBox9.Visible = false;
            dataGridView2.Visible = false;
            comboBox2.SelectedIndex = 2;
            comboBox2.Enabled = false;
            label14.Visible = true;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox7.Clear();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CRUDprestamos Bd = new CRUDprestamos();
            dataGridView3.DataSource = Bd.MostrarP();
            linkLabel4.Visible = false;
            textBox7.Clear();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                CRUDprestamos Bd = new CRUDprestamos();
                Bd.monto = textBox12.Text;
                Bd.cuotas = textBox10.Text;
                Bd.cedulaP = textBox9.Text;
                Bd.y = textBox7.Text;
                Bd.Actualizar();
                dataGridView3.DataSource = Bd.MostrarP();
                limpiarP();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CRUDprestamos Bd = new CRUDprestamos();


            try
            {
        
                Bd.y = textBox7.Text;
                Bd.Borrar();
                dataGridView3.DataSource = Bd.MostrarP();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                try
                {
                    CRUDprestamos Bd = new CRUDprestamos();
                    dataGridView2.DataSource = Bd.MostrarClP();

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

    

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
           


        }

        private void dataGridView5_SelectionChanged(object sender, EventArgs e)
        {
            comboBox4.Text = "Cuotas";
            comboBox4.Items.Clear();
            I = 1;
            var row2 = (sender as DataGridView).CurrentRow;
            try
            {
                label20.Text = row2.Cells[0].Value.ToString();
                label17.Text = row2.Cells[1].Value.ToString();
                label28.Text = row2.Cells[2].Value.ToString();
                label27.Text = row2.Cells[3].Value.ToString();
                textBox11.Text = row2.Cells[1].Value.ToString();




            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }

            NO = Convert.ToInt32(label28.Text);

            while (NO >= I)
            {
                comboBox4.Items.Add(I);
                I = I + 1;
            }
            index2 = 0;
            index2 = Convert.ToInt32(comboBox4.SelectedIndex) + 1;
            monto = Convert.ToDouble(label27.Text);
            cuotas = Convert.ToInt32(label28.Text);
            monto2 = monto / cuotas;
            montopagar = monto2 * index2;
            label29.Text = Convert.ToString(montopagar);
            cuotasres = cuotas - index2;
            montores = monto - montopagar;
        }

        private void button12_Click(object sender, EventArgs e)
        {

            limpiarP();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            CRUDprestamos Bd = new CRUDprestamos();
            try
            {
                Bd.y = textBox7.Text;
                dataGridView3.DataSource = Bd.BuscarPID();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void button15_Click(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            I = 1;
            try
            {
                FuncionesBD Bd = new FuncionesBD();
                Bd.nopres = textBox11.Text;
                dataGridView5.DataSource = Bd.BuscarNOP_M();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            NO = Convert.ToInt32(label28.Text);

            while (NO >= I) 
            {
                comboBox4.Items.Add(I);
                I = I + 1;
            }
            linkLabel7.Visible = true;
            index2 = Convert.ToInt32(comboBox4.SelectedIndex) + 1;
            monto = Convert.ToDouble(label27.Text);
            cuotas = Convert.ToInt32(label28.Text);
            monto2 = monto / cuotas;
            montopagar = monto2 * index2;
            label29.Text = Convert.ToString(montopagar);
            cuotasres = cuotas - index2;
            montores = monto - montopagar;

        }

  

        private void pagoDeCuotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            label48.Visible = false;
            this.BackColor = Color.DodgerBlue;
            radioButton9.Checked = true;
            FuncionesBD Bd = new FuncionesBD();
            timer1.Enabled = true;
            dataGridView5.DataSource = Bd.MostrarP();
            panel3.Size = new Size(519, 272);
            this.Size = new Size(559, 363);
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            button13.Enabled = true;
            button12.Enabled = true;
            dataGridView5.Visible = true;
            button15.Visible = true;

            comboBox4.Visible = true;
            label24.Text = "Cedula Cliente";
            label20.Text = "Cedula Cliente";
            label26.Text = "Monto a Pagar";
            label23.Text = "Cuotas a pagar";
            label19.Visible = false;
            this.Text = "Gestión de pagos";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

            FuncionesBD Bd = new FuncionesBD();
            dataGridView4.DataSource = Bd.MostrarP_F();
            panel3.Size = new Size(1171, 272);
            this.Size = new Size(1211, 362);
            button13.Enabled = false;
            button12.Enabled = false;
            dataGridView5.Visible = false;
            button15.Visible = false;
            timer1.Enabled = false;

            comboBox4.Visible = false;
            label24.Text = "Id Pagos";
            label26.Text = "Monto Pagado";
            label23.Text = "Deuda restante";
            label19.Visible = true;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            FuncionesBD Bd = new FuncionesBD();
            timer1.Enabled = true;
            dataGridView5.DataSource = Bd.MostrarP();
            panel3.Size = new Size(519, 272);
            this.Size = new Size(559, 363);
            button13.Enabled = true;
            button12.Enabled = true;
            dataGridView5.Visible = true;
            button15.Visible = true;


            comboBox4.Visible = true;
            label24.Text = "Cedula Cliente";
            label26.Text = "Monto a Pagar";
            label23.Text = "Cuotas a pagar";
            label19.Visible = false;

        }

  

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionesBD Bd = new FuncionesBD();
                Bd.fecha1 = Convert.ToString(dateTimePicker1.Value);
                Bd.fecha2 = Convert.ToString(dateTimePicker2.Value);
                dataGridView4.DataSource = Bd.BuscarP_F();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            linkLabel6.Visible = true;
        }

        private void dataGridView4_SelectionChanged(object sender, EventArgs e)
        {
            var row2 = (sender as DataGridView).CurrentRow;
            try
            {
                label20.Text = row2.Cells[0].Value.ToString();//Idpagos
                label21.Text = row2.Cells[1].Value.ToString();//Fecha
                label27.Text = row2.Cells[2].Value.ToString();//Prestamo
                label17.Text = row2.Cells[3].Value.ToString();//No-prestamo
                label29.Text = row2.Cells[4].Value.ToString();//montopagado
                label19.Text = row2.Cells[5].Value.ToString();//Deuda restante


            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FuncionesBD Bd = new FuncionesBD();
            dataGridView4.DataSource = Bd.MostrarP_F();
            linkLabel6.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                MovimientosR Bd = new MovimientosR();
                Bd.nopres = textBox8.Text;
                dataGridView7.DataSource = Bd.BuscarNOP_M();
                Bd.cedula = label38.Text;
                dataGridView6.DataSource = Bd.BuscarClC();
               //dataGridView8.DataSource = Bd.BuscarP_IdP();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            linkLabel5.Visible = true;
        }

        private void dataGridView7_SelectionChanged(object sender, EventArgs e)
        {
            var row2 = (sender as DataGridView).CurrentRow;
            try
            {
                label38.Text = row2.Cells[0].Value.ToString();
                label36.Text = row2.Cells[1].Value.ToString();
                MovimientosR Bd = new MovimientosR();
                Bd.cedula = label38.Text;
                Bd.nopres = label36.Text;
                dataGridView6.DataSource = Bd.BuscarClC();
                dataGridView8.DataSource = Bd.BuscarP_IdP();
                dataGridView9.DataSource = Bd.BuscarMov_IdP();



            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MovimientosR Bd = new MovimientosR();
            dataGridView7.DataSource = Bd.MostrarP();
            linkLabel5.Visible = false;
        }

        private void dataGridView8_SelectionChanged(object sender, EventArgs e)
        {
            var row2 = (sender as DataGridView).CurrentRow;
            try
            {
                label39.Text = row2.Cells[0].Value.ToString();//Idpagos
                label35.Text = row2.Cells[1].Value.ToString();//Fecha
                label31.Text = row2.Cells[2].Value.ToString();//Prestamo
                label33.Text = row2.Cells[4].Value.ToString();//montopagado
                label34.Text = row2.Cells[5].Value.ToString();//Deuda restante


            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void dataGridView9_SelectionChanged(object sender, EventArgs e)
        {
            var row2 = (sender as DataGridView).CurrentRow;
            try
            {
                label50.Text = row2.Cells[0].Value.ToString();
                label51.Text = row2.Cells[2].Value.ToString();



            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void consultarMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            label48.Visible = false;
            this.BackColor = Color.DodgerBlue;
            panel4.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            MovimientosR Bd = new MovimientosR();
            dataGridView7.DataSource = Bd.MostrarP();
            linkLabel5.Visible = false;
            this.Size = new Size(1121, 435);
            this.Text = "Consulta de movimientos";


        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            pictureBox4.Visible = true;
            label48.Visible = true;
            this.Size = new Size(655, 397);
            panel4.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            this.Text = "Gestor de prestamos";

        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormReporte FR = new FormReporte();
            FR.Show();
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormReportePrestamos FR = new FormReportePrestamos();
            FR.Show();
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormMovimientos FR = new FormMovimientos();
            FR.Show();
                
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormReportePagos FR = new FormReportePagos();
            FR.Show();
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }

        public void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            index2 = Convert.ToInt32(comboBox4.SelectedIndex)+1;
            monto = Convert.ToDouble(label27.Text);
            cuotas = Convert.ToInt32(label28.Text);
            monto2 = monto / cuotas;
            montopagar = monto2 * index2;
            label29.Text = Convert.ToString(montopagar);
            cuotasres = cuotas - index2;
            montores = monto - montopagar;

        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FuncionesBD Bd = new FuncionesBD();
            dataGridView5.DataSource = Bd.MostrarP();
            linkLabel7.Visible = false;
        }

        private void textBox11_Click(object sender, EventArgs e)
        {
            linkLabel7.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try //uso de try y catch por si se introduce una letra en el campo de edad
            {

                FuncionesBD Bd = new FuncionesBD();
                Bd.fecha = label21.Text;
                Bd.montopagado = label29.Text;
                Bd.cuotasrestantes = cuotasres;
                Bd.nopres = label17.Text;
                Bd.prestamo = label27.Text;
                Bd.montorestante = montores;
                Bd.Pagar();
                limpiarP();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
           

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            CRUDprestamos Bd = new CRUDprestamos();
            panel2.Size = new Size(520, 272);
            this.Size = new Size(562, 375);
            button10.Visible = true;
            button6.Visible = false;
            button7.Visible = false;
            textBox12.Enabled = true;
            textBox10.Enabled = true;
            textBox9.Visible = true;
            dataGridView2.Visible = true;
            timer1.Enabled = true;
            label13.Text = "Cedula Cliente";
            label14.Visible = false;
            comboBox2.Enabled = true;
            int x = 2;
            limpiarP();
            Bd.noprestamo(x);
            label16.Text = (Convert.ToString(Bd.noprestamo(x)));


        }

       
    }
}
