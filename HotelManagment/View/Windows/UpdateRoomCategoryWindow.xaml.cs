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
    /// Логика взаимодействия для UpdateRoomCategoryWindow.xaml
    /// </summary>
    public partial class UpdateRoomCategoryWindow : Window
    {
        HotelDBEntities _db = new HotelDBEntities();
        int Id;
        public UpdateRoomCategoryWindow(int roomId)
        {
            InitializeComponent();
            Id = roomId;
        }

        private void BtnUpdateCategory_Click(object sender, RoutedEventArgs e)
        {
            RoomCategory updateCategory = (from m in _db.RoomCategory
                                           where m.RoomCategoryID == Id
                                 select m).Single();

            updateCategory.NameOfCategory = UpdateRoomCategory.Text;
            
            _db.SaveChanges();
            CategoryWindow.datagrid.ItemsSource = _db.RoomCategory.ToList();
            this.Hide();
        }
    }
}
