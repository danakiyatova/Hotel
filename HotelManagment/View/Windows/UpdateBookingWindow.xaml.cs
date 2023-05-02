using HotelManagment.Model.Database;
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
    /// Логика взаимодействия для UpdateBookingWindow.xaml
    /// </summary>
    public partial class UpdateBookingWindow : Window
    {
        HotelDBEntities _db = new HotelDBEntities();
        int Id;
        public UpdateBookingWindow(int roomId)
        {
            InitializeComponent();
            Id = roomId;
        }

        private void BtnUpdateBooking_Click(object sender, RoutedEventArgs e)
        {
            Booking updateBooking = (from m in _db.Booking
                                   where m.BookingID == Id
                                 select m).Single();

          
            updateBooking.GuestID = Convert.ToInt32(InsertGuestID.Text);
            updateBooking.BookDate = Convert.ToDateTime(UpdateBookingDate.Text);
            updateBooking.Duration = Convert.ToInt32(InsertDuration.Text);
            updateBooking.Id_room = Convert.ToInt32(InsertId_room.Text);
            updateBooking.Amount = Convert.ToInt32(InsertAmount.Text);
            updateBooking.HotelAdminID = Convert.ToInt32(InsertHotelAdminID.Text);

            
            _db.SaveChanges();
            BookingWindow.datagrid.ItemsSource = _db.Booking.ToList();
            this.Hide();
        }
    }
}
