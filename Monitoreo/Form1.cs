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
        public Form1()
        {
            InitializeComponent();
            puertoSerie.DataReceived += PuertoSerie_DataReceived;
        }
    }

    private void PuertoSerie_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
        string data = puertoSerie.ReadLine();

        if (data.StartsWith("Temperatura"))
        {
            string[] partes = data.Split(',');
            string temp = partes[0].Split(':')[1].Trim();
            string humedad = partes[1].Split(':')[1].Trim();
            string humedadRelativa = partes[2].Split(':')[2].Trim();
            string porcentajeTanque = partes[3].Split(':')[3].Trim();
            
            if (txtTemperatura.Text)
            {

            }
        }
    }
}
