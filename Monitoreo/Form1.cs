using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Monitoreo
{
    public partial class Form1 : Form
    {
        private SerialPort puertoSerie = new SerialPort("COM3", 11500);
        private string datos;

        private void btnConectar_Click(object sender, EventArgs e)
        {
            puertoSerie.Open();
        }

        private void btnRegar_Click(object sender, EventArgs e)
        {
            puertoSerie.WriteLine("R");
        }

        private void btnEnfriar_Click(object sender, EventArgs e)
        {
            puertoSerie.WriteLine("E");
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            datos = puertoSerie.ReadLine();
            this.Invoke(new EventHandler(mostrarDatos));
        }

        private void mostrarDatos(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}