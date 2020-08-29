using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEstadoRes_Click(object sender, EventArgs e)
        {
            int orden  = short.Parse(txtOrdenRes.Text);
            using (WSRestaurante.WSRestauranteClient client = new WSRestaurante.WSRestauranteClient())
            {
                var EstadoOrden = client.ObtenerEstado(orden);
                string estado= EstadoOrden.estado;
                string error = EstadoOrden.Error;
                if (estado != null)
                {
                    lblOrdenRes.Text = estado;
                    Console.WriteLine("Estado obtenido del webservice del restaurante: " + estado);
                }
                else
                {
                    lblOrdenRes.Text = error;
                    Console.WriteLine("Estado obtenido del webservice del restaurante: " + error);
                }
            }

        }

        private void btnNewOrden_Click(object sender, EventArgs e)
        {
            using(WSRestaurante.WSRestauranteClient client = new WSRestaurante.WSRestauranteClient())
            {
                lblCrearOrden.Text = client.CrearOrden();
            }
        }

        private void btnOrdenRep_Click(object sender, EventArgs e)
        {
            int orden = short.Parse(txtOrdenRep.Text);
            using (WSRepartidor.WSRepartidorClient client = new WSRepartidor.WSRepartidorClient())
            {
                var EstadoOrden = client.ObtenerEstado(orden);
                string estado = EstadoOrden.estado;
                string error = EstadoOrden.Error;
                if (estado != null)
                {
                    lblOrdenRep.Text = estado;
                    Console.WriteLine("Estado obtenido del webservice del repartidor: " + estado);
                }
                else
                {
                    lblOrdenRep.Text = error;
                    Console.WriteLine("Estado obtenido del webservice del repartidor: " + error);
                }
            }
        }
    }
}
