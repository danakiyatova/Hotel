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
    /// Логика взаимодействия для UpdateRoomsWindow.xaml
    /// </summary>
    public partial class UpdateRoomsWindow : Window
    {
        HotelDBEntities _db = new HotelDBEntities();
        int Id;
        public UpdateRoomsWindow(int roomId)
        {
            InitializeComponent();
            Id = roomId;
        }

        private void BtnUpddateProduct_Click(object sender, RoutedEventArgs e)
        {
            Room updateMember = (from m in _db.Room
                                   where m.RoomID == Id
                                   select m).Single();
            
            updateMember.RoomName = InsertRoomName.Text;
            updateMember.RoomNumber = Convert.ToInt32(InsertRoomNumber.Text);
                updateMember.Seats = Convert.ToInt32(InsertSeats.Text);
                updateMember.Cost = Convert.ToInt32(InsertCost.Text); 
                updateMember.RoomStatusID = Convert.ToInt32(InsertRoomStatusID.Text);
            updateMember.RoomCategoryID = Convert.ToInt32(InsertRoomCategoryID.Text);
            _db.SaveChanges();
            RoomsWindow.datagrid.ItemsSource = _db.Room.ToList();
            this.Hide();
        }
    }
}
