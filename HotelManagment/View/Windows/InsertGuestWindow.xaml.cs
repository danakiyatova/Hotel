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
    /// Логика взаимодействия для InsertGuestWindow.xaml
    /// </summary>
    public partial class InsertGuestWindow : Window
    {
        HotelDBEntities _db = new HotelDBEntities();
        List<ModifyGuestsList> modifyGuestsLists = new List<ModifyGuestsList>();
        public InsertGuestWindow()
        {
            InitializeComponent();
        }

        private void BtnAddGuest_Click(object sender, RoutedEventArgs e)
        {
            Guest newGuest = new Guest()
            {

                Surname = InsertSurname.Text,
                Name = InsertName.Text,
                Patronymic = InsertPatronymic.Text,
                PhoneNumber = Convert.ToInt64(InsertPhoneNumber.Text),
                PassportSeries = Convert.ToInt32(InsertPSeries.Text),
                PassportNumber = Convert.ToInt32(InsertPNumber.Text),
                GenderID = Convert.ToInt32(GuestGenderID.Text)

            };

            _db.Guest.Add(newGuest);
            _db.SaveChanges();

            RoomsWindow.datagrid.ItemsSource = modifyGuestsLists.ToList();
            this.Hide();
        }
    }
    }

