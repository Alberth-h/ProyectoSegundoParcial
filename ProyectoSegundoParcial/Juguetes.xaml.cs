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
    /// Lógica de interacción para Juguetes.xaml
    /// </summary>
    public partial class Juguetes : UserControl
    {
        public Juguetes()
        {
            InitializeComponent();
        }

        private void CbJuguetes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cbJuguetes.SelectedIndex)
            {
                case 0:
                    double cantidadMax = 1;
                    double precioMax = 500 * cantidadMax;
                    txtCantidadJuguetes.Text = cantidadMax.ToString();
                    txtPrecioJuguetes.Text = precioMax.ToString();
                    break;
                case 1:
                    double cantidadCar = 1;
                    double precioCar = 23 * cantidadCar;
                    txtCantidadJuguetes.Text = cantidadCar.ToString();
                    txtPrecioJuguetes.Text = precioCar.ToString();
                    break;
                case 2:
                    double cantidadPista = 1;
                    double precioPista = 660 * cantidadPista;
                    txtCantidadJuguetes.Text = cantidadPista.ToString();
                    txtPrecioJuguetes.Text = precioPista.ToString();
                    break;
                case 3:
                    double cantidadMuneco = 1;
                    double precioMuneco = 1100 * cantidadMuneco;
                    txtCantidadJuguetes.Text = cantidadMuneco.ToString();
                    txtPrecioJuguetes.Text = precioMuneco.ToString();
                    imgChucky.Visibility = Visibility.Visible;
                    break;
                case 4:
                    double cantidadBarbie = 1;
                    double precioBarbie = 450 * cantidadBarbie;
                    txtCantidadJuguetes.Text = cantidadBarbie.ToString();
                    txtPrecioJuguetes.Text = precioBarbie.ToString();
                    break;
                case 5:
                    double cantidadLegos = 1;
                    double precioLegos = 900 * cantidadLegos;
                    txtCantidadJuguetes.Text = cantidadLegos.ToString();
                    txtPrecioJuguetes.Text = precioLegos.ToString();
                    break;
            }
        }
    }
}
