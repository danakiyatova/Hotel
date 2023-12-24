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
    /// Логика взаимодействия для RoomsWindow.xaml
    /// </summary>
    public partial class RoomsWindow : Window
    {
        HotelDBEntities _db = new HotelDBEntities();
        List<ModifyRoomList> modifyRoomLists = new List<ModifyRoomList>();
        public static DataGrid datagrid;
        public RoomsWindow()
        {
            InitializeComponent();
            this.DataContext = new Appvm();

            foreach (var item in _db.Room)
            {
                modifyRoomLists.Add(item);
            }
            Load();
        }

        private void Load()
        {
            myDataGrid.ItemsSource =modifyRoomLists.ToList();
            datagrid = myDataGrid;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void insertBtn_Click(object sender, RoutedEventArgs e)
        {
            InsertRoomsWindow iRoom = new InsertRoomsWindow();
            iRoom.ShowDialog();
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            int Id = (myDataGrid.SelectedItem as ModifyRoomList).RoomID;
            UpdateRoomsWindow uRoom = new UpdateRoomsWindow(Id);
            uRoom.ShowDialog();
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {var removeRoom = myDataGrid.SelectedItem as ModifyRoomList;
            if (MessageBox.Show($"Вы точно хотите удалить этот элемент?", "Внимаение!",
                MessageBoxButton.YesNo,MessageBoxImage.Question)== MessageBoxResult.Yes )
            {
                try
                {
                    int Id = (myDataGrid.SelectedItem as ModifyRoomList).RoomID;
                    var deleteMember = _db.Room.Where(m => m.RoomID == Id).Single();
                    _db.Room.Remove(deleteMember);
                    _db.SaveChanges();
                    myDataGrid.ItemsSource = _db.Room.ToList();
                    MessageBox.Show("Данные удалены.");

                }
                catch(Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }

            }
          
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }
    }
}
