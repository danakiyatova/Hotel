//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelManagment.Model.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Room()
        {
            this.Booking = new HashSet<Booking>();
        }
    
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public int RoomNumber { get; set; }
        public int Seats { get; set; }
        public double Cost { get; set; }
        public int RoomStatusID { get; set; }
        public int RoomCategoryID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Booking { get; set; }
        public virtual RoomCategory RoomCategory { get; set; }
        public virtual RoomStatus RoomStatus { get; set; }

      
    }
}
