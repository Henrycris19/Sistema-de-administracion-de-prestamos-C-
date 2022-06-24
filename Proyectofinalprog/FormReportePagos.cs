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
    public partial class FormReportePagos : Form
    {
        public FormReportePagos()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportePagos1.Load(@"C:\Users\pn\Documents\MEGAsync\Itla\Tercer cuatrimestre\Programación 1\Tareas\Proyecto Final\Proyectofinalprog\ReportePagos.rpt");
            crystalReportViewer1.ReportSource = ReportePagos1;
            crystalReportViewer1.Refresh();
        }
    }
}
