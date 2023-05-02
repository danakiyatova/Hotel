using HotelManagment.Model.Database;
using HotelManagment.ViewModel;
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
using System.Windows.Shapes;

namespace HotelManagment.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для BookingWindow.xaml
    /// </summary>
    public partial class BookingWindow : Window
    {
        HotelDBEntities _db = new HotelDBEntities();
        public static DataGrid datagrid;
        public BookingWindow()
        {
            InitializeComponent();
            this.DataContext = new Appvm();
            Load();
        }
        private void Load()
        {
            myDataGrid.ItemsSource = _db.Booking.ToList();
            datagrid = myDataGrid;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void BtnBack4_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void insertBtn4_Click(object sender, RoutedEventArgs e)
        {
            InsertBookingWindow iBooking = new InsertBookingWindow();
            iBooking.ShowDialog();
        }

        private void updateBtn4_Click(object sender, RoutedEventArgs e)
        {
            int Id = (myDataGrid.SelectedItem as Booking).BookingID;
            UpdateBookingWindow uBooking = new UpdateBookingWindow(Id);
            uBooking.ShowDialog();
        }

        private void deleteBtn4_Click(object sender, RoutedEventArgs e)
        {
            int Id = (myDataGrid.SelectedItem as Booking).BookingID;
            var deleteBooking = _db.Booking.Where(m => m.BookingID == Id).Single();
            _db.Booking.Remove(deleteBooking);
            _db.SaveChanges();
            myDataGrid.ItemsSource = _db.Booking.ToList();
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }
    }
}
