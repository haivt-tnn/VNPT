namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHIEU_NHAN_PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEU_NHAN_PHONG()
        {
            CHI_TIET_NHAN_PHONG = new HashSet<CHI_TIET_NHAN_PHONG>();
            PHIEU_THANH_TOAN = new HashSet<PHIEU_THANH_TOAN>();
        }

        [Key]
        public long SOPHIEU { get; set; }

        public long? PHIEUDATPHONG { get; set; }

        public long? MAKHACHHANG { get; set; }

        public long? CHITIETNHANPHONG { get; set; }

        public DateTime? NGAYNHANPHONG { get; set; }

        public DateTime? NGAYDUKIENTRA { get; set; }

        public int? HINHTHUCTHUE { get; set; }

        public double? TIENDATCOC { get; set; }

        public int? LOAITIEN { get; set; }

        [StringLength(50)]
        public string NGUOILAPPHIEU { get; set; }

        public DateTime? NGAYLAPPHIEU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_NHAN_PHONG> CHI_TIET_NHAN_PHONG { get; set; }

        public virtual DANH_SACH_KHACH_HANG DANH_MUC_KHACH_HANG { get; set; }

        public virtual PHIEU_DAT_PHONG PHIEU_DAT_PHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_THANH_TOAN> PHIEU_THANH_TOAN { get; set; }
    }
}
