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
    /// Lógica de interacción para Despensa.xaml
    /// </summary>
    public partial class Despensa : UserControl
    {
        public Despensa()
        {
            InitializeComponent();
        }

        private void CbDespensa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cbDespensa.SelectedIndex)
            {
                case 0:
                    double cantidadCereal = 1;
                    double precioCereal = 40 * cantidadCereal;
                    txtCantidadDespensa.Text = cantidadCereal.ToString();
                    txtPrecioDespensa.Text = precioCereal.ToString();
                    break;
                case 1:
                    double cantidadFrijol = 1;
                    double precioFrijol = 45.90 * cantidadFrijol;
                    txtCantidadDespensa.Text = cantidadFrijol.ToString();
                    txtPrecioDespensa.Text = precioFrijol.ToString();
                    break;
                case 2:
                    double cantidadAzucar = 1;
                    double precioAzucar = 24.50 * cantidadAzucar;
                    txtCantidadDespensa.Text = cantidadAzucar.ToString();
                    txtPrecioDespensa.Text = precioAzucar.ToString();
                    break;
                case 3:
                    double cantidadTotillas = 1;
                    double precioTotillas = 19.50 * cantidadTotillas;
                    txtCantidadDespensa.Text = cantidadTotillas.ToString();
                    txtPrecioDespensa.Text = precioTotillas.ToString();
                    break;
                case 4:
                    double cantidadAgua = 1;
                    double precioAgua = 10 * cantidadAgua;
                    txtCantidadDespensa.Text = cantidadAgua.ToString();
                    txtPrecioDespensa.Text = precioAgua.ToString();
                    break;
                case 5:
                    double cantidadLeche = 1;
                    double precioLeche = 18.50 * cantidadLeche;
                    txtCantidadDespensa.Text = cantidadLeche.ToString();
                    txtPrecioDespensa.Text = precioLeche.ToString();
                    break;
            }
        }
    }
}
