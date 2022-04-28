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

namespace salaryGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtDay.IsReadOnly = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            float Salary = float.Parse(txtSalary.Text);
            float Expenses = float.Parse(txtExpenses.Text);
            float Whislist = float.Parse(txtWhislist.Text);
            float Amount = Whislist / (Salary - Expenses);
            txtDay.Text = Amount.ToString();
        }
    }
}
