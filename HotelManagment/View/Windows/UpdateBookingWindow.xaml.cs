using HotelManagment.Model.Database;
using HotelManagment.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

            DataContext = new UpdateBookingWindowViewModel();

            Id = roomId;

            
        }

        private void BtnUpdateBooking_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Booking updateBooking = (from m in _db.Booking
                                   where m.BookingID == Id
                                 select m).Single();

                Room selectedRoom = RoomsList.SelectedItem as Room;
                if (selectedRoom != null)
                {
                    int roomId = _db.Room
                           .Where(r => r.RoomName == selectedRoom.RoomName)
                           .Select(r => r.RoomID)
                           .FirstOrDefault();

                    if (roomId != 0)
                    {
                        
                        updateBooking.Id_room = roomId;
                        updateBooking.GuestID = Convert.ToInt32(GuestsList.SelectedIndex + 1);
                        updateBooking.BookDate = Convert.ToDateTime(UpdateBookingDate.Text);
                    updateBooking.Duration = Convert.ToInt32(InsertDuration.Text);
                    updateBooking.Id_room = Convert.ToInt32(RoomsList.SelectedIndex + 1);
                    updateBooking.Amount = Convert.ToInt32(InsertAmount.Text);
                    updateBooking.HotelAdminID = Convert.ToInt32(AdminList.SelectedIndex + 1);
                    

                    _db.SaveChanges();
                    BookingWindow.datagrid.ItemsSource = _db.Booking.ToList();
                    this.Hide();
                    }
                    else
                    {
                        // Обработка случая, когда комната не найдена
                        MessageBox.Show("Выбранная комната не существует.");
                    }
                }
                else
                {
                    // Обработка случая, когда комната не выбрана
                    MessageBox.Show("Комната не выбрана.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении бронирования: {ex.Message}");
            }
        }
    }
}
