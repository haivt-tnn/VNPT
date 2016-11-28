namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DANH_MUC_DICH_VU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DANH_MUC_DICH_VU()
        {
            CHI_TIET_PHI_DICH_VU = new HashSet<CHI_TIET_PHI_DICH_VU>();
        }

        [Key]
        public int MADICHVU { get; set; }

        [StringLength(255)]
        public string TENDICHVU { get; set; }

        [StringLength(50)]
        public string DONVITINH { get; set; }

        public double? DONGIA { get; set; }

        public int? LOAITIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_PHI_DICH_VU> CHI_TIET_PHI_DICH_VU { get; set; }

        public virtual DANH_MUC_LOAI_TIEN DANH_MUC_LOAI_TIEN { get; set; }
    }
}
