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
    /// Логика взаимодействия для GuestsWindow.xaml
    /// </summary>
    public partial class GuestsWindow : Window
    {
        HotelDBEntities _db = new HotelDBEntities();
        List<ModifyGuestsList> modifyGuestsLists = new List<ModifyGuestsList>();
        public static DataGrid datagrid;
        public GuestsWindow()
        {
            InitializeComponent();
            this.DataContext = new Appvm();

            foreach (var item in _db.Guest)
            {
                modifyGuestsLists.Add(item);
            }
            Load();
        }

        private void Load()
        {
            myDataGrid.ItemsSource = null;
            myDataGrid.ItemsSource = modifyGuestsLists.ToList();
            datagrid = myDataGrid;
            
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void BtnBack3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void insertBtn3_Click(object sender, RoutedEventArgs e)
        {
            InsertGuestWindow iGuest = new InsertGuestWindow();
            iGuest.ShowDialog();
        }

        private void updateBtn3_Click(object sender, RoutedEventArgs e)
        {
            int Id = (myDataGrid.SelectedItem as ModifyGuestsList).GuestID;
            UpdateGuestWindow uGuest = new UpdateGuestWindow(Id);
            uGuest.ShowDialog();
        }

        private void deleteBtn3_Click(object sender, RoutedEventArgs e)
        {
            var removeRoom = myDataGrid.SelectedItem as ModifyGuestsList;
            if (MessageBox.Show($"Вы точно хотите удалить этот элемент?", "Внимаение!",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    int Id = (myDataGrid.SelectedItem as ModifyGuestsList).GuestID;
                    var deleteGuest = _db.Guest.Where(m => m.GuestID == Id).Single();
                    _db.Guest.Remove(deleteGuest);
                    _db.SaveChanges();
                    myDataGrid.ItemsSource = _db.Guest.ToList();
                    MessageBox.Show("Данные удалены.");

                }
                catch (Exception ex)
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
