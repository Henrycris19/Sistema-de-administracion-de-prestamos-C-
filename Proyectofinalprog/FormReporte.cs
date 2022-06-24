using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectofinalprog
{
    public partial class FormReporte : Form
    {
        public FormReporte()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ClientReport1.Load(@"C:\Users\pn\Documents\MEGAsync\Itla\Tercer cuatrimestre\Programación 1\Tareas\Proyecto Final\Proyectofinalprog\ClientReport.rpt");
            crystalReportViewer1.ReportSource = ClientReport1;
            crystalReportViewer1.Refresh();

        }
    }
}
