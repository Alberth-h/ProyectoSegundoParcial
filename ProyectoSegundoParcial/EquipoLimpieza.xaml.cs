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
    /// Lógica de interacción para EquipoLimpieza.xaml
    /// </summary>
    public partial class EquipoLimpieza : UserControl
    {
        public EquipoLimpieza()
        {
            InitializeComponent();
        }

        private void CbLimpieza_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cbLimpieza.SelectedIndex)
            {
                case 0:
                    double cantidadJabon = 1;
                    double precioJabon = 27.80 * cantidadJabon;
                    txtCantidadLimpieza.Text = cantidadJabon.ToString();
                    txtPrecioLimpieza.Text = precioJabon.ToString();
                    break;
                case 1:
                    double cantidadFabuloso = 1;
                    double precioFabuloso = 23 * cantidadFabuloso;
                    txtCantidadLimpieza.Text = cantidadFabuloso.ToString();
                    txtPrecioLimpieza.Text = precioFabuloso.ToString();
                    break;
                case 2:
                    double cantidadTrapeador = 1;
                    double precioTrapeador = 100 * cantidadTrapeador;
                    txtCantidadLimpieza.Text = cantidadTrapeador.ToString();
                    txtPrecioLimpieza.Text = precioTrapeador.ToString();
                    break;
                case 3:
                    double cantidadEscoba = 1;
                    double precioEscoba = 85 * cantidadEscoba;
                    txtCantidadLimpieza.Text = cantidadEscoba.ToString();
                    txtPrecioLimpieza.Text = precioEscoba.ToString();
                    break;
                case 4:
                    double cantidadEsponja = 1;
                    double precioEsponja = 10 * cantidadEsponja;
                    txtCantidadLimpieza.Text = cantidadEsponja.ToString();
                    txtPrecioLimpieza.Text = precioEsponja.ToString();
                    break;
                case 5:
                    double cantidadTrapo = 1;
                    double precioTrapo = 70 * cantidadTrapo;
                    txtCantidadLimpieza.Text = cantidadTrapo.ToString();
                    txtPrecioLimpieza.Text = precioTrapo.ToString();
                    break;
            }
        }
    }
}
