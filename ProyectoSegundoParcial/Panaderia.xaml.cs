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
    /// Lógica de interacción para Panaderia.xaml
    /// </summary>
    public partial class Panaderia : UserControl
    {
        public Panaderia()
        {
            InitializeComponent();
        }

        private void CbPanaderia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cbPanaderia.SelectedIndex)
            {
                case 0:
                    double cantidadBollo = 1;
                    double precioBollo = 7 * cantidadBollo;
                    txtCantidadPanaderia.Text = cantidadBollo.ToString();
                    txtPrecioPanaderia.Text = precioBollo.ToString();
                    break;
                case 1:
                    double cantidadMuerto = 1;
                    double precioMuerto = 12 * cantidadMuerto;
                    txtCantidadPanaderia.Text = cantidadMuerto.ToString();
                    txtPrecioPanaderia.Text = precioMuerto.ToString();
                    break;
                case 2:
                    double cantidadConcha = 1;
                    double precioConcha = 7 * cantidadConcha;
                    txtCantidadPanaderia.Text = cantidadConcha.ToString();
                    txtPrecioPanaderia.Text = precioConcha.ToString();
                    break;
                case 3:
                    double cantidadBolillo = 1;
                    double precioBolillo = 5 * cantidadBolillo;
                    txtCantidadPanaderia.Text = cantidadBolillo.ToString();
                    txtPrecioPanaderia.Text = precioBolillo.ToString();
                    break;
                case 4:
                    double cantidadCuernito = 1;
                    double precioCuernito = 9 * cantidadCuernito;
                    txtCantidadPanaderia.Text = cantidadCuernito.ToString();
                    txtPrecioPanaderia.Text = precioCuernito.ToString();
                    break;
                case 5:
                    double cantidadDona = 1;
                    double precioDona = 7 * cantidadDona;
                    txtCantidadPanaderia.Text = cantidadDona.ToString();
                    txtPrecioPanaderia.Text = precioDona.ToString();
                    break;
            }
        }
    }
}
