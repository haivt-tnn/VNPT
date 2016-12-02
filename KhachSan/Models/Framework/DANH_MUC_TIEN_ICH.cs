namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("account_website.DANH_MUC_TIEN_ICH")]
    public partial class DANH_MUC_TIEN_ICH
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string MADV { get; set; }

        public string TENDV { get; set; }

        public string MOTA { get; set; }

        [StringLength(50)]
        public string URL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYTAO { get; set; }
    }
}
