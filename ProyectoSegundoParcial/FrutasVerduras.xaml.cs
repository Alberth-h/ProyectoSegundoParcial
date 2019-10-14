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
    /// Lógica de interacción para FrutasVerduras.xaml
    /// </summary>
    public partial class FrutasVerduras : UserControl
    {
        public FrutasVerduras()
        {
            InitializeComponent();
        }

        private void CbFrutaVerdura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch(cbFrutaVerdura.SelectedIndex)
            {
                case 0:
                    double cantidadPlatanoChiapas = 1;
                    double precioPlatanoChiapas = 5.90 * cantidadPlatanoChiapas;
                    txtCantidadFrutaVerdura.Text = cantidadPlatanoChiapas.ToString();
                    txtPrecioFrutaVerdura.Text = precioPlatanoChiapas.ToString();
                    break;
                case 1:
                    double cantidadManzana = 1;
                    double precioManzana = 39.90 * cantidadManzana;
                    txtCantidadFrutaVerdura.Text = cantidadManzana.ToString();
                    txtPrecioFrutaVerdura.Text = precioManzana.ToString();
                    break;
                case 2:
                    double cantidadLechuga = 1;
                    double precioLechuga = 29.80 * cantidadLechuga;
                    txtCantidadFrutaVerdura.Text = cantidadLechuga.ToString();
                    txtPrecioFrutaVerdura.Text = precioLechuga.ToString();
                    break;
                case 3:
                    double cantidadPina = 1;
                    double precioPina = 12.90 * cantidadPina;
                    txtCantidadFrutaVerdura.Text = cantidadPina.ToString();
                    txtPrecioFrutaVerdura.Text = precioPina.ToString();
                    break;
                case 4:
                    double cantidadZanahoria = 1;
                    double precioZanahoria = 4.50 * cantidadZanahoria;
                    txtCantidadFrutaVerdura.Text = cantidadZanahoria.ToString();
                    txtPrecioFrutaVerdura.Text = precioZanahoria.ToString();
                    break;
                case 5:
                    double cantidadSandia = 1;
                    double precioSandia = 2.95 * cantidadSandia;
                    txtCantidadFrutaVerdura.Text = cantidadSandia.ToString();
                    txtPrecioFrutaVerdura.Text = precioSandia.ToString();
                    break;
            }
        }

    }
}
