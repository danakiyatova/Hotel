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
    /// Логика взаимодействия для InsertRoomsWindow.xaml
    /// </summary>
    public partial class InsertRoomsWindow : Window
    {
        HotelDBEntities _db = new HotelDBEntities();
        public InsertRoomsWindow()
        {
            InitializeComponent();
        }

        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            Room newRoom = new Room()
            {
                
                RoomName = InsertRoomName.Text,
                RoomNumber = Convert.ToInt32(InsertRoomNumber.Text),
                Seats = Convert.ToInt32(InsertRoomNumber.Text),
                Cost = Convert.ToInt32(InsertCost.Text),
                RoomStatusID = Convert.ToInt32(InsertRoomStatusID.Text),
                RoomCategoryID = Convert.ToInt32(InsertRoomCategoryID.Text)

            };

            _db.Room.Add(newRoom);
            _db.SaveChanges();
            RoomsWindow.datagrid.ItemsSource = _db.Room.ToList();
            this.Hide();
        }
    }
}
