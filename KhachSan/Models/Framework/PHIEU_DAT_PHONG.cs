namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHIEU_DAT_PHONG
    {
        [Key]
        public long SOPHIEU { get; set; }

        public int? LOAIPHONG { get; set; }

        [StringLength(100)]
        public string HOTENKHACHHANG { get; set; }

        [StringLength(50)]
        public string DIENTHOAI { get; set; }

        public DateTime? NGAYDUKIENDEN { get; set; }

        public DateTime? NGAYDUKIENTRA { get; set; }

        public DateTime? NGAYTAOPHIEU { get; set; }

        public int? TRANGTHAIPHIEU { get; set; }

        public double? TIENDATCOC { get; set; }

        public int? LOAITIEN { get; set; }

        [StringLength(50)]
        public string NGUOIXACNHAN { get; set; }

        public DateTime? NGAYXACNHAN { get; set; }

        public virtual DANH_MUC_LOAI_PHONG DANH_MUC_LOAI_PHONG { get; set; }
    }
}
