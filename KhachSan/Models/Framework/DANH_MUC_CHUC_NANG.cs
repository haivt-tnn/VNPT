namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DANH_MUC_CHUC_NANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DANH_MUC_CHUC_NANG()
        {
            PHAN_QUYEN_NGUOI_DUNG = new HashSet<PHAN_QUYEN_NGUOI_DUNG>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MACHUCNANG { get; set; }

        [StringLength(255)]
        public string TENCHUCNANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHAN_QUYEN_NGUOI_DUNG> PHAN_QUYEN_NGUOI_DUNG { get; set; }
    }
}
