﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SDP_V
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SDPV_ProjectEntities7 : DbContext
    {
        public SDPV_ProjectEntities7()
            : base("name=SDPV_ProjectEntities7")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Characteristics> Characteristics { get; set; }
        public virtual DbSet<Customers_FL_> Customers_FL_ { get; set; }
        public virtual DbSet<Customers_UL_> Customers_UL_ { get; set; }
        public virtual DbSet<Delivery> Delivery { get; set; }
        public virtual DbSet<Drivers> Drivers { get; set; }
        public virtual DbSet<Order_F> Order_F { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Production> Production { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
