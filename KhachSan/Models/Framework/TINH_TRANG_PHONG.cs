namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TINH_TRANG_PHONG
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaTinhTrangPhong { get; set; }

        [Required]
        [StringLength(500)]
        public string TenTinhTrangPhong { get; set; }

        public virtual TINH_TRANG_PHONG TINH_TRANG_PHONG1 { get; set; }

        public virtual TINH_TRANG_PHONG TINH_TRANG_PHONG2 { get; set; }
    }
}
