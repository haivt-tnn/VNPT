namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DANH_MUC_PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DANH_MUC_PHONG()
        {
            CHI_TIET_NHAN_PHONG = new HashSet<CHI_TIET_NHAN_PHONG>();
            CHI_TIET_PHI_DICH_VU = new HashSet<CHI_TIET_PHI_DICH_VU>();
            CHI_TIET_PHI_THUE_PHONG = new HashSet<CHI_TIET_PHI_THUE_PHONG>();
            DANH_MUC_TIEN_NGHI = new HashSet<DANH_MUC_TIEN_NGHI>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MASOPHONG { get; set; }

        public int? LOAIPHONG { get; set; }

        public int? KIEUPHONG { get; set; }

        public double? DONGIATHEONGAY { get; set; }

        public double? DONGIATHEOGIO { get; set; }

        public int? LOAITIEN { get; set; }

        public int? TINHTRANG { get; set; }

        public DateTime? NGAYTAO { get; set; }

        [StringLength(50)]
        public string NGUOITAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_NHAN_PHONG> CHI_TIET_NHAN_PHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_PHI_DICH_VU> CHI_TIET_PHI_DICH_VU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_PHI_THUE_PHONG> CHI_TIET_PHI_THUE_PHONG { get; set; }

        public virtual DANH_MUC_KIEU_PHONG DANH_MUC_KIEU_PHONG { get; set; }

        public virtual DANH_MUC_LOAI_PHONG DANH_MUC_LOAI_PHONG { get; set; }

        public virtual DANH_MUC_LOAI_TIEN DANH_MUC_LOAI_TIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANH_MUC_TIEN_NGHI> DANH_MUC_TIEN_NGHI { get; set; }
    }
}
