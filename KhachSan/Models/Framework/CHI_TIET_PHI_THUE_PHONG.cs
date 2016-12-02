namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHI_TIET_PHI_THUE_PHONG
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PHIEUTHANHTOAN { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MASOPHONG { get; set; }

        public DateTime? NGAYTRAPHONGTHUCTE { get; set; }

        public int? HINHTHUCTHUE { get; set; }

        public double? DONGIA { get; set; }

        public double? TONGTIEN { get; set; }

        public virtual DANH_MUC_PHONG DANH_MUC_PHONG { get; set; }

        public virtual PHIEU_THANH_TOAN PHIEU_THANH_TOAN { get; set; }
    }
}
