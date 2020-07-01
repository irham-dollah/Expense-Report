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

namespace ExpenseIT
{
    /// <summary>
    /// Interaction logic for ExpenseITHome.xaml
    /// </summary>
    public partial class ExpenseITHome : Page
    {
        public ExpenseITHome()
        {
            InitializeComponent();
        }
        private void Button_Click (object sender, RoutedEventArgs e)
        {
            ExpenseReportPage report = new ExpenseReportPage(this.peopleListBox.SelectedItem);
            this.NavigationService.Navigate(report);
        }
    }
}
