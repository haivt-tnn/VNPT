namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHI_TIET_NHAN_PHONG
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MACHITIET { get; set; }

        public long PHIEUNHANPHONG { get; set; }

        public int MASOPHONG { get; set; }

        public virtual DANH_MUC_PHONG DANH_MUC_PHONG { get; set; }

        public virtual PHIEU_NHAN_PHONG PHIEU_NHAN_PHONG { get; set; }
    }
}
