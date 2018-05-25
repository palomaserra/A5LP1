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

namespace Locadora
{
    /// <summary>
    /// Interação lógica para LocadoraHome.xam
    /// </summary>
    public partial class LocadoraHome : Page
    {
        public LocadoraHome()
        {
            InitializeComponent();
        }

        private void selecionarFilme(object sender, RoutedEventArgs e)
        {
            // Ver filme
            LocadoraFilme filme = new LocadoraFilme(this.peopleListBox.SelectedItem);
            this.NavigationService.Navigate(filme);
        }
    }
}
