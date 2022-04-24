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
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.PlanProductions = new HashSet<PlanProduction>();
        }
    
        public int Id { get; set; }
        public int IdProductType { get; set; }
        public int IdBalloon { get; set; }
        public Nullable<int> OneLine { get; set; }
        public Nullable<int> TwoLine { get; set; }
        public Nullable<int> ThreeLine { get; set; }
    
        public virtual Balloon Balloon { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanProduction> PlanProductions { get; set; }
        public virtual ProductType ProductType { get; set; }
    }
}
