namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHIEU_THANH_TOAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEU_THANH_TOAN()
        {
            CHI_TIET_PHI_DICH_VU = new HashSet<CHI_TIET_PHI_DICH_VU>();
            CHI_TIET_PHI_THUE_PHONG = new HashSet<CHI_TIET_PHI_THUE_PHONG>();
        }

        [Key]
        public long SOPHIEU { get; set; }

        public long? PHIEUNHANPHONG { get; set; }

        public long? MAKHACHHANG { get; set; }

        public double? PHITHUEPHONG { get; set; }

        public double? PHIDICHVU { get; set; }

        public double? VAT { get; set; }

        public double? TIENDATCOC { get; set; }

        public double? CHIPHIKHAC { get; set; }

        [StringLength(255)]
        public string GHICHU { get; set; }

        public double? THUCTHU { get; set; }

        public int? LOAITIEN { get; set; }

        [StringLength(50)]
        public string NGUOILAPPHIEU { get; set; }

        public DateTime? NGAYLAPPHIEU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_PHI_DICH_VU> CHI_TIET_PHI_DICH_VU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_PHI_THUE_PHONG> CHI_TIET_PHI_THUE_PHONG { get; set; }

        public virtual DANH_SACH_KHACH_HANG DANH_MUC_KHACH_HANG { get; set; }

        public virtual DANH_MUC_LOAI_TIEN DANH_MUC_LOAI_TIEN { get; set; }

        public virtual PHIEU_NHAN_PHONG PHIEU_NHAN_PHONG { get; set; }
    }
}
