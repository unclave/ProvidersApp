//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProvidersApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class operators
    {
        public int id { get; set; }
        public string full_name { get; set; }
        public int experience { get; set; }
        public int salary { get; set; }
        public int id_region { get; set; }
    
        public virtual regions regions { get; set; }
    }
}
