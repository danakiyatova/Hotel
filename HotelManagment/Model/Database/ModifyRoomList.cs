using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.Model.Database
{
    internal class ModifyRoomList
    {
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public int RoomNumber { get; set; }
        public int Seats { get; set; }
        public double Cost { get; set; }
        public int RoomStatusID { get; set; }
        public int RoomCategoryID { get; set; }

        public string CategoryName { get; set; }

        public string StatusName { get; set; }


        private static ModifyRoomList CreateFromContext(Room result)
        {
            HotelDBEntities db = new HotelDBEntities();

            string i = "";
            string k = "";

            foreach (var item in db.GetCategoryName(result.RoomCategoryID))
            {
                i = item;
            }

            foreach (var item in db.GetStatusName(result.RoomStatusID))
            {
                k = item;
            }

            var modify = new ModifyRoomList
            {
                RoomID = result.RoomID,
                RoomName = result.RoomName,
                RoomNumber = result.RoomNumber,
                Seats = result.Seats,
                Cost = result.Cost,
                RoomStatusID = result.RoomStatusID,
                RoomCategoryID = result.RoomCategoryID,
                CategoryName = i,
                StatusName = k
            };
            return modify;
        }

        public static implicit operator ModifyRoomList(Room result) => CreateFromContext(result);
    }
}
