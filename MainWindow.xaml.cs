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


namespace guitest1
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        //sub pages = 709x453

        private void menu_title_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            //entra
            menu_lateral.Width = 190;

        }

        private void menu_lateral_MouseLeave(object sender, MouseEventArgs e)
        {
            //sai
            menu_lateral.Width = 85;

        }

        private void bt_test_Click(object sender, RoutedEventArgs e)
        {
            form_loader.Content = new test1();
        }
    }
}
