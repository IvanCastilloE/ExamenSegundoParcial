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

namespace ExamenSegundoParcial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            informacionPersonal.Visibility = Visibility.Collapsed;
            contacto.Visibility = Visibility.Collapsed;
            informacionPago.Visibility = Visibility.Collapsed;
            switch (btnSiguiente.ClickMode)
            {
                case 0:
                    informacionPersonal.Visibility = Visibility.Visible;
                    btnSiguiente.Visibility = Visibility.Collapsed;
                    btnSiguiente2.Visibility = Visibility.Visible;
                    break;
                default:
                    break;
            }
        }

        private void btnSiguiente2_Click(object sender, RoutedEventArgs e)
        {
            informacionPersonal.Visibility = Visibility.Collapsed;
            contacto.Visibility = Visibility.Collapsed;
            informacionPago.Visibility = Visibility.Collapsed;

            switch (btnSiguiente.ClickMode)
            {
                case 0:
                    contacto.Visibility = Visibility.Visible;
                    btnSiguiente2.Visibility = Visibility.Collapsed;
                    btnSiguente3.Visibility = Visibility.Visible;
                    break;
                default:
                    break;
            }
        }

        private void btnSiguente3_Click(object sender, RoutedEventArgs e)
        {
            informacionPersonal.Visibility = Visibility.Collapsed;
            contacto.Visibility = Visibility.Collapsed;
            informacionPago.Visibility = Visibility.Collapsed;
            switch (btnSiguiente.ClickMode)
            {
                case 0:
                    informacionPago.Visibility = Visibility.Visible;
                    btnSiguente3.Visibility = Visibility.Collapsed;
                    btnFinalizar.Visibility = Visibility.Visible;
                    break;
                default:
                    break;
            }
        }

        private void btnFinalizar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
