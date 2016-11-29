namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DANH_MUC_NGUOI_DUNG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DANH_MUC_NGUOI_DUNG()
        {
            PHAN_QUYEN_NGUOI_DUNG = new HashSet<PHAN_QUYEN_NGUOI_DUNG>();
        }

        [Key]
        [StringLength(50)]
        public string TAIKHOAN { get; set; }

        [StringLength(255)]
        public string MATKHAU { get; set; }

        [StringLength(10)]
        public string NHOMQUYEN { get; set; }

        [StringLength(100)]
        public string HOTEN { get; set; }

        public int? GIOITINH { get; set; }

        public DateTime? NGAYSINH { get; set; }

        [StringLength(50)]
        public string SODIENTHOAI { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        public int? MADIACHI { get; set; }

        [StringLength(255)]
        public string CHITIETDIACHI { get; set; }

        public int? VITRICONGTAC { get; set; }

        public int? TRANGTHAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHAN_QUYEN_NGUOI_DUNG> PHAN_QUYEN_NGUOI_DUNG { get; set; }
    }
}
