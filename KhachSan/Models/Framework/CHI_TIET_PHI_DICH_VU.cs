namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHI_TIET_PHI_DICH_VU
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PHIEUTHANHTOAN { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MASOPHONG { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MADICHVU { get; set; }

        public int? SOLUONG { get; set; }

        public double? DONGIA { get; set; }

        [StringLength(50)]
        public string DONVITINH { get; set; }

        public double? TONGTIEN { get; set; }

        public virtual DANH_MUC_DICH_VU DANH_MUC_DICH_VU { get; set; }

        public virtual DANH_MUC_PHONG DANH_MUC_PHONG { get; set; }

        public virtual PHIEU_THANH_TOAN PHIEU_THANH_TOAN { get; set; }
    }
}
