using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.Model.Database
{
    internal class ModifyGuestsList
    {
        public int GuestID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public long PhoneNumber { get; set; }
        public int PassportSeries { get; set; }
        public int PassportNumber { get; set; }
        public int GenderID { get; set; }
        public string GenderName { get; set; }


        private static ModifyGuestsList CreateFromContext(Guest result)
        {
            HotelDBEntities db = new HotelDBEntities();

            string x = "";

            foreach (var item in db.GetGenderName(result.GenderID))
            {
                x = item;
            }

            var modify = new ModifyGuestsList
            {
                GuestID = result.GuestID,
                Surname = result.Surname,
                Name = result.Name,
                Patronymic = result.Patronymic,
                PhoneNumber = result.PhoneNumber,
                PassportSeries = result.PassportSeries,
                PassportNumber = result.PassportNumber,
                GenderName = x
            };
            return modify;
        }

        public static implicit operator ModifyGuestsList(Guest result) => CreateFromContext(result);
    }
}
