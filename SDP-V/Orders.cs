//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int Id { get; set; }
        public Nullable<int> Id_FL { get; set; }
        public Nullable<int> Id_UL { get; set; }
        public int Id_Tovar { get; set; }
        public int Quantity { get; set; }
        public System.DateTime Date { get; set; }
        public long Sum { get; set; }
    
        public virtual Characteristics Characteristics { get; set; }
        public virtual Customers_FL_ Customers_FL_ { get; set; }
        public virtual Customers_UL_ Customers_UL_ { get; set; }
        public virtual Order_F Order_F { get; set; }
    }
}
