using HotelManagment.Model.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.ViewModel
{
    internal class UpdateBookingWindowViewModel : BaseViewModel
    {
        List<HotelAdmin> _administratorsList;
        HotelAdmin _hotelAdmin;

        List<Room> _roomsList;
        Room _room;

        List<Guest> _guestsList;
        Guest _guest;

        public HotelAdmin HotelAdmins { get => _hotelAdmin; set => SetPropertyChanged(ref _hotelAdmin, value); }
        public List<HotelAdmin> AdministratorsList { get => _administratorsList; set => SetPropertyChanged(ref _administratorsList, value); }

        public Room Rooms { get => _room; set => SetPropertyChanged(ref _room, value); }
        public List<Room> RoomsList { get => _roomsList; set => SetPropertyChanged(ref _roomsList, value); }

        public Guest Guests { get => _guest; set => SetPropertyChanged(ref _guest, value); }
        public List<Guest> GuestsList { get => _guestsList; set => SetPropertyChanged(ref _guestsList, value); }

        public UpdateBookingWindowViewModel()
        {
            AdministratorsList = new List<HotelAdmin>();
            RoomsList = new List<Room>();
            GuestsList = new List<Guest>();

            using (HotelDBEntities db = new HotelDBEntities())
            {
                foreach (var item in db.HotelAdmin)
                {
                    AdministratorsList.Add(item);
                }

                foreach (var item in db.Room)
                {
                    RoomsList.Add(item);
                }

                foreach (var item in db.Guest)
                {
                    GuestsList.Add(item);
                }
            }

        }
    }
}
