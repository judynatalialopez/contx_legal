using System.Windows.Controls;
using System.Windows;
using System;

namespace gestorRoles
{
    public partial class RolesPage : Page
    {
        public RolesPage()
        {
            InitializeComponent();
        }

       

        private void BtnButton_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para crear el rol
            MessageBox.Show("Rol creado correctamente.");
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para cancelar la operación
            MessageBox.Show("Acción cancelada.");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Rol creado.");
        }
    }
}
