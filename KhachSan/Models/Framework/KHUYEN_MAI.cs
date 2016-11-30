namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("account_website.KHUYEN_MAI")]
    public partial class KHUYEN_MAI
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAKHUYENMAI { get; set; }

        [StringLength(50)]
        public string TIEUDEKHUYENMAI { get; set; }

        public string NOIDUNGKHUYENMAI { get; set; }

        [StringLength(50)]
        public string URLANH { get; set; }

        public DateTime? THOIGIANTAO { get; set; }

        [StringLength(50)]
        public string NGUOITAO { get; set; }
    }
}
