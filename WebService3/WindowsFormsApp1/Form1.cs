using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Repartidor : Form
    {
        public Repartidor()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtOrdenRes_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnEstadoRes_Click(object sender, EventArgs e)
        {
            int orden = short.Parse(txtOrdencam.Text);
            using (WSEsb.ESBClient client = new WSEsb.ESBClient())
            {
                lblCambio.Text = client.CambiarEstado(orden);
                Console.WriteLine("Cambio estado de orden del webservice del ResRepartidor en: " + orden);
            }
        }

        private void btnOrdenRep_Click(object sender, EventArgs e)
        {
            int orden = short.Parse(txtOrdenRep.Text);
            using (WSEsb.ESBClient client = new WSEsb.ESBClient ())
            {
                var EstadoOrden = client.ObtenerEstadoCli(orden);
                string estado = EstadoOrden.estado;
                string error = EstadoOrden.Error;
                if (estado != null)
                {
                    lblOrdenRep.Text = estado;
                    Console.WriteLine("Estado obtenido del webservice del ResRepartidor: " + estado);
                }
                else
                {
                    lblOrdenRep.Text = error;
                    Console.WriteLine("Estado obtenido del webservice del ResRepartidor: " + error);
                }
            }
        }
    }
}
