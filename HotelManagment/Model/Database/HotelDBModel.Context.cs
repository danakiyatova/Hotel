﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HotelDBEntities : DbContext
    {
        public HotelDBEntities()
            : base("name=HotelDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Guest> Guest { get; set; }
        public virtual DbSet<HotelAdmin> HotelAdmin { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<RoomCategory> RoomCategory { get; set; }
        public virtual DbSet<RoomStatus> RoomStatus { get; set; }
    }
}