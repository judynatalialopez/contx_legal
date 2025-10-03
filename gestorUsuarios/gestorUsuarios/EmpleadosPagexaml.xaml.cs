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

namespace gestorUsuarios
{
    /// <summary>
    /// Lógica de interacción para EmpleadosPagexaml.xaml
    /// </summary>
    public partial class EmpleadosPage : Page
    {
        public EmpleadosPage()
        {
            InitializeComponent(); // ✅ Este método debe estar presente
        }

        private void BtnCrearEmpleado_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Empleado creado correctamente.");
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Acción cancelada.");
        }

        // Aquí van los métodos de los botones
    }

}
