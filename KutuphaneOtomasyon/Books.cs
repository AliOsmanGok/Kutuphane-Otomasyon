//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KutuphaneOtomasyon
{
    using System;
    using System.Collections.Generic;
    
    public partial class Books
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Books()
        {
            this.Confirm = new HashSet<Confirm>();
        }
    
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string Writer { get; set; }
        public short PageNo { get; set; }
        public string Category { get; set; }
        public string SaloonShelf { get; set; }
        public string Status { get; set; }
        public byte[] Image { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Confirm> Confirm { get; set; }
    }
}
