//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AeroProPlanProductionApp.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class HistoryLogin
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public System.DateTime DateTime { get; set; }
    
        public virtual User User { get; set; }
    }
}
