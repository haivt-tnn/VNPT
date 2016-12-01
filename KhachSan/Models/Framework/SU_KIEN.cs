namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("account_website.SU_KIEN")]
    public partial class SU_KIEN
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MASUKIEN { get; set; }

        [StringLength(50)]
        public string TIEUDESUKIEN { get; set; }

        public string NOIDUNGSUKIEN { get; set; }

        [StringLength(50)]
        public string URLANH { get; set; }

        public DateTime? NGAYTAO { get; set; }

        [StringLength(50)]
        public string NGUOITAO { get; set; }
    }
}
