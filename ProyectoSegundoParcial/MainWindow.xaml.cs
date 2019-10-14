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
using System.Media;

namespace ProyectoSegundoParcial
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CbElementos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            grdInterfaz.Visibility = Visibility.Visible;
            btnCancelar.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Visible;
            lblExepcion.Visibility = Visibility.Hidden;
            grdInterfaz.Children.Clear();
            switch(cbElementos.SelectedIndex)
            {
                case 0:
                    grdInterfaz.Children.Add(new FrutasVerduras());
                    break;
                case 1:
                    grdInterfaz.Children.Add(new Panaderia());
                    break;
                case 2:
                    grdInterfaz.Children.Add(new Despensa());
                    break;
                case 3:
                    grdInterfaz.Children.Add(new EquipoLimpieza());
                    break;
                case 4:
                    grdInterfaz.Children.Add(new Juguetes());
                    break;
                case 5:
                    grdInterfaz.Children.Add(new Electronica());
                    break;
            }
        }


        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            grdInterfaz.Children.Clear();
            btnCancelar.Visibility = Visibility.Hidden;
            btnGuardar.Visibility = Visibility.Hidden;
            lblExepcion.Visibility = Visibility.Hidden;
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            switch(cbElementos.SelectedIndex)
            {
                //FrutaVerdura
                case 0:
                    if (
                        ((FrutasVerduras)(grdInterfaz.Children[0])).cbFrutaVerdura.SelectedIndex == -1 ||
                        string.IsNullOrEmpty(((FrutasVerduras)(grdInterfaz.Children[0])).txtCodigoFrutaVerdura.Text) ||
                        string.IsNullOrEmpty(((FrutasVerduras)(grdInterfaz.Children[0])).txtDescripcionFrutaVerdura.Text) ||
                        string.IsNullOrEmpty(((FrutasVerduras)(grdInterfaz.Children[0])).txtCantidadFrutaVerdura.Text) ||
                        string.IsNullOrEmpty(((FrutasVerduras)(grdInterfaz.Children[0])).txtDescuentoFrutaVerdura.Text) ||
                        string.IsNullOrEmpty(((FrutasVerduras)(grdInterfaz.Children[0])).txtPrecioFrutaVerdura.Text) ||
                        (((FrutasVerduras)(grdInterfaz.Children[0])).rdbFrutaVerduraFormaEntera.IsChecked == false && ((FrutasVerduras)(grdInterfaz.Children[0])).rdbFrutaVerduraFormaEntera.IsChecked == false) ||
                        (((FrutasVerduras)(grdInterfaz.Children[0])).cbxFrutaVerduraBolsaSi.IsChecked == false && ((FrutasVerduras)(grdInterfaz.Children[0])).cbxFrutaVerduraBolsaNo.IsChecked == false)
                        )
                    {
                        lblExepcion.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        lblExepcion.Visibility = Visibility.Hidden;
                        grdInterfaz.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                        btnGuardar.Visibility = Visibility.Hidden;
                        grdInterfaz.Children.Clear();
                    }
                    break;
                //Panaderia
                case 1:
                    if (
                        ((Panaderia)(grdInterfaz.Children[0])).cbPanaderia.SelectedIndex == -1 ||
                        string.IsNullOrEmpty(((Panaderia)(grdInterfaz.Children[0])).txtCodigoPanaderia.Text) ||
                        string.IsNullOrEmpty(((Panaderia)(grdInterfaz.Children[0])).txtDescripcionPanaderia.Text) ||
                        string.IsNullOrEmpty(((Panaderia)(grdInterfaz.Children[0])).txtCantidadPanaderia.Text) ||
                        string.IsNullOrEmpty(((Panaderia)(grdInterfaz.Children[0])).txtDescuentoPanaderia.Text) ||
                        string.IsNullOrEmpty(((Panaderia)(grdInterfaz.Children[0])).txtPrecioPanaderia.Text) ||
                        (((Panaderia)(grdInterfaz.Children[0])).rdbPanaderiaEntregaCaja.IsChecked == false && ((Panaderia)(grdInterfaz.Children[0])).rdbPanaderiaEntregaBolsa.IsChecked == false) ||
                        (((Panaderia)(grdInterfaz.Children[0])).cbxPanaderiaDomicilioSi.IsChecked == false && ((Panaderia)(grdInterfaz.Children[0])).cbxPanaderiaDomicilioNo.IsChecked == false)
                        )
                    {
                        lblExepcion.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        lblExepcion.Visibility = Visibility.Hidden;
                        grdInterfaz.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                        btnGuardar.Visibility = Visibility.Hidden;
                        grdInterfaz.Children.Clear();
                    }
                    break;
                //Despensa
                case 2:
                    if (
                        ((Despensa)(grdInterfaz.Children[0])).cbDespensa.SelectedIndex == -1 ||
                        string.IsNullOrEmpty(((Despensa)(grdInterfaz.Children[0])).txtCodigoDespensa.Text) ||
                        string.IsNullOrEmpty(((Despensa)(grdInterfaz.Children[0])).txtDescripcionDespensa.Text) ||
                        string.IsNullOrEmpty(((Despensa)(grdInterfaz.Children[0])).txtCantidadDespensa.Text) ||
                        string.IsNullOrEmpty(((Despensa)(grdInterfaz.Children[0])).txtDescuentoDespensa.Text) ||
                        string.IsNullOrEmpty(((Despensa)(grdInterfaz.Children[0])).txtPrecioDespensa.Text) ||
                        (((Despensa)(grdInterfaz.Children[0])).cbxDespensaValesSi.IsChecked == false && ((Despensa)(grdInterfaz.Children[0])).cbxDespensaValesNo.IsChecked == false) ||
                        (((Despensa)(grdInterfaz.Children[0])).rdbDespensaValesNinguna.IsChecked == false && ((Despensa)(grdInterfaz.Children[0])).rdbDespensaValesBasica.IsChecked == false && ((Despensa)(grdInterfaz.Children[0])).rdbDespensaValesAmigoSoriana.IsChecked == false && ((Despensa)(grdInterfaz.Children[0])).rdbDespensaValesDeluxe.IsChecked == false && ((Despensa)(grdInterfaz.Children[0])).rdbDespensaValesPro.IsChecked == false)
                        )
                    {
                        lblExepcion.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        lblExepcion.Visibility = Visibility.Hidden;
                        grdInterfaz.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                        btnGuardar.Visibility = Visibility.Hidden;
                        grdInterfaz.Children.Clear();
                    }
                    break;
                //EquipoLimpieza
                case 3:
                    if (
                        ((EquipoLimpieza)(grdInterfaz.Children[0])).cbLimpieza.SelectedIndex == -1 ||
                        string.IsNullOrEmpty(((EquipoLimpieza)(grdInterfaz.Children[0])).txtCodigoLimpieza.Text) ||
                        string.IsNullOrEmpty(((EquipoLimpieza)(grdInterfaz.Children[0])).txtDescripcionLimpieza.Text) ||
                        string.IsNullOrEmpty(((EquipoLimpieza)(grdInterfaz.Children[0])).txtCantidadLimpieza.Text) ||
                        string.IsNullOrEmpty(((EquipoLimpieza)(grdInterfaz.Children[0])).txtDescuentoLimpieza.Text) ||
                        string.IsNullOrEmpty(((EquipoLimpieza)(grdInterfaz.Children[0])).txtPrecioLimpieza.Text) ||
                        (((EquipoLimpieza)(grdInterfaz.Children[0])).cbxEquipoLimpiezaKitSi.IsChecked == false && ((EquipoLimpieza)(grdInterfaz.Children[0])).cbxEquipoLimpiezaKitNo.IsChecked == false) ||
                        (((EquipoLimpieza)(grdInterfaz.Children[0])).cbxEquipoLimpiezaValesSi.IsChecked == false && ((EquipoLimpieza)(grdInterfaz.Children[0])).cbxEquipoLimpiezaValesNo.IsChecked == false) ||
                        (((EquipoLimpieza)(grdInterfaz.Children[0])).rdbEquipoLimpiezaValesNinguna.IsChecked == false && ((EquipoLimpieza)(grdInterfaz.Children[0])).rdbEquipoLimpiezaValesBasica.IsChecked == false && ((EquipoLimpieza)(grdInterfaz.Children[0])).rdbEquipoLimpiezaValesAmigoSoriana.IsChecked == false && ((EquipoLimpieza)(grdInterfaz.Children[0])).rdbEquipoLimpiezaValesDeluxe.IsChecked == false && ((EquipoLimpieza)(grdInterfaz.Children[0])).rdbEquipoLimpiezaValesPro.IsChecked == false)
                        )
                    {
                        lblExepcion.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        lblExepcion.Visibility = Visibility.Hidden;
                        grdInterfaz.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                        btnGuardar.Visibility = Visibility.Hidden;
                        grdInterfaz.Children.Clear();
                    }
                    break;
                //Juguetes
                case 4:
                    if (
                        ((Juguetes)(grdInterfaz.Children[0])).cbJuguetes.SelectedIndex == -1 ||
                        string.IsNullOrEmpty(((Juguetes)(grdInterfaz.Children[0])).txtCodigoJuguetes.Text) ||
                        string.IsNullOrEmpty(((Juguetes)(grdInterfaz.Children[0])).txtDescripcionJuguetes.Text) ||
                        string.IsNullOrEmpty(((Juguetes)(grdInterfaz.Children[0])).txtCantidadJuguetes.Text) ||
                        string.IsNullOrEmpty(((Juguetes)(grdInterfaz.Children[0])).txtDescuentoJuguetes.Text) ||
                        string.IsNullOrEmpty(((Juguetes)(grdInterfaz.Children[0])).txtPrecioJuguetes.Text) ||
                        (((Juguetes)(grdInterfaz.Children[0])).cbxJuguetesOfertaSi.IsChecked == false && ((Juguetes)(grdInterfaz.Children[0])).cbxJuguetesOfertaNo.IsChecked == false) ||
                        (((Juguetes)(grdInterfaz.Children[0])).cbxJuguetesValesSi.IsChecked == false && ((Juguetes)(grdInterfaz.Children[0])).cbxJuguetesValesNo.IsChecked == false) ||
                        (((Juguetes)(grdInterfaz.Children[0])).rdbJuguetesValesNinguna.IsChecked == false && ((Juguetes)(grdInterfaz.Children[0])).rdbJuguetesValesBasica.IsChecked == false && ((Juguetes)(grdInterfaz.Children[0])).rdbJuguetesValesAmigoSoriana.IsChecked == false && ((Juguetes)(grdInterfaz.Children[0])).rdbJuguetesValesDeluxe.IsChecked == false && ((Juguetes)(grdInterfaz.Children[0])).rdbJuguetesValesPro.IsChecked == false)
                        )
                    {
                        lblExepcion.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        lblExepcion.Visibility = Visibility.Hidden;
                        grdInterfaz.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                        btnGuardar.Visibility = Visibility.Hidden;
                        grdInterfaz.Children.Clear();
                    }
                    break;
                //Electronica
                case 5:
                    if (
                        ((Electronica)(grdInterfaz.Children[0])).cbElectronica.SelectedIndex == -1 ||
                        string.IsNullOrEmpty(((Electronica)(grdInterfaz.Children[0])).txtCodigoElectronica.Text) ||
                        string.IsNullOrEmpty(((Electronica)(grdInterfaz.Children[0])).txtDescripcionElectronica.Text) ||
                        string.IsNullOrEmpty(((Electronica)(grdInterfaz.Children[0])).txtCantidadElectronica.Text) ||
                        string.IsNullOrEmpty(((Electronica)(grdInterfaz.Children[0])).txtDescuentoElectronica.Text) ||
                        string.IsNullOrEmpty(((Electronica)(grdInterfaz.Children[0])).txtPrecioElectronica.Text) ||
                        (((Electronica)(grdInterfaz.Children[0])).rdbElectronicaPlanContado.IsChecked == false && ((Electronica)(grdInterfaz.Children[0])).rdbElectronicaPlanSeis.IsChecked == false && ((Electronica)(grdInterfaz.Children[0])).rdbElectronicaPlanDoce.IsChecked == false && ((Electronica)(grdInterfaz.Children[0])).rdbElectronicaPlanDiesiocho.IsChecked == false && ((Electronica)(grdInterfaz.Children[0])).rdbElectronicaPlanVeinticuatro.IsChecked == false) ||
                        (((Electronica)(grdInterfaz.Children[0])).cbxElectronicaValesSi.IsChecked == false && ((Electronica)(grdInterfaz.Children[0])).cbxElectronicaValesNo.IsChecked == false) ||
                        (((Electronica)(grdInterfaz.Children[0])).rdbElectronicaValesNinguna.IsChecked == false && ((Electronica)(grdInterfaz.Children[0])).rdbElectronicaValesBasica.IsChecked == false && ((Electronica)(grdInterfaz.Children[0])).rdbElectronicaValesAmigoSoriana.IsChecked == false && ((Electronica)(grdInterfaz.Children[0])).rdbElectronicaValesDeluxe.IsChecked == false && ((Electronica)(grdInterfaz.Children[0])).rdbElectronicaValesPro.IsChecked == false)
                        )
                    {
                        lblExepcion.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        lblExepcion.Visibility = Visibility.Hidden;
                        grdInterfaz.Children.Clear();
                        btnCancelar.Visibility = Visibility.Hidden;
                        btnGuardar.Visibility = Visibility.Hidden;
                    }
                    break;
            }
        }


    }
}
