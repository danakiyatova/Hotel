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
    /// Логика взаимодействия для UpdateGuestWindow.xaml
    /// </summary>
    public partial class UpdateGuestWindow : Window
    {
        HotelDBEntities _db = new HotelDBEntities();
        int Id;
        public UpdateGuestWindow(int roomId)
        {
            InitializeComponent();
            Id = roomId;
        }

        private void BtnUpdateGuest_Click(object sender, RoutedEventArgs e)
        {
            Guest updateGuest = (from m in _db.Guest
                                 where m.GuestID == Id
                                 select m).Single();

            updateGuest.Surname = InsertSurname.Text;
            updateGuest.Name = InsertName.Text;
            updateGuest.Patronymic = InsertPatronymic.Text;
            updateGuest.PhoneNumber = Convert.ToInt64(InsertPhoneNumber.Text);
            updateGuest.PassportSeries = Convert.ToInt32(InsertPSeries.Text);
            updateGuest.PassportNumber = Convert.ToInt32(InsertPNumber.Text);
            updateGuest.GenderID = Convert.ToInt32(GuestGenderID.Text);
           
            _db.SaveChanges();
            GuestsWindow.datagrid.ItemsSource = _db.Guest.ToList();
            this.Hide();
                       
        }
    }
}
