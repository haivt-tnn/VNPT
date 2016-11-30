namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("account_website.DICH_VU_TIEN_ICH")]
    public partial class DICH_VU_TIEN_ICH
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string MADV { get; set; }

        [Required]
        [StringLength(100)]
        public string TENDV_VI { get; set; }

        [Required]
        [StringLength(100)]
        public string TENDV_EN { get; set; }

        [StringLength(1000)]
        public string MOTANGAN_VI { get; set; }

        [StringLength(1000)]
        public string MOTANGAN_EN { get; set; }

        [Required]
        public string MOTA_VI { get; set; }

        [Required]
        public string MOTA_EN { get; set; }

        [Required]
        [StringLength(256)]
        public string URL { get; set; }

        public DateTime? NGAYTAO { get; set; }
    }
}
