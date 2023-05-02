using HotelManagment.Model.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.ViewModel
{
    internal class Appvm :  BaseViewModel
    {
        private ObservableCollection<Model.Database.Room> _rooms;

        public ObservableCollection<Model.Database.Room> Rooms
        {

            get => _rooms;

            set
            {
                _rooms = value;
                OnPropertyChanged(nameof(Rooms));
            }

        }
        private void LoadData()
        {
            using (HotelDBEntities db = new HotelDBEntities())
            {
                var roomList = db.Room.ToList();
                foreach (var room in roomList) { _rooms.Add(room); }

            }

        }
        private void Initilize()
        {
            Rooms = new 
            ObservableCollection<Model.Database.Room>();
        }

        public Appvm()
        {
            Initilize();
            LoadData();
        }
    }

}
