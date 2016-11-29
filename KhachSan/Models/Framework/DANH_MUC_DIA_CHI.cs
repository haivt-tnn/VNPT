namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DANH_MUC_DIA_CHI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DANH_MUC_DIA_CHI()
        {
            DANH_MUC_KHACH_HANG = new HashSet<DANH_MUC_KHACH_HANG>();
        }

        [Key]
        public int MADIACHI { get; set; }

        public int? MADIACHICHA { get; set; }

        [StringLength(255)]
        public string TENDIACHI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANH_MUC_KHACH_HANG> DANH_MUC_KHACH_HANG { get; set; }
    }
}
