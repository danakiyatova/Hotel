using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.Model.Database
{
    internal class ModifyBookingList
    {
        public int BookingID { get; set; }
        public int GuestID { get; set; }
        public System.DateTime BookDate { get; set; }
        public int Duration { get; set; }
        public int Id_room { get; set; }
        public double Amount { get; set; }
        public int HotelAdminID { get; set; }

        public string AdminSurname { get; set; }
        public string GuestSurname { get; set; }

        public string RoomName { get; set; }

        private static ModifyBookingList CreateFromContext(Booking result)
        {
            HotelDBEntities db = new HotelDBEntities();

            string x = "";
            string y = "";
            string z = "";

            foreach (var item in db.GetAdminSurname(result.HotelAdminID))
            {
                x = item;
            }

            foreach (var item in db.GetGuestSurname(result.GuestID))
            {
                y = item;
            }

            foreach (var item in db.GetRoomName(result.Id_room))
            {
                z = item;
            }

            var modify = new ModifyBookingList
            {
                BookingID = result.BookingID,
                GuestID = result.GuestID,
                BookDate = result.BookDate,
                Duration = result.Duration,
                Id_room = result.Id_room,
                Amount = result.Amount,
                AdminSurname = x,
                GuestSurname = y,
                RoomName = z

            };
            return modify;
        }

        public static implicit operator ModifyBookingList(Booking result) => CreateFromContext(result);

    }

}
