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
    /// Логика взаимодействия для InsertBookingWindow.xaml
    /// </summary>
    public partial class InsertBookingWindow : Window
    {
        HotelDBEntities _db = new HotelDBEntities();
        private Booking newBooking;

        public InsertBookingWindow()
        {
            InitializeComponent();
        }

        private void StackPanel_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {

        }
          
        private void BtnAddBooking_Click(object sender, RoutedEventArgs e)
        {
           
                Booking newBooking = new Booking()
                {


                    GuestID = Convert.ToInt32(InsertGuestID.Text),
                    BookDate = Convert.ToDateTime(InsertBookingDate.Text),
                    Duration = Convert.ToInt32(InsertDuration.Text),
                    Id_room = Convert.ToInt32(InsertId_room.Text),
                    Amount = Convert.ToInt64(InsertAmount.Text),
                    HotelAdminID = Convert.ToInt32(InsertHotelAdminID.Text)

                };
            
            
            
                _db.Booking.Add(newBooking);
                _db.SaveChanges();
                BookingWindow.datagrid.ItemsSource = _db.Booking.ToList();
                this.Hide();
           
        }
    }
}
