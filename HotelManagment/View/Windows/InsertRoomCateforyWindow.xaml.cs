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
    /// Логика взаимодействия для InsertRoomCateforyWindow.xaml
    /// </summary>
    public partial class InsertRoomCateforyWindow : Window
    {
        HotelDBEntities _db = new HotelDBEntities();
        public InsertRoomCateforyWindow()
        {
            InitializeComponent();
        }

        private void BtnInsertCategory_Click(object sender, RoutedEventArgs e)
        {
            RoomCategory newCategory = new RoomCategory()
            {
                
                NameOfCategory = InsertRoomCategory.Text

            };

            _db.RoomCategory.Add(newCategory);
            _db.SaveChanges();
            CategoryWindow.datagrid.ItemsSource = _db.Room.ToList();
            this.Hide();
        }
    }
    }

