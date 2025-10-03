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
    /// Lógica de interacción para UsuarioPage.xaml
    /// </summary>
    public partial class UsuarioPage : Page
    {
        public UsuarioPage()
        {
            InitializeComponent();
        }

        private void BtnCrearUsuario_Click(object sender, RoutedEventArgs e)
        {
            // Aquí va la lógica para crear el usuario
            MessageBox.Show("Usuario creado.");
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            // Aquí va la lógica para cancelar la operación
            MessageBox.Show("Operación cancelada.");
        }

    }
}
