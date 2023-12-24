using HotelManagment.Model.Database;
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
    /// Логика взаимодействия для UpdateGuestWindow.xaml
    /// </summary>
    public partial class UpdateGuestWindow : Window
    {
        HotelDBEntities _db = new HotelDBEntities();
        List<ModifyGuestsList> modifyGuestsLists = new List<ModifyGuestsList>();

        int Id;
        public UpdateGuestWindow(int roomId)
        {
            InitializeComponent();
            Id = roomId;
        }

        private void BtnUpdateGuest_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int genderID = 1;

                Guest updateGuest = (from m in _db.Guest
                                     where m.GuestID == Id
                                     select m).Single();

                if (GenderCB.SelectedIndex == 0)
                    genderID = 1;
                else if (GenderCB.SelectedIndex == 1)
                    genderID = 2;

                updateGuest.Surname = InsertSurname.Text;
                updateGuest.Name = InsertName.Text;
                updateGuest.Patronymic = InsertPatronymic.Text;
                updateGuest.PhoneNumber = Convert.ToInt64(InsertPhoneNumber.Text);
                updateGuest.PassportSeries = Convert.ToInt32(InsertPSeries.Text);
                updateGuest.PassportNumber = Convert.ToInt32(InsertPNumber.Text);
                updateGuest.GenderID = Convert.ToInt32(genderID.ToString());

                _db.SaveChanges();

                foreach (var item in _db.Guest)
                {
                    modifyGuestsLists.Add(item);
                }
                GuestsWindow.datagrid.ItemsSource = modifyGuestsLists.ToList();
                Hide();
            }
            catch { MessageBox.Show("Не все поля заполнены!"); }
                       
        }
    }
}
