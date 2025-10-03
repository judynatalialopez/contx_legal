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
using gestorRoles;

namespace gestorUsuarios
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Navega al formulario de creación de rol
            MainFrame.Navigate(new RolesPage());
        }

        private void Button_Click_User(object sender, RoutedEventArgs e)
        {
            // Navega al formulario de creación de usuario
            MainFrame.Navigate(new UsuarioPage());
        }
        private void Button_Click_Empleado(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new EmpleadosPage());
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            // Este método se ejecuta después de cada navegación
            // Puedes dejarlo vacío o usarlo para lógica adicional
        }
    }

}
