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
    /// Логика взаимодействия для CategoryWindow.xaml
    /// </summary>
    public partial class CategoryWindow : Window
    {
        HotelDBEntities _db = new HotelDBEntities();
        public static DataGrid datagrid;
        public CategoryWindow()
        {
            InitializeComponent();
            this.DataContext = new Appvm();
            Load();
        }
        private void Load()
        {
            myDataGrid.ItemsSource = _db.RoomCategory.ToList();
            datagrid = myDataGrid;
        }

        private void BtnBack2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void insertBtn2_Click(object sender, RoutedEventArgs e)
        {
            InsertRoomCateforyWindow iRoom = new InsertRoomCateforyWindow();
            iRoom.ShowDialog();
        }

        private void updateBtn2_Click(object sender, RoutedEventArgs e)
        {
            int Id = (myDataGrid.SelectedItem as RoomCategory).RoomCategoryID;
            UpdateRoomCategoryWindow uRoom = new UpdateRoomCategoryWindow(Id);
            uRoom.ShowDialog();
        }

        private void deleteBtn2_Click(object sender, RoutedEventArgs e)
        {
            int Id = (myDataGrid.SelectedItem as RoomCategory).RoomCategoryID;
            var deleteM = _db.RoomCategory.Where(m => m.RoomCategoryID == Id).Single();
            _db.RoomCategory.Remove(deleteM);
            _db.SaveChanges();
            myDataGrid.ItemsSource = _db.RoomCategory.ToList();
        }

        private void deleteBtn2_Click_1(object sender, RoutedEventArgs e)
        {
            int Id = (myDataGrid.SelectedItem as RoomCategory).RoomCategoryID;
            var deleteM = _db.RoomCategory.Where(m => m.RoomCategoryID == Id).Single();
            _db.RoomCategory.Remove(deleteM);
            _db.SaveChanges();
            myDataGrid.ItemsSource = _db.RoomCategory.ToList();
        }
    }
}
