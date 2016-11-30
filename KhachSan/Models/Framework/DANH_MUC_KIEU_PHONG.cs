namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DANH_MUC_KIEU_PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DANH_MUC_KIEU_PHONG()
        {
            DANH_MUC_PHONG = new HashSet<DANH_MUC_PHONG>();
        }

        [Key]
        public int MAKIEUPHONG { get; set; }

        [StringLength(100)]
        public string TENKIEUPHONG { get; set; }

        public int? SONGUOILON { get; set; }

        public int? SOTREEM { get; set; }

        public string MOTA { get; set; }

        [StringLength(50)]
        public string ULRIMAGE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANH_MUC_PHONG> DANH_MUC_PHONG { get; set; }
    }
}
