namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHAN_QUYEN_NGUOI_DUNG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string TAIKHOAN { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MACHUCNANG { get; set; }

        public int? QUYENXEM { get; set; }

        public int? QUYENSUA { get; set; }

        public int? QUYENXOA { get; set; }

        public virtual DANH_MUC_CHUC_NANG DANH_MUC_CHUC_NANG { get; set; }

        public virtual DANH_MUC_NGUOI_DUNG DANH_MUC_NGUOI_DUNG { get; set; }
    }
}
