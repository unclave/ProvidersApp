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
    
    public partial class subscribers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public subscribers()
        {
            this.subscriber_tariff_list = new HashSet<subscriber_tariff_list>();
        }
    
        public int id { get; set; }
        public int id_personal_data { get; set; }
        public string full_name { get; set; }
        public string telephone_number { get; set; }
        public int id_region { get; set; }
    
        public virtual personal_data personal_data { get; set; }
        public virtual regions regions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<subscriber_tariff_list> subscriber_tariff_list { get; set; }
    }
}
