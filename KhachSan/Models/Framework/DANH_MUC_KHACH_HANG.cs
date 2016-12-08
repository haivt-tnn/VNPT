namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DANH_SACH_KHACH_HANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DANH_SACH_KHACH_HANG()
        {
            PHIEU_NHAN_PHONG = new HashSet<PHIEU_NHAN_PHONG>();
            PHIEU_THANH_TOAN = new HashSet<PHIEU_THANH_TOAN>();
        }

        [Key]
        public long MAKHACHHANG { get; set; }

        [StringLength(100)]
        public string HOTEN { get; set; }

        public int? MADIACHI { get; set; }

        [StringLength(255)]
        public string CHITIETDIACHI { get; set; }

        public int? GIOITINH { get; set; }

        public DateTime? NGAYSINH { get; set; }

        [StringLength(100)]
        public string SODIENTHOAI { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [StringLength(50)]
        public string SOGIAYTO { get; set; }

        public int? LOAIGIAYTO { get; set; }

        public DateTime? NGAYTAO { get; set; }

        [StringLength(50)]
        public string NGUOITAO { get; set; }

        public virtual DANH_MUC_DIA_CHI DANH_MUC_DIA_CHI { get; set; }

        public virtual DANH_MUC_GIOI_TINH DANH_MUC_GIOI_TINH { get; set; }

        public virtual DANH_MUC_LOAI_GIAY_TO DANH_MUC_LOAI_GIAY_TO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_NHAN_PHONG> PHIEU_NHAN_PHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_THANH_TOAN> PHIEU_THANH_TOAN { get; set; }
    }
}
