using HotelManagment.View.Windows;
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

namespace HotelManagment
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal static object datagrid;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRooms_Click(object sender, RoutedEventArgs e)
        {
            RoomsWindow roomWindow = new RoomsWindow();
            roomWindow.Show();
            this.Hide();
        }

        private void btnCategory_Click(object sender, RoutedEventArgs e)
        {
            CategoryWindow сategoryWindow = new CategoryWindow();
            сategoryWindow.Show();
            this.Hide();
        }

        private void btnGuests_Click(object sender, RoutedEventArgs e)
        {
            GuestsWindow guestsWindow = new GuestsWindow();
            guestsWindow.Show();
            this.Hide();
        }

        private void btnBooking_Click(object sender, RoutedEventArgs e)
        {
            BookingWindow bookingWindow = new BookingWindow();
            bookingWindow.Show();
            this.Hide();
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }
    }
}
