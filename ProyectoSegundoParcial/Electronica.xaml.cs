using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProyectoSegundoParcial
{
    /// <summary>
    /// Lógica de interacción para Electronica.xaml
    /// </summary>
    public partial class Electronica : UserControl
    {
        public Electronica()
        {
            InitializeComponent();
        }

        private void CbElectronica_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cbElectronica.SelectedIndex)
            {
                case 0:
                    double cantidadCel = 1;
                    double precioCel = 1399 * cantidadCel;
                    txtCantidadElectronica.Text = cantidadCel.ToString();
                    txtPrecioElectronica.Text = precioCel.ToString();
                    break;
                case 1:
                    double cantidadLap = 1;
                    double precioLap = 8499 * cantidadLap;
                    txtCantidadElectronica.Text = cantidadLap.ToString();
                    txtPrecioElectronica.Text = precioLap.ToString();
                    break;
                case 2:
                    double cantidadAudifonos = 1;
                    double precioAudifonos = 149 * cantidadAudifonos;
                    txtCantidadElectronica.Text = cantidadAudifonos.ToString();
                    txtPrecioElectronica.Text = precioAudifonos.ToString();
                    break;
                case 3:
                    double cantidadBocina = 1;
                    double precioBocina = 999 * cantidadBocina;
                    txtCantidadElectronica.Text = cantidadBocina.ToString();
                    txtPrecioElectronica.Text = precioBocina.ToString();
                    break;
                case 4:
                    double cantidadUSB = 1;
                    double precioUSB = 199 * cantidadUSB;
                    txtCantidadElectronica.Text = cantidadUSB.ToString();
                    txtPrecioElectronica.Text = precioUSB.ToString();
                    break;
                case 5:
                    double cantidadCargador = 1;
                    double precioCargador = 299 * cantidadCargador;
                    txtCantidadElectronica.Text = cantidadCargador.ToString();
                    txtPrecioElectronica.Text = precioCargador.ToString();
                    break;
            }
        }
    }
}
