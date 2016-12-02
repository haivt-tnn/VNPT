namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DANH_MUC_LOAI_PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DANH_MUC_LOAI_PHONG()
        {
            DANH_MUC_PHONG = new HashSet<DANH_MUC_PHONG>();
            PHIEU_DAT_PHONG = new HashSet<PHIEU_DAT_PHONG>();
        }

        [Key]
        public int MALOAIPHONG { get; set; }

        [StringLength(50)]
        public string TENLOAIPHONG { get; set; }

        public string MOTA { get; set; }

        [StringLength(50)]
        public string URLIMAGE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANH_MUC_PHONG> DANH_MUC_PHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_DAT_PHONG> PHIEU_DAT_PHONG { get; set; }
    }
}
